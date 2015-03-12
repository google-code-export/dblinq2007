### Features ###
Here are some features that would be useful:

May Release (version 0.17)

  * Includes Thomas Glaser's Linq-To-Ingres
  * Supports for subqueries (eg. Any(), All() clauses)
  * Primary key update

June Release (version 0.18)

  * Graphical SqlMetal, which remembers any renaming you have done previously
  * Fix partial property entity update so that corresponding unit test works (get rid of IModified interface)

Later

  * Discriminator property support for select, insert, update, delete
  * Add custom string property conversion delegate on entity update
  * Make sure units tests run in MONO, use MONO Olive System.Data.Linq.dll
  * Ask Jahmani to change license to DbLinq compatible. Merge Jahmani and DbLinq code.

Lower Importance

  * CreateDatabase and DropDatabase implementation
  * Caching of compiled queries (speed optimization)

### Refactoring ###
#### DbLinq ####
  * Refactor BulkInsert different implementations
  * Remove unnecessary static classes and members
  * --(Remove the reference to database drivers in implementations)-- [Done](Done.md)

#### DbMetal ####
  * --(Factorize code (there is still to much copy/paste from one implementation to another) )--