using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class TenantDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public TenantDA()
		{
		}

		public TenantDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Tenant table.
		/// </summary>
		public  int Insert(Tenant tenant)
		{
			ValidationUtility.ValidateArgument("tenant", tenant);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenant.TenantID),
				new SqlParameter("@TenantCode", tenant.TenantCode),
				new SqlParameter("@TenantName", tenant.TenantName),
				new SqlParameter("@ShortName", tenant.ShortName),
				new SqlParameter("@PAN", tenant.PAN),
				new SqlParameter("@TIN", tenant.TIN),
				new SqlParameter("@ServiceRef", tenant.ServiceRef),
				new SqlParameter("@Address1", tenant.Address1),
				new SqlParameter("@Address2", tenant.Address2),
				new SqlParameter("@Address3", tenant.Address3),
				new SqlParameter("@TenantDesc", tenant.TenantDesc),
				new SqlParameter("@Fax", tenant.Fax),
				new SqlParameter("@Email", tenant.Email),
				new SqlParameter("@VATno", tenant.VATno),
				new SqlParameter("@DLNo", tenant.DLNo),
				new SqlParameter("@CSTNo", tenant.CSTNo),
				new SqlParameter("@GST", tenant.GST),
				new SqlParameter("@Lanline", tenant.Lanline),
				new SqlParameter("@Mobile", tenant.Mobile),
				new SqlParameter("@Website", tenant.Website),
				new SqlParameter("@IsActive", tenant.IsActive),
				new SqlParameter("@StatusID", tenant.StatusID),
				new SqlParameter("@SuscriptionStartDate", tenant.SuscriptionStartDate),
				new SqlParameter("@SuscriptionEndDate", tenant.SuscriptionEndDate),
				new SqlParameter("@TenantRemark", tenant.TenantRemark),
				new SqlParameter("@FinancialYear", tenant.FinancialYear),
				new SqlParameter("@CreatedDate", tenant.CreatedDate),
				new SqlParameter("@UpdatedDate", tenant.UpdatedDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantInsert", parameters));
		}

		/// <summary>
		/// Updates a record in the Tenant table.
		/// </summary>
		public  int Update(Tenant tenant)
		{
			ValidationUtility.ValidateArgument("tenant", tenant);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenant.TenantID),
				new SqlParameter("@TenantCode", tenant.TenantCode),
				new SqlParameter("@TenantName", tenant.TenantName),
				new SqlParameter("@ShortName", tenant.ShortName),
				new SqlParameter("@PAN", tenant.PAN),
				new SqlParameter("@TIN", tenant.TIN),
				new SqlParameter("@ServiceRef", tenant.ServiceRef),
				new SqlParameter("@Address1", tenant.Address1),
				new SqlParameter("@Address2", tenant.Address2),
				new SqlParameter("@Address3", tenant.Address3),
				new SqlParameter("@TenantDesc", tenant.TenantDesc),
				new SqlParameter("@Fax", tenant.Fax),
				new SqlParameter("@Email", tenant.Email),
				new SqlParameter("@VATno", tenant.VATno),
				new SqlParameter("@DLNo", tenant.DLNo),
				new SqlParameter("@CSTNo", tenant.CSTNo),
				new SqlParameter("@GST", tenant.GST),
				new SqlParameter("@Lanline", tenant.Lanline),
				new SqlParameter("@Mobile", tenant.Mobile),
				new SqlParameter("@Website", tenant.Website),
				new SqlParameter("@IsActive", tenant.IsActive),
				new SqlParameter("@StatusID", tenant.StatusID),
				new SqlParameter("@SuscriptionStartDate", tenant.SuscriptionStartDate),
				new SqlParameter("@SuscriptionEndDate", tenant.SuscriptionEndDate),
				new SqlParameter("@TenantRemark", tenant.TenantRemark),
				new SqlParameter("@FinancialYear", tenant.FinancialYear),
				new SqlParameter("@CreatedDate", tenant.CreatedDate),
				new SqlParameter("@UpdatedDate", tenant.UpdatedDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the Tenant table by its primary key.
		/// </summary>
		public  int Delete(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the Tenant table.
		/// </summary>
		public  Tenant Select(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TenantSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTenant(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Tenant table.
		/// </summary>
		public  List<Tenant> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TenantSelectAll", parameters))
			{
				List<Tenant> tenantList = new List<Tenant>();
				while (dataReader.Read())
				{
					Tenant tenant = MakeTenant(dataReader);
					tenantList.Add(tenant);
				}

				return tenantList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Tenant class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  Tenant MakeTenant(SqlDataReader dataReader)
		{
			Tenant tenant = new Tenant();
			tenant.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			tenant.TenantCode = SqlClientUtility.GetString(dataReader, "TenantCode", String.Empty);
			tenant.TenantName = SqlClientUtility.GetString(dataReader, "TenantName", String.Empty);
			tenant.ShortName = SqlClientUtility.GetString(dataReader, "ShortName", String.Empty);
			tenant.PAN = SqlClientUtility.GetString(dataReader, "PAN", String.Empty);
			tenant.TIN = SqlClientUtility.GetString(dataReader, "TIN", String.Empty);
			tenant.ServiceRef = SqlClientUtility.GetString(dataReader, "ServiceRef", String.Empty);
			tenant.Address1 = SqlClientUtility.GetString(dataReader, "Address1", String.Empty);
			tenant.Address2 = SqlClientUtility.GetString(dataReader, "Address2", String.Empty);
			tenant.Address3 = SqlClientUtility.GetString(dataReader, "Address3", String.Empty);
			tenant.TenantDesc = SqlClientUtility.GetString(dataReader, "TenantDesc", String.Empty);
			tenant.Fax = SqlClientUtility.GetString(dataReader, "Fax", String.Empty);
			tenant.Email = SqlClientUtility.GetString(dataReader, "Email", String.Empty);
			tenant.VATno = SqlClientUtility.GetString(dataReader, "VATno", String.Empty);
			tenant.DLNo = SqlClientUtility.GetString(dataReader, "DLNo", String.Empty);
			tenant.CSTNo = SqlClientUtility.GetString(dataReader, "CSTNo", String.Empty);
			tenant.GST = SqlClientUtility.GetString(dataReader, "GST", String.Empty);
			tenant.Lanline = SqlClientUtility.GetString(dataReader, "Lanline", String.Empty);
			tenant.Mobile = SqlClientUtility.GetString(dataReader, "Mobile", String.Empty);
			tenant.Website = SqlClientUtility.GetString(dataReader, "Website", String.Empty);
			tenant.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			tenant.StatusID = SqlClientUtility.GetInt32(dataReader, "StatusID", 0);
			tenant.SuscriptionStartDate = SqlClientUtility.GetDateTime(dataReader, "SuscriptionStartDate", DateTime.Now);
			tenant.SuscriptionEndDate = SqlClientUtility.GetDateTime(dataReader, "SuscriptionEndDate", DateTime.Now);
			tenant.TenantRemark = SqlClientUtility.GetString(dataReader, "TenantRemark", String.Empty);
			tenant.FinancialYear = SqlClientUtility.GetInt32(dataReader, "FinancialYear", 0);
			tenant.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			tenant.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);

			return tenant;
		}

		#endregion
	}
}
