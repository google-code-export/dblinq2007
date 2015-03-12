# Roadmap to Mono #

Prerequisites: we must have different csprojs for strict(System.Data.Linq.csproj) and non strict modes(DbLinq.csproj).

  * In first place because assembly references, we cannot reference System.Data.Linq in strict mode for evident reasons.
  * In second place because extensibility. if we want to have public Vendors they mustn't belong to System.Data.Linq project.
  * In third place because design,  useless files in strict mode, useless files in non strict mode.
  * In fourth place for suitability: project symbols, builds...
  * In fifth place because csprojs does not matter in Mono, that won't use DbLinq.csproj but makefiles.


---


## First stage: Build a System.Data.Linq with correct public classes. ##

  1. In strict mode we should locate all classes into System.Data.Linq.**namespace (even older classes, they likely will disappear in the future)
    * DbLinq.Data.Linq.** would be moved to System.Data.Linq.*** DbLinq.** would be moved to System.Data.Linq.Base (this namespace should disappear in the future)
> > > (as we are currently doing we would use a preprocessor directive for not annoy the non-strict build)

  * Some directives will be wrong in strict mode ie: using DbLinq.**(ie: System.Data.Linq.Base.XX won't exist in non strict build) -> apply also using preprocessor directives in that points.**

  * Make all classes visibility internal except the "key classes" (DataContext, DataTable...) also using preprocessor directives

  * Add rest of classes of System.Data.Linq to from current mono svn repository (since this project does not references MS/System.Data.Linq.dll). Remove duplicated classes (DataContext, DataTable...)

  * Remove some "using System.Data.Linq" since in strict mode we are such namespace

> > (we should use a preprocessor directive for not annoy the non-strict build)

  * To Add some using directives in strict code ie: System.Data.Base (but they would disappear in the future)


All those task don't annoy the current non-strict build.
Pascal work can continue like nothing happened.

Preprocessor directives explosion is the main threat in this step. But at least they would be located in 3 known places:
  * using blocks
  * namespace declarations
  * classes visibility

At the end of this stage we would have:
  * a non strict mode project that works and builds like now.
  * a strict mode  project builds itself but:
  * It isn't builds in rest of projects of dbLinq (tests, vendors, examples, dbMetal..).
  * Maybe Test\_Nunit\_Mssql\_strict.csproj builds (removing DbLinq.dll and DbLinq.SqlServer.dll reference).
  * And maybe default vendor lets that some those test work fine.


---

## Second stage: Correct classes interface ##

In this step we must to avoid preprocessor directives. That could be fatal for the maintainability,
So this step affect to the non strict mode design.

  1. From those few "key classes" (DataContext, DataTable...) take public members that does not match with .NET interface and do:
    * set them as internal.
    * that change will break the other projects (Tests, Examples, DbMetal) until the point 3.

  * Mark those methods with a prefix (ie: "public void foo()" to "internal void strict\_foo()")
  * Create a extension.cs file with public methods, they only will be stubs. (ie: "public void foo(){strict\_foo();}").
> > (This file would not be included just in non strict csproj)
  * Move constructors that does not match with .net to the extensions file.


Code conventions for Extensions files:
  * Only "key classes" should contain extension files.
  * Extension files methods calls should be forbidden inside neither DbLinq.csproj nor System.Data.Linq.csproj files (you should use the internal ones).
  * Extensions files just define the interface of DbLinq.Data.XXX to outside of the project (DbMetal,Examples,Tests...)
  * They also contains non standard constructors. That constructors shouldn't be used in DbLinq Project.

At the end of this stage we would have:
  * A DbLinq project that works and builds like before but with a few extensions files.
  * A System.Data.Linq.dll that has correct classes and correct methods, but is incompatible with (DbMetal, Examples, Tests..) and does not have Vendors extensibility.



---

## Third stage: Vendors in strict mode ##

  1. Create a new csproj Vendors.csproj with needed classes and interfaces to vendors projects.
  * Create code for managing ProviderAttribute for vendors extensibility. Maybe this code will be useful in both System.Data.Linq.csproj and DbLinq.csproj
  * How will it affect to DbLinq.csproj? There are two choices:
> > A. DbLinq.csproj keep vendors classes.
      * + only one assembly for DbLinq.csproj, everything work like before
      * - DbMetal, Vendors projects won't build with System.Data.Linq.dll but it can be solved duplicating each csproj of the solution and referencing our System.Data.Linq.csproj and Vendors.csproj
    * DbLinq.csproj lose vendor classes (like System.Data.Linq.csproj)
      * - two assemblies referenced in all projects.
      * + no csproj explosion.


At the end of this stage everything should work correctly with System.Data.Linq.csproj and DbLinq.csproj.