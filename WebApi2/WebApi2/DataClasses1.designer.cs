﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebRevision")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebRevisionConnectionString"].ConnectionString, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetInfo")]
		public ISingleResult<GetInfoResult> GetInfo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetInfoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetImage")]
		public ISingleResult<GetImageResult> GetImage([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetImageResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetInfoResult
	{
		
		private System.Guid _Idtest;
		
		private string _Nom;
		
		public GetInfoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idtest", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Idtest
		{
			get
			{
				return this._Idtest;
			}
			set
			{
				if ((this._Idtest != value))
				{
					this._Idtest = value;
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
	}
	
	public partial class GetImageResult
	{
		
		private System.Data.Linq.Binary _photo;
		
		public GetImageResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Image")]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this._photo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591