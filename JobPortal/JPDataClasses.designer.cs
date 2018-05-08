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

namespace JobPortal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JPDatabase")]
	public partial class JPDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertListing(Listing instance);
    partial void UpdateListing(Listing instance);
    partial void DeleteListing(Listing instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertJobApplication(JobApplication instance);
    partial void UpdateJobApplication(JobApplication instance);
    partial void DeleteJobApplication(JobApplication instance);
    #endregion
		
		public JPDataClassesDataContext() : 
				base(global::JobPortal.Properties.Settings.Default.JPDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JPDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JPDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JPDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JPDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Listing> Listings
		{
			get
			{
				return this.GetTable<Listing>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<JobApplication> JobApplications
		{
			get
			{
				return this.GetTable<JobApplication>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Listing")]
	public partial class Listing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ListingId;
		
		private string _ListingDescription;
		
		private System.Nullable<System.DateTime> _ListedDate;
		
		private System.Nullable<double> _GpaRequirement;
		
		private System.Nullable<double> _ExperienceRequirement;
		
		private System.Nullable<int> _OpenToAll;
		
		private string _ListingTitle;
		
		private System.Nullable<double> _AgeRequirement;
		
		private int _UserId;
		
		private EntitySet<JobApplication> _JobApplications;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnListingIdChanging(int value);
    partial void OnListingIdChanged();
    partial void OnListingDescriptionChanging(string value);
    partial void OnListingDescriptionChanged();
    partial void OnListedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnListedDateChanged();
    partial void OnGpaRequirementChanging(System.Nullable<double> value);
    partial void OnGpaRequirementChanged();
    partial void OnExperienceRequirementChanging(System.Nullable<double> value);
    partial void OnExperienceRequirementChanged();
    partial void OnOpenToAllChanging(System.Nullable<int> value);
    partial void OnOpenToAllChanged();
    partial void OnListingTitleChanging(string value);
    partial void OnListingTitleChanged();
    partial void OnAgeRequirementChanging(System.Nullable<double> value);
    partial void OnAgeRequirementChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    #endregion
		
		public Listing()
		{
			this._JobApplications = new EntitySet<JobApplication>(new Action<JobApplication>(this.attach_JobApplications), new Action<JobApplication>(this.detach_JobApplications));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListingId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ListingId
		{
			get
			{
				return this._ListingId;
			}
			set
			{
				if ((this._ListingId != value))
				{
					this.OnListingIdChanging(value);
					this.SendPropertyChanging();
					this._ListingId = value;
					this.SendPropertyChanged("ListingId");
					this.OnListingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListingDescription", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ListingDescription
		{
			get
			{
				return this._ListingDescription;
			}
			set
			{
				if ((this._ListingDescription != value))
				{
					this.OnListingDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ListingDescription = value;
					this.SendPropertyChanged("ListingDescription");
					this.OnListingDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ListedDate
		{
			get
			{
				return this._ListedDate;
			}
			set
			{
				if ((this._ListedDate != value))
				{
					this.OnListedDateChanging(value);
					this.SendPropertyChanging();
					this._ListedDate = value;
					this.SendPropertyChanged("ListedDate");
					this.OnListedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GpaRequirement", DbType="Float")]
		public System.Nullable<double> GpaRequirement
		{
			get
			{
				return this._GpaRequirement;
			}
			set
			{
				if ((this._GpaRequirement != value))
				{
					this.OnGpaRequirementChanging(value);
					this.SendPropertyChanging();
					this._GpaRequirement = value;
					this.SendPropertyChanged("GpaRequirement");
					this.OnGpaRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExperienceRequirement", DbType="Float")]
		public System.Nullable<double> ExperienceRequirement
		{
			get
			{
				return this._ExperienceRequirement;
			}
			set
			{
				if ((this._ExperienceRequirement != value))
				{
					this.OnExperienceRequirementChanging(value);
					this.SendPropertyChanging();
					this._ExperienceRequirement = value;
					this.SendPropertyChanged("ExperienceRequirement");
					this.OnExperienceRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpenToAll", DbType="Int")]
		public System.Nullable<int> OpenToAll
		{
			get
			{
				return this._OpenToAll;
			}
			set
			{
				if ((this._OpenToAll != value))
				{
					this.OnOpenToAllChanging(value);
					this.SendPropertyChanging();
					this._OpenToAll = value;
					this.SendPropertyChanged("OpenToAll");
					this.OnOpenToAllChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListingTitle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ListingTitle
		{
			get
			{
				return this._ListingTitle;
			}
			set
			{
				if ((this._ListingTitle != value))
				{
					this.OnListingTitleChanging(value);
					this.SendPropertyChanging();
					this._ListingTitle = value;
					this.SendPropertyChanged("ListingTitle");
					this.OnListingTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgeRequirement", DbType="Float")]
		public System.Nullable<double> AgeRequirement
		{
			get
			{
				return this._AgeRequirement;
			}
			set
			{
				if ((this._AgeRequirement != value))
				{
					this.OnAgeRequirementChanging(value);
					this.SendPropertyChanging();
					this._AgeRequirement = value;
					this.SendPropertyChanged("AgeRequirement");
					this.OnAgeRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Listing_JobApplication", Storage="_JobApplications", ThisKey="ListingId", OtherKey="ListingId")]
		public EntitySet<JobApplication> JobApplications
		{
			get
			{
				return this._JobApplications;
			}
			set
			{
				this._JobApplications.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Listing", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Listings.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Listings.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_JobApplications(JobApplication entity)
		{
			this.SendPropertyChanging();
			entity.Listing = this;
		}
		
		private void detach_JobApplications(JobApplication entity)
		{
			this.SendPropertyChanging();
			entity.Listing = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserType;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<double> _Gpa;
		
		private System.Nullable<double> _Age;
		
		private System.Nullable<double> _Experience;
		
		private EntitySet<Listing> _Listings;
		
		private EntitySet<Message> _Messages;
		
		private EntitySet<Message> _Messages1;
		
		private EntitySet<JobApplication> _JobApplications;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnGpaChanging(System.Nullable<double> value);
    partial void OnGpaChanged();
    partial void OnAgeChanging(System.Nullable<double> value);
    partial void OnAgeChanged();
    partial void OnExperienceChanging(System.Nullable<double> value);
    partial void OnExperienceChanged();
    #endregion
		
		public User()
		{
			this._Listings = new EntitySet<Listing>(new Action<Listing>(this.attach_Listings), new Action<Listing>(this.detach_Listings));
			this._Messages = new EntitySet<Message>(new Action<Message>(this.attach_Messages), new Action<Message>(this.detach_Messages));
			this._Messages1 = new EntitySet<Message>(new Action<Message>(this.attach_Messages1), new Action<Message>(this.detach_Messages1));
			this._JobApplications = new EntitySet<JobApplication>(new Action<JobApplication>(this.attach_JobApplications), new Action<JobApplication>(this.detach_JobApplications));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gpa", DbType="Float")]
		public System.Nullable<double> Gpa
		{
			get
			{
				return this._Gpa;
			}
			set
			{
				if ((this._Gpa != value))
				{
					this.OnGpaChanging(value);
					this.SendPropertyChanging();
					this._Gpa = value;
					this.SendPropertyChanged("Gpa");
					this.OnGpaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Float")]
		public System.Nullable<double> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Experience", DbType="Float")]
		public System.Nullable<double> Experience
		{
			get
			{
				return this._Experience;
			}
			set
			{
				if ((this._Experience != value))
				{
					this.OnExperienceChanging(value);
					this.SendPropertyChanging();
					this._Experience = value;
					this.SendPropertyChanged("Experience");
					this.OnExperienceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Listing", Storage="_Listings", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Listing> Listings
		{
			get
			{
				return this._Listings;
			}
			set
			{
				this._Listings.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_Messages", ThisKey="UserId", OtherKey="Sender")]
		public EntitySet<Message> Messages
		{
			get
			{
				return this._Messages;
			}
			set
			{
				this._Messages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_Messages1", ThisKey="UserId", OtherKey="Receiver")]
		public EntitySet<Message> Messages1
		{
			get
			{
				return this._Messages1;
			}
			set
			{
				this._Messages1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_JobApplication", Storage="_JobApplications", ThisKey="UserId", OtherKey="Candidate")]
		public EntitySet<JobApplication> JobApplications
		{
			get
			{
				return this._JobApplications;
			}
			set
			{
				this._JobApplications.Assign(value);
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
		
		private void attach_Listings(Listing entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Listings(Listing entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
		
		private void attach_JobApplications(JobApplication entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_JobApplications(JobApplication entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Message")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MessageId;
		
		private int _Sender;
		
		private int _Receiver;
		
		private string _MessageBody;
		
		private System.DateTime _MessageTime;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMessageIdChanging(int value);
    partial void OnMessageIdChanged();
    partial void OnSenderChanging(int value);
    partial void OnSenderChanged();
    partial void OnReceiverChanging(int value);
    partial void OnReceiverChanged();
    partial void OnMessageBodyChanging(string value);
    partial void OnMessageBodyChanged();
    partial void OnMessageTimeChanging(System.DateTime value);
    partial void OnMessageTimeChanged();
    #endregion
		
		public Message()
		{
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MessageId
		{
			get
			{
				return this._MessageId;
			}
			set
			{
				if ((this._MessageId != value))
				{
					this.OnMessageIdChanging(value);
					this.SendPropertyChanging();
					this._MessageId = value;
					this.SendPropertyChanged("MessageId");
					this.OnMessageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sender", DbType="Int NOT NULL")]
		public int Sender
		{
			get
			{
				return this._Sender;
			}
			set
			{
				if ((this._Sender != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSenderChanging(value);
					this.SendPropertyChanging();
					this._Sender = value;
					this.SendPropertyChanged("Sender");
					this.OnSenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Receiver", DbType="Int NOT NULL")]
		public int Receiver
		{
			get
			{
				return this._Receiver;
			}
			set
			{
				if ((this._Receiver != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReceiverChanging(value);
					this.SendPropertyChanging();
					this._Receiver = value;
					this.SendPropertyChanged("Receiver");
					this.OnReceiverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageBody", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string MessageBody
		{
			get
			{
				return this._MessageBody;
			}
			set
			{
				if ((this._MessageBody != value))
				{
					this.OnMessageBodyChanging(value);
					this.SendPropertyChanging();
					this._MessageBody = value;
					this.SendPropertyChanged("MessageBody");
					this.OnMessageBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageTime", DbType="DateTime NOT NULL")]
		public System.DateTime MessageTime
		{
			get
			{
				return this._MessageTime;
			}
			set
			{
				if ((this._MessageTime != value))
				{
					this.OnMessageTimeChanging(value);
					this.SendPropertyChanging();
					this._MessageTime = value;
					this.SendPropertyChanged("MessageTime");
					this.OnMessageTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_User", ThisKey="Sender", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Messages.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Messages.Add(this);
						this._Sender = value.UserId;
					}
					else
					{
						this._Sender = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_User1", ThisKey="Receiver", OtherKey="UserId", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Messages1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Messages1.Add(this);
						this._Receiver = value.UserId;
					}
					else
					{
						this._Receiver = default(int);
					}
					this.SendPropertyChanged("User1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JobApplication")]
	public partial class JobApplication : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ApplicationId;
		
		private int _Candidate;
		
		private int _ListingId;
		
		private EntityRef<Listing> _Listing;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnApplicationIdChanging(int value);
    partial void OnApplicationIdChanged();
    partial void OnCandidateChanging(int value);
    partial void OnCandidateChanged();
    partial void OnListingIdChanging(int value);
    partial void OnListingIdChanged();
    #endregion
		
		public JobApplication()
		{
			this._Listing = default(EntityRef<Listing>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Candidate", DbType="Int NOT NULL")]
		public int Candidate
		{
			get
			{
				return this._Candidate;
			}
			set
			{
				if ((this._Candidate != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCandidateChanging(value);
					this.SendPropertyChanging();
					this._Candidate = value;
					this.SendPropertyChanged("Candidate");
					this.OnCandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListingId", DbType="Int NOT NULL")]
		public int ListingId
		{
			get
			{
				return this._ListingId;
			}
			set
			{
				if ((this._ListingId != value))
				{
					if (this._Listing.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnListingIdChanging(value);
					this.SendPropertyChanging();
					this._ListingId = value;
					this.SendPropertyChanged("ListingId");
					this.OnListingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Listing_JobApplication", Storage="_Listing", ThisKey="ListingId", OtherKey="ListingId", IsForeignKey=true)]
		public Listing Listing
		{
			get
			{
				return this._Listing.Entity;
			}
			set
			{
				Listing previousValue = this._Listing.Entity;
				if (((previousValue != value) 
							|| (this._Listing.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Listing.Entity = null;
						previousValue.JobApplications.Remove(this);
					}
					this._Listing.Entity = value;
					if ((value != null))
					{
						value.JobApplications.Add(this);
						this._ListingId = value.ListingId;
					}
					else
					{
						this._ListingId = default(int);
					}
					this.SendPropertyChanged("Listing");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_JobApplication", Storage="_User", ThisKey="Candidate", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.JobApplications.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.JobApplications.Add(this);
						this._Candidate = value.UserId;
					}
					else
					{
						this._Candidate = default(int);
					}
					this.SendPropertyChanged("User");
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
