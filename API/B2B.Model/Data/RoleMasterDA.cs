using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class RoleMasterDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public RoleMasterDA()
		{
		}

		public RoleMasterDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the RoleMaster table.
		/// </summary>
		public  int Insert(RoleMaster roleMaster)
		{
			ValidationUtility.ValidateArgument("roleMaster", roleMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@RoleID", roleMaster.RoleID),
				new SqlParameter("@TenantID", roleMaster.TenantID),
				new SqlParameter("@IsActive", roleMaster.IsActive),
				new SqlParameter("@RoleCode", roleMaster.RoleCode),
				new SqlParameter("@RoleName", roleMaster.RoleName),
				new SqlParameter("@RoleRemark", roleMaster.RoleRemark),
				new SqlParameter("@CreatedDate", roleMaster.CreatedDate),
				new SqlParameter("@UpdatedDate", roleMaster.UpdatedDate),
				new SqlParameter("@CreatedBy", roleMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", roleMaster.UpdatedBy)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "RoleMasterInsert", parameters));
		}

		/// <summary>
		/// Updates a record in the RoleMaster table.
		/// </summary>
		public  int Update(RoleMaster roleMaster)
		{
			ValidationUtility.ValidateArgument("roleMaster", roleMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@RoleID", roleMaster.RoleID),
				new SqlParameter("@TenantID", roleMaster.TenantID),
				new SqlParameter("@IsActive", roleMaster.IsActive),
				new SqlParameter("@RoleCode", roleMaster.RoleCode),
				new SqlParameter("@RoleName", roleMaster.RoleName),
				new SqlParameter("@RoleRemark", roleMaster.RoleRemark),
				new SqlParameter("@CreatedDate", roleMaster.CreatedDate),
				new SqlParameter("@UpdatedDate", roleMaster.UpdatedDate),
				new SqlParameter("@CreatedBy", roleMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", roleMaster.UpdatedBy)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "RoleMasterUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the RoleMaster table by its primary key.
		/// </summary>
		public  int Delete(int roleID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@RoleID", roleID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "RoleMasterDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the RoleMaster table.
		/// </summary>
		public  RoleMaster Select(int roleID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@RoleID", roleID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "RoleMasterSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeRoleMaster(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the RoleMaster table.
		/// </summary>
		public  List<RoleMaster> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "RoleMasterSelectAll", parameters))
			{
				List<RoleMaster> roleMasterList = new List<RoleMaster>();
				while (dataReader.Read())
				{
					RoleMaster roleMaster = MakeRoleMaster(dataReader);
					roleMasterList.Add(roleMaster);
				}

				return roleMasterList;
			}
		}

		/// <summary>
		/// Creates a new instance of the RoleMaster class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  RoleMaster MakeRoleMaster(SqlDataReader dataReader)
		{
			RoleMaster roleMaster = new RoleMaster();
			roleMaster.RoleID = SqlClientUtility.GetInt32(dataReader, "RoleID", 0);
			roleMaster.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			roleMaster.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			roleMaster.RoleCode = SqlClientUtility.GetString(dataReader, "RoleCode", String.Empty);
			roleMaster.RoleName = SqlClientUtility.GetString(dataReader, "RoleName", String.Empty);
			roleMaster.RoleRemark = SqlClientUtility.GetString(dataReader, "RoleRemark", String.Empty);
			roleMaster.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			roleMaster.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);
			roleMaster.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			roleMaster.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);

			return roleMaster;
		}

		#endregion
	}
}
