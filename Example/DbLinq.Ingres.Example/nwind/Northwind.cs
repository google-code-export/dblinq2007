#region Auto-generated classes for northwind database on 2008-03-29 13:39:42Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from northwind on 2008-03-29 13:39:42Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using DbLinq.Linq;
using DbLinq.Linq.Mapping;

public partial class Northwind : DbLinq.Ingres.IngresDataContext
{
	//public Northwind(string connectionString)
	//    : base(connectionString)
	//{
	//}

	public Northwind(IDbConnection connection)
	    : base(connection)
	{
	}

	public Table<Categories> Categories { get { return GetTable<Categories>(); } }
	public Table<Customers> Customers { get { return GetTable<Customers>(); } }
	public Table<Employees> Employees { get { return GetTable<Employees>(); } }
	public Table<Employeeterritories> Employeeterritories { get { return GetTable<Employeeterritories>(); } }
	public Table<Iietab107108> Iietab107108 { get { return GetTable<Iietab107108>(); } }
	public Table<Iietab12B12C> Iietab12B12C { get { return GetTable<Iietab12B12C>(); } }
	public Table<Orderdetails> Orderdetails { get { return GetTable<Orderdetails>(); } }
	public Table<Orders> Orders { get { return GetTable<Orders>(); } }
	public Table<Products> Products { get { return GetTable<Products>(); } }
	public Table<Region> Region { get { return GetTable<Region>(); } }
	public Table<Suppliers> Suppliers { get { return GetTable<Suppliers>(); } }
	public Table<Territories> Territories { get { return GetTable<Territories>(); } }

}

[Table(Name = "linquser.categories")]
public partial class Categories : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region  Categoryid

	private Int32 categoryid;
	[Column(Storage = "categoryid", Name = "categoryid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Categoryid
	{
		get
		{
			return categoryid;
		}
		set
		{
			if (value != categoryid)
			{
				categoryid = value;
				OnPropertyChanged("Categoryid");
			}
		}
	}

	#endregion

	#region string Categoryname

	private string categoryname;
	[Column(Storage = "categoryname", Name = "categoryname", DbType = "VARCHAR(15)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Categoryname
	{
		get
		{
			return categoryname;
		}
		set
		{
			if (value != categoryname)
			{
				categoryname = value;
				OnPropertyChanged("Categoryname");
			}
		}
	}

	#endregion

	#region string Description

	private string description;
	[Column(Storage = "description", Name = "description", DbType = "VARCHAR(500)")]
	[DebuggerNonUserCode]
	public string Description
	{
		get
		{
			return description;
		}
		set
		{
			if (value != description)
			{
				description = value;
				OnPropertyChanged("Description");
			}
		}
	}

	#endregion

	#region System.Byte[] Picture

	private byte[] picture;
	[Column(Storage = "picture", Name = "picture", DbType = "LONG BYTE")]
	[DebuggerNonUserCode]
	public byte[] Picture
	{
		get
		{
			return picture;
		}
		set
		{
			if (value != picture)
			{
				picture = value;
				OnPropertyChanged("Picture");
			}
		}
	}

	#endregion

	#warning L189 table linquser.categories has no primary key. Multiple C# objects will refer to the same row.
}

[Table(Name = "linquser.customers")]
public partial class Customers : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string Address

	private string address;
	[Column(Storage = "address", Name = "address", DbType = "VARCHAR(60)")]
	[DebuggerNonUserCode]
	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			if (value != address)
			{
				address = value;
				OnPropertyChanged("Address");
			}
		}
	}

	#endregion

	#region string City

	private string city;
	[Column(Storage = "city", Name = "city", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string City
	{
		get
		{
			return city;
		}
		set
		{
			if (value != city)
			{
				city = value;
				OnPropertyChanged("City");
			}
		}
	}

	#endregion

	#region string Companyname

	private string companyname;
	[Column(Storage = "companyname", Name = "companyname", DbType = "VARCHAR(40)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Companyname
	{
		get
		{
			return companyname;
		}
		set
		{
			if (value != companyname)
			{
				companyname = value;
				OnPropertyChanged("Companyname");
			}
		}
	}

	#endregion

	#region string Contactname

	private string contactname;
	[Column(Storage = "contactname", Name = "contactname", DbType = "VARCHAR(30)")]
	[DebuggerNonUserCode]
	public string Contactname
	{
		get
		{
			return contactname;
		}
		set
		{
			if (value != contactname)
			{
				contactname = value;
				OnPropertyChanged("Contactname");
			}
		}
	}

	#endregion

	#region string Contacttitle

	private string contacttitle;
	[Column(Storage = "contacttitle", Name = "contacttitle", DbType = "VARCHAR(30)")]
	[DebuggerNonUserCode]
	public string Contacttitle
	{
		get
		{
			return contacttitle;
		}
		set
		{
			if (value != contacttitle)
			{
				contacttitle = value;
				OnPropertyChanged("Contacttitle");
			}
		}
	}

	#endregion

	#region string Country

	private string country;
	[Column(Storage = "country", Name = "country", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Country
	{
		get
		{
			return country;
		}
		set
		{
			if (value != country)
			{
				country = value;
				OnPropertyChanged("Country");
			}
		}
	}

	#endregion

	#region string Customerid

	private string customerid;
	[Column(Storage = "customerid", Name = "customerid", DbType = "VARCHAR(5)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Customerid
	{
		get
		{
			return customerid;
		}
		set
		{
			if (value != customerid)
			{
				customerid = value;
				OnPropertyChanged("Customerid");
			}
		}
	}

	#endregion

	#region string Fax

	private string fax;
	[Column(Storage = "fax", Name = "fax", DbType = "VARCHAR(24)")]
	[DebuggerNonUserCode]
	public string Fax
	{
		get
		{
			return fax;
		}
		set
		{
			if (value != fax)
			{
				fax = value;
				OnPropertyChanged("Fax");
			}
		}
	}

	#endregion

	#region string Phone

	private string phone;
	[Column(Storage = "phone", Name = "phone", DbType = "VARCHAR(24)")]
	[DebuggerNonUserCode]
	public string Phone
	{
		get
		{
			return phone;
		}
		set
		{
			if (value != phone)
			{
				phone = value;
				OnPropertyChanged("Phone");
			}
		}
	}

	#endregion

	#region string Postalcode

	private string postalcode;
	[Column(Storage = "postalcode", Name = "postalcode", DbType = "VARCHAR(10)")]
	[DebuggerNonUserCode]
	public string Postalcode
	{
		get
		{
			return postalcode;
		}
		set
		{
			if (value != postalcode)
			{
				postalcode = value;
				OnPropertyChanged("Postalcode");
			}
		}
	}

	#endregion

	#region string Region

	private string region;
	[Column(Storage = "region", Name = "region", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Region
	{
		get
		{
			return region;
		}
		set
		{
			if (value != region)
			{
				region = value;
				OnPropertyChanged("Region");
			}
		}
	}

	#endregion

	#warning L189 table linquser.customers has no primary key. Multiple C# objects will refer to the same row.
}

[Table(Name = "linquser.employees")]
public partial class Employees : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string Address

	private string address;
	[Column(Storage = "address", Name = "address", DbType = "VARCHAR(60)")]
	[DebuggerNonUserCode]
	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			if (value != address)
			{
				address = value;
				OnPropertyChanged("Address");
			}
		}
	}

	#endregion

	#region System.DateTime? Birthdate

	private DateTime? birthdate;
	[Column(Storage = "birthdate", Name = "birthdate", DbType = "INGRESDATE")]
	[DebuggerNonUserCode]
	public DateTime? Birthdate
	{
		get
		{
			return birthdate;
		}
		set
		{
			if (value != birthdate)
			{
				birthdate = value;
				OnPropertyChanged("Birthdate");
			}
		}
	}

	#endregion

	#region string City

	private string city;
	[Column(Storage = "city", Name = "city", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string City
	{
		get
		{
			return city;
		}
		set
		{
			if (value != city)
			{
				city = value;
				OnPropertyChanged("City");
			}
		}
	}

	#endregion

	#region string Country

	private string country;
	[Column(Storage = "country", Name = "country", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Country
	{
		get
		{
			return country;
		}
		set
		{
			if (value != country)
			{
				country = value;
				OnPropertyChanged("Country");
			}
		}
	}

	#endregion

	#region  Employeeid

	private Int32 employeeid;
	[Column(Storage = "employeeid", Name = "employeeid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Employeeid
	{
		get
		{
			return employeeid;
		}
		set
		{
			if (value != employeeid)
			{
				employeeid = value;
				OnPropertyChanged("Employeeid");
			}
		}
	}

	#endregion

	#region string Firstname

	private string firstname;
	[Column(Storage = "firstname", Name = "firstname", DbType = "VARCHAR(10)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Firstname
	{
		get
		{
			return firstname;
		}
		set
		{
			if (value != firstname)
			{
				firstname = value;
				OnPropertyChanged("Firstname");
			}
		}
	}

	#endregion

	#region System.DateTime? Hiredate

	private DateTime? hiredate;
	[Column(Storage = "hiredate", Name = "hiredate", DbType = "INGRESDATE")]
	[DebuggerNonUserCode]
	public DateTime? Hiredate
	{
		get
		{
			return hiredate;
		}
		set
		{
			if (value != hiredate)
			{
				hiredate = value;
				OnPropertyChanged("Hiredate");
			}
		}
	}

	#endregion

	#region string Homephone

	private string homephone;
	[Column(Storage = "homephone", Name = "homephone", DbType = "VARCHAR(24)")]
	[DebuggerNonUserCode]
	public string Homephone
	{
		get
		{
			return homephone;
		}
		set
		{
			if (value != homephone)
			{
				homephone = value;
				OnPropertyChanged("Homephone");
			}
		}
	}

	#endregion

	#region string Lastname

	private string lastname;
	[Column(Storage = "lastname", Name = "lastname", DbType = "VARCHAR(20)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Lastname
	{
		get
		{
			return lastname;
		}
		set
		{
			if (value != lastname)
			{
				lastname = value;
				OnPropertyChanged("Lastname");
			}
		}
	}

	#endregion

	#region string Notes

	private string notes;
	[Column(Storage = "notes", Name = "notes", DbType = "VARCHAR(100)")]
	[DebuggerNonUserCode]
	public string Notes
	{
		get
		{
			return notes;
		}
		set
		{
			if (value != notes)
			{
				notes = value;
				OnPropertyChanged("Notes");
			}
		}
	}

	#endregion

	#region System.Byte[] Photo

	private byte[] photo;
	[Column(Storage = "photo", Name = "photo", DbType = "LONG BYTE")]
	[DebuggerNonUserCode]
	public byte[] Photo
	{
		get
		{
			return photo;
		}
		set
		{
			if (value != photo)
			{
				photo = value;
				OnPropertyChanged("Photo");
			}
		}
	}

	#endregion

	#region string Postalcode

	private string postalcode;
	[Column(Storage = "postalcode", Name = "postalcode", DbType = "VARCHAR(10)")]
	[DebuggerNonUserCode]
	public string Postalcode
	{
		get
		{
			return postalcode;
		}
		set
		{
			if (value != postalcode)
			{
				postalcode = value;
				OnPropertyChanged("Postalcode");
			}
		}
	}

	#endregion

	#region string Region

	private string region;
	[Column(Storage = "region", Name = "region", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Region
	{
		get
		{
			return region;
		}
		set
		{
			if (value != region)
			{
				region = value;
				OnPropertyChanged("Region");
			}
		}
	}

	#endregion

	#region  Reportsto

	private Int32 reportsto;
	[Column(Storage = "reportsto", Name = "reportsto", DbType = "INTEGER(4)")]
	[DebuggerNonUserCode]
	public Int32 Reportsto
	{
		get
		{
			return reportsto;
		}
		set
		{
			if (value != reportsto)
			{
				reportsto = value;
				OnPropertyChanged("Reportsto");
			}
		}
	}

	#endregion

	#region string Title

	private string title;
	[Column(Storage = "title", Name = "title", DbType = "VARCHAR(30)")]
	[DebuggerNonUserCode]
	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			if (value != title)
			{
				title = value;
				OnPropertyChanged("Title");
			}
		}
	}

	#endregion

	#warning L189 table linquser.employees has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Reportsto", Name = "linquser_employees_reportsto_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public EntityMSet<Employees> _TODO_L35Employees
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Employees> lInQUserEmployeesReportsToLInQUserEmployeesEmployeEiD;
	[Association(Storage = "lInQUserEmployeesReportsToLInQUserEmployeesEmployeEiD", ThisKey = "Reportsto", Name = "linquser_employees_reportsto_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public Employees ParentEmployees
	{
		get
		{
			return lInQUserEmployeesReportsToLInQUserEmployeesEmployeEiD.Entity;
		}
		set
		{
			lInQUserEmployeesReportsToLInQUserEmployeesEmployeEiD.Entity = value;
		}
	}


	#endregion

}

[Table(Name = "linquser.employeeterritories")]
public partial class Employeeterritories : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region  Employeeid

	private Int32 employeeid;
	[Column(Storage = "employeeid", Name = "employeeid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Employeeid
	{
		get
		{
			return employeeid;
		}
		set
		{
			if (value != employeeid)
			{
				employeeid = value;
				OnPropertyChanged("Employeeid");
			}
		}
	}

	#endregion

	#region string Territoryid

	private string territoryid;
	[Column(Storage = "territoryid", Name = "territoryid", DbType = "VARCHAR(20)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Territoryid
	{
		get
		{
			return territoryid;
		}
		set
		{
			if (value != territoryid)
			{
				territoryid = value;
				OnPropertyChanged("Territoryid");
			}
		}
	}

	#endregion

	#warning L189 table linquser.employeeterritories has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Territoryid", Name = "linquser_employeeterritories_territoryid_linquser_territories_territoryid")]
	[DebuggerNonUserCode]
	public EntityMSet<Employeeterritories> EmployeeTerritories
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}

	[Association(Storage = "null", OtherKey = "Employeeid", Name = "linquser_employeeterritories_employeeid_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public EntityMSet<Employeeterritories> EmployeeTerritories_linquser_employeeterritories_employeeid_linquser_employees_employeeid
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Employeeterritories> lInQUserEmployeeTerritoriesTerritoryIDLInQUserTerritoriesTerritoryID;
	[Association(Storage = "lInQUserEmployeeTerritoriesTerritoryIDLInQUserTerritoriesTerritoryID", ThisKey = "Territoryid", Name = "linquser_employeeterritories_territoryid_linquser_territories_territoryid")]
	[DebuggerNonUserCode]
	public Employeeterritories Territories
	{
		get
		{
			return lInQUserEmployeeTerritoriesTerritoryIDLInQUserTerritoriesTerritoryID.Entity;
		}
		set
		{
			lInQUserEmployeeTerritoriesTerritoryIDLInQUserTerritoriesTerritoryID.Entity = value;
		}
	}

	private System.Data.Linq.EntityRef<Employeeterritories> lInQUserEmployeeTerritoriesEmployeEiDLInQUserEmployeesEmployeEiD;
	[Association(Storage = "lInQUserEmployeeTerritoriesEmployeEiDLInQUserEmployeesEmployeEiD", ThisKey = "Employeeid", Name = "linquser_employeeterritories_employeeid_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public Employeeterritories Employees
	{
		get
		{
			return lInQUserEmployeeTerritoriesEmployeEiDLInQUserEmployeesEmployeEiD.Entity;
		}
		set
		{
			lInQUserEmployeeTerritoriesEmployeEiDLInQUserEmployeesEmployeEiD.Entity = value;
		}
	}


	#endregion

}

[Table(Name = "linquser.iietab_107_108")]
public partial class Iietab107108 : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string PerKey

	private string perKey;
	[Column(Storage = "perKey", Name = "per_key", DbType = "CHAR(8)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public string PerKey
	{
		get
		{
			return perKey;
		}
		set
		{
			if (value != perKey)
			{
				perKey = value;
				OnPropertyChanged("PerKey");
			}
		}
	}

	#endregion

	#region  PerNext

	private Int32 perNext;
	[Column(Storage = "perNext", Name = "per_next", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerNext
	{
		get
		{
			return perNext;
		}
		set
		{
			if (value != perNext)
			{
				perNext = value;
				OnPropertyChanged("PerNext");
			}
		}
	}

	#endregion

	#region  PerSegment0

	private Int32 perSegment0;
	[Column(Storage = "perSegment0", Name = "per_segment0", DbType = "INTEGER(4)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerSegment0
	{
		get
		{
			return perSegment0;
		}
		set
		{
			if (value != perSegment0)
			{
				perSegment0 = value;
				OnPropertyChanged("PerSegment0");
			}
		}
	}

	#endregion

	#region  PerSegment1

	private Int32 perSegment1;
	[Column(Storage = "perSegment1", Name = "per_segment1", DbType = "INTEGER(4)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerSegment1
	{
		get
		{
			return perSegment1;
		}
		set
		{
			if (value != perSegment1)
			{
				perSegment1 = value;
				OnPropertyChanged("PerSegment1");
			}
		}
	}

	#endregion

	#region System.Byte[] PerValue

	private byte[] perValue;
	[Column(Storage = "perValue", Name = "per_value", DbType = "BYTE VARYING", CanBeNull = false)]
	[DebuggerNonUserCode]
	public byte[] PerValue
	{
		get
		{
			return perValue;
		}
		set
		{
			if (value != perValue)
			{
				perValue = value;
				OnPropertyChanged("PerValue");
			}
		}
	}

	#endregion

	#region GetHashCode(), Equals() - uses column PerKey, PerSegment0, PerSegment1 to look up objects in liveObjectMap

	public override int GetHashCode()
	{
		return PerKey.GetHashCode() ^ PerSegment0.GetHashCode() ^ PerSegment1.GetHashCode();
	}

	public override bool Equals(object o)
	{
		Iietab107108 other = o as Iietab107108;
		if (other == null)
		{
			return false;
		}
		return PerKey.Equals(other.PerKey) && PerSegment0.Equals(other.PerSegment0) && PerSegment1.Equals(other.PerSegment1);
	}

	#endregion

}

[Table(Name = "linquser.iietab_12b_12c")]
public partial class Iietab12B12C : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string PerKey

	private string perKey;
	[Column(Storage = "perKey", Name = "per_key", DbType = "CHAR(8)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public string PerKey
	{
		get
		{
			return perKey;
		}
		set
		{
			if (value != perKey)
			{
				perKey = value;
				OnPropertyChanged("PerKey");
			}
		}
	}

	#endregion

	#region  PerNext

	private Int32 perNext;
	[Column(Storage = "perNext", Name = "per_next", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerNext
	{
		get
		{
			return perNext;
		}
		set
		{
			if (value != perNext)
			{
				perNext = value;
				OnPropertyChanged("PerNext");
			}
		}
	}

	#endregion

	#region  PerSegment0

	private Int32 perSegment0;
	[Column(Storage = "perSegment0", Name = "per_segment0", DbType = "INTEGER(4)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerSegment0
	{
		get
		{
			return perSegment0;
		}
		set
		{
			if (value != perSegment0)
			{
				perSegment0 = value;
				OnPropertyChanged("PerSegment0");
			}
		}
	}

	#endregion

	#region  PerSegment1

	private Int32 perSegment1;
	[Column(Storage = "perSegment1", Name = "per_segment1", DbType = "INTEGER(4)", IsPrimaryKey = true, CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 PerSegment1
	{
		get
		{
			return perSegment1;
		}
		set
		{
			if (value != perSegment1)
			{
				perSegment1 = value;
				OnPropertyChanged("PerSegment1");
			}
		}
	}

	#endregion

	#region System.Byte[] PerValue

	private byte[] perValue;
	[Column(Storage = "perValue", Name = "per_value", DbType = "BYTE VARYING", CanBeNull = false)]
	[DebuggerNonUserCode]
	public byte[] PerValue
	{
		get
		{
			return perValue;
		}
		set
		{
			if (value != perValue)
			{
				perValue = value;
				OnPropertyChanged("PerValue");
			}
		}
	}

	#endregion

	#region GetHashCode(), Equals() - uses column PerKey, PerSegment0, PerSegment1 to look up objects in liveObjectMap

	public override int GetHashCode()
	{
		return PerKey.GetHashCode() ^ PerSegment0.GetHashCode() ^ PerSegment1.GetHashCode();
	}

	public override bool Equals(object o)
	{
		Iietab12B12C other = o as Iietab12B12C;
		if (other == null)
		{
			return false;
		}
		return PerKey.Equals(other.PerKey) && PerSegment0.Equals(other.PerSegment0) && PerSegment1.Equals(other.PerSegment1);
	}

	#endregion

}

[Table(Name = "linquser.orderdetails")]
public partial class Orderdetails : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region  Discount

	private Double discount;
	[Column(Storage = "discount", Name = "discount", DbType = "FLOAT", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Double Discount
	{
		get
		{
			return discount;
		}
		set
		{
			if (value != discount)
			{
				discount = value;
				OnPropertyChanged("Discount");
			}
		}
	}

	#endregion

	#region  Orderid

	private Int32 orderid;
	[Column(Storage = "orderid", Name = "orderid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Orderid
	{
		get
		{
			return orderid;
		}
		set
		{
			if (value != orderid)
			{
				orderid = value;
				OnPropertyChanged("Orderid");
			}
		}
	}

	#endregion

	#region  Productid

	private Int32 productid;
	[Column(Storage = "productid", Name = "productid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Productid
	{
		get
		{
			return productid;
		}
		set
		{
			if (value != productid)
			{
				productid = value;
				OnPropertyChanged("Productid");
			}
		}
	}

	#endregion

	#region  Quantity

	private Int16 quantity;
	[Column(Storage = "quantity", Name = "quantity", DbType = "INTEGER(2)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int16 Quantity
	{
		get
		{
			return quantity;
		}
		set
		{
			if (value != quantity)
			{
				quantity = value;
				OnPropertyChanged("Quantity");
			}
		}
	}

	#endregion

	#region  Unitprice

	private Decimal unitprice;
	[Column(Storage = "unitprice", Name = "unitprice", DbType = "DECIMAL(5, 0)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Decimal Unitprice
	{
		get
		{
			return unitprice;
		}
		set
		{
			if (value != unitprice)
			{
				unitprice = value;
				OnPropertyChanged("Unitprice");
			}
		}
	}

	#endregion

	#warning L189 table linquser.orderdetails has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Orderid", Name = "linquser_orderdetails_orderid_linquser_orders_orderid")]
	[DebuggerNonUserCode]
	public EntityMSet<Orderdetails> OrderDetails
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}

	[Association(Storage = "null", OtherKey = "Productid", Name = "linquser_orderdetails_productid_linquser_products_productid")]
	[DebuggerNonUserCode]
	public EntityMSet<Orderdetails> OrderDetails_linquser_orderdetails_productid_linquser_products_productid
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Orderdetails> lInQUserOrderDetailsOrderIDLInQUserOrdersOrderID;
	[Association(Storage = "lInQUserOrderDetailsOrderIDLInQUserOrdersOrderID", ThisKey = "Orderid", Name = "linquser_orderdetails_orderid_linquser_orders_orderid")]
	[DebuggerNonUserCode]
	public Orderdetails Orders
	{
		get
		{
			return lInQUserOrderDetailsOrderIDLInQUserOrdersOrderID.Entity;
		}
		set
		{
			lInQUserOrderDetailsOrderIDLInQUserOrdersOrderID.Entity = value;
		}
	}

	private System.Data.Linq.EntityRef<Orderdetails> lInQUserOrderDetailsProductIDLInQUserProductsProductID;
	[Association(Storage = "lInQUserOrderDetailsProductIDLInQUserProductsProductID", ThisKey = "Productid", Name = "linquser_orderdetails_productid_linquser_products_productid")]
	[DebuggerNonUserCode]
	public Orderdetails Products
	{
		get
		{
			return lInQUserOrderDetailsProductIDLInQUserProductsProductID.Entity;
		}
		set
		{
			lInQUserOrderDetailsProductIDLInQUserProductsProductID.Entity = value;
		}
	}


	#endregion

}

[Table(Name = "linquser.orders")]
public partial class Orders : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string Customerid

	private string customerid;
	[Column(Storage = "customerid", Name = "customerid", DbType = "VARCHAR(5)")]
	[DebuggerNonUserCode]
	public string Customerid
	{
		get
		{
			return customerid;
		}
		set
		{
			if (value != customerid)
			{
				customerid = value;
				OnPropertyChanged("Customerid");
			}
		}
	}

	#endregion

	#region  Employeeid

	private Int32 employeeid;
	[Column(Storage = "employeeid", Name = "employeeid", DbType = "INTEGER(4)")]
	[DebuggerNonUserCode]
	public Int32 Employeeid
	{
		get
		{
			return employeeid;
		}
		set
		{
			if (value != employeeid)
			{
				employeeid = value;
				OnPropertyChanged("Employeeid");
			}
		}
	}

	#endregion

	#region  Freight

	private Decimal freight;
	[Column(Storage = "freight", Name = "freight", DbType = "DECIMAL(5, 0)")]
	[DebuggerNonUserCode]
	public Decimal Freight
	{
		get
		{
			return freight;
		}
		set
		{
			if (value != freight)
			{
				freight = value;
				OnPropertyChanged("Freight");
			}
		}
	}

	#endregion

	#region System.DateTime? Orderdate

	private DateTime? orderdate;
	[Column(Storage = "orderdate", Name = "orderdate", DbType = "INGRESDATE")]
	[DebuggerNonUserCode]
	public DateTime? Orderdate
	{
		get
		{
			return orderdate;
		}
		set
		{
			if (value != orderdate)
			{
				orderdate = value;
				OnPropertyChanged("Orderdate");
			}
		}
	}

	#endregion

	#region  Orderid

	private Int32 orderid;
	[Column(Storage = "orderid", Name = "orderid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Orderid
	{
		get
		{
			return orderid;
		}
		set
		{
			if (value != orderid)
			{
				orderid = value;
				OnPropertyChanged("Orderid");
			}
		}
	}

	#endregion

	#region System.DateTime? Requireddate

	private DateTime? requireddate;
	[Column(Storage = "requireddate", Name = "requireddate", DbType = "INGRESDATE")]
	[DebuggerNonUserCode]
	public DateTime? Requireddate
	{
		get
		{
			return requireddate;
		}
		set
		{
			if (value != requireddate)
			{
				requireddate = value;
				OnPropertyChanged("Requireddate");
			}
		}
	}

	#endregion

	#region string Shipaddress

	private string shipaddress;
	[Column(Storage = "shipaddress", Name = "shipaddress", DbType = "VARCHAR(60)")]
	[DebuggerNonUserCode]
	public string Shipaddress
	{
		get
		{
			return shipaddress;
		}
		set
		{
			if (value != shipaddress)
			{
				shipaddress = value;
				OnPropertyChanged("Shipaddress");
			}
		}
	}

	#endregion

	#region string Shipcity

	private string shipcity;
	[Column(Storage = "shipcity", Name = "shipcity", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Shipcity
	{
		get
		{
			return shipcity;
		}
		set
		{
			if (value != shipcity)
			{
				shipcity = value;
				OnPropertyChanged("Shipcity");
			}
		}
	}

	#endregion

	#region string Shipcountry

	private string shipcountry;
	[Column(Storage = "shipcountry", Name = "shipcountry", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Shipcountry
	{
		get
		{
			return shipcountry;
		}
		set
		{
			if (value != shipcountry)
			{
				shipcountry = value;
				OnPropertyChanged("Shipcountry");
			}
		}
	}

	#endregion

	#region string Shipname

	private string shipname;
	[Column(Storage = "shipname", Name = "shipname", DbType = "VARCHAR(40)")]
	[DebuggerNonUserCode]
	public string Shipname
	{
		get
		{
			return shipname;
		}
		set
		{
			if (value != shipname)
			{
				shipname = value;
				OnPropertyChanged("Shipname");
			}
		}
	}

	#endregion

	#region System.DateTime? Shippeddate

	private DateTime? shippeddate;
	[Column(Storage = "shippeddate", Name = "shippeddate", DbType = "INGRESDATE")]
	[DebuggerNonUserCode]
	public DateTime? Shippeddate
	{
		get
		{
			return shippeddate;
		}
		set
		{
			if (value != shippeddate)
			{
				shippeddate = value;
				OnPropertyChanged("Shippeddate");
			}
		}
	}

	#endregion

	#region string Shippostalcode

	private string shippostalcode;
	[Column(Storage = "shippostalcode", Name = "shippostalcode", DbType = "VARCHAR(10)")]
	[DebuggerNonUserCode]
	public string Shippostalcode
	{
		get
		{
			return shippostalcode;
		}
		set
		{
			if (value != shippostalcode)
			{
				shippostalcode = value;
				OnPropertyChanged("Shippostalcode");
			}
		}
	}

	#endregion

	#region string Shipregion

	private string shipregion;
	[Column(Storage = "shipregion", Name = "shipregion", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Shipregion
	{
		get
		{
			return shipregion;
		}
		set
		{
			if (value != shipregion)
			{
				shipregion = value;
				OnPropertyChanged("Shipregion");
			}
		}
	}

	#endregion

	#region  Shipvia

	private Int32 shipvia;
	[Column(Storage = "shipvia", Name = "shipvia", DbType = "INTEGER(4)")]
	[DebuggerNonUserCode]
	public Int32 Shipvia
	{
		get
		{
			return shipvia;
		}
		set
		{
			if (value != shipvia)
			{
				shipvia = value;
				OnPropertyChanged("Shipvia");
			}
		}
	}

	#endregion

	#warning L189 table linquser.orders has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Employeeid", Name = "linquser_orders_employeeid_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public EntityMSet<Orders> _TODO_L35Orders
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}

	[Association(Storage = "null", OtherKey = "Customerid", Name = "linquser_orders_customerid_linquser_customers_customerid")]
	[DebuggerNonUserCode]
	public EntityMSet<Orders> _TODO_L35Orders_linquser_orders_customerid_linquser_customers_customerid
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Orders> lInQUserOrdersEmployeEiDLInQUserEmployeesEmployeEiD;
	[Association(Storage = "lInQUserOrdersEmployeEiDLInQUserEmployeesEmployeEiD", ThisKey = "Employeeid", Name = "linquser_orders_employeeid_linquser_employees_employeeid")]
	[DebuggerNonUserCode]
	public Orders Employees
	{
		get
		{
			return lInQUserOrdersEmployeEiDLInQUserEmployeesEmployeEiD.Entity;
		}
		set
		{
			lInQUserOrdersEmployeEiDLInQUserEmployeesEmployeEiD.Entity = value;
		}
	}

	private System.Data.Linq.EntityRef<Orders> lInQUserOrdersCustomERidLInQUserCustomersCustomERid;
	[Association(Storage = "lInQUserOrdersCustomERidLInQUserCustomersCustomERid", ThisKey = "Customerid", Name = "linquser_orders_customerid_linquser_customers_customerid")]
	[DebuggerNonUserCode]
	public Orders Customers
	{
		get
		{
			return lInQUserOrdersCustomERidLInQUserCustomersCustomERid.Entity;
		}
		set
		{
			lInQUserOrdersCustomERidLInQUserCustomersCustomERid.Entity = value;
		}
	}


	#endregion

}

[Table(Name = "linquser.products")]
public partial class Products : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region  Categoryid

	private Int32 categoryid;
	[Column(Storage = "categoryid", Name = "categoryid", DbType = "INTEGER(4)")]
	[DebuggerNonUserCode]
	public Int32 Categoryid
	{
		get
		{
			return categoryid;
		}
		set
		{
			if (value != categoryid)
			{
				categoryid = value;
				OnPropertyChanged("Categoryid");
			}
		}
	}

	#endregion

	#region  Discontinued

	private Int16 discontinued;
	[Column(Storage = "discontinued", Name = "discontinued", DbType = "INTEGER(2)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int16 Discontinued
	{
		get
		{
			return discontinued;
		}
		set
		{
			if (value != discontinued)
			{
				discontinued = value;
				OnPropertyChanged("Discontinued");
			}
		}
	}

	#endregion

	#region  Productid

	private Int32 productid;
	[Column(Storage = "productid", Name = "productid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Productid
	{
		get
		{
			return productid;
		}
		set
		{
			if (value != productid)
			{
				productid = value;
				OnPropertyChanged("Productid");
			}
		}
	}

	#endregion

	#region string Productname

	private string productname;
	[Column(Storage = "productname", Name = "productname", DbType = "VARCHAR(40)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Productname
	{
		get
		{
			return productname;
		}
		set
		{
			if (value != productname)
			{
				productname = value;
				OnPropertyChanged("Productname");
			}
		}
	}

	#endregion

	#region string Quantityperunit

	private string quantityperunit;
	[Column(Storage = "quantityperunit", Name = "quantityperunit", DbType = "VARCHAR(20)")]
	[DebuggerNonUserCode]
	public string Quantityperunit
	{
		get
		{
			return quantityperunit;
		}
		set
		{
			if (value != quantityperunit)
			{
				quantityperunit = value;
				OnPropertyChanged("Quantityperunit");
			}
		}
	}

	#endregion

	#region  Reorderlevel

	private Int16 reorderlevel;
	[Column(Storage = "reorderlevel", Name = "reorderlevel", DbType = "INTEGER(2)")]
	[DebuggerNonUserCode]
	public Int16 Reorderlevel
	{
		get
		{
			return reorderlevel;
		}
		set
		{
			if (value != reorderlevel)
			{
				reorderlevel = value;
				OnPropertyChanged("Reorderlevel");
			}
		}
	}

	#endregion

	#region  Supplierid

	private Int32 supplierid;
	[Column(Storage = "supplierid", Name = "supplierid", DbType = "INTEGER(4)")]
	[DebuggerNonUserCode]
	public Int32 Supplierid
	{
		get
		{
			return supplierid;
		}
		set
		{
			if (value != supplierid)
			{
				supplierid = value;
				OnPropertyChanged("Supplierid");
			}
		}
	}

	#endregion

	#region  Unitprice

	private Decimal unitprice;
	[Column(Storage = "unitprice", Name = "unitprice", DbType = "DECIMAL(5, 0)")]
	[DebuggerNonUserCode]
	public Decimal Unitprice
	{
		get
		{
			return unitprice;
		}
		set
		{
			if (value != unitprice)
			{
				unitprice = value;
				OnPropertyChanged("Unitprice");
			}
		}
	}

	#endregion

	#region  Unitsinstock

	private Int16 unitsinstock;
	[Column(Storage = "unitsinstock", Name = "unitsinstock", DbType = "INTEGER(2)")]
	[DebuggerNonUserCode]
	public Int16 Unitsinstock
	{
		get
		{
			return unitsinstock;
		}
		set
		{
			if (value != unitsinstock)
			{
				unitsinstock = value;
				OnPropertyChanged("Unitsinstock");
			}
		}
	}

	#endregion

	#region  Unitsonorder

	private Int16 unitsonorder;
	[Column(Storage = "unitsonorder", Name = "unitsonorder", DbType = "INTEGER(2)")]
	[DebuggerNonUserCode]
	public Int16 Unitsonorder
	{
		get
		{
			return unitsonorder;
		}
		set
		{
			if (value != unitsonorder)
			{
				unitsonorder = value;
				OnPropertyChanged("Unitsonorder");
			}
		}
	}

	#endregion

	#warning L189 table linquser.products has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Supplierid", Name = "linquser_products_supplierid_linquser_suppliers_supplierid")]
	[DebuggerNonUserCode]
	public EntityMSet<Products> _TODO_L35Products
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}

	[Association(Storage = "null", OtherKey = "Categoryid", Name = "linquser_products_categoryid_linquser_categories_categoryid")]
	[DebuggerNonUserCode]
	public EntityMSet<Products> _TODO_L35Products_linquser_products_categoryid_linquser_categories_categoryid
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Products> lInQUserProductsSupplierIDLInQUserSuppliersSupplierID;
	[Association(Storage = "lInQUserProductsSupplierIDLInQUserSuppliersSupplierID", ThisKey = "Supplierid", Name = "linquser_products_supplierid_linquser_suppliers_supplierid")]
	[DebuggerNonUserCode]
	public Products Suppliers
	{
		get
		{
			return lInQUserProductsSupplierIDLInQUserSuppliersSupplierID.Entity;
		}
		set
		{
			lInQUserProductsSupplierIDLInQUserSuppliersSupplierID.Entity = value;
		}
	}

	private System.Data.Linq.EntityRef<Products> lInQUserProductsCategoryIDLInQUserCategoriesCategoryID;
	[Association(Storage = "lInQUserProductsCategoryIDLInQUserCategoriesCategoryID", ThisKey = "Categoryid", Name = "linquser_products_categoryid_linquser_categories_categoryid")]
	[DebuggerNonUserCode]
	public Products Categories
	{
		get
		{
			return lInQUserProductsCategoryIDLInQUserCategoriesCategoryID.Entity;
		}
		set
		{
			lInQUserProductsCategoryIDLInQUserCategoriesCategoryID.Entity = value;
		}
	}


	#endregion

}

[Table(Name = "linquser.region")]
public partial class Region : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string Regiondescription

	private string regiondescription;
	[Column(Storage = "regiondescription", Name = "regiondescription", DbType = "VARCHAR(50)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Regiondescription
	{
		get
		{
			return regiondescription;
		}
		set
		{
			if (value != regiondescription)
			{
				regiondescription = value;
				OnPropertyChanged("Regiondescription");
			}
		}
	}

	#endregion

	#region  Regionid

	private Int32 regionid;
	[Column(Storage = "regionid", Name = "regionid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Regionid
	{
		get
		{
			return regionid;
		}
		set
		{
			if (value != regionid)
			{
				regionid = value;
				OnPropertyChanged("Regionid");
			}
		}
	}

	#endregion

	#warning L189 table linquser.region has no primary key. Multiple C# objects will refer to the same row.
}

[Table(Name = "linquser.suppliers")]
public partial class Suppliers : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region string Address

	private string address;
	[Column(Storage = "address", Name = "address", DbType = "VARCHAR(60)")]
	[DebuggerNonUserCode]
	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			if (value != address)
			{
				address = value;
				OnPropertyChanged("Address");
			}
		}
	}

	#endregion

	#region string City

	private string city;
	[Column(Storage = "city", Name = "city", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string City
	{
		get
		{
			return city;
		}
		set
		{
			if (value != city)
			{
				city = value;
				OnPropertyChanged("City");
			}
		}
	}

	#endregion

	#region string Companyname

	private string companyname;
	[Column(Storage = "companyname", Name = "companyname", DbType = "VARCHAR(40)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Companyname
	{
		get
		{
			return companyname;
		}
		set
		{
			if (value != companyname)
			{
				companyname = value;
				OnPropertyChanged("Companyname");
			}
		}
	}

	#endregion

	#region string Contactname

	private string contactname;
	[Column(Storage = "contactname", Name = "contactname", DbType = "VARCHAR(30)")]
	[DebuggerNonUserCode]
	public string Contactname
	{
		get
		{
			return contactname;
		}
		set
		{
			if (value != contactname)
			{
				contactname = value;
				OnPropertyChanged("Contactname");
			}
		}
	}

	#endregion

	#region string Contacttitle

	private string contacttitle;
	[Column(Storage = "contacttitle", Name = "contacttitle", DbType = "VARCHAR(30)")]
	[DebuggerNonUserCode]
	public string Contacttitle
	{
		get
		{
			return contacttitle;
		}
		set
		{
			if (value != contacttitle)
			{
				contacttitle = value;
				OnPropertyChanged("Contacttitle");
			}
		}
	}

	#endregion

	#region string Country

	private string country;
	[Column(Storage = "country", Name = "country", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Country
	{
		get
		{
			return country;
		}
		set
		{
			if (value != country)
			{
				country = value;
				OnPropertyChanged("Country");
			}
		}
	}

	#endregion

	#region string Fax

	private string fax;
	[Column(Storage = "fax", Name = "fax", DbType = "VARCHAR(24)")]
	[DebuggerNonUserCode]
	public string Fax
	{
		get
		{
			return fax;
		}
		set
		{
			if (value != fax)
			{
				fax = value;
				OnPropertyChanged("Fax");
			}
		}
	}

	#endregion

	#region string Phone

	private string phone;
	[Column(Storage = "phone", Name = "phone", DbType = "VARCHAR(24)")]
	[DebuggerNonUserCode]
	public string Phone
	{
		get
		{
			return phone;
		}
		set
		{
			if (value != phone)
			{
				phone = value;
				OnPropertyChanged("Phone");
			}
		}
	}

	#endregion

	#region string Postalcode

	private string postalcode;
	[Column(Storage = "postalcode", Name = "postalcode", DbType = "VARCHAR(10)")]
	[DebuggerNonUserCode]
	public string Postalcode
	{
		get
		{
			return postalcode;
		}
		set
		{
			if (value != postalcode)
			{
				postalcode = value;
				OnPropertyChanged("Postalcode");
			}
		}
	}

	#endregion

	#region string Region

	private string region;
	[Column(Storage = "region", Name = "region", DbType = "VARCHAR(15)")]
	[DebuggerNonUserCode]
	public string Region
	{
		get
		{
			return region;
		}
		set
		{
			if (value != region)
			{
				region = value;
				OnPropertyChanged("Region");
			}
		}
	}

	#endregion

	#region  Supplierid

	private Int32 supplierid;
	[Column(Storage = "supplierid", Name = "supplierid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Supplierid
	{
		get
		{
			return supplierid;
		}
		set
		{
			if (value != supplierid)
			{
				supplierid = value;
				OnPropertyChanged("Supplierid");
			}
		}
	}

	#endregion

	#warning L189 table linquser.suppliers has no primary key. Multiple C# objects will refer to the same row.
}

[Table(Name = "linquser.territories")]
public partial class Territories : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region  Regionid

	private Int32 regionid;
	[Column(Storage = "regionid", Name = "regionid", DbType = "INTEGER(4)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public Int32 Regionid
	{
		get
		{
			return regionid;
		}
		set
		{
			if (value != regionid)
			{
				regionid = value;
				OnPropertyChanged("Regionid");
			}
		}
	}

	#endregion

	#region string Territorydescription

	private string territorydescription;
	[Column(Storage = "territorydescription", Name = "territorydescription", DbType = "VARCHAR(50)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Territorydescription
	{
		get
		{
			return territorydescription;
		}
		set
		{
			if (value != territorydescription)
			{
				territorydescription = value;
				OnPropertyChanged("Territorydescription");
			}
		}
	}

	#endregion

	#region string Territoryid

	private string territoryid;
	[Column(Storage = "territoryid", Name = "territoryid", DbType = "VARCHAR(20)", CanBeNull = false)]
	[DebuggerNonUserCode]
	public string Territoryid
	{
		get
		{
			return territoryid;
		}
		set
		{
			if (value != territoryid)
			{
				territoryid = value;
				OnPropertyChanged("Territoryid");
			}
		}
	}

	#endregion

	#warning L189 table linquser.territories has no primary key. Multiple C# objects will refer to the same row.
	#region Children

	[Association(Storage = "null", OtherKey = "Regionid", Name = "linquser_territories_regionid_linquser_region_regionid")]
	[DebuggerNonUserCode]
	public EntityMSet<Territories> _TODO_L35Territories
	{
		get
		{
			// L212 - child data available only when part of query
			return null;
		}
	}


	#endregion

	#region Parents

	private System.Data.Linq.EntityRef<Territories> lInQUserTerritoriesRegionIDLInQUserRegionRegionID;
	[Association(Storage = "lInQUserTerritoriesRegionIDLInQUserRegionRegionID", ThisKey = "Regionid", Name = "linquser_territories_regionid_linquser_region_regionid")]
	[DebuggerNonUserCode]
	public Territories Region
	{
		get
		{
			return lInQUserTerritoriesRegionIDLInQUserRegionRegionID.Entity;
		}
		set
		{
			lInQUserTerritoriesRegionIDLInQUserRegionRegionID.Entity = value;
		}
	}


	#endregion

}
