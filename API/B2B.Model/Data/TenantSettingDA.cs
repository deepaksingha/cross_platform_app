using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class TenantSettingDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public TenantSettingDA()
		{
		}

		public TenantSettingDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the TenantSetting table.
		/// </summary>
		public  int Insert(TenantSetting tenantSetting)
		{
			ValidationUtility.ValidateArgument("tenantSetting", tenantSetting);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@SettingID", tenantSetting.SettingID),
				new SqlParameter("@TenantID", tenantSetting.TenantID),
				new SqlParameter("@EntityName", tenantSetting.EntityName),
				new SqlParameter("@EntityAddress_1", tenantSetting.EntityAddress_1),
				new SqlParameter("@EntityAddress_2", tenantSetting.EntityAddress_2),
				new SqlParameter("@EntityAddress_3", tenantSetting.EntityAddress_3),
				new SqlParameter("@EntityAddress_4", tenantSetting.EntityAddress_4),
				new SqlParameter("@EntityAddress_5", tenantSetting.EntityAddress_5),
				new SqlParameter("@EntityMobile_1", tenantSetting.EntityMobile_1),
				new SqlParameter("@EntityMobile_2", tenantSetting.EntityMobile_2),
				new SqlParameter("@EntityLanline_1", tenantSetting.EntityLanline_1),
				new SqlParameter("@EntityLanline_2", tenantSetting.EntityLanline_2),
				new SqlParameter("@EntityLogoFlag", tenantSetting.EntityLogoFlag),
				new SqlParameter("@EntityLogo", tenantSetting.EntityLogo),
				new SqlParameter("@TIN", tenantSetting.TIN),
				new SqlParameter("@PAN", tenantSetting.PAN),
				new SqlParameter("@ServiceRegNo", tenantSetting.ServiceRegNo),
				new SqlParameter("@IsActive", tenantSetting.IsActive),
				new SqlParameter("@FinancialYearFrom", tenantSetting.FinancialYearFrom),
				new SqlParameter("@FinancialYearTo", tenantSetting.FinancialYearTo),
				new SqlParameter("@RegNPrefix", tenantSetting.RegNPrefix),
				new SqlParameter("@MoneyRecPrefix", tenantSetting.MoneyRecPrefix),
				new SqlParameter("@BillRefPrefix", tenantSetting.BillRefPrefix),
				new SqlParameter("@SampleCollectFlag", tenantSetting.SampleCollectFlag),
				new SqlParameter("@LabDoctorFlag", tenantSetting.LabDoctorFlag),
				new SqlParameter("@LabDoctorList", tenantSetting.LabDoctorList),
				new SqlParameter("@RadioDoctorFlag", tenantSetting.RadioDoctorFlag),
				new SqlParameter("@RadioDoctorList", tenantSetting.RadioDoctorList),
				new SqlParameter("@RadReportHeadPrintFlag", tenantSetting.RadReportHeadPrintFlag),
				new SqlParameter("@LabReportHeadPrintFlag", tenantSetting.LabReportHeadPrintFlag),
				new SqlParameter("@KeyActivateFlag", tenantSetting.KeyActivateFlag),
				new SqlParameter("@ActivateDate", tenantSetting.ActivateDate),
				new SqlParameter("@KeyCode", tenantSetting.KeyCode),
				new SqlParameter("@DischargeHeadPrintFlag", tenantSetting.DischargeHeadPrintFlag),
				new SqlParameter("@LabFooterEnable", tenantSetting.LabFooterEnable),
				new SqlParameter("@DigitalSignatureFlag", tenantSetting.DigitalSignatureFlag),
				new SqlParameter("@LabDispDateTime", tenantSetting.LabDispDateTime),
				new SqlParameter("@RadDispDateTime", tenantSetting.RadDispDateTime),
				new SqlParameter("@CurrencyFlag", tenantSetting.CurrencyFlag),
				new SqlParameter("@CurrencyName", tenantSetting.CurrencyName),
				new SqlParameter("@DisSummaryDclFlag", tenantSetting.DisSummaryDclFlag),
				new SqlParameter("@DisSummaryDclTxt", tenantSetting.DisSummaryDclTxt),
				new SqlParameter("@RegServiceID", tenantSetting.RegServiceID),
				new SqlParameter("@RegServiceName", tenantSetting.RegServiceName),
				new SqlParameter("@RegDayValidity", tenantSetting.RegDayValidity),
				new SqlParameter("@AllowBedLimit", tenantSetting.AllowBedLimit),
				new SqlParameter("@MaxRetailDue", tenantSetting.MaxRetailDue),
				new SqlParameter("@MaxCompanyDue", tenantSetting.MaxCompanyDue),
				new SqlParameter("@EntityDesc", tenantSetting.EntityDesc),
				new SqlParameter("@EntityHighlight", tenantSetting.EntityHighlight),
				new SqlParameter("@MultiStikerPerRow", tenantSetting.MultiStikerPerRow),
				new SqlParameter("@MultiStikerTotalRow", tenantSetting.MultiStikerTotalRow),
				new SqlParameter("@IndentAutoAppFlag", tenantSetting.IndentAutoAppFlag),
				new SqlParameter("@IndentMediAutoAppFlag", tenantSetting.IndentMediAutoAppFlag),
				new SqlParameter("@DiscountExcludeGroupFlag", tenantSetting.DiscountExcludeGroupFlag),
				new SqlParameter("@DiscountExcludeGroupID", tenantSetting.DiscountExcludeGroupID),
				new SqlParameter("@DiscountExcludeServiceFlag", tenantSetting.DiscountExcludeServiceFlag),
				new SqlParameter("@DiscountExcludeServiceID", tenantSetting.DiscountExcludeServiceID),
				new SqlParameter("@Custom_1", tenantSetting.Custom_1),
				new SqlParameter("@Custom_2", tenantSetting.Custom_2),
				new SqlParameter("@Custom_3", tenantSetting.Custom_3),
				new SqlParameter("@UpdatedBy", tenantSetting.UpdatedBy),
				new SqlParameter("@CreatedDate", tenantSetting.CreatedDate),
				new SqlParameter("@UpdatedDate", tenantSetting.UpdatedDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantSettingInsert", parameters));
		}

		/// <summary>
		/// Updates a record in the TenantSetting table.
		/// </summary>
		public  int Update(TenantSetting tenantSetting)
		{
			ValidationUtility.ValidateArgument("tenantSetting", tenantSetting);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@SettingID", tenantSetting.SettingID),
				new SqlParameter("@TenantID", tenantSetting.TenantID),
				new SqlParameter("@EntityName", tenantSetting.EntityName),
				new SqlParameter("@EntityAddress_1", tenantSetting.EntityAddress_1),
				new SqlParameter("@EntityAddress_2", tenantSetting.EntityAddress_2),
				new SqlParameter("@EntityAddress_3", tenantSetting.EntityAddress_3),
				new SqlParameter("@EntityAddress_4", tenantSetting.EntityAddress_4),
				new SqlParameter("@EntityAddress_5", tenantSetting.EntityAddress_5),
				new SqlParameter("@EntityMobile_1", tenantSetting.EntityMobile_1),
				new SqlParameter("@EntityMobile_2", tenantSetting.EntityMobile_2),
				new SqlParameter("@EntityLanline_1", tenantSetting.EntityLanline_1),
				new SqlParameter("@EntityLanline_2", tenantSetting.EntityLanline_2),
				new SqlParameter("@EntityLogoFlag", tenantSetting.EntityLogoFlag),
				new SqlParameter("@EntityLogo", tenantSetting.EntityLogo),
				new SqlParameter("@TIN", tenantSetting.TIN),
				new SqlParameter("@PAN", tenantSetting.PAN),
				new SqlParameter("@ServiceRegNo", tenantSetting.ServiceRegNo),
				new SqlParameter("@IsActive", tenantSetting.IsActive),
				new SqlParameter("@FinancialYearFrom", tenantSetting.FinancialYearFrom),
				new SqlParameter("@FinancialYearTo", tenantSetting.FinancialYearTo),
				new SqlParameter("@RegNPrefix", tenantSetting.RegNPrefix),
				new SqlParameter("@MoneyRecPrefix", tenantSetting.MoneyRecPrefix),
				new SqlParameter("@BillRefPrefix", tenantSetting.BillRefPrefix),
				new SqlParameter("@SampleCollectFlag", tenantSetting.SampleCollectFlag),
				new SqlParameter("@LabDoctorFlag", tenantSetting.LabDoctorFlag),
				new SqlParameter("@LabDoctorList", tenantSetting.LabDoctorList),
				new SqlParameter("@RadioDoctorFlag", tenantSetting.RadioDoctorFlag),
				new SqlParameter("@RadioDoctorList", tenantSetting.RadioDoctorList),
				new SqlParameter("@RadReportHeadPrintFlag", tenantSetting.RadReportHeadPrintFlag),
				new SqlParameter("@LabReportHeadPrintFlag", tenantSetting.LabReportHeadPrintFlag),
				new SqlParameter("@KeyActivateFlag", tenantSetting.KeyActivateFlag),
				new SqlParameter("@ActivateDate", tenantSetting.ActivateDate),
				new SqlParameter("@KeyCode", tenantSetting.KeyCode),
				new SqlParameter("@DischargeHeadPrintFlag", tenantSetting.DischargeHeadPrintFlag),
				new SqlParameter("@LabFooterEnable", tenantSetting.LabFooterEnable),
				new SqlParameter("@DigitalSignatureFlag", tenantSetting.DigitalSignatureFlag),
				new SqlParameter("@LabDispDateTime", tenantSetting.LabDispDateTime),
				new SqlParameter("@RadDispDateTime", tenantSetting.RadDispDateTime),
				new SqlParameter("@CurrencyFlag", tenantSetting.CurrencyFlag),
				new SqlParameter("@CurrencyName", tenantSetting.CurrencyName),
				new SqlParameter("@DisSummaryDclFlag", tenantSetting.DisSummaryDclFlag),
				new SqlParameter("@DisSummaryDclTxt", tenantSetting.DisSummaryDclTxt),
				new SqlParameter("@RegServiceID", tenantSetting.RegServiceID),
				new SqlParameter("@RegServiceName", tenantSetting.RegServiceName),
				new SqlParameter("@RegDayValidity", tenantSetting.RegDayValidity),
				new SqlParameter("@AllowBedLimit", tenantSetting.AllowBedLimit),
				new SqlParameter("@MaxRetailDue", tenantSetting.MaxRetailDue),
				new SqlParameter("@MaxCompanyDue", tenantSetting.MaxCompanyDue),
				new SqlParameter("@EntityDesc", tenantSetting.EntityDesc),
				new SqlParameter("@EntityHighlight", tenantSetting.EntityHighlight),
				new SqlParameter("@MultiStikerPerRow", tenantSetting.MultiStikerPerRow),
				new SqlParameter("@MultiStikerTotalRow", tenantSetting.MultiStikerTotalRow),
				new SqlParameter("@IndentAutoAppFlag", tenantSetting.IndentAutoAppFlag),
				new SqlParameter("@IndentMediAutoAppFlag", tenantSetting.IndentMediAutoAppFlag),
				new SqlParameter("@DiscountExcludeGroupFlag", tenantSetting.DiscountExcludeGroupFlag),
				new SqlParameter("@DiscountExcludeGroupID", tenantSetting.DiscountExcludeGroupID),
				new SqlParameter("@DiscountExcludeServiceFlag", tenantSetting.DiscountExcludeServiceFlag),
				new SqlParameter("@DiscountExcludeServiceID", tenantSetting.DiscountExcludeServiceID),
				new SqlParameter("@Custom_1", tenantSetting.Custom_1),
				new SqlParameter("@Custom_2", tenantSetting.Custom_2),
				new SqlParameter("@Custom_3", tenantSetting.Custom_3),
				new SqlParameter("@UpdatedBy", tenantSetting.UpdatedBy),
				new SqlParameter("@CreatedDate", tenantSetting.CreatedDate),
				new SqlParameter("@UpdatedDate", tenantSetting.UpdatedDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantSettingUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the TenantSetting table by its primary key.
		/// </summary>
		public  int Delete(int settingID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@SettingID", settingID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TenantSettingDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the TenantSetting table.
		/// </summary>
		public  TenantSetting Select(int settingID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@SettingID", settingID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TenantSettingSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTenantSetting(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the TenantSetting table.
		/// </summary>
		public  List<TenantSetting> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TenantSettingSelectAll", parameters))
			{
				List<TenantSetting> tenantSettingList = new List<TenantSetting>();
				while (dataReader.Read())
				{
					TenantSetting tenantSetting = MakeTenantSetting(dataReader);
					tenantSettingList.Add(tenantSetting);
				}

				return tenantSettingList;
			}
		}

		/// <summary>
		/// Creates a new instance of the TenantSetting class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  TenantSetting MakeTenantSetting(SqlDataReader dataReader)
		{
			TenantSetting tenantSetting = new TenantSetting();
			tenantSetting.SettingID = SqlClientUtility.GetInt32(dataReader, "SettingID", 0);
			tenantSetting.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			tenantSetting.EntityName = SqlClientUtility.GetString(dataReader, "EntityName", String.Empty);
			tenantSetting.EntityAddress_1 = SqlClientUtility.GetString(dataReader, "EntityAddress_1", String.Empty);
			tenantSetting.EntityAddress_2 = SqlClientUtility.GetString(dataReader, "EntityAddress_2", String.Empty);
			tenantSetting.EntityAddress_3 = SqlClientUtility.GetString(dataReader, "EntityAddress_3", String.Empty);
			tenantSetting.EntityAddress_4 = SqlClientUtility.GetString(dataReader, "EntityAddress_4", String.Empty);
			tenantSetting.EntityAddress_5 = SqlClientUtility.GetString(dataReader, "EntityAddress_5", String.Empty);
			tenantSetting.EntityMobile_1 = SqlClientUtility.GetString(dataReader, "EntityMobile_1", String.Empty);
			tenantSetting.EntityMobile_2 = SqlClientUtility.GetString(dataReader, "EntityMobile_2", String.Empty);
			tenantSetting.EntityLanline_1 = SqlClientUtility.GetString(dataReader, "EntityLanline_1", String.Empty);
			tenantSetting.EntityLanline_2 = SqlClientUtility.GetString(dataReader, "EntityLanline_2", String.Empty);
			tenantSetting.EntityLogoFlag = SqlClientUtility.GetString(dataReader, "EntityLogoFlag", String.Empty);
			tenantSetting.EntityLogo = SqlClientUtility.GetString(dataReader, "EntityLogo", String.Empty);
			tenantSetting.TIN = SqlClientUtility.GetString(dataReader, "TIN", String.Empty);
			tenantSetting.PAN = SqlClientUtility.GetString(dataReader, "PAN", String.Empty);
			tenantSetting.ServiceRegNo = SqlClientUtility.GetString(dataReader, "ServiceRegNo", String.Empty);
			tenantSetting.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			tenantSetting.FinancialYearFrom = SqlClientUtility.GetInt32(dataReader, "FinancialYearFrom", 0);
			tenantSetting.FinancialYearTo = SqlClientUtility.GetInt32(dataReader, "FinancialYearTo", 0);
			tenantSetting.RegNPrefix = SqlClientUtility.GetString(dataReader, "RegNPrefix", String.Empty);
			tenantSetting.MoneyRecPrefix = SqlClientUtility.GetString(dataReader, "MoneyRecPrefix", String.Empty);
			tenantSetting.BillRefPrefix = SqlClientUtility.GetString(dataReader, "BillRefPrefix", String.Empty);
			tenantSetting.SampleCollectFlag = SqlClientUtility.GetString(dataReader, "SampleCollectFlag", String.Empty);
			tenantSetting.LabDoctorFlag = SqlClientUtility.GetString(dataReader, "LabDoctorFlag", String.Empty);
			tenantSetting.LabDoctorList = SqlClientUtility.GetString(dataReader, "LabDoctorList", String.Empty);
			tenantSetting.RadioDoctorFlag = SqlClientUtility.GetString(dataReader, "RadioDoctorFlag", String.Empty);
			tenantSetting.RadioDoctorList = SqlClientUtility.GetString(dataReader, "RadioDoctorList", String.Empty);
			tenantSetting.RadReportHeadPrintFlag = SqlClientUtility.GetString(dataReader, "RadReportHeadPrintFlag", String.Empty);
			tenantSetting.LabReportHeadPrintFlag = SqlClientUtility.GetString(dataReader, "LabReportHeadPrintFlag", String.Empty);
			tenantSetting.KeyActivateFlag = SqlClientUtility.GetString(dataReader, "KeyActivateFlag", String.Empty);
			tenantSetting.ActivateDate = SqlClientUtility.GetString(dataReader, "ActivateDate", String.Empty);
			tenantSetting.KeyCode = SqlClientUtility.GetString(dataReader, "KeyCode", String.Empty);
			tenantSetting.DischargeHeadPrintFlag = SqlClientUtility.GetString(dataReader, "DischargeHeadPrintFlag", String.Empty);
			tenantSetting.LabFooterEnable = SqlClientUtility.GetString(dataReader, "LabFooterEnable", String.Empty);
			tenantSetting.DigitalSignatureFlag = SqlClientUtility.GetString(dataReader, "DigitalSignatureFlag", String.Empty);
			tenantSetting.LabDispDateTime = SqlClientUtility.GetString(dataReader, "LabDispDateTime", String.Empty);
			tenantSetting.RadDispDateTime = SqlClientUtility.GetString(dataReader, "RadDispDateTime", String.Empty);
			tenantSetting.CurrencyFlag = SqlClientUtility.GetString(dataReader, "CurrencyFlag", String.Empty);
			tenantSetting.CurrencyName = SqlClientUtility.GetString(dataReader, "CurrencyName", String.Empty);
			tenantSetting.DisSummaryDclFlag = SqlClientUtility.GetString(dataReader, "DisSummaryDclFlag", String.Empty);
			tenantSetting.DisSummaryDclTxt = SqlClientUtility.GetString(dataReader, "DisSummaryDclTxt", String.Empty);
			tenantSetting.RegServiceID = SqlClientUtility.GetInt32(dataReader, "RegServiceID", 0);
			tenantSetting.RegServiceName = SqlClientUtility.GetString(dataReader, "RegServiceName", String.Empty);
			tenantSetting.RegDayValidity = SqlClientUtility.GetInt32(dataReader, "RegDayValidity", 0);
			tenantSetting.AllowBedLimit = SqlClientUtility.GetInt32(dataReader, "AllowBedLimit", 0);
			tenantSetting.MaxRetailDue = SqlClientUtility.GetDecimal(dataReader, "MaxRetailDue", Decimal.Zero);
			tenantSetting.MaxCompanyDue = SqlClientUtility.GetDecimal(dataReader, "MaxCompanyDue", Decimal.Zero);
			tenantSetting.EntityDesc = SqlClientUtility.GetString(dataReader, "EntityDesc", String.Empty);
			tenantSetting.EntityHighlight = SqlClientUtility.GetString(dataReader, "EntityHighlight", String.Empty);
			tenantSetting.MultiStikerPerRow = SqlClientUtility.GetInt32(dataReader, "MultiStikerPerRow", 0);
			tenantSetting.MultiStikerTotalRow = SqlClientUtility.GetInt32(dataReader, "MultiStikerTotalRow", 0);
			tenantSetting.IndentAutoAppFlag = SqlClientUtility.GetString(dataReader, "IndentAutoAppFlag", String.Empty);
			tenantSetting.IndentMediAutoAppFlag = SqlClientUtility.GetString(dataReader, "IndentMediAutoAppFlag", String.Empty);
			tenantSetting.DiscountExcludeGroupFlag = SqlClientUtility.GetString(dataReader, "DiscountExcludeGroupFlag", String.Empty);
			tenantSetting.DiscountExcludeGroupID = SqlClientUtility.GetString(dataReader, "DiscountExcludeGroupID", String.Empty);
			tenantSetting.DiscountExcludeServiceFlag = SqlClientUtility.GetString(dataReader, "DiscountExcludeServiceFlag", String.Empty);
			tenantSetting.DiscountExcludeServiceID = SqlClientUtility.GetString(dataReader, "DiscountExcludeServiceID", String.Empty);
			tenantSetting.Custom_1 = SqlClientUtility.GetString(dataReader, "Custom_1", String.Empty);
			tenantSetting.Custom_2 = SqlClientUtility.GetString(dataReader, "Custom_2", String.Empty);
			tenantSetting.Custom_3 = SqlClientUtility.GetString(dataReader, "Custom_3", String.Empty);
			tenantSetting.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);
			tenantSetting.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			tenantSetting.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);

			return tenantSetting;
		}

		#endregion
	}
}
