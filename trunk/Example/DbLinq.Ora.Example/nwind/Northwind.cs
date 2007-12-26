//#########################################################################
//generated by MysqlMetal on 2007-Dec-25 - extracted from server localhost.
//#########################################################################

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using DBLinq.Linq;
using DBLinq.Linq.Mapping;

namespace nwind
{
    
	/// <summary>
	/// This class represents Oracle database Northwind.
	/// </summary>
	public partial class Northwind : MContext
	{
		public Northwind(string connStr) : base(connStr)
		{
		}
		public Northwind(System.Data.IDbConnection connection) : base(connection)
		{
		}
	
		//these fields represent tables in database and are
		//ordered - parent tables first, child tables next. Do not change the order.
		public MTable<Region> Regions { get { return base.GetTable<Region>("Regions"); } }
		public MTable<Territory> Territories { get { return base.GetTable<Territory>("Territories"); } }
		public MTable<Category> Categories { get { return base.GetTable<Category>("Categories"); } }
		public MTable<Supplier> Suppliers { get { return base.GetTable<Supplier>("Suppliers"); } }
		public MTable<Product> Products { get { return base.GetTable<Product>("Products"); } }
		public MTable<Customer> Customers { get { return base.GetTable<Customer>("Customers"); } }
		public MTable<Employee> Employees { get { return base.GetTable<Employee>("Employees"); } }
		public MTable<Employeeterritory> Employeeterritories { get { return base.GetTable<Employeeterritory>("Employeeterritories"); } }
		public MTable<Order> Orders { get { return base.GetTable<Order>("Orders"); } }
		public MTable<Orderdetail> Orderdetails { get { return base.GetTable<Orderdetail>("Orderdetails"); } }
	
		
	}
	
	
	
	[Table(Name = "REGION")]
	public partial class Region : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _REGIONID;
		protected string _REGIONDESCRIPTION;
	
		
		#region costructors
		public Region()
		{
		}
		public Region(int REGIONID,string REGIONDESCRIPTION)
		{
		    this._REGIONID = REGIONID;
		this._REGIONDESCRIPTION = REGIONDESCRIPTION;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "REGIONID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int REGIONID
		{
		    get { return _REGIONID; }
		    set { _REGIONID = value; IsModified = true; }
		}
		
	
		[Column(Name = "REGIONDESCRIPTION", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string REGIONDESCRIPTION
		{
		    get { return _REGIONDESCRIPTION; }
		    set { _REGIONDESCRIPTION = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _REGIONID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Region o2 = obj as Region;
			if(o2==null)
				return false;
			return _REGIONID == o2._REGIONID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "REGIONID", Name = "SYS_C005222")]
		public EntityMSet<Territory> Territories
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "TERRITORIES")]
	public partial class Territory : IModified
	{
		
		protected string _TERRITORYID;
		protected string _TERRITORYDESCRIPTION;
		protected int _REGIONID;
	
		
		#region costructors
		public Territory()
		{
		}
		public Territory(string TERRITORYID,string TerritoryDescription,int REGIONID)
		{
		    this._TERRITORYID = TERRITORYID;
		this._TERRITORYDESCRIPTION = TerritoryDescription;
		this._REGIONID = REGIONID;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "TERRITORYID", DbType = "VARCHAR2", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public string TERRITORYID
		{
		    get { return _TERRITORYID; }
		    set { _TERRITORYID = value; IsModified = true; }
		}
		
	
		[Column(Name = "TERRITORYDESCRIPTION", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string TerritoryDescription
		{
		    get { return _TERRITORYDESCRIPTION; }
		    set { _TERRITORYDESCRIPTION = value; IsModified = true; }
		}
		
	
		[Column(Name = "REGIONID", DbType = "NUMBER", CanBeNull = false)]
		[DebuggerNonUserCode]
		public int REGIONID
		{
		    get { return _REGIONID; }
		    set { _REGIONID = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return (_TERRITORYID == null ? 0 : _TERRITORYID.GetHashCode());
		}
		public override bool Equals(object obj)
		{
			Territory o2 = obj as Territory;
			if(o2==null)
				return false;
			return object.Equals(_TERRITORYID, o2._TERRITORYID);
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "TERRITORYID", Name = "SYS_C005247")]
		public EntityMSet<Employeeterritory> EmployeeTerritories
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		private EntityRef<Region> _Region;    
		
		[Association(Storage="_Region", ThisKey="REGIONID", Name="SYS_C005222")]
		[DebuggerNonUserCode]
		public Region Region {
			get { return this._Region.Entity; }
			set { this._Region.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "CATEGORIES")]
	public partial class Category : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _CATEGORYID;
		protected string _CATEGORYNAME;
		protected string _DESCRIPTION;
		protected byte[] _PICTURE;
	
		
		#region costructors
		public Category()
		{
		}
		public Category(int CategoryID,string CATEGORYNAME,string DESCRIPTION,byte[] PICTURE)
		{
		    this._CATEGORYID = CategoryID;
		this._CATEGORYNAME = CATEGORYNAME;
		this._DESCRIPTION = DESCRIPTION;
		this._PICTURE = PICTURE;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "CATEGORYID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int CategoryID
		{
		    get { return _CATEGORYID; }
		    set { _CATEGORYID = value; IsModified = true; }
		}
		
	
		[Column(Name = "CATEGORYNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string CATEGORYNAME
		{
		    get { return _CATEGORYNAME; }
		    set { _CATEGORYNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "DESCRIPTION", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string DESCRIPTION
		{
		    get { return _DESCRIPTION; }
		    set { _DESCRIPTION = value; IsModified = true; }
		}
		
	
		[Column(Name = "PICTURE", DbType = "BLOB", CanBeNull = true)]
		[DebuggerNonUserCode]
		public byte[] PICTURE
		{
		    get { return _PICTURE; }
		    set { _PICTURE = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _CATEGORYID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Category o2 = obj as Category;
			if(o2==null)
				return false;
			return _CATEGORYID == o2._CATEGORYID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "CATEGORYID", Name = "SYS_C005233")]
		public EntityMSet<Product> Products
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "SUPPLIERS")]
	public partial class Supplier : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _SUPPLIERID;
		protected string _COMPANYNAME;
		protected string _CONTACTNAME;
		protected string _CONTACTTITLE;
		protected string _ADDRESS;
		protected string _CITY;
		protected string _REGION;
		protected string _POSTALCODE;
		protected string _COUNTRY;
		protected string _PHONE;
		protected string _FAX;
	
		
		#region costructors
		public Supplier()
		{
		}
		public Supplier(int SupplierID,string CompanyName,string ContactName,string ContactTitle,string Address,string City,string Region,string PostalCode,string Country,string Phone,string Fax)
		{
		    this._SUPPLIERID = SupplierID;
		this._COMPANYNAME = CompanyName;
		this._CONTACTNAME = ContactName;
		this._CONTACTTITLE = ContactTitle;
		this._ADDRESS = Address;
		this._CITY = City;
		this._REGION = Region;
		this._POSTALCODE = PostalCode;
		this._COUNTRY = Country;
		this._PHONE = Phone;
		this._FAX = Fax;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "SUPPLIERID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int SupplierID
		{
		    get { return _SUPPLIERID; }
		    set { _SUPPLIERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "COMPANYNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string CompanyName
		{
		    get { return _COMPANYNAME; }
		    set { _COMPANYNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "CONTACTNAME", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string ContactName
		{
		    get { return _CONTACTNAME; }
		    set { _CONTACTNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "CONTACTTITLE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string ContactTitle
		{
		    get { return _CONTACTTITLE; }
		    set { _CONTACTTITLE = value; IsModified = true; }
		}
		
	
		[Column(Name = "ADDRESS", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Address
		{
		    get { return _ADDRESS; }
		    set { _ADDRESS = value; IsModified = true; }
		}
		
	
		[Column(Name = "CITY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string City
		{
		    get { return _CITY; }
		    set { _CITY = value; IsModified = true; }
		}
		
	
		[Column(Name = "REGION", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Region
		{
		    get { return _REGION; }
		    set { _REGION = value; IsModified = true; }
		}
		
	
		[Column(Name = "POSTALCODE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string PostalCode
		{
		    get { return _POSTALCODE; }
		    set { _POSTALCODE = value; IsModified = true; }
		}
		
	
		[Column(Name = "COUNTRY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Country
		{
		    get { return _COUNTRY; }
		    set { _COUNTRY = value; IsModified = true; }
		}
		
	
		[Column(Name = "PHONE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Phone
		{
		    get { return _PHONE; }
		    set { _PHONE = value; IsModified = true; }
		}
		
	
		[Column(Name = "FAX", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Fax
		{
		    get { return _FAX; }
		    set { _FAX = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _SUPPLIERID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Supplier o2 = obj as Supplier;
			if(o2==null)
				return false;
			return _SUPPLIERID == o2._SUPPLIERID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "SUPPLIERID", Name = "SYS_C005234")]
		public EntityMSet<Product> Products
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "PRODUCTS")]
	public partial class Product : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _PRODUCTID;
		protected string _PRODUCTNAME;
		protected int? _SUPPLIERID;
		protected int? _CATEGORYID;
		protected string _QUANTITYPERUNIT;
		protected int? _UNITPRICE;
		protected int? _UNITSINSTOCK;
		protected int? _UNITSONORDER;
		protected int? _REORDERLEVEL;
		protected bool _DISCONTINUED;
	
		
		#region costructors
		public Product()
		{
		}
		public Product(int ProductID,string ProductName,int? SupplierID,int? CategoryID,string QuantityPerUnit,int? UnitPrice,int? UnitsInStock,int? UnitsOnOrder,int? ReorderLevel,bool Discontinued)
		{
		    this._PRODUCTID = ProductID;
		this._PRODUCTNAME = ProductName;
		this._SUPPLIERID = SupplierID;
		this._CATEGORYID = CategoryID;
		this._QUANTITYPERUNIT = QuantityPerUnit;
		this._UNITPRICE = UnitPrice;
		this._UNITSINSTOCK = UnitsInStock;
		this._UNITSONORDER = UnitsOnOrder;
		this._REORDERLEVEL = ReorderLevel;
		this._DISCONTINUED = Discontinued;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "PRODUCTID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int ProductID
		{
		    get { return _PRODUCTID; }
		    set { _PRODUCTID = value; IsModified = true; }
		}
		
	
		[Column(Name = "PRODUCTNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string ProductName
		{
		    get { return _PRODUCTNAME; }
		    set { _PRODUCTNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "SUPPLIERID", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? SupplierID
		{
		    get { return _SUPPLIERID; }
		    set { _SUPPLIERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "CATEGORYID", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? CategoryID
		{
		    get { return _CATEGORYID; }
		    set { _CATEGORYID = value; IsModified = true; }
		}
		
	
		[Column(Name = "QUANTITYPERUNIT", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string QuantityPerUnit
		{
		    get { return _QUANTITYPERUNIT; }
		    set { _QUANTITYPERUNIT = value; IsModified = true; }
		}
		
	
		[Column(Name = "UNITPRICE", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? UnitPrice
		{
		    get { return _UNITPRICE; }
		    set { _UNITPRICE = value; IsModified = true; }
		}
		
	
		[Column(Name = "UNITSINSTOCK", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? UnitsInStock
		{
		    get { return _UNITSINSTOCK; }
		    set { _UNITSINSTOCK = value; IsModified = true; }
		}
		
	
		[Column(Name = "UNITSONORDER", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? UnitsOnOrder
		{
		    get { return _UNITSONORDER; }
		    set { _UNITSONORDER = value; IsModified = true; }
		}
		
	
		[Column(Name = "REORDERLEVEL", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? ReorderLevel
		{
		    get { return _REORDERLEVEL; }
		    set { _REORDERLEVEL = value; IsModified = true; }
		}
		
	
		[Column(Name = "DISCONTINUED", DbType = "NUMBER", CanBeNull = false)]
		[DebuggerNonUserCode]
		public bool Discontinued
		{
		    get { return _DISCONTINUED; }
		    set { _DISCONTINUED = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _PRODUCTID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Product o2 = obj as Product;
			if(o2==null)
				return false;
			return _PRODUCTID == o2._PRODUCTID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "PRODUCTID", Name = "SYS_C005259")]
		public EntityMSet<Orderdetail> Orderdetails
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		private EntityRef<Category> _Category;    
		
		[Association(Storage="_Category", ThisKey="CATEGORYID", Name="SYS_C005233")]
		[DebuggerNonUserCode]
		public Category Category {
			get { return this._Category.Entity; }
			set { this._Category.Entity = value; }
		}
		
		private EntityRef<Supplier> _Supplier;    
		
		[Association(Storage="_Supplier", ThisKey="SUPPLIERID", Name="SYS_C005234")]
		[DebuggerNonUserCode]
		public Supplier Supplier {
			get { return this._Supplier.Entity; }
			set { this._Supplier.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "CUSTOMERS")]
	public partial class Customer : IModified
	{
		
		protected string _CUSTOMERID;
		protected string _COMPANYNAME;
		protected string _CONTACTNAME;
		protected string _CONTACTTITLE;
		protected string _ADDRESS;
		protected string _CITY;
		protected string _REGION;
		protected string _POSTALCODE;
		protected string _COUNTRY;
		protected string _PHONE;
		protected string _FAX;
	
		
		#region costructors
		public Customer()
		{
		}
		public Customer(string CustomerID,string CompanyName,string ContactName,string ContactTitle,string Address,string City,string Region,string PostalCode,string Country,string Phone,string Fax)
		{
		    this._CUSTOMERID = CustomerID;
		this._COMPANYNAME = CompanyName;
		this._CONTACTNAME = ContactName;
		this._CONTACTTITLE = ContactTitle;
		this._ADDRESS = Address;
		this._CITY = City;
		this._REGION = Region;
		this._POSTALCODE = PostalCode;
		this._COUNTRY = Country;
		this._PHONE = Phone;
		this._FAX = Fax;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "CUSTOMERID", DbType = "VARCHAR2", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public string CustomerID
		{
		    get { return _CUSTOMERID; }
		    set { _CUSTOMERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "COMPANYNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string CompanyName
		{
		    get { return _COMPANYNAME; }
		    set { _COMPANYNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "CONTACTNAME", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string ContactName
		{
		    get { return _CONTACTNAME; }
		    set { _CONTACTNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "CONTACTTITLE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string ContactTitle
		{
		    get { return _CONTACTTITLE; }
		    set { _CONTACTTITLE = value; IsModified = true; }
		}
		
	
		[Column(Name = "ADDRESS", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Address
		{
		    get { return _ADDRESS; }
		    set { _ADDRESS = value; IsModified = true; }
		}
		
	
		[Column(Name = "CITY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string City
		{
		    get { return _CITY; }
		    set { _CITY = value; IsModified = true; }
		}
		
	
		[Column(Name = "REGION", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Region
		{
		    get { return _REGION; }
		    set { _REGION = value; IsModified = true; }
		}
		
	
		[Column(Name = "POSTALCODE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string PostalCode
		{
		    get { return _POSTALCODE; }
		    set { _POSTALCODE = value; IsModified = true; }
		}
		
	
		[Column(Name = "COUNTRY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Country
		{
		    get { return _COUNTRY; }
		    set { _COUNTRY = value; IsModified = true; }
		}
		
	
		[Column(Name = "PHONE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Phone
		{
		    get { return _PHONE; }
		    set { _PHONE = value; IsModified = true; }
		}
		
	
		[Column(Name = "FAX", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Fax
		{
		    get { return _FAX; }
		    set { _FAX = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return (_CUSTOMERID == null ? 0 : _CUSTOMERID.GetHashCode());
		}
		public override bool Equals(object obj)
		{
			Customer o2 = obj as Customer;
			if(o2==null)
				return false;
			return object.Equals(_CUSTOMERID, o2._CUSTOMERID);
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "CUSTOMERID", Name = "SYS_C005250")]
		public EntityMSet<Order> Orders
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "EMPLOYEES")]
	public partial class Employee : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _EMPLOYEEID;
		protected string _LASTNAME;
		protected string _FIRSTNAME;
		protected string _TITLE;
		protected DateTime? _BIRTHDATE;
		protected DateTime? _HIREDATE;
		protected string _ADDRESS;
		protected string _CITY;
		protected string _REGION;
		protected string _POSTALCODE;
		protected string _COUNTRY;
		protected string _HOMEPHONE;
		protected byte[] _PHOTO;
		protected string _NOTES;
		protected int? _REPORTSTO;
	
		
		#region costructors
		public Employee()
		{
		}
		public Employee(int EmployeeID,string LastName,string FirstName,string TITLE,DateTime? BIRTHDATE,DateTime? HireDate,string Address,string City,string Region,string PostalCode,string Country,string HomePhone,byte[] PHOTO,string NOTES,int? ReportsTo)
		{
		    this._EMPLOYEEID = EmployeeID;
		this._LASTNAME = LastName;
		this._FIRSTNAME = FirstName;
		this._TITLE = TITLE;
		this._BIRTHDATE = BIRTHDATE;
		this._HIREDATE = HireDate;
		this._ADDRESS = Address;
		this._CITY = City;
		this._REGION = Region;
		this._POSTALCODE = PostalCode;
		this._COUNTRY = Country;
		this._HOMEPHONE = HomePhone;
		this._PHOTO = PHOTO;
		this._NOTES = NOTES;
		this._REPORTSTO = ReportsTo;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "EMPLOYEEID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int EmployeeID
		{
		    get { return _EMPLOYEEID; }
		    set { _EMPLOYEEID = value; IsModified = true; }
		}
		
	
		[Column(Name = "LASTNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string LastName
		{
		    get { return _LASTNAME; }
		    set { _LASTNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "FIRSTNAME", DbType = "VARCHAR2", CanBeNull = false)]
		[DebuggerNonUserCode]
		public string FirstName
		{
		    get { return _FIRSTNAME; }
		    set { _FIRSTNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "TITLE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string TITLE
		{
		    get { return _TITLE; }
		    set { _TITLE = value; IsModified = true; }
		}
		
	
		[Column(Name = "BIRTHDATE", DbType = "DATE", CanBeNull = true)]
		[DebuggerNonUserCode]
		public DateTime? BIRTHDATE
		{
		    get { return _BIRTHDATE; }
		    set { _BIRTHDATE = value; IsModified = true; }
		}
		
	
		[Column(Name = "HIREDATE", DbType = "DATE", CanBeNull = true)]
		[DebuggerNonUserCode]
		public DateTime? HireDate
		{
		    get { return _HIREDATE; }
		    set { _HIREDATE = value; IsModified = true; }
		}
		
	
		[Column(Name = "ADDRESS", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Address
		{
		    get { return _ADDRESS; }
		    set { _ADDRESS = value; IsModified = true; }
		}
		
	
		[Column(Name = "CITY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string City
		{
		    get { return _CITY; }
		    set { _CITY = value; IsModified = true; }
		}
		
	
		[Column(Name = "REGION", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Region
		{
		    get { return _REGION; }
		    set { _REGION = value; IsModified = true; }
		}
		
	
		[Column(Name = "POSTALCODE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string PostalCode
		{
		    get { return _POSTALCODE; }
		    set { _POSTALCODE = value; IsModified = true; }
		}
		
	
		[Column(Name = "COUNTRY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string Country
		{
		    get { return _COUNTRY; }
		    set { _COUNTRY = value; IsModified = true; }
		}
		
	
		[Column(Name = "HOMEPHONE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string HomePhone
		{
		    get { return _HOMEPHONE; }
		    set { _HOMEPHONE = value; IsModified = true; }
		}
		
	
		[Column(Name = "PHOTO", DbType = "BLOB", CanBeNull = true)]
		[DebuggerNonUserCode]
		public byte[] PHOTO
		{
		    get { return _PHOTO; }
		    set { _PHOTO = value; IsModified = true; }
		}
		
	
		[Column(Name = "NOTES", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string NOTES
		{
		    get { return _NOTES; }
		    set { _NOTES = value; IsModified = true; }
		}
		
	
		[Column(Name = "REPORTSTO", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? ReportsTo
		{
		    get { return _REPORTSTO; }
		    set { _REPORTSTO = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _EMPLOYEEID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Employee o2 = obj as Employee;
			if(o2==null)
				return false;
			return _EMPLOYEEID == o2._EMPLOYEEID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "EMPLOYEEID", Name = "SYS_C005242")]
		public EntityMSet<Employee> Employees
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		[Association(Storage = "null", OtherKey = "EMPLOYEEID", Name = "SYS_C005246")]
		public EntityMSet<Employeeterritory> EmployeeTerritories
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		[Association(Storage = "null", OtherKey = "EMPLOYEEID", Name = "SYS_C005251")]
		public EntityMSet<Order> Orders
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		private EntityRef<Employee> _Employee;    
		
		[Association(Storage="_Employee", ThisKey="REPORTSTO", Name="SYS_C005242")]
		[DebuggerNonUserCode]
		public Employee REPORTSTOEmployee {
			get { return this._Employee.Entity; }
			set { this._Employee.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "EMPLOYEETERRITORIES")]
	public partial class Employeeterritory : IModified
	{
		
		protected int _EMPLOYEEID;
		protected string _TERRITORYID;
	
		
		#region costructors
		public Employeeterritory()
		{
		}
		public Employeeterritory(int EmployeeID,string TERRITORYID)
		{
		    this._EMPLOYEEID = EmployeeID;
		this._TERRITORYID = TERRITORYID;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "EMPLOYEEID", DbType = "NUMBER", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public int EmployeeID
		{
		    get { return _EMPLOYEEID; }
		    set { _EMPLOYEEID = value; IsModified = true; }
		}
		
	
		[Column(Name = "TERRITORYID", DbType = "VARCHAR2", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public string TERRITORYID
		{
		    get { return _TERRITORYID; }
		    set { _TERRITORYID = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _EMPLOYEEID.GetHashCode() ^ (_TERRITORYID == null ? 0 : _TERRITORYID.GetHashCode());
		}
		public override bool Equals(object obj)
		{
			Employeeterritory o2 = obj as Employeeterritory;
			if(o2==null)
				return false;
			return _EMPLOYEEID == o2._EMPLOYEEID && object.Equals(_TERRITORYID, o2._TERRITORYID);
		}
		#endregion
	
		
		
		private EntityRef<Employee> _Employee;    
		
		[Association(Storage="_Employee", ThisKey="EMPLOYEEID", Name="SYS_C005246")]
		[DebuggerNonUserCode]
		public Employee Employee {
			get { return this._Employee.Entity; }
			set { this._Employee.Entity = value; }
		}
		
		private EntityRef<Territory> _Territory;    
		
		[Association(Storage="_Territory", ThisKey="TERRITORYID", Name="SYS_C005247")]
		[DebuggerNonUserCode]
		public Territory Territory {
			get { return this._Territory.Entity; }
			set { this._Territory.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "ORDERS")]
	public partial class Order : IModified
	{
		[DBLinq.Linq.Mapping.AutoGenId] 
		protected int _ORDERID;
		protected string _CUSTOMERID;
		protected int? _EMPLOYEEID;
		protected DateTime? _ORDERDATE;
		protected DateTime? _REQUIREDDATE;
		protected DateTime? _SHIPPEDDATE;
		protected int? _SHIPVIA;
		protected int? _FREIGHT;
		protected string _SHIPNAME;
		protected string _SHIPADDRESS;
		protected string _SHIPCITY;
		protected string _SHIPREGION;
		protected string _SHIPPOSTALCODE;
		protected string _SHIPCOUNTRY;
	
		
		#region costructors
		public Order()
		{
		}
		public Order(int OrderID,string CustomerID,int? EmployeeID,DateTime? OrderDate,DateTime? RequiredDate,DateTime? ShippedDate,int? ShipVia,int? Freight,string SHIPNAME,string SHIPADDRESS,string SHIPCITY,string SHIPREGION,string SHIPPOSTALCODE,string SHIPCOUNTRY)
		{
		    this._ORDERID = OrderID;
		this._CUSTOMERID = CustomerID;
		this._EMPLOYEEID = EmployeeID;
		this._ORDERDATE = OrderDate;
		this._REQUIREDDATE = RequiredDate;
		this._SHIPPEDDATE = ShippedDate;
		this._SHIPVIA = ShipVia;
		this._FREIGHT = Freight;
		this._SHIPNAME = SHIPNAME;
		this._SHIPADDRESS = SHIPADDRESS;
		this._SHIPCITY = SHIPCITY;
		this._SHIPREGION = SHIPREGION;
		this._SHIPPOSTALCODE = SHIPPOSTALCODE;
		this._SHIPCOUNTRY = SHIPCOUNTRY;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "ORDERID", DbType = "NUMBER", IsPrimaryKey = true, IsDbGenerated = true)]
		[DebuggerNonUserCode]
		public int OrderID
		{
		    get { return _ORDERID; }
		    set { _ORDERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "CUSTOMERID", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string CustomerID
		{
		    get { return _CUSTOMERID; }
		    set { _CUSTOMERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "EMPLOYEEID", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? EmployeeID
		{
		    get { return _EMPLOYEEID; }
		    set { _EMPLOYEEID = value; IsModified = true; }
		}
		
	
		[Column(Name = "ORDERDATE", DbType = "DATE", CanBeNull = true)]
		[DebuggerNonUserCode]
		public DateTime? OrderDate
		{
		    get { return _ORDERDATE; }
		    set { _ORDERDATE = value; IsModified = true; }
		}
		
	
		[Column(Name = "REQUIREDDATE", DbType = "DATE", CanBeNull = true)]
		[DebuggerNonUserCode]
		public DateTime? RequiredDate
		{
		    get { return _REQUIREDDATE; }
		    set { _REQUIREDDATE = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPPEDDATE", DbType = "DATE", CanBeNull = true)]
		[DebuggerNonUserCode]
		public DateTime? ShippedDate
		{
		    get { return _SHIPPEDDATE; }
		    set { _SHIPPEDDATE = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPVIA", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? ShipVia
		{
		    get { return _SHIPVIA; }
		    set { _SHIPVIA = value; IsModified = true; }
		}
		
	
		[Column(Name = "FREIGHT", DbType = "NUMBER", CanBeNull = true)]
		[DebuggerNonUserCode]
		public int? Freight
		{
		    get { return _FREIGHT; }
		    set { _FREIGHT = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPNAME", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPNAME
		{
		    get { return _SHIPNAME; }
		    set { _SHIPNAME = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPADDRESS", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPADDRESS
		{
		    get { return _SHIPADDRESS; }
		    set { _SHIPADDRESS = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPCITY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPCITY
		{
		    get { return _SHIPCITY; }
		    set { _SHIPCITY = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPREGION", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPREGION
		{
		    get { return _SHIPREGION; }
		    set { _SHIPREGION = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPPOSTALCODE", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPPOSTALCODE
		{
		    get { return _SHIPPOSTALCODE; }
		    set { _SHIPPOSTALCODE = value; IsModified = true; }
		}
		
	
		[Column(Name = "SHIPCOUNTRY", DbType = "VARCHAR2", CanBeNull = true)]
		[DebuggerNonUserCode]
		public string SHIPCOUNTRY
		{
		    get { return _SHIPCOUNTRY; }
		    set { _SHIPCOUNTRY = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _ORDERID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Order o2 = obj as Order;
			if(o2==null)
				return false;
			return _ORDERID == o2._ORDERID;
		}
		#endregion
	
		
		[Association(Storage = "null", OtherKey = "ORDERID", Name = "SYS_C005258")]
		public EntityMSet<Orderdetail> Orderdetails
		{
		    get { return null; } //L212 - child data available only when part of query
		}
		
		private EntityRef<Customer> _Customer;    
		
		[Association(Storage="_Customer", ThisKey="CUSTOMERID", Name="SYS_C005250")]
		[DebuggerNonUserCode]
		public Customer Customer {
			get { return this._Customer.Entity; }
			set { this._Customer.Entity = value; }
		}
		
		private EntityRef<Employee> _Employee;    
		
		[Association(Storage="_Employee", ThisKey="EMPLOYEEID", Name="SYS_C005251")]
		[DebuggerNonUserCode]
		public Employee Employee {
			get { return this._Employee.Entity; }
			set { this._Employee.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
	
	
	[Table(Name = "ORDERDETAILS")]
	public partial class Orderdetail : IModified
	{
		
		protected int _ORDERID;
		protected int _PRODUCTID;
		protected int _UNITPRICE;
		protected int _QUANTITY;
		protected double _DISCOUNT;
	
		
		#region costructors
		public Orderdetail()
		{
		}
		public Orderdetail(int OrderID,int ProductID,int UnitPrice,int QUANTITY,double DISCOUNT)
		{
		    this._ORDERID = OrderID;
		this._PRODUCTID = ProductID;
		this._UNITPRICE = UnitPrice;
		this._QUANTITY = QUANTITY;
		this._DISCOUNT = DISCOUNT;
		}
		#endregion
		
	
		#region properties - accessors
	
		[Column(Name = "ORDERID", DbType = "NUMBER", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public int OrderID
		{
		    get { return _ORDERID; }
		    set { _ORDERID = value; IsModified = true; }
		}
		
	
		[Column(Name = "PRODUCTID", DbType = "NUMBER", IsPrimaryKey = true)]
		[DebuggerNonUserCode]
		public int ProductID
		{
		    get { return _PRODUCTID; }
		    set { _PRODUCTID = value; IsModified = true; }
		}
		
	
		[Column(Name = "UNITPRICE", DbType = "NUMBER", CanBeNull = false)]
		[DebuggerNonUserCode]
		public int UnitPrice
		{
		    get { return _UNITPRICE; }
		    set { _UNITPRICE = value; IsModified = true; }
		}
		
	
		[Column(Name = "QUANTITY", DbType = "NUMBER", CanBeNull = false)]
		[DebuggerNonUserCode]
		public int QUANTITY
		{
		    get { return _QUANTITY; }
		    set { _QUANTITY = value; IsModified = true; }
		}
		
	
		[Column(Name = "DISCOUNT", DbType = "FLOAT", CanBeNull = false)]
		[DebuggerNonUserCode]
		public double DISCOUNT
		{
		    get { return _DISCOUNT; }
		    set { _DISCOUNT = value; IsModified = true; }
		}
		
	#endregion
		
		#region GetHashCode(),Equals() - uses column $fieldID to look up objects in liveObjectMap
		//TODO: move this logic our of user code, into a generated class
		public override int GetHashCode()
		{
			return _ORDERID.GetHashCode() ^ _PRODUCTID.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			Orderdetail o2 = obj as Orderdetail;
			if(o2==null)
				return false;
			return _ORDERID == o2._ORDERID && _PRODUCTID == o2._PRODUCTID;
		}
		#endregion
	
		
		
		private EntityRef<Order> _Order;    
		
		[Association(Storage="_Order", ThisKey="ORDERID", Name="SYS_C005258")]
		[DebuggerNonUserCode]
		public Order Order {
			get { return this._Order.Entity; }
			set { this._Order.Entity = value; }
		}
		
		private EntityRef<Product> _Product;    
		
		[Association(Storage="_Product", ThisKey="PRODUCTID", Name="SYS_C005259")]
		[DebuggerNonUserCode]
		public Product Product {
			get { return this._Product.Entity; }
			set { this._Product.Entity = value; }
		}
	
		public bool IsModified { get; set; }
	}
	
}
