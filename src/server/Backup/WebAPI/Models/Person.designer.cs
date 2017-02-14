﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Innovation")]
	public partial class PersonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    #endregion
		
		public PersonDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["InnovationConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PersonDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Person> Persons
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persons")]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MisparIshi;
		
		private string _WorkPhone;
		
		private string _GivenName;
		
		private string _JobTitle;
		
		private string _Location;
		
		private string _LongWorkTitle;
		
		private string _AlternateName;
		
		private string _Department;
		
		private string _Company;
		
		private string _Mobile;
		
		private string _Mail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMisparIshiChanging(string value);
    partial void OnMisparIshiChanged();
    partial void OnWorkPhoneChanging(string value);
    partial void OnWorkPhoneChanged();
    partial void OnGivenNameChanging(string value);
    partial void OnGivenNameChanged();
    partial void OnJobTitleChanging(string value);
    partial void OnJobTitleChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnLongWorkTitleChanging(string value);
    partial void OnLongWorkTitleChanged();
    partial void OnAlternateNameChanging(string value);
    partial void OnAlternateNameChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    #endregion
		
		public Person()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MisparIshi", DbType="VarChar(7) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MisparIshi
		{
			get
			{
				return this._MisparIshi;
			}
			set
			{
				if ((this._MisparIshi != value))
				{
					this.OnMisparIshiChanging(value);
					this.SendPropertyChanging();
					this._MisparIshi = value;
					this.SendPropertyChanged("MisparIshi");
					this.OnMisparIshiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkPhone", DbType="VarChar(255)")]
		public string WorkPhone
		{
			get
			{
				return this._WorkPhone;
			}
			set
			{
				if ((this._WorkPhone != value))
				{
					this.OnWorkPhoneChanging(value);
					this.SendPropertyChanging();
					this._WorkPhone = value;
					this.SendPropertyChanged("WorkPhone");
					this.OnWorkPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GivenName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string GivenName
		{
			get
			{
				return this._GivenName;
			}
			set
			{
				if ((this._GivenName != value))
				{
					this.OnGivenNameChanging(value);
					this.SendPropertyChanging();
					this._GivenName = value;
					this.SendPropertyChanged("GivenName");
					this.OnGivenNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobTitle", DbType="VarChar(255)")]
		public string JobTitle
		{
			get
			{
				return this._JobTitle;
			}
			set
			{
				if ((this._JobTitle != value))
				{
					this.OnJobTitleChanging(value);
					this.SendPropertyChanging();
					this._JobTitle = value;
					this.SendPropertyChanged("JobTitle");
					this.OnJobTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(255)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LongWorkTitle", DbType="VarChar(255)")]
		public string LongWorkTitle
		{
			get
			{
				return this._LongWorkTitle;
			}
			set
			{
				if ((this._LongWorkTitle != value))
				{
					this.OnLongWorkTitleChanging(value);
					this.SendPropertyChanging();
					this._LongWorkTitle = value;
					this.SendPropertyChanged("LongWorkTitle");
					this.OnLongWorkTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlternateName", DbType="VarChar(255)")]
		public string AlternateName
		{
			get
			{
				return this._AlternateName;
			}
			set
			{
				if ((this._AlternateName != value))
				{
					this.OnAlternateNameChanging(value);
					this.SendPropertyChanging();
					this._AlternateName = value;
					this.SendPropertyChanged("AlternateName");
					this.OnAlternateNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(255)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(255)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="VarChar(255)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(255)")]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
