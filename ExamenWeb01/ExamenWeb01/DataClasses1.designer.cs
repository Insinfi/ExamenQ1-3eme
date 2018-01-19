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

namespace ExamenWeb01
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
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Cours20172018ConnectionString"].ConnectionString, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllArticleByGenre")]
		public ISingleResult<GetAllArticleByGenreResult> GetAllArticleByGenre([global::System.Data.Linq.Mapping.ParameterAttribute(Name="GenreID", DbType="UniqueIdentifier")] System.Nullable<System.Guid> genreID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), genreID);
			return ((ISingleResult<GetAllArticleByGenreResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllGenre")]
		public ISingleResult<GetAllGenreResult> GetAllGenre()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllGenreResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllArticle")]
		public ISingleResult<GetAllArticleResult> GetAllArticle()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllArticleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetPhotoByArticleID")]
		public ISingleResult<GetPhotoByArticleIDResult> GetPhotoByArticleID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetPhotoByArticleIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllColl")]
		public ISingleResult<GetAllCollResult> GetAllColl()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllCollResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetArticle")]
		public ISingleResult<GetArticleResult> GetArticle([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetArticleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateByID")]
		public int UpdateByID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gid", DbType="UniqueIdentifier")] System.Nullable<System.Guid> gid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cid", DbType="UniqueIdentifier")] System.Nullable<System.Guid> cid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nom", DbType="NVarChar(50)")] string nom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Des", DbType="NVarChar(MAX)")] string des)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, gid, cid, nom, des);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetMyBalls")]
		public ISingleResult<GetMyBallsResult> GetMyBalls([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<GetMyBallsResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetAllArticleByGenreResult
	{
		
		private string _Nom;
		
		private string _CollNom;
		
		private System.Guid _Articleid;
		
		public GetAllArticleByGenreResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CollNom
		{
			get
			{
				return this._CollNom;
			}
			set
			{
				if ((this._CollNom != value))
				{
					this._CollNom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Articleid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Articleid
		{
			get
			{
				return this._Articleid;
			}
			set
			{
				if ((this._Articleid != value))
				{
					this._Articleid = value;
				}
			}
		}
	}
	
	public partial class GetAllGenreResult
	{
		
		private string _GNom;
		
		private System.Guid _Genreid;
		
		public GetAllGenreResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string GNom
		{
			get
			{
				return this._GNom;
			}
			set
			{
				if ((this._GNom != value))
				{
					this._GNom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genreid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Genreid
		{
			get
			{
				return this._Genreid;
			}
			set
			{
				if ((this._Genreid != value))
				{
					this._Genreid = value;
				}
			}
		}
	}
	
	public partial class GetAllArticleResult
	{
		
		private System.Guid _Articleid;
		
		private string _Nom;
		
		private System.Guid _Genreid;
		
		private string _CollNom;
		
		private System.Nullable<int> _Stock;
		
		private System.Data.Linq.Binary _photo;
		
		public GetAllArticleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Articleid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Articleid
		{
			get
			{
				return this._Articleid;
			}
			set
			{
				if ((this._Articleid != value))
				{
					this._Articleid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genreid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Genreid
		{
			get
			{
				return this._Genreid;
			}
			set
			{
				if ((this._Genreid != value))
				{
					this._Genreid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CollNom
		{
			get
			{
				return this._CollNom;
			}
			set
			{
				if ((this._CollNom != value))
				{
					this._CollNom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock", DbType="Int")]
		public System.Nullable<int> Stock
		{
			get
			{
				return this._Stock;
			}
			set
			{
				if ((this._Stock != value))
				{
					this._Stock = value;
				}
			}
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
	
	public partial class GetPhotoByArticleIDResult
	{
		
		private System.Data.Linq.Binary _photo;
		
		public GetPhotoByArticleIDResult()
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
	
	public partial class GetAllCollResult
	{
		
		private System.Guid _Collectionid;
		
		private string _CollNom;
		
		public GetAllCollResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Collectionid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Collectionid
		{
			get
			{
				return this._Collectionid;
			}
			set
			{
				if ((this._Collectionid != value))
				{
					this._Collectionid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CollNom
		{
			get
			{
				return this._CollNom;
			}
			set
			{
				if ((this._CollNom != value))
				{
					this._CollNom = value;
				}
			}
		}
	}
	
	public partial class GetArticleResult
	{
		
		private System.Guid _Articleid;
		
		private string _Nom;
		
		private string _GNom;
		
		private string _CollNom;
		
		private System.Guid _Genreid;
		
		private System.Guid _Collid;
		
		private string _Descriptif;
		
		public GetArticleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Articleid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Articleid
		{
			get
			{
				return this._Articleid;
			}
			set
			{
				if ((this._Articleid != value))
				{
					this._Articleid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string GNom
		{
			get
			{
				return this._GNom;
			}
			set
			{
				if ((this._GNom != value))
				{
					this._GNom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollNom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CollNom
		{
			get
			{
				return this._CollNom;
			}
			set
			{
				if ((this._CollNom != value))
				{
					this._CollNom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genreid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Genreid
		{
			get
			{
				return this._Genreid;
			}
			set
			{
				if ((this._Genreid != value))
				{
					this._Genreid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Collid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Collid
		{
			get
			{
				return this._Collid;
			}
			set
			{
				if ((this._Collid != value))
				{
					this._Collid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descriptif", DbType="NVarChar(MAX)")]
		public string Descriptif
		{
			get
			{
				return this._Descriptif;
			}
			set
			{
				if ((this._Descriptif != value))
				{
					this._Descriptif = value;
				}
			}
		}
	}
	
	public partial class GetMyBallsResult
	{
		
		private System.Data.Linq.Binary _photo;
		
		public GetMyBallsResult()
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
