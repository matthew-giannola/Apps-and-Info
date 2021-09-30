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

namespace Finalprog
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Users")]
	public partial class UserDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void InsertClass(Class instance);
    partial void UpdateClass(Class instance);
    partial void DeleteClass(Class instance);
    partial void Insertquizanswer(quizanswer instance);
    partial void Updatequizanswer(quizanswer instance);
    partial void Deletequizanswer(quizanswer instance);
    partial void Insertquizze(quizze instance);
    partial void Updatequizze(quizze instance);
    partial void Deletequizze(quizze instance);
    partial void Insertquizquestion(quizquestion instance);
    partial void Updatequizquestion(quizquestion instance);
    partial void Deletequizquestion(quizquestion instance);
    #endregion
		
		public UserDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<Class> Classes
		{
			get
			{
				return this.GetTable<Class>();
			}
		}
		
		public System.Data.Linq.Table<quizanswer> quizanswers
		{
			get
			{
				return this.GetTable<quizanswer>();
			}
		}
		
		public System.Data.Linq.Table<quizze> quizzes
		{
			get
			{
				return this.GetTable<quizze>();
			}
		}
		
		public System.Data.Linq.Table<quizquestion> quizquestions
		{
			get
			{
				return this.GetTable<quizquestion>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _username;
		
		private string _password;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _phone_number;
		
		private string _degree;
		
		private string _organization;
		
		private string _role;
		
		private string _email;
		
		private string _status;
		
		private string _color;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    partial void OndegreeChanging(string value);
    partial void OndegreeChanged();
    partial void OnorganizationChanging(string value);
    partial void OnorganizationChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string phone_number
		{
			get
			{
				return this._phone_number;
			}
			set
			{
				if ((this._phone_number != value))
				{
					this.Onphone_numberChanging(value);
					this.SendPropertyChanging();
					this._phone_number = value;
					this.SendPropertyChanged("phone_number");
					this.Onphone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_degree", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string degree
		{
			get
			{
				return this._degree;
			}
			set
			{
				if ((this._degree != value))
				{
					this.OndegreeChanging(value);
					this.SendPropertyChanging();
					this._degree = value;
					this.SendPropertyChanged("degree");
					this.OndegreeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_organization", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string organization
		{
			get
			{
				return this._organization;
			}
			set
			{
				if ((this._organization != value))
				{
					this.OnorganizationChanging(value);
					this.SendPropertyChanging();
					this._organization = value;
					this.SendPropertyChanged("organization");
					this.OnorganizationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(MAX)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NVarChar(50)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Classes")]
	public partial class Class : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _description;
		
		private string _videourl;
		
		private EntitySet<quizze> _quizzes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnvideourlChanging(string value);
    partial void OnvideourlChanged();
    #endregion
		
		public Class()
		{
			this._quizzes = new EntitySet<quizze>(new Action<quizze>(this.attach_quizzes), new Action<quizze>(this.detach_quizzes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_videourl", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string videourl
		{
			get
			{
				return this._videourl;
			}
			set
			{
				if ((this._videourl != value))
				{
					this.OnvideourlChanging(value);
					this.SendPropertyChanging();
					this._videourl = value;
					this.SendPropertyChanged("videourl");
					this.OnvideourlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_quizze", Storage="_quizzes", ThisKey="Id", OtherKey="courseid")]
		public EntitySet<quizze> quizzes
		{
			get
			{
				return this._quizzes;
			}
			set
			{
				this._quizzes.Assign(value);
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
		
		private void attach_quizzes(quizze entity)
		{
			this.SendPropertyChanging();
			entity.Class = this;
		}
		
		private void detach_quizzes(quizze entity)
		{
			this.SendPropertyChanging();
			entity.Class = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.quizanswers")]
	public partial class quizanswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _aid;
		
		private string _answer;
		
		private int _quizid;
		
		private int _qqid;
		
		private bool _correctanswer;
		
		private int _qcount;
		
		private int _anum;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnaidChanging(int value);
    partial void OnaidChanged();
    partial void OnanswerChanging(string value);
    partial void OnanswerChanged();
    partial void OnquizidChanging(int value);
    partial void OnquizidChanged();
    partial void OnqqidChanging(int value);
    partial void OnqqidChanged();
    partial void OncorrectanswerChanging(bool value);
    partial void OncorrectanswerChanged();
    partial void OnqcountChanging(int value);
    partial void OnqcountChanged();
    partial void OnanumChanging(int value);
    partial void OnanumChanged();
    #endregion
		
		public quizanswer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int aid
		{
			get
			{
				return this._aid;
			}
			set
			{
				if ((this._aid != value))
				{
					this.OnaidChanging(value);
					this.SendPropertyChanging();
					this._aid = value;
					this.SendPropertyChanged("aid");
					this.OnaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string answer
		{
			get
			{
				return this._answer;
			}
			set
			{
				if ((this._answer != value))
				{
					this.OnanswerChanging(value);
					this.SendPropertyChanging();
					this._answer = value;
					this.SendPropertyChanged("answer");
					this.OnanswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quizid", DbType="Int NOT NULL")]
		public int quizid
		{
			get
			{
				return this._quizid;
			}
			set
			{
				if ((this._quizid != value))
				{
					this.OnquizidChanging(value);
					this.SendPropertyChanging();
					this._quizid = value;
					this.SendPropertyChanged("quizid");
					this.OnquizidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qqid", DbType="Int NOT NULL")]
		public int qqid
		{
			get
			{
				return this._qqid;
			}
			set
			{
				if ((this._qqid != value))
				{
					this.OnqqidChanging(value);
					this.SendPropertyChanging();
					this._qqid = value;
					this.SendPropertyChanged("qqid");
					this.OnqqidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correctanswer", DbType="Bit NOT NULL")]
		public bool correctanswer
		{
			get
			{
				return this._correctanswer;
			}
			set
			{
				if ((this._correctanswer != value))
				{
					this.OncorrectanswerChanging(value);
					this.SendPropertyChanging();
					this._correctanswer = value;
					this.SendPropertyChanged("correctanswer");
					this.OncorrectanswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qcount", DbType="Int NOT NULL")]
		public int qcount
		{
			get
			{
				return this._qcount;
			}
			set
			{
				if ((this._qcount != value))
				{
					this.OnqcountChanging(value);
					this.SendPropertyChanging();
					this._qcount = value;
					this.SendPropertyChanged("qcount");
					this.OnqcountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anum", DbType="Int NOT NULL")]
		public int anum
		{
			get
			{
				return this._anum;
			}
			set
			{
				if ((this._anum != value))
				{
					this.OnanumChanging(value);
					this.SendPropertyChanging();
					this._anum = value;
					this.SendPropertyChanged("anum");
					this.OnanumChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.quizzes")]
	public partial class quizze : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _quizid;
		
		private string _quiztitle;
		
		private System.Nullable<int> _courseid;
		
		private EntitySet<quizquestion> _quizquestions;
		
		private EntityRef<Class> _Class;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnquizidChanging(int value);
    partial void OnquizidChanged();
    partial void OnquiztitleChanging(string value);
    partial void OnquiztitleChanged();
    partial void OncourseidChanging(System.Nullable<int> value);
    partial void OncourseidChanged();
    #endregion
		
		public quizze()
		{
			this._quizquestions = new EntitySet<quizquestion>(new Action<quizquestion>(this.attach_quizquestions), new Action<quizquestion>(this.detach_quizquestions));
			this._Class = default(EntityRef<Class>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quizid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int quizid
		{
			get
			{
				return this._quizid;
			}
			set
			{
				if ((this._quizid != value))
				{
					this.OnquizidChanging(value);
					this.SendPropertyChanging();
					this._quizid = value;
					this.SendPropertyChanged("quizid");
					this.OnquizidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quiztitle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string quiztitle
		{
			get
			{
				return this._quiztitle;
			}
			set
			{
				if ((this._quiztitle != value))
				{
					this.OnquiztitleChanging(value);
					this.SendPropertyChanging();
					this._quiztitle = value;
					this.SendPropertyChanged("quiztitle");
					this.OnquiztitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseid", DbType="Int")]
		public System.Nullable<int> courseid
		{
			get
			{
				return this._courseid;
			}
			set
			{
				if ((this._courseid != value))
				{
					if (this._Class.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncourseidChanging(value);
					this.SendPropertyChanging();
					this._courseid = value;
					this.SendPropertyChanged("courseid");
					this.OncourseidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="quizze_quizquestion", Storage="_quizquestions", ThisKey="quizid", OtherKey="quizid")]
		public EntitySet<quizquestion> quizquestions
		{
			get
			{
				return this._quizquestions;
			}
			set
			{
				this._quizquestions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_quizze", Storage="_Class", ThisKey="courseid", OtherKey="Id", IsForeignKey=true)]
		public Class Class
		{
			get
			{
				return this._Class.Entity;
			}
			set
			{
				Class previousValue = this._Class.Entity;
				if (((previousValue != value) 
							|| (this._Class.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Class.Entity = null;
						previousValue.quizzes.Remove(this);
					}
					this._Class.Entity = value;
					if ((value != null))
					{
						value.quizzes.Add(this);
						this._courseid = value.Id;
					}
					else
					{
						this._courseid = default(Nullable<int>);
					}
					this.SendPropertyChanged("Class");
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
		
		private void attach_quizquestions(quizquestion entity)
		{
			this.SendPropertyChanging();
			entity.quizze = this;
		}
		
		private void detach_quizquestions(quizquestion entity)
		{
			this.SendPropertyChanging();
			entity.quizze = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.quizquestions")]
	public partial class quizquestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _qid;
		
		private string _question;
		
		private int _quizid;
		
		private int _qcount;
		
		private EntityRef<quizze> _quizze;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnqidChanging(int value);
    partial void OnqidChanged();
    partial void OnquestionChanging(string value);
    partial void OnquestionChanged();
    partial void OnquizidChanging(int value);
    partial void OnquizidChanged();
    partial void OnqcountChanging(int value);
    partial void OnqcountChanged();
    #endregion
		
		public quizquestion()
		{
			this._quizze = default(EntityRef<quizze>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int qid
		{
			get
			{
				return this._qid;
			}
			set
			{
				if ((this._qid != value))
				{
					this.OnqidChanging(value);
					this.SendPropertyChanging();
					this._qid = value;
					this.SendPropertyChanged("qid");
					this.OnqidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_question", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string question
		{
			get
			{
				return this._question;
			}
			set
			{
				if ((this._question != value))
				{
					this.OnquestionChanging(value);
					this.SendPropertyChanging();
					this._question = value;
					this.SendPropertyChanged("question");
					this.OnquestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quizid", DbType="Int NOT NULL")]
		public int quizid
		{
			get
			{
				return this._quizid;
			}
			set
			{
				if ((this._quizid != value))
				{
					if (this._quizze.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnquizidChanging(value);
					this.SendPropertyChanging();
					this._quizid = value;
					this.SendPropertyChanged("quizid");
					this.OnquizidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qcount", DbType="Int NOT NULL")]
		public int qcount
		{
			get
			{
				return this._qcount;
			}
			set
			{
				if ((this._qcount != value))
				{
					this.OnqcountChanging(value);
					this.SendPropertyChanging();
					this._qcount = value;
					this.SendPropertyChanged("qcount");
					this.OnqcountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="quizze_quizquestion", Storage="_quizze", ThisKey="quizid", OtherKey="quizid", IsForeignKey=true)]
		public quizze quizze
		{
			get
			{
				return this._quizze.Entity;
			}
			set
			{
				quizze previousValue = this._quizze.Entity;
				if (((previousValue != value) 
							|| (this._quizze.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._quizze.Entity = null;
						previousValue.quizquestions.Remove(this);
					}
					this._quizze.Entity = value;
					if ((value != null))
					{
						value.quizquestions.Add(this);
						this._quizid = value.quizid;
					}
					else
					{
						this._quizid = default(int);
					}
					this.SendPropertyChanged("quizze");
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
