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

namespace AlexLabBL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AlexLab")]
	public partial class DataClassesAlexLabDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAppointment(Appointment instance);
    partial void UpdateAppointment(Appointment instance);
    partial void DeleteAppointment(Appointment instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertResource(Resource instance);
    partial void UpdateResource(Resource instance);
    partial void DeleteResource(Resource instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertCourseType(CourseType instance);
    partial void UpdateCourseType(CourseType instance);
    partial void DeleteCourseType(CourseType instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    #endregion
		
		public DataClassesAlexLabDataContext() : 
				base(global::AlexLabBL.Properties.Settings.Default.AlexLabConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesAlexLabDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesAlexLabDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesAlexLabDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesAlexLabDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Appointment> Appointments
		{
			get
			{
				return this.GetTable<Appointment>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<Resource> Resources
		{
			get
			{
				return this.GetTable<Resource>();
			}
		}
		
		public System.Data.Linq.Table<Client> Clients
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<CourseType> CourseTypes
		{
			get
			{
				return this.GetTable<CourseType>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Appointments")]
	public partial class Appointment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UniqueID;
		
		private System.Nullable<int> _Type;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<bool> _AllDay;
		
		private string _Subject;
		
		private string _Location;
		
		private string _Description;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<int> _Label;
		
		private System.Nullable<int> _ResourceID;
		
		private string _ResourceIDs;
		
		private string _ReminderInfo;
		
		private string _RecurrenceInfo;
		
		private string _CustomField1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUniqueIDChanging(int value);
    partial void OnUniqueIDChanged();
    partial void OnTypeChanging(System.Nullable<int> value);
    partial void OnTypeChanged();
    partial void OnStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    partial void OnAllDayChanging(System.Nullable<bool> value);
    partial void OnAllDayChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnLabelChanging(System.Nullable<int> value);
    partial void OnLabelChanged();
    partial void OnResourceIDChanging(System.Nullable<int> value);
    partial void OnResourceIDChanged();
    partial void OnResourceIDsChanging(string value);
    partial void OnResourceIDsChanged();
    partial void OnReminderInfoChanging(string value);
    partial void OnReminderInfoChanged();
    partial void OnRecurrenceInfoChanging(string value);
    partial void OnRecurrenceInfoChanged();
    partial void OnCustomField1Changing(string value);
    partial void OnCustomField1Changed();
    #endregion
		
		public Appointment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UniqueID
		{
			get
			{
				return this._UniqueID;
			}
			set
			{
				if ((this._UniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._UniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int")]
		public System.Nullable<int> Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllDay", DbType="Bit")]
		public System.Nullable<bool> AllDay
		{
			get
			{
				return this._AllDay;
			}
			set
			{
				if ((this._AllDay != value))
				{
					this.OnAllDayChanging(value);
					this.SendPropertyChanging();
					this._AllDay = value;
					this.SendPropertyChanged("AllDay");
					this.OnAllDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(50)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Label", DbType="Int")]
		public System.Nullable<int> Label
		{
			get
			{
				return this._Label;
			}
			set
			{
				if ((this._Label != value))
				{
					this.OnLabelChanging(value);
					this.SendPropertyChanging();
					this._Label = value;
					this.SendPropertyChanged("Label");
					this.OnLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceID", DbType="Int")]
		public System.Nullable<int> ResourceID
		{
			get
			{
				return this._ResourceID;
			}
			set
			{
				if ((this._ResourceID != value))
				{
					this.OnResourceIDChanging(value);
					this.SendPropertyChanging();
					this._ResourceID = value;
					this.SendPropertyChanged("ResourceID");
					this.OnResourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceIDs", DbType="NVarChar(MAX)")]
		public string ResourceIDs
		{
			get
			{
				return this._ResourceIDs;
			}
			set
			{
				if ((this._ResourceIDs != value))
				{
					this.OnResourceIDsChanging(value);
					this.SendPropertyChanging();
					this._ResourceIDs = value;
					this.SendPropertyChanged("ResourceIDs");
					this.OnResourceIDsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReminderInfo", DbType="NVarChar(MAX)")]
		public string ReminderInfo
		{
			get
			{
				return this._ReminderInfo;
			}
			set
			{
				if ((this._ReminderInfo != value))
				{
					this.OnReminderInfoChanging(value);
					this.SendPropertyChanging();
					this._ReminderInfo = value;
					this.SendPropertyChanged("ReminderInfo");
					this.OnReminderInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecurrenceInfo", DbType="NVarChar(MAX)")]
		public string RecurrenceInfo
		{
			get
			{
				return this._RecurrenceInfo;
			}
			set
			{
				if ((this._RecurrenceInfo != value))
				{
					this.OnRecurrenceInfoChanging(value);
					this.SendPropertyChanging();
					this._RecurrenceInfo = value;
					this.SendPropertyChanged("RecurrenceInfo");
					this.OnRecurrenceInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomField1", DbType="NVarChar(MAX)")]
		public string CustomField1
		{
			get
			{
				return this._CustomField1;
			}
			set
			{
				if ((this._CustomField1 != value))
				{
					this.OnCustomField1Changing(value);
					this.SendPropertyChanging();
					this._CustomField1 = value;
					this.SendPropertyChanged("CustomField1");
					this.OnCustomField1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoomId;
		
		private string _RoomDesc;
		
		private System.Nullable<decimal> _HourPrice;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    partial void OnRoomDescChanging(string value);
    partial void OnRoomDescChanged();
    partial void OnHourPriceChanging(System.Nullable<decimal> value);
    partial void OnHourPriceChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Room()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomDesc", DbType="NVarChar(50)")]
		public string RoomDesc
		{
			get
			{
				return this._RoomDesc;
			}
			set
			{
				if ((this._RoomDesc != value))
				{
					this.OnRoomDescChanging(value);
					this.SendPropertyChanging();
					this._RoomDesc = value;
					this.SendPropertyChanged("RoomDesc");
					this.OnRoomDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HourPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> HourPrice
		{
			get
			{
				return this._HourPrice;
			}
			set
			{
				if ((this._HourPrice != value))
				{
					this.OnHourPriceChanging(value);
					this.SendPropertyChanging();
					this._HourPrice = value;
					this.SendPropertyChanged("HourPrice");
					this.OnHourPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(50)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Resources")]
	public partial class Resource : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UniqueID;
		
		private int _ResourceID;
		
		private string _ResourceName;
		
		private System.Nullable<int> _Color;
		
		private System.Data.Linq.Binary _Image;
		
		private string _CustomField1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUniqueIDChanging(int value);
    partial void OnUniqueIDChanged();
    partial void OnResourceIDChanging(int value);
    partial void OnResourceIDChanged();
    partial void OnResourceNameChanging(string value);
    partial void OnResourceNameChanged();
    partial void OnColorChanging(System.Nullable<int> value);
    partial void OnColorChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    partial void OnCustomField1Changing(string value);
    partial void OnCustomField1Changed();
    #endregion
		
		public Resource()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UniqueID
		{
			get
			{
				return this._UniqueID;
			}
			set
			{
				if ((this._UniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._UniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceID", DbType="Int NOT NULL")]
		public int ResourceID
		{
			get
			{
				return this._ResourceID;
			}
			set
			{
				if ((this._ResourceID != value))
				{
					this.OnResourceIDChanging(value);
					this.SendPropertyChanging();
					this._ResourceID = value;
					this.SendPropertyChanged("ResourceID");
					this.OnResourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceName", DbType="NVarChar(50)")]
		public string ResourceName
		{
			get
			{
				return this._ResourceName;
			}
			set
			{
				if ((this._ResourceName != value))
				{
					this.OnResourceNameChanging(value);
					this.SendPropertyChanging();
					this._ResourceName = value;
					this.SendPropertyChanged("ResourceName");
					this.OnResourceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="Int")]
		public System.Nullable<int> Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomField1", DbType="NVarChar(MAX)")]
		public string CustomField1
		{
			get
			{
				return this._CustomField1;
			}
			set
			{
				if ((this._CustomField1 != value))
				{
					this.OnCustomField1Changing(value);
					this.SendPropertyChanging();
					this._CustomField1 = value;
					this.SendPropertyChanged("CustomField1");
					this.OnCustomField1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClientId;
		
		private string _ClientName;
		
		private string _ClientPhone;
		
		private string _ClientNationalId;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientIdChanging(int value);
    partial void OnClientIdChanged();
    partial void OnClientNameChanging(string value);
    partial void OnClientNameChanged();
    partial void OnClientPhoneChanging(string value);
    partial void OnClientPhoneChanged();
    partial void OnClientNationalIdChanging(string value);
    partial void OnClientNationalIdChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientName", DbType="NVarChar(50)")]
		public string ClientName
		{
			get
			{
				return this._ClientName;
			}
			set
			{
				if ((this._ClientName != value))
				{
					this.OnClientNameChanging(value);
					this.SendPropertyChanging();
					this._ClientName = value;
					this.SendPropertyChanged("ClientName");
					this.OnClientNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientPhone", DbType="NVarChar(50)")]
		public string ClientPhone
		{
			get
			{
				return this._ClientPhone;
			}
			set
			{
				if ((this._ClientPhone != value))
				{
					this.OnClientPhoneChanging(value);
					this.SendPropertyChanging();
					this._ClientPhone = value;
					this.SendPropertyChanged("ClientPhone");
					this.OnClientPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientNationalId", DbType="NVarChar(50)")]
		public string ClientNationalId
		{
			get
			{
				return this._ClientNationalId;
			}
			set
			{
				if ((this._ClientNationalId != value))
				{
					this.OnClientNationalIdChanging(value);
					this.SendPropertyChanging();
					this._ClientNationalId = value;
					this.SendPropertyChanged("ClientNationalId");
					this.OnClientNationalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(MAX)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CourseType")]
	public partial class CourseType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CourseTypeId;
		
		private string _CourseTypeDesc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseTypeIdChanging(int value);
    partial void OnCourseTypeIdChanged();
    partial void OnCourseTypeDescChanging(string value);
    partial void OnCourseTypeDescChanged();
    #endregion
		
		public CourseType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseTypeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CourseTypeId
		{
			get
			{
				return this._CourseTypeId;
			}
			set
			{
				if ((this._CourseTypeId != value))
				{
					this.OnCourseTypeIdChanging(value);
					this.SendPropertyChanging();
					this._CourseTypeId = value;
					this.SendPropertyChanged("CourseTypeId");
					this.OnCourseTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseTypeDesc", DbType="NVarChar(50)")]
		public string CourseTypeDesc
		{
			get
			{
				return this._CourseTypeDesc;
			}
			set
			{
				if ((this._CourseTypeDesc != value))
				{
					this.OnCourseTypeDescChanging(value);
					this.SendPropertyChanging();
					this._CourseTypeDesc = value;
					this.SendPropertyChanged("CourseTypeDesc");
					this.OnCourseTypeDescChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CourseId;
		
		private System.Nullable<int> _CourseTypeId;
		
		private System.Nullable<int> _ClientId;
		
		private string _CourseName;
		
		private System.Nullable<decimal> _StudentBookMoney;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnCourseTypeIdChanging(System.Nullable<int> value);
    partial void OnCourseTypeIdChanged();
    partial void OnClientIdChanging(System.Nullable<int> value);
    partial void OnClientIdChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnStudentBookMoneyChanging(System.Nullable<decimal> value);
    partial void OnStudentBookMoneyChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Course()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseTypeId", DbType="Int")]
		public System.Nullable<int> CourseTypeId
		{
			get
			{
				return this._CourseTypeId;
			}
			set
			{
				if ((this._CourseTypeId != value))
				{
					this.OnCourseTypeIdChanging(value);
					this.SendPropertyChanging();
					this._CourseTypeId = value;
					this.SendPropertyChanged("CourseTypeId");
					this.OnCourseTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="Int")]
		public System.Nullable<int> ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="NVarChar(50)")]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentBookMoney", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> StudentBookMoney
		{
			get
			{
				return this._StudentBookMoney;
			}
			set
			{
				if ((this._StudentBookMoney != value))
				{
					this.OnStudentBookMoneyChanging(value);
					this.SendPropertyChanging();
					this._StudentBookMoney = value;
					this.SendPropertyChanged("StudentBookMoney");
					this.OnStudentBookMoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(MAX)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
