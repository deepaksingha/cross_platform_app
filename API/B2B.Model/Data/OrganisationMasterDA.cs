using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class OrganisationMasterDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public OrganisationMasterDA()
		{
		}

		public OrganisationMasterDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the OrganisationMaster table.
		/// </summary>
		public  int Insert(OrganisationMaster organisationMaster)
		{
			ValidationUtility.ValidateArgument("organisationMaster", organisationMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", organisationMaster.TenantID),
				new SqlParameter("@IsActive", organisationMaster.IsActive),
				new SqlParameter("@OrgTypeID", organisationMaster.OrgTypeID),
				new SqlParameter("@OrgType", organisationMaster.OrgType),
				new SqlParameter("@CustomerTypeID", organisationMaster.CustomerTypeID),
				new SqlParameter("@CustomerType", organisationMaster.CustomerType),
				new SqlParameter("@OrgName", organisationMaster.OrgName),
				new SqlParameter("@OrgCode", organisationMaster.OrgCode),
				new SqlParameter("@Phone", organisationMaster.Phone),
				new SqlParameter("@EntityAddress_1", organisationMaster.EntityAddress_1),
				new SqlParameter("@EntityAddress_2", organisationMaster.EntityAddress_2),
				new SqlParameter("@EntityAddress_3", organisationMaster.EntityAddress_3),
				new SqlParameter("@EntityAddress_4", organisationMaster.EntityAddress_4),
				new SqlParameter("@EntityAddress_5", organisationMaster.EntityAddress_5),
				new SqlParameter("@EntityMobile_1", organisationMaster.EntityMobile_1),
				new SqlParameter("@EntityMobile_2", organisationMaster.EntityMobile_2),
				new SqlParameter("@EntityLanline_1", organisationMaster.EntityLanline_1),
				new SqlParameter("@EntityLanline_2", organisationMaster.EntityLanline_2),
				new SqlParameter("@LogoFlag", organisationMaster.LogoFlag),
				new SqlParameter("@OrgLogo", organisationMaster.OrgLogo),
				new SqlParameter("@TIN", organisationMaster.TIN),
				new SqlParameter("@PAN", organisationMaster.PAN),
				new SqlParameter("@GST", organisationMaster.GST),
				new SqlParameter("@RegNPrefix", organisationMaster.RegNPrefix),
				new SqlParameter("@MoneyRecPrefix", organisationMaster.MoneyRecPrefix),
				new SqlParameter("@BillRefPrefix", organisationMaster.BillRefPrefix),
				new SqlParameter("@CreditLimit", organisationMaster.CreditLimit),
				new SqlParameter("@OpeningBal", organisationMaster.OpeningBal),
				new SqlParameter("@ClosingBal", organisationMaster.ClosingBal),
				new SqlParameter("@Website", organisationMaster.Website),
				new SqlParameter("@Custom_1", organisationMaster.Custom_1),
				new SqlParameter("@Custom_2", organisationMaster.Custom_2),
				new SqlParameter("@Custom_3", organisationMaster.Custom_3),
				new SqlParameter("@CreatedBy", organisationMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", organisationMaster.UpdatedBy),
				new SqlParameter("@CreatedDate", organisationMaster.CreatedDate),
				new SqlParameter("@UpdateDate", organisationMaster.UpdateDate)
			};

			organisationMaster.OrgID = Convert.ToInt32(SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "OrganisationMasterInsert", parameters));
			return organisationMaster.OrgID;
		}

		/// <summary>
		/// Updates a record in the OrganisationMaster table.
		/// </summary>
		public  int Update(OrganisationMaster organisationMaster)
		{
			ValidationUtility.ValidateArgument("organisationMaster", organisationMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrgID", organisationMaster.OrgID),
				new SqlParameter("@TenantID", organisationMaster.TenantID),
				new SqlParameter("@IsActive", organisationMaster.IsActive),
				new SqlParameter("@OrgTypeID", organisationMaster.OrgTypeID),
				new SqlParameter("@OrgType", organisationMaster.OrgType),
				new SqlParameter("@CustomerTypeID", organisationMaster.CustomerTypeID),
				new SqlParameter("@CustomerType", organisationMaster.CustomerType),
				new SqlParameter("@OrgName", organisationMaster.OrgName),
				new SqlParameter("@OrgCode", organisationMaster.OrgCode),
				new SqlParameter("@Phone", organisationMaster.Phone),
				new SqlParameter("@EntityAddress_1", organisationMaster.EntityAddress_1),
				new SqlParameter("@EntityAddress_2", organisationMaster.EntityAddress_2),
				new SqlParameter("@EntityAddress_3", organisationMaster.EntityAddress_3),
				new SqlParameter("@EntityAddress_4", organisationMaster.EntityAddress_4),
				new SqlParameter("@EntityAddress_5", organisationMaster.EntityAddress_5),
				new SqlParameter("@EntityMobile_1", organisationMaster.EntityMobile_1),
				new SqlParameter("@EntityMobile_2", organisationMaster.EntityMobile_2),
				new SqlParameter("@EntityLanline_1", organisationMaster.EntityLanline_1),
				new SqlParameter("@EntityLanline_2", organisationMaster.EntityLanline_2),
				new SqlParameter("@LogoFlag", organisationMaster.LogoFlag),
				new SqlParameter("@OrgLogo", organisationMaster.OrgLogo),
				new SqlParameter("@TIN", organisationMaster.TIN),
				new SqlParameter("@PAN", organisationMaster.PAN),
				new SqlParameter("@GST", organisationMaster.GST),
				new SqlParameter("@RegNPrefix", organisationMaster.RegNPrefix),
				new SqlParameter("@MoneyRecPrefix", organisationMaster.MoneyRecPrefix),
				new SqlParameter("@BillRefPrefix", organisationMaster.BillRefPrefix),
				new SqlParameter("@CreditLimit", organisationMaster.CreditLimit),
				new SqlParameter("@OpeningBal", organisationMaster.OpeningBal),
				new SqlParameter("@ClosingBal", organisationMaster.ClosingBal),
				new SqlParameter("@Website", organisationMaster.Website),
				new SqlParameter("@Custom_1", organisationMaster.Custom_1),
				new SqlParameter("@Custom_2", organisationMaster.Custom_2),
				new SqlParameter("@Custom_3", organisationMaster.Custom_3),
				new SqlParameter("@CreatedBy", organisationMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", organisationMaster.UpdatedBy),
				new SqlParameter("@CreatedDate", organisationMaster.CreatedDate),
				new SqlParameter("@UpdateDate", organisationMaster.UpdateDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrganisationMasterUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the OrganisationMaster table by its primary key.
		/// </summary>
		public  int Delete(int orgID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrgID", orgID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrganisationMasterDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the OrganisationMaster table.
		/// </summary>
		public  OrganisationMaster Select(int orgID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrgID", orgID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrganisationMasterSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeOrganisationMaster(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the OrganisationMaster table.
		/// </summary>
		public  List<OrganisationMaster> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrganisationMasterSelectAll", parameters))
			{
				List<OrganisationMaster> organisationMasterList = new List<OrganisationMaster>();
				while (dataReader.Read())
				{
					OrganisationMaster organisationMaster = MakeOrganisationMaster(dataReader);
					organisationMasterList.Add(organisationMaster);
				}

				return organisationMasterList;
			}
		}

		/// <summary>
		/// Creates a new instance of the OrganisationMaster class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  OrganisationMaster MakeOrganisationMaster(SqlDataReader dataReader)
		{
			OrganisationMaster organisationMaster = new OrganisationMaster();
			organisationMaster.OrgID = SqlClientUtility.GetInt32(dataReader, "OrgID", 0);
			organisationMaster.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			organisationMaster.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			organisationMaster.OrgTypeID = SqlClientUtility.GetInt32(dataReader, "OrgTypeID", 0);
			organisationMaster.OrgType = SqlClientUtility.GetString(dataReader, "OrgType", String.Empty);
			organisationMaster.CustomerTypeID = SqlClientUtility.GetInt32(dataReader, "CustomerTypeID", 0);
			organisationMaster.CustomerType = SqlClientUtility.GetString(dataReader, "CustomerType", String.Empty);
			organisationMaster.OrgName = SqlClientUtility.GetString(dataReader, "OrgName", String.Empty);
			organisationMaster.OrgCode = SqlClientUtility.GetString(dataReader, "OrgCode", String.Empty);
			organisationMaster.Phone = SqlClientUtility.GetString(dataReader, "Phone", String.Empty);
			organisationMaster.EntityAddress_1 = SqlClientUtility.GetString(dataReader, "EntityAddress_1", String.Empty);
			organisationMaster.EntityAddress_2 = SqlClientUtility.GetString(dataReader, "EntityAddress_2", String.Empty);
			organisationMaster.EntityAddress_3 = SqlClientUtility.GetString(dataReader, "EntityAddress_3", String.Empty);
			organisationMaster.EntityAddress_4 = SqlClientUtility.GetString(dataReader, "EntityAddress_4", String.Empty);
			organisationMaster.EntityAddress_5 = SqlClientUtility.GetString(dataReader, "EntityAddress_5", String.Empty);
			organisationMaster.EntityMobile_1 = SqlClientUtility.GetString(dataReader, "EntityMobile_1", String.Empty);
			organisationMaster.EntityMobile_2 = SqlClientUtility.GetString(dataReader, "EntityMobile_2", String.Empty);
			organisationMaster.EntityLanline_1 = SqlClientUtility.GetString(dataReader, "EntityLanline_1", String.Empty);
			organisationMaster.EntityLanline_2 = SqlClientUtility.GetString(dataReader, "EntityLanline_2", String.Empty);
			organisationMaster.LogoFlag = SqlClientUtility.GetString(dataReader, "LogoFlag", String.Empty);
			organisationMaster.OrgLogo = SqlClientUtility.GetString(dataReader, "OrgLogo", String.Empty);
			organisationMaster.TIN = SqlClientUtility.GetString(dataReader, "TIN", String.Empty);
			organisationMaster.PAN = SqlClientUtility.GetString(dataReader, "PAN", String.Empty);
			organisationMaster.GST = SqlClientUtility.GetString(dataReader, "GST", String.Empty);
			organisationMaster.RegNPrefix = SqlClientUtility.GetString(dataReader, "RegNPrefix", String.Empty);
			organisationMaster.MoneyRecPrefix = SqlClientUtility.GetString(dataReader, "MoneyRecPrefix", String.Empty);
			organisationMaster.BillRefPrefix = SqlClientUtility.GetString(dataReader, "BillRefPrefix", String.Empty);
			organisationMaster.CreditLimit = SqlClientUtility.GetDecimal(dataReader, "CreditLimit", Decimal.Zero);
			organisationMaster.OpeningBal = SqlClientUtility.GetDecimal(dataReader, "OpeningBal", Decimal.Zero);
			organisationMaster.ClosingBal = SqlClientUtility.GetDecimal(dataReader, "ClosingBal", Decimal.Zero);
			organisationMaster.Website = SqlClientUtility.GetString(dataReader, "Website", String.Empty);
			organisationMaster.Custom_1 = SqlClientUtility.GetString(dataReader, "Custom_1", String.Empty);
			organisationMaster.Custom_2 = SqlClientUtility.GetString(dataReader, "Custom_2", String.Empty);
			organisationMaster.Custom_3 = SqlClientUtility.GetString(dataReader, "Custom_3", String.Empty);
			organisationMaster.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			organisationMaster.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);
			organisationMaster.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			organisationMaster.UpdateDate = SqlClientUtility.GetDateTime(dataReader, "UpdateDate", DateTime.Now);

			return organisationMaster;
		}

		#endregion
	}
}
