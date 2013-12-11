using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection;

using OrmLib;

namespace dbMantenimientoBiz
{
	/// <summary>
	/// Wraps stored proceedure calls
	/// </summary>
	public class StoredProcedures 
	{
		private	static DataManager dm;
		/// <summary>
		/// Wraps stored proceedure calls
		/// </summary>
		static StoredProcedures() { dm = new DataManager(Config.Dsn);}
	
		/// <summary>
		/// Calls sp_helpdiagrams, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_helpdiagrams(  System.String diagramname,
  System.Int32 owner_id )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );


			DataSet ds = dm.ExecuteProcedure("sp_helpdiagrams", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_helpdiagramdefinition, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_helpdiagramdefinition(  System.String diagramname,
  System.Int32 owner_id )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );


			DataSet ds = dm.ExecuteProcedure("sp_helpdiagramdefinition", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_creatediagram, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_creatediagram(  System.String diagramname,
  System.Int32 owner_id,
  System.Int32 version,
  System.Byte[] definition )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );

			SqlParameter paramversion = new SqlParameter( "@version", version);
			paramversion.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramversion.Direction = ParameterDirection.Input;
			paramversion.Size = 4;
			arrayParams.Add( paramversion );

			SqlParameter paramdefinition = new SqlParameter( "@definition", definition);
			paramdefinition.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "varbinary", true);
			paramdefinition.Direction = ParameterDirection.Input;
			paramdefinition.Size = -1;
			arrayParams.Add( paramdefinition );


			DataSet ds = dm.ExecuteProcedure("sp_creatediagram", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_renamediagram, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_renamediagram(  System.String diagramname,
  System.Int32 owner_id,
  System.String new_diagramname )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );

			SqlParameter paramnew_diagramname = new SqlParameter( "@new_diagramname", new_diagramname);
			paramnew_diagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramnew_diagramname.Direction = ParameterDirection.Input;
			paramnew_diagramname.Size = 256;
			arrayParams.Add( paramnew_diagramname );


			DataSet ds = dm.ExecuteProcedure("sp_renamediagram", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_alterdiagram, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_alterdiagram(  System.String diagramname,
  System.Int32 owner_id,
  System.Int32 version,
  System.Byte[] definition )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );

			SqlParameter paramversion = new SqlParameter( "@version", version);
			paramversion.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramversion.Direction = ParameterDirection.Input;
			paramversion.Size = 4;
			arrayParams.Add( paramversion );

			SqlParameter paramdefinition = new SqlParameter( "@definition", definition);
			paramdefinition.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "varbinary", true);
			paramdefinition.Direction = ParameterDirection.Input;
			paramdefinition.Size = -1;
			arrayParams.Add( paramdefinition );


			DataSet ds = dm.ExecuteProcedure("sp_alterdiagram", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_dropdiagram, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_dropdiagram(  System.String diagramname,
  System.Int32 owner_id )
		{
			ArrayList arrayParams = new ArrayList();
	
			SqlParameter paramdiagramname = new SqlParameter( "@diagramname", diagramname);
			paramdiagramname.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "nvarchar", true);
			paramdiagramname.Direction = ParameterDirection.Input;
			paramdiagramname.Size = 256;
			arrayParams.Add( paramdiagramname );

			SqlParameter paramowner_id = new SqlParameter( "@owner_id", owner_id);
			paramowner_id.SqlDbType = (SqlDbType) Enum.Parse( typeof(SqlDbType), "int", true);
			paramowner_id.Direction = ParameterDirection.Input;
			paramowner_id.Size = 4;
			arrayParams.Add( paramowner_id );


			DataSet ds = dm.ExecuteProcedure("sp_dropdiagram", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}

		/// <summary>
		/// Calls sp_upgraddiagrams, returning a DataSet of any rows returned 
		/// from the stored proceedure.
		/// </summary>
		/// <returns>DataSet</returns>
		public static DataSet sp_upgraddiagrams(  )
		{
			ArrayList arrayParams = new ArrayList();
	

			DataSet ds = dm.ExecuteProcedure("sp_upgraddiagrams", (SqlParameter[]) arrayParams.ToArray(typeof(SqlParameter)));
			
			return ds;
		}


	}
}
