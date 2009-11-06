#region Auto-generated classes for Northwind database on [TIMESTAMP]

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from Northwind on [TIMESTAMP]
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
using System.Data.Linq;
using System.ComponentModel;

namespace nwind
{
	public partial class Northwind : DataContext
	{
		public Northwind(string connectionString)
		: base(connectionString)
		{
		}

		public Northwind(IDbConnection connection)
		: base(connection)
		{
		}

		public Northwind(string connection, MappingSource mappingSource)
		: base(connection, mappingSource)
		{
		}

		public Northwind(IDbConnection connection, MappingSource mappingSource)
		: base(connection, mappingSource)
		{
		}

		public Table<Category> Categories { get { return GetTable<Category>(); } }
		public Table<Customer> Customers { get { return GetTable<Customer>(); } }
		public Table<CustomerCustomerDemo> CustomerCustomerDemo { get { return GetTable<CustomerCustomerDemo>(); } }
		public Table<CustomerDemographic> CustomerDemographics { get { return GetTable<CustomerDemographic>(); } }
		public Table<Employee> Employees { get { return GetTable<Employee>(); } }
		public Table<EmployeeTerritory> EmployeeTerritories { get { return GetTable<EmployeeTerritory>(); } }
		public Table<Order> Orders { get { return GetTable<Order>(); } }
		public Table<OrderDetail> OrderDetails { get { return GetTable<OrderDetail>(); } }
		public Table<Product> Products { get { return GetTable<Product>(); } }
		public Table<Region> Regions { get { return GetTable<Region>(); } }
		public Table<Shipper> Shippers { get { return GetTable<Shipper>(); } }
		public Table<Supplier> Suppliers { get { return GetTable<Supplier>(); } }
		public Table<Territory> Territories { get { return GetTable<Territory>(); } }

	}

	[Table(Name = "main.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int CategoryID

		private int _categoryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_categoryID", Name = "CategoryID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int CategoryID
		{
			get
			{
				return _categoryID;
			}
			set
			{
				if (value != _categoryID)
				{
					SendPropertyChanging();
					_categoryID = value;
					SendPropertyChanged("CategoryID");
				}
			}
		}

		#endregion

		#region string CategoryName

		private string _categoryName;
		[DebuggerNonUserCode]
		[Column(Storage = "_categoryName", Name = "CategoryName", DbType = "nvarchar (15)", AutoSync = AutoSync.Never)]
		public string CategoryName
		{
			get
			{
				return _categoryName;
			}
			set
			{
				if (value != _categoryName)
				{
					SendPropertyChanging();
					_categoryName = value;
					SendPropertyChanged("CategoryName");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "ntext", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					SendPropertyChanging();
					_description = value;
					SendPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region Byte[] Picture

		private Byte[] _picture;
		[DebuggerNonUserCode]
		[Column(Storage = "_picture", Name = "Picture", DbType = "image", AutoSync = AutoSync.Never, CanBeNull = true)]
		public Byte[] Picture
		{
			get
			{
				return _picture;
			}
			set
			{
				if (value != _picture)
				{
					SendPropertyChanging();
					_picture = value;
					SendPropertyChanged("Picture");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Product> _products;
		[Association(Storage = "_products", OtherKey = "CategoryID", ThisKey = "CategoryID", Name = "fk_Products_1")]
		[DebuggerNonUserCode]
		public EntitySet<Product> Products
		{
			get
			{
				return _products;
			}
			set
			{
				_products = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Products_Attach(Product entity)
		{
			entity.Category = this;
		}

		private void Products_Detach(Product entity)
		{
			entity.Category = null;
		}


		#endregion

		#region ctor

		public Category()
		{
			_products = new EntitySet<Product>(Products_Attach, Products_Detach);
		}

		#endregion

	}

	[Table(Name = "main.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address

		private string _address;
		[DebuggerNonUserCode]
		[Column(Storage = "_address", Name = "Address", DbType = "nvarchar (60)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (value != _address)
				{
					SendPropertyChanging();
					_address = value;
					SendPropertyChanged("Address");
				}
			}
		}

		#endregion

		#region string City

		private string _city;
		[DebuggerNonUserCode]
		[Column(Storage = "_city", Name = "City", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string City
		{
			get
			{
				return _city;
			}
			set
			{
				if (value != _city)
				{
					SendPropertyChanging();
					_city = value;
					SendPropertyChanged("City");
				}
			}
		}

		#endregion

		#region string CompanyName

		private string _companyName;
		[DebuggerNonUserCode]
		[Column(Storage = "_companyName", Name = "CompanyName", DbType = "nvarchar (40)", AutoSync = AutoSync.Never)]
		public string CompanyName
		{
			get
			{
				return _companyName;
			}
			set
			{
				if (value != _companyName)
				{
					SendPropertyChanging();
					_companyName = value;
					SendPropertyChanged("CompanyName");
				}
			}
		}

		#endregion

		#region string ContactName

		private string _contactName;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactName", Name = "ContactName", DbType = "nvarchar (30)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ContactName
		{
			get
			{
				return _contactName;
			}
			set
			{
				if (value != _contactName)
				{
					SendPropertyChanging();
					_contactName = value;
					SendPropertyChanged("ContactName");
				}
			}
		}

		#endregion

		#region string ContactTitle

		private string _contactTitle;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactTitle", Name = "ContactTitle", DbType = "nvarchar (30)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ContactTitle
		{
			get
			{
				return _contactTitle;
			}
			set
			{
				if (value != _contactTitle)
				{
					SendPropertyChanging();
					_contactTitle = value;
					SendPropertyChanged("ContactTitle");
				}
			}
		}

		#endregion

		#region string Country

		private string _country;
		[DebuggerNonUserCode]
		[Column(Storage = "_country", Name = "Country", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Country
		{
			get
			{
				return _country;
			}
			set
			{
				if (value != _country)
				{
					SendPropertyChanging();
					_country = value;
					SendPropertyChanged("Country");
				}
			}
		}

		#endregion

		#region string CustomerID

		private string _customerID;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerID", Name = "CustomerID", DbType = "nchar (5)", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string CustomerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				if (value != _customerID)
				{
					SendPropertyChanging();
					_customerID = value;
					SendPropertyChanged("CustomerID");
				}
			}
		}

		#endregion

		#region string Fax

		private string _fax;
		[DebuggerNonUserCode]
		[Column(Storage = "_fax", Name = "Fax", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Fax
		{
			get
			{
				return _fax;
			}
			set
			{
				if (value != _fax)
				{
					SendPropertyChanging();
					_fax = value;
					SendPropertyChanged("Fax");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					SendPropertyChanging();
					_phone = value;
					SendPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region string PostalCode

		private string _postalCode;
		[DebuggerNonUserCode]
		[Column(Storage = "_postalCode", Name = "PostalCode", DbType = "nvarchar (10)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string PostalCode
		{
			get
			{
				return _postalCode;
			}
			set
			{
				if (value != _postalCode)
				{
					SendPropertyChanging();
					_postalCode = value;
					SendPropertyChanged("PostalCode");
				}
			}
		}

		#endregion

		#region string Region

		private string _region;
		[DebuggerNonUserCode]
		[Column(Storage = "_region", Name = "Region", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Region
		{
			get
			{
				return _region;
			}
			set
			{
				if (value != _region)
				{
					SendPropertyChanging();
					_region = value;
					SendPropertyChanged("Region");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<CustomerCustomerDemo> _customerCustomerDemo;
		[Association(Storage = "_customerCustomerDemo", OtherKey = "CustomerID", ThisKey = "CustomerID", Name = "fk_CustomerCustomerDemo_0")]
		[DebuggerNonUserCode]
		public EntitySet<CustomerCustomerDemo> CustomerCustomerDemo
		{
			get
			{
				return _customerCustomerDemo;
			}
			set
			{
				_customerCustomerDemo = value;
			}
		}

		private EntitySet<Order> _orders;
		[Association(Storage = "_orders", OtherKey = "CustomerID", ThisKey = "CustomerID", Name = "fk_Orders_2")]
		[DebuggerNonUserCode]
		public EntitySet<Order> Orders
		{
			get
			{
				return _orders;
			}
			set
			{
				_orders = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void CustomerCustomerDemo_Attach(CustomerCustomerDemo entity)
		{
			entity.Customer = this;
		}

		private void CustomerCustomerDemo_Detach(CustomerCustomerDemo entity)
		{
			entity.Customer = null;
		}

		private void Orders_Attach(Order entity)
		{
			entity.Customer = this;
		}

		private void Orders_Detach(Order entity)
		{
			entity.Customer = null;
		}


		#endregion

		#region ctor

		public Customer()
		{
			_customerCustomerDemo = new EntitySet<CustomerCustomerDemo>(CustomerCustomerDemo_Attach, CustomerCustomerDemo_Detach);
			_orders = new EntitySet<Order>(Orders_Attach, Orders_Detach);
		}

		#endregion

	}

	[Table(Name = "main.CustomerCustomerDemo")]
	public partial class CustomerCustomerDemo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CustomerID

		private string _customerID;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerID", Name = "CustomerID", DbType = "nchar (5)", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string CustomerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				if (value != _customerID)
				{
					if (_customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_customerID = value;
					SendPropertyChanged("CustomerID");
				}
			}
		}

		#endregion

		#region string CustomerTypeID

		private string _customerTypeID;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerTypeID", Name = "CustomerTypeID", DbType = "nchar", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string CustomerTypeID
		{
			get
			{
				return _customerTypeID;
			}
			set
			{
				if (value != _customerTypeID)
				{
					if (_customerDemographic.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_customerTypeID = value;
					SendPropertyChanged("CustomerTypeID");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Customer> _customer;
		[Association(Storage = "_customer", OtherKey = "CustomerID", ThisKey = "CustomerID", Name = "fk_CustomerCustomerDemo_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Customer Customer
		{
			get
			{
				return _customer.Entity;
			}
			set
			{
				if (value != _customer.Entity)
				{
					if (_customer.Entity != null)
					{
						var previousCustomer = _customer.Entity;
						_customer.Entity = null;
						previousCustomer.CustomerCustomerDemo.Remove(this);
					}
					_customer.Entity = value;
					if (value != null)
					{
						value.CustomerCustomerDemo.Add(this);
						_customerID = value.CustomerID;
					}
					else
					{
						_customerID = default(string);
					}
				}
			}
		}

		private EntityRef<CustomerDemographic> _customerDemographic;
		[Association(Storage = "_customerDemographic", OtherKey = "CustomerTypeID", ThisKey = "CustomerTypeID", Name = "fk_CustomerCustomerDemo_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public CustomerDemographic CustomerDemographic
		{
			get
			{
				return _customerDemographic.Entity;
			}
			set
			{
				if (value != _customerDemographic.Entity)
				{
					if (_customerDemographic.Entity != null)
					{
						var previousCustomerDemographic = _customerDemographic.Entity;
						_customerDemographic.Entity = null;
						previousCustomerDemographic.CustomerCustomerDemo.Remove(this);
					}
					_customerDemographic.Entity = value;
					if (value != null)
					{
						value.CustomerCustomerDemo.Add(this);
						_customerTypeID = value.CustomerTypeID;
					}
					else
					{
						_customerTypeID = default(string);
					}
				}
			}
		}


		#endregion

		#region ctor

		public CustomerCustomerDemo()
		{
			_customer = new EntityRef<Customer>();
			_customerDemographic = new EntityRef<CustomerDemographic>();
		}

		#endregion

	}

	[Table(Name = "main.CustomerDemographics")]
	public partial class CustomerDemographic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CustomerDesc

		private string _customerDesc;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerDesc", Name = "CustomerDesc", DbType = "ntext", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string CustomerDesc
		{
			get
			{
				return _customerDesc;
			}
			set
			{
				if (value != _customerDesc)
				{
					SendPropertyChanging();
					_customerDesc = value;
					SendPropertyChanged("CustomerDesc");
				}
			}
		}

		#endregion

		#region string CustomerTypeID

		private string _customerTypeID;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerTypeID", Name = "CustomerTypeID", DbType = "nchar", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string CustomerTypeID
		{
			get
			{
				return _customerTypeID;
			}
			set
			{
				if (value != _customerTypeID)
				{
					SendPropertyChanging();
					_customerTypeID = value;
					SendPropertyChanged("CustomerTypeID");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<CustomerCustomerDemo> _customerCustomerDemo;
		[Association(Storage = "_customerCustomerDemo", OtherKey = "CustomerTypeID", ThisKey = "CustomerTypeID", Name = "fk_CustomerCustomerDemo_1")]
		[DebuggerNonUserCode]
		public EntitySet<CustomerCustomerDemo> CustomerCustomerDemo
		{
			get
			{
				return _customerCustomerDemo;
			}
			set
			{
				_customerCustomerDemo = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void CustomerCustomerDemo_Attach(CustomerCustomerDemo entity)
		{
			entity.CustomerDemographic = this;
		}

		private void CustomerCustomerDemo_Detach(CustomerCustomerDemo entity)
		{
			entity.CustomerDemographic = null;
		}


		#endregion

		#region ctor

		public CustomerDemographic()
		{
			_customerCustomerDemo = new EntitySet<CustomerCustomerDemo>(CustomerCustomerDemo_Attach, CustomerCustomerDemo_Detach);
		}

		#endregion

	}

	[Table(Name = "main.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address

		private string _address;
		[DebuggerNonUserCode]
		[Column(Storage = "_address", Name = "Address", DbType = "nvarchar (60)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (value != _address)
				{
					SendPropertyChanging();
					_address = value;
					SendPropertyChanged("Address");
				}
			}
		}

		#endregion

		#region DateTime? BirthDate

		private DateTime? _birthDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_birthDate", Name = "BirthDate", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = true)]
		public DateTime? BirthDate
		{
			get
			{
				return _birthDate;
			}
			set
			{
				if (value != _birthDate)
				{
					SendPropertyChanging();
					_birthDate = value;
					SendPropertyChanged("BirthDate");
				}
			}
		}

		#endregion

		#region string City

		private string _city;
		[DebuggerNonUserCode]
		[Column(Storage = "_city", Name = "City", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string City
		{
			get
			{
				return _city;
			}
			set
			{
				if (value != _city)
				{
					SendPropertyChanging();
					_city = value;
					SendPropertyChanged("City");
				}
			}
		}

		#endregion

		#region string Country

		private string _country;
		[DebuggerNonUserCode]
		[Column(Storage = "_country", Name = "Country", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Country
		{
			get
			{
				return _country;
			}
			set
			{
				if (value != _country)
				{
					SendPropertyChanging();
					_country = value;
					SendPropertyChanged("Country");
				}
			}
		}

		#endregion

		#region int EmployeeID

		private int _employeeID;
		[DebuggerNonUserCode]
		[Column(Storage = "_employeeID", Name = "EmployeeID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int EmployeeID
		{
			get
			{
				return _employeeID;
			}
			set
			{
				if (value != _employeeID)
				{
					SendPropertyChanging();
					_employeeID = value;
					SendPropertyChanged("EmployeeID");
				}
			}
		}

		#endregion

		#region string Extension

		private string _extension;
		[DebuggerNonUserCode]
		[Column(Storage = "_extension", Name = "Extension", DbType = "nvarchar (4)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Extension
		{
			get
			{
				return _extension;
			}
			set
			{
				if (value != _extension)
				{
					SendPropertyChanging();
					_extension = value;
					SendPropertyChanged("Extension");
				}
			}
		}

		#endregion

		#region string FirstName

		private string _firstName;
		[DebuggerNonUserCode]
		[Column(Storage = "_firstName", Name = "FirstName", DbType = "nvarchar (10)", AutoSync = AutoSync.Never)]
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (value != _firstName)
				{
					SendPropertyChanging();
					_firstName = value;
					SendPropertyChanged("FirstName");
				}
			}
		}

		#endregion

		#region DateTime? HireDate

		private DateTime? _hireDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_hireDate", Name = "HireDate", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = true)]
		public DateTime? HireDate
		{
			get
			{
				return _hireDate;
			}
			set
			{
				if (value != _hireDate)
				{
					SendPropertyChanging();
					_hireDate = value;
					SendPropertyChanged("HireDate");
				}
			}
		}

		#endregion

		#region string HomePhone

		private string _homePhone;
		[DebuggerNonUserCode]
		[Column(Storage = "_homePhone", Name = "HomePhone", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string HomePhone
		{
			get
			{
				return _homePhone;
			}
			set
			{
				if (value != _homePhone)
				{
					SendPropertyChanging();
					_homePhone = value;
					SendPropertyChanged("HomePhone");
				}
			}
		}

		#endregion

		#region string LastName

		private string _lastName;
		[DebuggerNonUserCode]
		[Column(Storage = "_lastName", Name = "LastName", DbType = "nvarchar (20)", AutoSync = AutoSync.Never)]
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				if (value != _lastName)
				{
					SendPropertyChanging();
					_lastName = value;
					SendPropertyChanged("LastName");
				}
			}
		}

		#endregion

		#region string Notes

		private string _notes;
		[DebuggerNonUserCode]
		[Column(Storage = "_notes", Name = "Notes", DbType = "ntext", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Notes
		{
			get
			{
				return _notes;
			}
			set
			{
				if (value != _notes)
				{
					SendPropertyChanging();
					_notes = value;
					SendPropertyChanged("Notes");
				}
			}
		}

		#endregion

		#region Byte[] Photo

		private Byte[] _photo;
		[DebuggerNonUserCode]
		[Column(Storage = "_photo", Name = "Photo", DbType = "image", AutoSync = AutoSync.Never, CanBeNull = true)]
		public Byte[] Photo
		{
			get
			{
				return _photo;
			}
			set
			{
				if (value != _photo)
				{
					SendPropertyChanging();
					_photo = value;
					SendPropertyChanged("Photo");
				}
			}
		}

		#endregion

		#region string PhotoPath

		private string _photoPath;
		[DebuggerNonUserCode]
		[Column(Storage = "_photoPath", Name = "PhotoPath", DbType = "nvarchar (255)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string PhotoPath
		{
			get
			{
				return _photoPath;
			}
			set
			{
				if (value != _photoPath)
				{
					SendPropertyChanging();
					_photoPath = value;
					SendPropertyChanged("PhotoPath");
				}
			}
		}

		#endregion

		#region string PostalCode

		private string _postalCode;
		[DebuggerNonUserCode]
		[Column(Storage = "_postalCode", Name = "PostalCode", DbType = "nvarchar (10)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string PostalCode
		{
			get
			{
				return _postalCode;
			}
			set
			{
				if (value != _postalCode)
				{
					SendPropertyChanging();
					_postalCode = value;
					SendPropertyChanged("PostalCode");
				}
			}
		}

		#endregion

		#region string Region

		private string _region;
		[DebuggerNonUserCode]
		[Column(Storage = "_region", Name = "Region", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Region
		{
			get
			{
				return _region;
			}
			set
			{
				if (value != _region)
				{
					SendPropertyChanging();
					_region = value;
					SendPropertyChanged("Region");
				}
			}
		}

		#endregion

		#region int? ReportsTo

		private int? _reportsTo;
		[DebuggerNonUserCode]
		[Column(Storage = "_reportsTo", Name = "ReportsTo", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = true)]
		public int? ReportsTo
		{
			get
			{
				return _reportsTo;
			}
			set
			{
				if (value != _reportsTo)
				{
					if (_reportsToEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_reportsTo = value;
					SendPropertyChanged("ReportsTo");
				}
			}
		}

		#endregion

		#region string Title

		private string _title;
		[DebuggerNonUserCode]
		[Column(Storage = "_title", Name = "Title", DbType = "nvarchar (30)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				if (value != _title)
				{
					SendPropertyChanging();
					_title = value;
					SendPropertyChanged("Title");
				}
			}
		}

		#endregion

		#region string TitleOfCourtesy

		private string _titleOfCourtesy;
		[DebuggerNonUserCode]
		[Column(Storage = "_titleOfCourtesy", Name = "TitleOfCourtesy", DbType = "nvarchar (25)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string TitleOfCourtesy
		{
			get
			{
				return _titleOfCourtesy;
			}
			set
			{
				if (value != _titleOfCourtesy)
				{
					SendPropertyChanging();
					_titleOfCourtesy = value;
					SendPropertyChanged("TitleOfCourtesy");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<EmployeeTerritory> _employeeTerritories;
		[Association(Storage = "_employeeTerritories", OtherKey = "EmployeeID", ThisKey = "EmployeeID", Name = "fk_EmployeeTerritories_1")]
		[DebuggerNonUserCode]
		public EntitySet<EmployeeTerritory> EmployeeTerritories
		{
			get
			{
				return _employeeTerritories;
			}
			set
			{
				_employeeTerritories = value;
			}
		}

		private EntitySet<Employee> _employees;
		[Association(Storage = "_employees", OtherKey = "ReportsTo", ThisKey = "EmployeeID", Name = "fk_Employees_0")]
		[DebuggerNonUserCode]
		public EntitySet<Employee> Employees
		{
			get
			{
				return _employees;
			}
			set
			{
				_employees = value;
			}
		}

		private EntitySet<Order> _orders;
		[Association(Storage = "_orders", OtherKey = "EmployeeID", ThisKey = "EmployeeID", Name = "fk_Orders_1")]
		[DebuggerNonUserCode]
		public EntitySet<Order> Orders
		{
			get
			{
				return _orders;
			}
			set
			{
				_orders = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Employee> _reportsToEmployee;
		[Association(Storage = "_reportsToEmployee", OtherKey = "EmployeeID", ThisKey = "ReportsTo", Name = "fk_Employees_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Employee ReportsToEmployee
		{
			get
			{
				return _reportsToEmployee.Entity;
			}
			set
			{
				if (value != _reportsToEmployee.Entity)
				{
					if (_reportsToEmployee.Entity != null)
					{
						var previousEmployee = _reportsToEmployee.Entity;
						_reportsToEmployee.Entity = null;
						previousEmployee.Employees.Remove(this);
					}
					_reportsToEmployee.Entity = value;
					if (value != null)
					{
						value.Employees.Add(this);
						_reportsTo = value.EmployeeID;
					}
					else
					{
						_reportsTo = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void EmployeeTerritories_Attach(EmployeeTerritory entity)
		{
			entity.Employee = this;
		}

		private void EmployeeTerritories_Detach(EmployeeTerritory entity)
		{
			entity.Employee = null;
		}

		private void Employees_Attach(Employee entity)
		{
			entity.ReportsToEmployee = this;
		}

		private void Employees_Detach(Employee entity)
		{
			entity.ReportsToEmployee = null;
		}

		private void Orders_Attach(Order entity)
		{
			entity.Employee = this;
		}

		private void Orders_Detach(Order entity)
		{
			entity.Employee = null;
		}


		#endregion

		#region ctor

		public Employee()
		{
			_employeeTerritories = new EntitySet<EmployeeTerritory>(EmployeeTerritories_Attach, EmployeeTerritories_Detach);
			_employees = new EntitySet<Employee>(Employees_Attach, Employees_Detach);
			_orders = new EntitySet<Order>(Orders_Attach, Orders_Detach);
			_reportsToEmployee = new EntityRef<Employee>();
		}

		#endregion

	}

	[Table(Name = "main.EmployeeTerritories")]
	public partial class EmployeeTerritory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int EmployeeID

		private int _employeeID;
		[DebuggerNonUserCode]
		[Column(Storage = "_employeeID", Name = "EmployeeID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int EmployeeID
		{
			get
			{
				return _employeeID;
			}
			set
			{
				if (value != _employeeID)
				{
					if (_employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_employeeID = value;
					SendPropertyChanged("EmployeeID");
				}
			}
		}

		#endregion

		#region string TerritoryID

		private string _territoryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_territoryID", Name = "TerritoryID", DbType = "nvarchar", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string TerritoryID
		{
			get
			{
				return _territoryID;
			}
			set
			{
				if (value != _territoryID)
				{
					if (_territory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_territoryID = value;
					SendPropertyChanged("TerritoryID");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Territory> _territory;
		[Association(Storage = "_territory", OtherKey = "TerritoryID", ThisKey = "TerritoryID", Name = "fk_EmployeeTerritories_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Territory Territory
		{
			get
			{
				return _territory.Entity;
			}
			set
			{
				if (value != _territory.Entity)
				{
					if (_territory.Entity != null)
					{
						var previousTerritory = _territory.Entity;
						_territory.Entity = null;
						previousTerritory.EmployeeTerritories.Remove(this);
					}
					_territory.Entity = value;
					if (value != null)
					{
						value.EmployeeTerritories.Add(this);
						_territoryID = value.TerritoryID;
					}
					else
					{
						_territoryID = default(string);
					}
				}
			}
		}

		private EntityRef<Employee> _employee;
		[Association(Storage = "_employee", OtherKey = "EmployeeID", ThisKey = "EmployeeID", Name = "fk_EmployeeTerritories_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Employee Employee
		{
			get
			{
				return _employee.Entity;
			}
			set
			{
				if (value != _employee.Entity)
				{
					if (_employee.Entity != null)
					{
						var previousEmployee = _employee.Entity;
						_employee.Entity = null;
						previousEmployee.EmployeeTerritories.Remove(this);
					}
					_employee.Entity = value;
					if (value != null)
					{
						value.EmployeeTerritories.Add(this);
						_employeeID = value.EmployeeID;
					}
					else
					{
						_employeeID = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public EmployeeTerritory()
		{
			_territory = new EntityRef<Territory>();
			_employee = new EntityRef<Employee>();
		}

		#endregion

	}

	[Table(Name = "main.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CustomerID

		private string _customerID;
		[DebuggerNonUserCode]
		[Column(Storage = "_customerID", Name = "CustomerID", DbType = "nchar (5)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string CustomerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				if (value != _customerID)
				{
					if (_customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_customerID = value;
					SendPropertyChanged("CustomerID");
				}
			}
		}

		#endregion

		#region int? EmployeeID

		private int? _employeeID;
		[DebuggerNonUserCode]
		[Column(Storage = "_employeeID", Name = "EmployeeID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = true)]
		public int? EmployeeID
		{
			get
			{
				return _employeeID;
			}
			set
			{
				if (value != _employeeID)
				{
					if (_employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_employeeID = value;
					SendPropertyChanged("EmployeeID");
				}
			}
		}

		#endregion

		#region decimal? Freight

		private decimal? _freight;
		[DebuggerNonUserCode]
		[Column(Storage = "_freight", Name = "Freight", DbType = "money", AutoSync = AutoSync.Never, CanBeNull = true)]
		public decimal? Freight
		{
			get
			{
				return _freight;
			}
			set
			{
				if (value != _freight)
				{
					SendPropertyChanging();
					_freight = value;
					SendPropertyChanged("Freight");
				}
			}
		}

		#endregion

		#region DateTime? OrderDate

		private DateTime? _orderDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_orderDate", Name = "OrderDate", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = true)]
		public DateTime? OrderDate
		{
			get
			{
				return _orderDate;
			}
			set
			{
				if (value != _orderDate)
				{
					SendPropertyChanging();
					_orderDate = value;
					SendPropertyChanged("OrderDate");
				}
			}
		}

		#endregion

		#region int OrderID

		private int _orderID;
		[DebuggerNonUserCode]
		[Column(Storage = "_orderID", Name = "OrderID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int OrderID
		{
			get
			{
				return _orderID;
			}
			set
			{
				if (value != _orderID)
				{
					SendPropertyChanging();
					_orderID = value;
					SendPropertyChanged("OrderID");
				}
			}
		}

		#endregion

		#region DateTime? RequiredDate

		private DateTime? _requiredDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_requiredDate", Name = "RequiredDate", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = true)]
		public DateTime? RequiredDate
		{
			get
			{
				return _requiredDate;
			}
			set
			{
				if (value != _requiredDate)
				{
					SendPropertyChanging();
					_requiredDate = value;
					SendPropertyChanged("RequiredDate");
				}
			}
		}

		#endregion

		#region string ShipAddress

		private string _shipAddress;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipAddress", Name = "ShipAddress", DbType = "nvarchar (60)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipAddress
		{
			get
			{
				return _shipAddress;
			}
			set
			{
				if (value != _shipAddress)
				{
					SendPropertyChanging();
					_shipAddress = value;
					SendPropertyChanged("ShipAddress");
				}
			}
		}

		#endregion

		#region string ShipCity

		private string _shipCity;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipCity", Name = "ShipCity", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipCity
		{
			get
			{
				return _shipCity;
			}
			set
			{
				if (value != _shipCity)
				{
					SendPropertyChanging();
					_shipCity = value;
					SendPropertyChanged("ShipCity");
				}
			}
		}

		#endregion

		#region string ShipCountry

		private string _shipCountry;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipCountry", Name = "ShipCountry", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipCountry
		{
			get
			{
				return _shipCountry;
			}
			set
			{
				if (value != _shipCountry)
				{
					SendPropertyChanging();
					_shipCountry = value;
					SendPropertyChanged("ShipCountry");
				}
			}
		}

		#endregion

		#region string ShipName

		private string _shipName;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipName", Name = "ShipName", DbType = "nvarchar (40)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipName
		{
			get
			{
				return _shipName;
			}
			set
			{
				if (value != _shipName)
				{
					SendPropertyChanging();
					_shipName = value;
					SendPropertyChanged("ShipName");
				}
			}
		}

		#endregion

		#region DateTime? ShippedDate

		private DateTime? _shippedDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_shippedDate", Name = "ShippedDate", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = true)]
		public DateTime? ShippedDate
		{
			get
			{
				return _shippedDate;
			}
			set
			{
				if (value != _shippedDate)
				{
					SendPropertyChanging();
					_shippedDate = value;
					SendPropertyChanged("ShippedDate");
				}
			}
		}

		#endregion

		#region string ShipPostalCode

		private string _shipPostalCode;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipPostalCode", Name = "ShipPostalCode", DbType = "nvarchar (10)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipPostalCode
		{
			get
			{
				return _shipPostalCode;
			}
			set
			{
				if (value != _shipPostalCode)
				{
					SendPropertyChanging();
					_shipPostalCode = value;
					SendPropertyChanged("ShipPostalCode");
				}
			}
		}

		#endregion

		#region string ShipRegion

		private string _shipRegion;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipRegion", Name = "ShipRegion", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ShipRegion
		{
			get
			{
				return _shipRegion;
			}
			set
			{
				if (value != _shipRegion)
				{
					SendPropertyChanging();
					_shipRegion = value;
					SendPropertyChanged("ShipRegion");
				}
			}
		}

		#endregion

		#region int? ShipVia

		private int? _shipVia;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipVia", Name = "ShipVia", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = true)]
		public int? ShipVia
		{
			get
			{
				return _shipVia;
			}
			set
			{
				if (value != _shipVia)
				{
					if (_shipper.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_shipVia = value;
					SendPropertyChanged("ShipVia");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<OrderDetail> _orderDetails;
		[Association(Storage = "_orderDetails", OtherKey = "OrderID", ThisKey = "OrderID", Name = "\"fk_Order Details_1\"")]
		[DebuggerNonUserCode]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return _orderDetails;
			}
			set
			{
				_orderDetails = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Shipper> _shipper;
		[Association(Storage = "_shipper", OtherKey = "ShipperID", ThisKey = "ShipVia", Name = "fk_Orders_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Shipper Shipper
		{
			get
			{
				return _shipper.Entity;
			}
			set
			{
				if (value != _shipper.Entity)
				{
					if (_shipper.Entity != null)
					{
						var previousShipper = _shipper.Entity;
						_shipper.Entity = null;
						previousShipper.Orders.Remove(this);
					}
					_shipper.Entity = value;
					if (value != null)
					{
						value.Orders.Add(this);
						_shipVia = value.ShipperID;
					}
					else
					{
						_shipVia = null;
					}
				}
			}
		}

		private EntityRef<Employee> _employee;
		[Association(Storage = "_employee", OtherKey = "EmployeeID", ThisKey = "EmployeeID", Name = "fk_Orders_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Employee Employee
		{
			get
			{
				return _employee.Entity;
			}
			set
			{
				if (value != _employee.Entity)
				{
					if (_employee.Entity != null)
					{
						var previousEmployee = _employee.Entity;
						_employee.Entity = null;
						previousEmployee.Orders.Remove(this);
					}
					_employee.Entity = value;
					if (value != null)
					{
						value.Orders.Add(this);
						_employeeID = value.EmployeeID;
					}
					else
					{
						_employeeID = null;
					}
				}
			}
		}

		private EntityRef<Customer> _customer;
		[Association(Storage = "_customer", OtherKey = "CustomerID", ThisKey = "CustomerID", Name = "fk_Orders_2", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Customer Customer
		{
			get
			{
				return _customer.Entity;
			}
			set
			{
				if (value != _customer.Entity)
				{
					if (_customer.Entity != null)
					{
						var previousCustomer = _customer.Entity;
						_customer.Entity = null;
						previousCustomer.Orders.Remove(this);
					}
					_customer.Entity = value;
					if (value != null)
					{
						value.Orders.Add(this);
						_customerID = value.CustomerID;
					}
					else
					{
						_customerID = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void OrderDetails_Attach(OrderDetail entity)
		{
			entity.Order = this;
		}

		private void OrderDetails_Detach(OrderDetail entity)
		{
			entity.Order = null;
		}


		#endregion

		#region ctor

		public Order()
		{
			_orderDetails = new EntitySet<OrderDetail>(OrderDetails_Attach, OrderDetails_Detach);
			_shipper = new EntityRef<Shipper>();
			_employee = new EntityRef<Employee>();
			_customer = new EntityRef<Customer>();
		}

		#endregion

	}

	[Table(Name = "main.\"Order Details\"")]
	public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region float Discount

		private float _discount;
		[DebuggerNonUserCode]
		[Column(Storage = "_discount", Name = "Discount", DbType = "real", AutoSync = AutoSync.Never)]
		public float Discount
		{
			get
			{
				return _discount;
			}
			set
			{
				if (value != _discount)
				{
					SendPropertyChanging();
					_discount = value;
					SendPropertyChanged("Discount");
				}
			}
		}

		#endregion

		#region int OrderID

		private int _orderID;
		[DebuggerNonUserCode]
		[Column(Storage = "_orderID", Name = "OrderID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int OrderID
		{
			get
			{
				return _orderID;
			}
			set
			{
				if (value != _orderID)
				{
					if (_order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_orderID = value;
					SendPropertyChanged("OrderID");
				}
			}
		}

		#endregion

		#region int ProductID

		private int _productID;
		[DebuggerNonUserCode]
		[Column(Storage = "_productID", Name = "ProductID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int ProductID
		{
			get
			{
				return _productID;
			}
			set
			{
				if (value != _productID)
				{
					if (_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_productID = value;
					SendPropertyChanged("ProductID");
				}
			}
		}

		#endregion

		#region short Quantity

		private short _quantity;
		[DebuggerNonUserCode]
		[Column(Storage = "_quantity", Name = "Quantity", DbType = "smallint", AutoSync = AutoSync.Never)]
		public short Quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				if (value != _quantity)
				{
					SendPropertyChanging();
					_quantity = value;
					SendPropertyChanged("Quantity");
				}
			}
		}

		#endregion

		#region decimal UnitPrice

		private decimal _unitPrice;
		[DebuggerNonUserCode]
		[Column(Storage = "_unitPrice", Name = "UnitPrice", DbType = "money", AutoSync = AutoSync.Never)]
		public decimal UnitPrice
		{
			get
			{
				return _unitPrice;
			}
			set
			{
				if (value != _unitPrice)
				{
					SendPropertyChanging();
					_unitPrice = value;
					SendPropertyChanged("UnitPrice");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Product> _product;
		[Association(Storage = "_product", OtherKey = "ProductID", ThisKey = "ProductID", Name = "\"fk_Order Details_0\"", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Product Product
		{
			get
			{
				return _product.Entity;
			}
			set
			{
				if (value != _product.Entity)
				{
					if (_product.Entity != null)
					{
						var previousProduct = _product.Entity;
						_product.Entity = null;
						previousProduct.OrderDetails.Remove(this);
					}
					_product.Entity = value;
					if (value != null)
					{
						value.OrderDetails.Add(this);
						_productID = value.ProductID;
					}
					else
					{
						_productID = default(int);
					}
				}
			}
		}

		private EntityRef<Order> _order;
		[Association(Storage = "_order", OtherKey = "OrderID", ThisKey = "OrderID", Name = "\"fk_Order Details_1\"", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Order Order
		{
			get
			{
				return _order.Entity;
			}
			set
			{
				if (value != _order.Entity)
				{
					if (_order.Entity != null)
					{
						var previousOrder = _order.Entity;
						_order.Entity = null;
						previousOrder.OrderDetails.Remove(this);
					}
					_order.Entity = value;
					if (value != null)
					{
						value.OrderDetails.Add(this);
						_orderID = value.OrderID;
					}
					else
					{
						_orderID = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public OrderDetail()
		{
			_product = new EntityRef<Product>();
			_order = new EntityRef<Order>();
		}

		#endregion

	}

	[Table(Name = "main.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int? CategoryID

		private int? _categoryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_categoryID", Name = "CategoryID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = true)]
		public int? CategoryID
		{
			get
			{
				return _categoryID;
			}
			set
			{
				if (value != _categoryID)
				{
					if (_category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_categoryID = value;
					SendPropertyChanged("CategoryID");
				}
			}
		}

		#endregion

		#region bool Discontinued

		private bool _discontinued;
		[DebuggerNonUserCode]
		[Column(Storage = "_discontinued", Name = "Discontinued", DbType = "bit", AutoSync = AutoSync.Never)]
		public bool Discontinued
		{
			get
			{
				return _discontinued;
			}
			set
			{
				if (value != _discontinued)
				{
					SendPropertyChanging();
					_discontinued = value;
					SendPropertyChanged("Discontinued");
				}
			}
		}

		#endregion

		#region int ProductID

		private int _productID;
		[DebuggerNonUserCode]
		[Column(Storage = "_productID", Name = "ProductID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int ProductID
		{
			get
			{
				return _productID;
			}
			set
			{
				if (value != _productID)
				{
					SendPropertyChanging();
					_productID = value;
					SendPropertyChanged("ProductID");
				}
			}
		}

		#endregion

		#region string ProductName

		private string _productName;
		[DebuggerNonUserCode]
		[Column(Storage = "_productName", Name = "ProductName", DbType = "nvarchar (40)", AutoSync = AutoSync.Never)]
		public string ProductName
		{
			get
			{
				return _productName;
			}
			set
			{
				if (value != _productName)
				{
					SendPropertyChanging();
					_productName = value;
					SendPropertyChanged("ProductName");
				}
			}
		}

		#endregion

		#region string QuantityPerUnit

		private string _quantityPerUnit;
		[DebuggerNonUserCode]
		[Column(Storage = "_quantityPerUnit", Name = "QuantityPerUnit", DbType = "nvarchar (20)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string QuantityPerUnit
		{
			get
			{
				return _quantityPerUnit;
			}
			set
			{
				if (value != _quantityPerUnit)
				{
					SendPropertyChanging();
					_quantityPerUnit = value;
					SendPropertyChanged("QuantityPerUnit");
				}
			}
		}

		#endregion

		#region short? ReorderLevel

		private short? _reorderLevel;
		[DebuggerNonUserCode]
		[Column(Storage = "_reorderLevel", Name = "ReorderLevel", DbType = "smallint", AutoSync = AutoSync.Never, CanBeNull = true)]
		public short? ReorderLevel
		{
			get
			{
				return _reorderLevel;
			}
			set
			{
				if (value != _reorderLevel)
				{
					SendPropertyChanging();
					_reorderLevel = value;
					SendPropertyChanged("ReorderLevel");
				}
			}
		}

		#endregion

		#region int? SupplierID

		private int? _supplierID;
		[DebuggerNonUserCode]
		[Column(Storage = "_supplierID", Name = "SupplierID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = true)]
		public int? SupplierID
		{
			get
			{
				return _supplierID;
			}
			set
			{
				if (value != _supplierID)
				{
					if (_supplier.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_supplierID = value;
					SendPropertyChanged("SupplierID");
				}
			}
		}

		#endregion

		#region decimal? UnitPrice

		private decimal? _unitPrice;
		[DebuggerNonUserCode]
		[Column(Storage = "_unitPrice", Name = "UnitPrice", DbType = "money", AutoSync = AutoSync.Never, CanBeNull = true)]
		public decimal? UnitPrice
		{
			get
			{
				return _unitPrice;
			}
			set
			{
				if (value != _unitPrice)
				{
					SendPropertyChanging();
					_unitPrice = value;
					SendPropertyChanged("UnitPrice");
				}
			}
		}

		#endregion

		#region short? UnitsInStock

		private short? _unitsInStock;
		[DebuggerNonUserCode]
		[Column(Storage = "_unitsInStock", Name = "UnitsInStock", DbType = "smallint", AutoSync = AutoSync.Never, CanBeNull = true)]
		public short? UnitsInStock
		{
			get
			{
				return _unitsInStock;
			}
			set
			{
				if (value != _unitsInStock)
				{
					SendPropertyChanging();
					_unitsInStock = value;
					SendPropertyChanged("UnitsInStock");
				}
			}
		}

		#endregion

		#region short? UnitsOnOrder

		private short? _unitsOnOrder;
		[DebuggerNonUserCode]
		[Column(Storage = "_unitsOnOrder", Name = "UnitsOnOrder", DbType = "smallint", AutoSync = AutoSync.Never, CanBeNull = true)]
		public short? UnitsOnOrder
		{
			get
			{
				return _unitsOnOrder;
			}
			set
			{
				if (value != _unitsOnOrder)
				{
					SendPropertyChanging();
					_unitsOnOrder = value;
					SendPropertyChanged("UnitsOnOrder");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<OrderDetail> _orderDetails;
		[Association(Storage = "_orderDetails", OtherKey = "ProductID", ThisKey = "ProductID", Name = "\"fk_Order Details_0\"")]
		[DebuggerNonUserCode]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return _orderDetails;
			}
			set
			{
				_orderDetails = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Supplier> _supplier;
		[Association(Storage = "_supplier", OtherKey = "SupplierID", ThisKey = "SupplierID", Name = "fk_Products_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Supplier Supplier
		{
			get
			{
				return _supplier.Entity;
			}
			set
			{
				if (value != _supplier.Entity)
				{
					if (_supplier.Entity != null)
					{
						var previousSupplier = _supplier.Entity;
						_supplier.Entity = null;
						previousSupplier.Products.Remove(this);
					}
					_supplier.Entity = value;
					if (value != null)
					{
						value.Products.Add(this);
						_supplierID = value.SupplierID;
					}
					else
					{
						_supplierID = null;
					}
				}
			}
		}

		private EntityRef<Category> _category;
		[Association(Storage = "_category", OtherKey = "CategoryID", ThisKey = "CategoryID", Name = "fk_Products_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Category Category
		{
			get
			{
				return _category.Entity;
			}
			set
			{
				if (value != _category.Entity)
				{
					if (_category.Entity != null)
					{
						var previousCategory = _category.Entity;
						_category.Entity = null;
						previousCategory.Products.Remove(this);
					}
					_category.Entity = value;
					if (value != null)
					{
						value.Products.Add(this);
						_categoryID = value.CategoryID;
					}
					else
					{
						_categoryID = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void OrderDetails_Attach(OrderDetail entity)
		{
			entity.Product = this;
		}

		private void OrderDetails_Detach(OrderDetail entity)
		{
			entity.Product = null;
		}


		#endregion

		#region ctor

		public Product()
		{
			_orderDetails = new EntitySet<OrderDetail>(OrderDetails_Attach, OrderDetails_Detach);
			_supplier = new EntityRef<Supplier>();
			_category = new EntityRef<Category>();
		}

		#endregion

	}

	[Table(Name = "main.Region")]
	public partial class Region : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string RegionDescription

		private string _regionDescription;
		[DebuggerNonUserCode]
		[Column(Storage = "_regionDescription", Name = "RegionDescription", DbType = "nchar", AutoSync = AutoSync.Never)]
		public string RegionDescription
		{
			get
			{
				return _regionDescription;
			}
			set
			{
				if (value != _regionDescription)
				{
					SendPropertyChanging();
					_regionDescription = value;
					SendPropertyChanged("RegionDescription");
				}
			}
		}

		#endregion

		#region int RegionID

		private int _regionID;
		[DebuggerNonUserCode]
		[Column(Storage = "_regionID", Name = "RegionID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int RegionID
		{
			get
			{
				return _regionID;
			}
			set
			{
				if (value != _regionID)
				{
					SendPropertyChanging();
					_regionID = value;
					SendPropertyChanged("RegionID");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Territory> _territories;
		[Association(Storage = "_territories", OtherKey = "RegionID", ThisKey = "RegionID", Name = "fk_Territories_0")]
		[DebuggerNonUserCode]
		public EntitySet<Territory> Territories
		{
			get
			{
				return _territories;
			}
			set
			{
				_territories = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Territories_Attach(Territory entity)
		{
			entity.Region = this;
		}

		private void Territories_Detach(Territory entity)
		{
			entity.Region = null;
		}


		#endregion

		#region ctor

		public Region()
		{
			_territories = new EntitySet<Territory>(Territories_Attach, Territories_Detach);
		}

		#endregion

	}

	[Table(Name = "main.Shippers")]
	public partial class Shipper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CompanyName

		private string _companyName;
		[DebuggerNonUserCode]
		[Column(Storage = "_companyName", Name = "CompanyName", DbType = "nvarchar (40)", AutoSync = AutoSync.Never)]
		public string CompanyName
		{
			get
			{
				return _companyName;
			}
			set
			{
				if (value != _companyName)
				{
					SendPropertyChanging();
					_companyName = value;
					SendPropertyChanged("CompanyName");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					SendPropertyChanging();
					_phone = value;
					SendPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region int ShipperID

		private int _shipperID;
		[DebuggerNonUserCode]
		[Column(Storage = "_shipperID", Name = "ShipperID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int ShipperID
		{
			get
			{
				return _shipperID;
			}
			set
			{
				if (value != _shipperID)
				{
					SendPropertyChanging();
					_shipperID = value;
					SendPropertyChanged("ShipperID");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Order> _orders;
		[Association(Storage = "_orders", OtherKey = "ShipVia", ThisKey = "ShipperID", Name = "fk_Orders_0")]
		[DebuggerNonUserCode]
		public EntitySet<Order> Orders
		{
			get
			{
				return _orders;
			}
			set
			{
				_orders = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Orders_Attach(Order entity)
		{
			entity.Shipper = this;
		}

		private void Orders_Detach(Order entity)
		{
			entity.Shipper = null;
		}


		#endregion

		#region ctor

		public Shipper()
		{
			_orders = new EntitySet<Order>(Orders_Attach, Orders_Detach);
		}

		#endregion

	}

	[Table(Name = "main.Suppliers")]
	public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address

		private string _address;
		[DebuggerNonUserCode]
		[Column(Storage = "_address", Name = "Address", DbType = "nvarchar (60)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (value != _address)
				{
					SendPropertyChanging();
					_address = value;
					SendPropertyChanged("Address");
				}
			}
		}

		#endregion

		#region string City

		private string _city;
		[DebuggerNonUserCode]
		[Column(Storage = "_city", Name = "City", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string City
		{
			get
			{
				return _city;
			}
			set
			{
				if (value != _city)
				{
					SendPropertyChanging();
					_city = value;
					SendPropertyChanged("City");
				}
			}
		}

		#endregion

		#region string CompanyName

		private string _companyName;
		[DebuggerNonUserCode]
		[Column(Storage = "_companyName", Name = "CompanyName", DbType = "nvarchar (40)", AutoSync = AutoSync.Never)]
		public string CompanyName
		{
			get
			{
				return _companyName;
			}
			set
			{
				if (value != _companyName)
				{
					SendPropertyChanging();
					_companyName = value;
					SendPropertyChanged("CompanyName");
				}
			}
		}

		#endregion

		#region string ContactName

		private string _contactName;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactName", Name = "ContactName", DbType = "nvarchar (30)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ContactName
		{
			get
			{
				return _contactName;
			}
			set
			{
				if (value != _contactName)
				{
					SendPropertyChanging();
					_contactName = value;
					SendPropertyChanged("ContactName");
				}
			}
		}

		#endregion

		#region string ContactTitle

		private string _contactTitle;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactTitle", Name = "ContactTitle", DbType = "nvarchar (30)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string ContactTitle
		{
			get
			{
				return _contactTitle;
			}
			set
			{
				if (value != _contactTitle)
				{
					SendPropertyChanging();
					_contactTitle = value;
					SendPropertyChanged("ContactTitle");
				}
			}
		}

		#endregion

		#region string Country

		private string _country;
		[DebuggerNonUserCode]
		[Column(Storage = "_country", Name = "Country", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Country
		{
			get
			{
				return _country;
			}
			set
			{
				if (value != _country)
				{
					SendPropertyChanging();
					_country = value;
					SendPropertyChanged("Country");
				}
			}
		}

		#endregion

		#region string Fax

		private string _fax;
		[DebuggerNonUserCode]
		[Column(Storage = "_fax", Name = "Fax", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Fax
		{
			get
			{
				return _fax;
			}
			set
			{
				if (value != _fax)
				{
					SendPropertyChanging();
					_fax = value;
					SendPropertyChanged("Fax");
				}
			}
		}

		#endregion

		#region string HomePage

		private string _homePage;
		[DebuggerNonUserCode]
		[Column(Storage = "_homePage", Name = "HomePage", DbType = "ntext", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string HomePage
		{
			get
			{
				return _homePage;
			}
			set
			{
				if (value != _homePage)
				{
					SendPropertyChanging();
					_homePage = value;
					SendPropertyChanged("HomePage");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "nvarchar (24)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					SendPropertyChanging();
					_phone = value;
					SendPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region string PostalCode

		private string _postalCode;
		[DebuggerNonUserCode]
		[Column(Storage = "_postalCode", Name = "PostalCode", DbType = "nvarchar (10)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string PostalCode
		{
			get
			{
				return _postalCode;
			}
			set
			{
				if (value != _postalCode)
				{
					SendPropertyChanging();
					_postalCode = value;
					SendPropertyChanged("PostalCode");
				}
			}
		}

		#endregion

		#region string Region

		private string _region;
		[DebuggerNonUserCode]
		[Column(Storage = "_region", Name = "Region", DbType = "nvarchar (15)", AutoSync = AutoSync.Never, CanBeNull = true)]
		public string Region
		{
			get
			{
				return _region;
			}
			set
			{
				if (value != _region)
				{
					SendPropertyChanging();
					_region = value;
					SendPropertyChanged("Region");
				}
			}
		}

		#endregion

		#region int SupplierID

		private int _supplierID;
		[DebuggerNonUserCode]
		[Column(Storage = "_supplierID", Name = "SupplierID", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never)]
		public int SupplierID
		{
			get
			{
				return _supplierID;
			}
			set
			{
				if (value != _supplierID)
				{
					SendPropertyChanging();
					_supplierID = value;
					SendPropertyChanged("SupplierID");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Product> _products;
		[Association(Storage = "_products", OtherKey = "SupplierID", ThisKey = "SupplierID", Name = "fk_Products_0")]
		[DebuggerNonUserCode]
		public EntitySet<Product> Products
		{
			get
			{
				return _products;
			}
			set
			{
				_products = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Products_Attach(Product entity)
		{
			entity.Supplier = this;
		}

		private void Products_Detach(Product entity)
		{
			entity.Supplier = null;
		}


		#endregion

		#region ctor

		public Supplier()
		{
			_products = new EntitySet<Product>(Products_Attach, Products_Detach);
		}

		#endregion

	}

	[Table(Name = "main.Territories")]
	public partial class Territory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int RegionID

		private int _regionID;
		[DebuggerNonUserCode]
		[Column(Storage = "_regionID", Name = "RegionID", DbType = "int", AutoSync = AutoSync.Never)]
		public int RegionID
		{
			get
			{
				return _regionID;
			}
			set
			{
				if (value != _regionID)
				{
					if (_region.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					SendPropertyChanging();
					_regionID = value;
					SendPropertyChanged("RegionID");
				}
			}
		}

		#endregion

		#region string TerritoryDescription

		private string _territoryDescription;
		[DebuggerNonUserCode]
		[Column(Storage = "_territoryDescription", Name = "TerritoryDescription", DbType = "nchar", AutoSync = AutoSync.Never)]
		public string TerritoryDescription
		{
			get
			{
				return _territoryDescription;
			}
			set
			{
				if (value != _territoryDescription)
				{
					SendPropertyChanging();
					_territoryDescription = value;
					SendPropertyChanged("TerritoryDescription");
				}
			}
		}

		#endregion

		#region string TerritoryID

		private string _territoryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_territoryID", Name = "TerritoryID", DbType = "nvarchar", IsPrimaryKey = true, AutoSync = AutoSync.Never)]
		public string TerritoryID
		{
			get
			{
				return _territoryID;
			}
			set
			{
				if (value != _territoryID)
				{
					SendPropertyChanging();
					_territoryID = value;
					SendPropertyChanged("TerritoryID");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<EmployeeTerritory> _employeeTerritories;
		[Association(Storage = "_employeeTerritories", OtherKey = "TerritoryID", ThisKey = "TerritoryID", Name = "fk_EmployeeTerritories_0")]
		[DebuggerNonUserCode]
		public EntitySet<EmployeeTerritory> EmployeeTerritories
		{
			get
			{
				return _employeeTerritories;
			}
			set
			{
				_employeeTerritories = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Region> _region;
		[Association(Storage = "_region", OtherKey = "RegionID", ThisKey = "RegionID", Name = "fk_Territories_0", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Region Region
		{
			get
			{
				return _region.Entity;
			}
			set
			{
				if (value != _region.Entity)
				{
					if (_region.Entity != null)
					{
						var previousRegion = _region.Entity;
						_region.Entity = null;
						previousRegion.Territories.Remove(this);
					}
					_region.Entity = value;
					if (value != null)
					{
						value.Territories.Add(this);
						_regionID = value.RegionID;
					}
					else
					{
						_regionID = default(int);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void EmployeeTerritories_Attach(EmployeeTerritory entity)
		{
			entity.Territory = this;
		}

		private void EmployeeTerritories_Detach(EmployeeTerritory entity)
		{
			entity.Territory = null;
		}


		#endregion

		#region ctor

		public Territory()
		{
			_employeeTerritories = new EntitySet<EmployeeTerritory>(EmployeeTerritories_Attach, EmployeeTerritories_Detach);
			_region = new EntityRef<Region>();
		}

		#endregion

	}
}