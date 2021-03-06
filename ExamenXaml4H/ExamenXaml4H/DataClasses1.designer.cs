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

namespace ExamenXaml4H
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Cours20172018")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ExamenXaml4H.Properties.Settings.Default.Cours20172018ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetCurrentContact")]
		public ISingleResult<GetCurrentContactResult> GetCurrentContact([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetCurrentContactResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetRDVByID")]
		public ISingleResult<GetRDVByIDResult> GetRDVByID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetRDVByIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllContact")]
		public ISingleResult<GetAllContactResult> GetAllContact()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllContactResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetCurrentContactResult
	{
		
		private System.Guid _IdContact;
		
		private string _Nom;
		
		private string _Prenom;
		
		private string _rue;
		
		private string _Localite;
		
		private string _Gsm;
		
		private System.Nullable<System.DateTime> _BirthDay;
		
		public GetCurrentContactResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdContact", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdContact
		{
			get
			{
				return this._IdContact;
			}
			set
			{
				if ((this._IdContact != value))
				{
					this._IdContact = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this._Nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this._Prenom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rue", DbType="NVarChar(50)")]
		public string rue
		{
			get
			{
				return this._rue;
			}
			set
			{
				if ((this._rue != value))
				{
					this._rue = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localite", DbType="NVarChar(50)")]
		public string Localite
		{
			get
			{
				return this._Localite;
			}
			set
			{
				if ((this._Localite != value))
				{
					this._Localite = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gsm", DbType="NVarChar(50)")]
		public string Gsm
		{
			get
			{
				return this._Gsm;
			}
			set
			{
				if ((this._Gsm != value))
				{
					this._Gsm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDay", DbType="DateTime")]
		public System.Nullable<System.DateTime> BirthDay
		{
			get
			{
				return this._BirthDay;
			}
			set
			{
				if ((this._BirthDay != value))
				{
					this._BirthDay = value;
				}
			}
		}
	}
	
	public partial class GetRDVByIDResult
	{
		
		private System.Nullable<System.DateTime> _DateHeureRV;
		
		private string _Commentaire;
		
		private System.Guid _IdRV;
		
		public GetRDVByIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateHeureRV", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateHeureRV
		{
			get
			{
				return this._DateHeureRV;
			}
			set
			{
				if ((this._DateHeureRV != value))
				{
					this._DateHeureRV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Commentaire", DbType="NVarChar(50)")]
		public string Commentaire
		{
			get
			{
				return this._Commentaire;
			}
			set
			{
				if ((this._Commentaire != value))
				{
					this._Commentaire = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRV", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdRV
		{
			get
			{
				return this._IdRV;
			}
			set
			{
				if ((this._IdRV != value))
				{
					this._IdRV = value;
				}
			}
		}
	}
	
	public partial class GetAllContactResult
	{
		
		private System.Guid _IdContact;
		
		private string _Nom;
		
		private string _Prenom;
		
		private string _Gsm;
		
		private System.Data.Linq.Binary _Photo;
		
		public GetAllContactResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdContact", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdContact
		{
			get
			{
				return this._IdContact;
			}
			set
			{
				if ((this._IdContact != value))
				{
					this._IdContact = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this._Nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this._Prenom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gsm", DbType="NVarChar(50)")]
		public string Gsm
		{
			get
			{
				return this._Gsm;
			}
			set
			{
				if ((this._Gsm != value))
				{
					this._Gsm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image")]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this._Photo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
