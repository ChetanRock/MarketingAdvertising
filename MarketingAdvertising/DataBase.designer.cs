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

namespace MarketingAdvertising
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MarketingAdvertising")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomerInfo(CustomerInfo instance);
    partial void UpdateCustomerInfo(CustomerInfo instance);
    partial void DeleteCustomerInfo(CustomerInfo instance);
    partial void InsertDeviceInfo(DeviceInfo instance);
    partial void UpdateDeviceInfo(DeviceInfo instance);
    partial void DeleteDeviceInfo(DeviceInfo instance);
    partial void InsertLoginInfo(LoginInfo instance);
    partial void UpdateLoginInfo(LoginInfo instance);
    partial void DeleteLoginInfo(LoginInfo instance);
    partial void InsertSlotInfo(SlotInfo instance);
    partial void UpdateSlotInfo(SlotInfo instance);
    partial void DeleteSlotInfo(SlotInfo instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MarketingAdvertisingConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CustomerInfo> CustomerInfos
		{
			get
			{
				return this.GetTable<CustomerInfo>();
			}
		}
		
		public System.Data.Linq.Table<DeviceInfo> DeviceInfos
		{
			get
			{
				return this.GetTable<DeviceInfo>();
			}
		}
		
		public System.Data.Linq.Table<LoginInfo> LoginInfos
		{
			get
			{
				return this.GetTable<LoginInfo>();
			}
		}
		
		public System.Data.Linq.Table<SlotInfo> SlotInfos
		{
			get
			{
				return this.GetTable<SlotInfo>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertLogin")]
		public int spInsertLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Emailid", DbType="VarChar(200)")] string emailid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), emailid, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertDeviceDetails")]
		public int spInsertDeviceDetails([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string txtDeviceMacId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string txtAddressLine1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtAddressLine2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtCity, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtState, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtCountry)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), txtDeviceMacId, txtAddressLine1, txtAddressLine2, txtCity, txtState, txtCountry);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertCustomerDetails")]
		public int spInsertCustomerDetails([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtCustomerFirstName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtCustomerLastName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string txtCellNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string txtEmailId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), txtCustomerFirstName, txtCustomerLastName, txtCellNumber, txtEmailId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertSlotInfo")]
		public int spInsertSlotInfo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dtDate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dtFrom, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dtTo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string txtDeviceMacId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCustomerId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(500)")] string txtAdPath)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dtDate, dtFrom, dtTo, txtDeviceMacId, intCustomerId, txtAdPath);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerInfo")]
	public partial class CustomerInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _intCustomId;
		
		private string _txtCustomerFirstName;
		
		private string _txtCustomerLastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnintCustomIdChanging(int value);
    partial void OnintCustomIdChanged();
    partial void OntxtCustomerFirstNameChanging(string value);
    partial void OntxtCustomerFirstNameChanged();
    partial void OntxtCustomerLastNameChanging(string value);
    partial void OntxtCustomerLastNameChanged();
    #endregion
		
		public CustomerInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCustomId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int intCustomId
		{
			get
			{
				return this._intCustomId;
			}
			set
			{
				if ((this._intCustomId != value))
				{
					this.OnintCustomIdChanging(value);
					this.SendPropertyChanging();
					this._intCustomId = value;
					this.SendPropertyChanged("intCustomId");
					this.OnintCustomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtCustomerFirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string txtCustomerFirstName
		{
			get
			{
				return this._txtCustomerFirstName;
			}
			set
			{
				if ((this._txtCustomerFirstName != value))
				{
					this.OntxtCustomerFirstNameChanging(value);
					this.SendPropertyChanging();
					this._txtCustomerFirstName = value;
					this.SendPropertyChanged("txtCustomerFirstName");
					this.OntxtCustomerFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtCustomerLastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string txtCustomerLastName
		{
			get
			{
				return this._txtCustomerLastName;
			}
			set
			{
				if ((this._txtCustomerLastName != value))
				{
					this.OntxtCustomerLastNameChanging(value);
					this.SendPropertyChanging();
					this._txtCustomerLastName = value;
					this.SendPropertyChanged("txtCustomerLastName");
					this.OntxtCustomerLastNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DeviceInfo")]
	public partial class DeviceInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _intDeviceId;
		
		private string _txtDeviceMacId;
		
		private string _txtAddressLine1;
		
		private string _txtAddressLine2;
		
		private string _txtCity;
		
		private string _txtState;
		
		private string _txtCountry;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnintDeviceIdChanging(int value);
    partial void OnintDeviceIdChanged();
    partial void OntxtDeviceMacIdChanging(string value);
    partial void OntxtDeviceMacIdChanged();
    partial void OntxtAddressLine1Changing(string value);
    partial void OntxtAddressLine1Changed();
    partial void OntxtAddressLine2Changing(string value);
    partial void OntxtAddressLine2Changed();
    partial void OntxtCityChanging(string value);
    partial void OntxtCityChanged();
    partial void OntxtStateChanging(string value);
    partial void OntxtStateChanged();
    partial void OntxtCountryChanging(string value);
    partial void OntxtCountryChanged();
    #endregion
		
		public DeviceInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDeviceId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int intDeviceId
		{
			get
			{
				return this._intDeviceId;
			}
			set
			{
				if ((this._intDeviceId != value))
				{
					this.OnintDeviceIdChanging(value);
					this.SendPropertyChanging();
					this._intDeviceId = value;
					this.SendPropertyChanged("intDeviceId");
					this.OnintDeviceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtDeviceMacId", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string txtDeviceMacId
		{
			get
			{
				return this._txtDeviceMacId;
			}
			set
			{
				if ((this._txtDeviceMacId != value))
				{
					this.OntxtDeviceMacIdChanging(value);
					this.SendPropertyChanging();
					this._txtDeviceMacId = value;
					this.SendPropertyChanged("txtDeviceMacId");
					this.OntxtDeviceMacIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtAddressLine1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string txtAddressLine1
		{
			get
			{
				return this._txtAddressLine1;
			}
			set
			{
				if ((this._txtAddressLine1 != value))
				{
					this.OntxtAddressLine1Changing(value);
					this.SendPropertyChanging();
					this._txtAddressLine1 = value;
					this.SendPropertyChanged("txtAddressLine1");
					this.OntxtAddressLine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtAddressLine2", DbType="VarChar(50)")]
		public string txtAddressLine2
		{
			get
			{
				return this._txtAddressLine2;
			}
			set
			{
				if ((this._txtAddressLine2 != value))
				{
					this.OntxtAddressLine2Changing(value);
					this.SendPropertyChanging();
					this._txtAddressLine2 = value;
					this.SendPropertyChanged("txtAddressLine2");
					this.OntxtAddressLine2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtCity", DbType="VarChar(50)")]
		public string txtCity
		{
			get
			{
				return this._txtCity;
			}
			set
			{
				if ((this._txtCity != value))
				{
					this.OntxtCityChanging(value);
					this.SendPropertyChanging();
					this._txtCity = value;
					this.SendPropertyChanged("txtCity");
					this.OntxtCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtState", DbType="VarChar(50)")]
		public string txtState
		{
			get
			{
				return this._txtState;
			}
			set
			{
				if ((this._txtState != value))
				{
					this.OntxtStateChanging(value);
					this.SendPropertyChanging();
					this._txtState = value;
					this.SendPropertyChanged("txtState");
					this.OntxtStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtCountry", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string txtCountry
		{
			get
			{
				return this._txtCountry;
			}
			set
			{
				if ((this._txtCountry != value))
				{
					this.OntxtCountryChanging(value);
					this.SendPropertyChanging();
					this._txtCountry = value;
					this.SendPropertyChanged("txtCountry");
					this.OntxtCountryChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginInfo")]
	public partial class LoginInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _intLoginId;
		
		private string _txtEmailId;
		
		private string _txtPassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnintLoginIdChanging(int value);
    partial void OnintLoginIdChanged();
    partial void OntxtEmailIdChanging(string value);
    partial void OntxtEmailIdChanged();
    partial void OntxtPasswordChanging(string value);
    partial void OntxtPasswordChanged();
    #endregion
		
		public LoginInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intLoginId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int intLoginId
		{
			get
			{
				return this._intLoginId;
			}
			set
			{
				if ((this._intLoginId != value))
				{
					this.OnintLoginIdChanging(value);
					this.SendPropertyChanging();
					this._intLoginId = value;
					this.SendPropertyChanged("intLoginId");
					this.OnintLoginIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtEmailId", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string txtEmailId
		{
			get
			{
				return this._txtEmailId;
			}
			set
			{
				if ((this._txtEmailId != value))
				{
					this.OntxtEmailIdChanging(value);
					this.SendPropertyChanging();
					this._txtEmailId = value;
					this.SendPropertyChanged("txtEmailId");
					this.OntxtEmailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtPassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string txtPassword
		{
			get
			{
				return this._txtPassword;
			}
			set
			{
				if ((this._txtPassword != value))
				{
					this.OntxtPasswordChanging(value);
					this.SendPropertyChanging();
					this._txtPassword = value;
					this.SendPropertyChanged("txtPassword");
					this.OntxtPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SlotInfo")]
	public partial class SlotInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _intSlotId;
		
		private System.DateTime _dtDate;
		
		private System.DateTime _dtFrom;
		
		private System.DateTime _dtTo;
		
		private string _txtDeviceMacId;
		
		private int _intCustomerId;
		
		private string _txtAdPath;
		
		private EntityRef<SlotInfo> _SlotInfo2;
		
		private EntityRef<SlotInfo> _SlotInfo1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnintSlotIdChanging(int value);
    partial void OnintSlotIdChanged();
    partial void OndtDateChanging(System.DateTime value);
    partial void OndtDateChanged();
    partial void OndtFromChanging(System.DateTime value);
    partial void OndtFromChanged();
    partial void OndtToChanging(System.DateTime value);
    partial void OndtToChanged();
    partial void OntxtDeviceMacIdChanging(string value);
    partial void OntxtDeviceMacIdChanged();
    partial void OnintCustomerIdChanging(int value);
    partial void OnintCustomerIdChanged();
    partial void OntxtAdPathChanging(string value);
    partial void OntxtAdPathChanged();
    #endregion
		
		public SlotInfo()
		{
			this._SlotInfo2 = default(EntityRef<SlotInfo>);
			this._SlotInfo1 = default(EntityRef<SlotInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSlotId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int intSlotId
		{
			get
			{
				return this._intSlotId;
			}
			set
			{
				if ((this._intSlotId != value))
				{
					if (this._SlotInfo1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnintSlotIdChanging(value);
					this.SendPropertyChanging();
					this._intSlotId = value;
					this.SendPropertyChanged("intSlotId");
					this.OnintSlotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dtDate", DbType="Date NOT NULL")]
		public System.DateTime dtDate
		{
			get
			{
				return this._dtDate;
			}
			set
			{
				if ((this._dtDate != value))
				{
					this.OndtDateChanging(value);
					this.SendPropertyChanging();
					this._dtDate = value;
					this.SendPropertyChanged("dtDate");
					this.OndtDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dtFrom", DbType="DateTime NOT NULL")]
		public System.DateTime dtFrom
		{
			get
			{
				return this._dtFrom;
			}
			set
			{
				if ((this._dtFrom != value))
				{
					this.OndtFromChanging(value);
					this.SendPropertyChanging();
					this._dtFrom = value;
					this.SendPropertyChanged("dtFrom");
					this.OndtFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dtTo", DbType="DateTime NOT NULL")]
		public System.DateTime dtTo
		{
			get
			{
				return this._dtTo;
			}
			set
			{
				if ((this._dtTo != value))
				{
					this.OndtToChanging(value);
					this.SendPropertyChanging();
					this._dtTo = value;
					this.SendPropertyChanged("dtTo");
					this.OndtToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtDeviceMacId", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string txtDeviceMacId
		{
			get
			{
				return this._txtDeviceMacId;
			}
			set
			{
				if ((this._txtDeviceMacId != value))
				{
					this.OntxtDeviceMacIdChanging(value);
					this.SendPropertyChanging();
					this._txtDeviceMacId = value;
					this.SendPropertyChanged("txtDeviceMacId");
					this.OntxtDeviceMacIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCustomerId", DbType="Int NOT NULL")]
		public int intCustomerId
		{
			get
			{
				return this._intCustomerId;
			}
			set
			{
				if ((this._intCustomerId != value))
				{
					this.OnintCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._intCustomerId = value;
					this.SendPropertyChanged("intCustomerId");
					this.OnintCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txtAdPath", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string txtAdPath
		{
			get
			{
				return this._txtAdPath;
			}
			set
			{
				if ((this._txtAdPath != value))
				{
					this.OntxtAdPathChanging(value);
					this.SendPropertyChanging();
					this._txtAdPath = value;
					this.SendPropertyChanged("txtAdPath");
					this.OntxtAdPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SlotInfo_SlotInfo", Storage="_SlotInfo2", ThisKey="intSlotId", OtherKey="intSlotId", IsUnique=true, IsForeignKey=false)]
		public SlotInfo SlotInfo2
		{
			get
			{
				return this._SlotInfo2.Entity;
			}
			set
			{
				SlotInfo previousValue = this._SlotInfo2.Entity;
				if (((previousValue != value) 
							|| (this._SlotInfo2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SlotInfo2.Entity = null;
						previousValue.SlotInfo1 = null;
					}
					this._SlotInfo2.Entity = value;
					if ((value != null))
					{
						value.SlotInfo1 = this;
					}
					this.SendPropertyChanged("SlotInfo2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SlotInfo_SlotInfo", Storage="_SlotInfo1", ThisKey="intSlotId", OtherKey="intSlotId", IsForeignKey=true)]
		public SlotInfo SlotInfo1
		{
			get
			{
				return this._SlotInfo1.Entity;
			}
			set
			{
				SlotInfo previousValue = this._SlotInfo1.Entity;
				if (((previousValue != value) 
							|| (this._SlotInfo1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SlotInfo1.Entity = null;
						previousValue.SlotInfo2 = null;
					}
					this._SlotInfo1.Entity = value;
					if ((value != null))
					{
						value.SlotInfo2 = this;
						this._intSlotId = value.intSlotId;
					}
					else
					{
						this._intSlotId = default(int);
					}
					this.SendPropertyChanged("SlotInfo1");
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
