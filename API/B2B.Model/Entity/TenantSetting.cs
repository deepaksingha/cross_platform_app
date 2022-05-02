using System;

namespace B2B.Model
{
	[Serializable]
	public class TenantSetting : BizObject
	{
		#region Fields

		private int settingID;
		private int tenantID;
		private string entityName;
		private string entityAddress_1;
		private string entityAddress_2;
		private string entityAddress_3;
		private string entityAddress_4;
		private string entityAddress_5;
		private string entityMobile_1;
		private string entityMobile_2;
		private string entityLanline_1;
		private string entityLanline_2;
		private string entityLogoFlag;
		private string entityLogo;
		private string tIN;
		private string pAN;
		private string serviceRegNo;
		private string isActive;
		private int financialYearFrom;
		private int financialYearTo;
		private string regNPrefix;
		private string moneyRecPrefix;
		private string billRefPrefix;
		private string sampleCollectFlag;
		private string labDoctorFlag;
		private string labDoctorList;
		private string radioDoctorFlag;
		private string radioDoctorList;
		private string radReportHeadPrintFlag;
		private string labReportHeadPrintFlag;
		private string keyActivateFlag;
		private string activateDate;
		private string keyCode;
		private string dischargeHeadPrintFlag;
		private string labFooterEnable;
		private string digitalSignatureFlag;
		private string labDispDateTime;
		private string radDispDateTime;
		private string currencyFlag;
		private string currencyName;
		private string disSummaryDclFlag;
		private string disSummaryDclTxt;
		private int regServiceID;
		private string regServiceName;
		private int regDayValidity;
		private int allowBedLimit;
		private decimal maxRetailDue;
		private decimal maxCompanyDue;
		private string entityDesc;
		private string entityHighlight;
		private int multiStikerPerRow;
		private int multiStikerTotalRow;
		private string indentAutoAppFlag;
		private string indentMediAutoAppFlag;
		private string discountExcludeGroupFlag;
		private string discountExcludeGroupID;
		private string discountExcludeServiceFlag;
		private string discountExcludeServiceID;
		private string custom_1;
		private string custom_2;
		private string custom_3;
		private string updatedBy;
		private DateTime createdDate;
		private DateTime updatedDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TenantSetting class.
		/// </summary>
		public TenantSetting()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TenantSetting class.
		/// </summary>
		public TenantSetting(int settingID, int tenantID, string entityName, string entityAddress_1, string entityAddress_2, string entityAddress_3, string entityAddress_4, string entityAddress_5, string entityMobile_1, string entityMobile_2, string entityLanline_1, string entityLanline_2, string entityLogoFlag, string entityLogo, string tIN, string pAN, string serviceRegNo, string isActive, int financialYearFrom, int financialYearTo, string regNPrefix, string moneyRecPrefix, string billRefPrefix, string sampleCollectFlag, string labDoctorFlag, string labDoctorList, string radioDoctorFlag, string radioDoctorList, string radReportHeadPrintFlag, string labReportHeadPrintFlag, string keyActivateFlag, string activateDate, string keyCode, string dischargeHeadPrintFlag, string labFooterEnable, string digitalSignatureFlag, string labDispDateTime, string radDispDateTime, string currencyFlag, string currencyName, string disSummaryDclFlag, string disSummaryDclTxt, int regServiceID, string regServiceName, int regDayValidity, int allowBedLimit, decimal maxRetailDue, decimal maxCompanyDue, string entityDesc, string entityHighlight, int multiStikerPerRow, int multiStikerTotalRow, string indentAutoAppFlag, string indentMediAutoAppFlag, string discountExcludeGroupFlag, string discountExcludeGroupID, string discountExcludeServiceFlag, string discountExcludeServiceID, string custom_1, string custom_2, string custom_3, string updatedBy, DateTime createdDate, DateTime updatedDate)
		{
			this.settingID = settingID;
			this.tenantID = tenantID;
			this.entityName = entityName;
			this.entityAddress_1 = entityAddress_1;
			this.entityAddress_2 = entityAddress_2;
			this.entityAddress_3 = entityAddress_3;
			this.entityAddress_4 = entityAddress_4;
			this.entityAddress_5 = entityAddress_5;
			this.entityMobile_1 = entityMobile_1;
			this.entityMobile_2 = entityMobile_2;
			this.entityLanline_1 = entityLanline_1;
			this.entityLanline_2 = entityLanline_2;
			this.entityLogoFlag = entityLogoFlag;
			this.entityLogo = entityLogo;
			this.tIN = tIN;
			this.pAN = pAN;
			this.serviceRegNo = serviceRegNo;
			this.isActive = isActive;
			this.financialYearFrom = financialYearFrom;
			this.financialYearTo = financialYearTo;
			this.regNPrefix = regNPrefix;
			this.moneyRecPrefix = moneyRecPrefix;
			this.billRefPrefix = billRefPrefix;
			this.sampleCollectFlag = sampleCollectFlag;
			this.labDoctorFlag = labDoctorFlag;
			this.labDoctorList = labDoctorList;
			this.radioDoctorFlag = radioDoctorFlag;
			this.radioDoctorList = radioDoctorList;
			this.radReportHeadPrintFlag = radReportHeadPrintFlag;
			this.labReportHeadPrintFlag = labReportHeadPrintFlag;
			this.keyActivateFlag = keyActivateFlag;
			this.activateDate = activateDate;
			this.keyCode = keyCode;
			this.dischargeHeadPrintFlag = dischargeHeadPrintFlag;
			this.labFooterEnable = labFooterEnable;
			this.digitalSignatureFlag = digitalSignatureFlag;
			this.labDispDateTime = labDispDateTime;
			this.radDispDateTime = radDispDateTime;
			this.currencyFlag = currencyFlag;
			this.currencyName = currencyName;
			this.disSummaryDclFlag = disSummaryDclFlag;
			this.disSummaryDclTxt = disSummaryDclTxt;
			this.regServiceID = regServiceID;
			this.regServiceName = regServiceName;
			this.regDayValidity = regDayValidity;
			this.allowBedLimit = allowBedLimit;
			this.maxRetailDue = maxRetailDue;
			this.maxCompanyDue = maxCompanyDue;
			this.entityDesc = entityDesc;
			this.entityHighlight = entityHighlight;
			this.multiStikerPerRow = multiStikerPerRow;
			this.multiStikerTotalRow = multiStikerTotalRow;
			this.indentAutoAppFlag = indentAutoAppFlag;
			this.indentMediAutoAppFlag = indentMediAutoAppFlag;
			this.discountExcludeGroupFlag = discountExcludeGroupFlag;
			this.discountExcludeGroupID = discountExcludeGroupID;
			this.discountExcludeServiceFlag = discountExcludeServiceFlag;
			this.discountExcludeServiceID = discountExcludeServiceID;
			this.custom_1 = custom_1;
			this.custom_2 = custom_2;
			this.custom_3 = custom_3;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SettingID value.
		/// </summary>
		public  int SettingID
		{
			get { return settingID; }
			set { settingID = value; }
		}

		/// <summary>
		/// Gets or sets the TenantID value.
		/// </summary>
		public  int TenantID
		{
			get { return tenantID; }
			set { tenantID = value; }
		}

		/// <summary>
		/// Gets or sets the EntityName value.
		/// </summary>
		public  string EntityName
		{
			get { return entityName; }
			set { entityName = value; }
		}

		/// <summary>
		/// Gets or sets the EntityAddress_1 value.
		/// </summary>
		public  string EntityAddress_1
		{
			get { return entityAddress_1; }
			set { entityAddress_1 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityAddress_2 value.
		/// </summary>
		public  string EntityAddress_2
		{
			get { return entityAddress_2; }
			set { entityAddress_2 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityAddress_3 value.
		/// </summary>
		public  string EntityAddress_3
		{
			get { return entityAddress_3; }
			set { entityAddress_3 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityAddress_4 value.
		/// </summary>
		public  string EntityAddress_4
		{
			get { return entityAddress_4; }
			set { entityAddress_4 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityAddress_5 value.
		/// </summary>
		public  string EntityAddress_5
		{
			get { return entityAddress_5; }
			set { entityAddress_5 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityMobile_1 value.
		/// </summary>
		public  string EntityMobile_1
		{
			get { return entityMobile_1; }
			set { entityMobile_1 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityMobile_2 value.
		/// </summary>
		public  string EntityMobile_2
		{
			get { return entityMobile_2; }
			set { entityMobile_2 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityLanline_1 value.
		/// </summary>
		public  string EntityLanline_1
		{
			get { return entityLanline_1; }
			set { entityLanline_1 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityLanline_2 value.
		/// </summary>
		public  string EntityLanline_2
		{
			get { return entityLanline_2; }
			set { entityLanline_2 = value; }
		}

		/// <summary>
		/// Gets or sets the EntityLogoFlag value.
		/// </summary>
		public  string EntityLogoFlag
		{
			get { return entityLogoFlag; }
			set { entityLogoFlag = value; }
		}

		/// <summary>
		/// Gets or sets the EntityLogo value.
		/// </summary>
		public  string EntityLogo
		{
			get { return entityLogo; }
			set { entityLogo = value; }
		}

		/// <summary>
		/// Gets or sets the TIN value.
		/// </summary>
		public  string TIN
		{
			get { return tIN; }
			set { tIN = value; }
		}

		/// <summary>
		/// Gets or sets the PAN value.
		/// </summary>
		public  string PAN
		{
			get { return pAN; }
			set { pAN = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceRegNo value.
		/// </summary>
		public  string ServiceRegNo
		{
			get { return serviceRegNo; }
			set { serviceRegNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public  string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the FinancialYearFrom value.
		/// </summary>
		public  int FinancialYearFrom
		{
			get { return financialYearFrom; }
			set { financialYearFrom = value; }
		}

		/// <summary>
		/// Gets or sets the FinancialYearTo value.
		/// </summary>
		public  int FinancialYearTo
		{
			get { return financialYearTo; }
			set { financialYearTo = value; }
		}

		/// <summary>
		/// Gets or sets the RegNPrefix value.
		/// </summary>
		public  string RegNPrefix
		{
			get { return regNPrefix; }
			set { regNPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the MoneyRecPrefix value.
		/// </summary>
		public  string MoneyRecPrefix
		{
			get { return moneyRecPrefix; }
			set { moneyRecPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the BillRefPrefix value.
		/// </summary>
		public  string BillRefPrefix
		{
			get { return billRefPrefix; }
			set { billRefPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCollectFlag value.
		/// </summary>
		public  string SampleCollectFlag
		{
			get { return sampleCollectFlag; }
			set { sampleCollectFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LabDoctorFlag value.
		/// </summary>
		public  string LabDoctorFlag
		{
			get { return labDoctorFlag; }
			set { labDoctorFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LabDoctorList value.
		/// </summary>
		public  string LabDoctorList
		{
			get { return labDoctorList; }
			set { labDoctorList = value; }
		}

		/// <summary>
		/// Gets or sets the RadioDoctorFlag value.
		/// </summary>
		public  string RadioDoctorFlag
		{
			get { return radioDoctorFlag; }
			set { radioDoctorFlag = value; }
		}

		/// <summary>
		/// Gets or sets the RadioDoctorList value.
		/// </summary>
		public  string RadioDoctorList
		{
			get { return radioDoctorList; }
			set { radioDoctorList = value; }
		}

		/// <summary>
		/// Gets or sets the RadReportHeadPrintFlag value.
		/// </summary>
		public  string RadReportHeadPrintFlag
		{
			get { return radReportHeadPrintFlag; }
			set { radReportHeadPrintFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LabReportHeadPrintFlag value.
		/// </summary>
		public  string LabReportHeadPrintFlag
		{
			get { return labReportHeadPrintFlag; }
			set { labReportHeadPrintFlag = value; }
		}

		/// <summary>
		/// Gets or sets the KeyActivateFlag value.
		/// </summary>
		public  string KeyActivateFlag
		{
			get { return keyActivateFlag; }
			set { keyActivateFlag = value; }
		}

		/// <summary>
		/// Gets or sets the ActivateDate value.
		/// </summary>
		public  string ActivateDate
		{
			get { return activateDate; }
			set { activateDate = value; }
		}

		/// <summary>
		/// Gets or sets the KeyCode value.
		/// </summary>
		public  string KeyCode
		{
			get { return keyCode; }
			set { keyCode = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeHeadPrintFlag value.
		/// </summary>
		public  string DischargeHeadPrintFlag
		{
			get { return dischargeHeadPrintFlag; }
			set { dischargeHeadPrintFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LabFooterEnable value.
		/// </summary>
		public  string LabFooterEnable
		{
			get { return labFooterEnable; }
			set { labFooterEnable = value; }
		}

		/// <summary>
		/// Gets or sets the DigitalSignatureFlag value.
		/// </summary>
		public  string DigitalSignatureFlag
		{
			get { return digitalSignatureFlag; }
			set { digitalSignatureFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LabDispDateTime value.
		/// </summary>
		public  string LabDispDateTime
		{
			get { return labDispDateTime; }
			set { labDispDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the RadDispDateTime value.
		/// </summary>
		public  string RadDispDateTime
		{
			get { return radDispDateTime; }
			set { radDispDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyFlag value.
		/// </summary>
		public  string CurrencyFlag
		{
			get { return currencyFlag; }
			set { currencyFlag = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyName value.
		/// </summary>
		public  string CurrencyName
		{
			get { return currencyName; }
			set { currencyName = value; }
		}

		/// <summary>
		/// Gets or sets the DisSummaryDclFlag value.
		/// </summary>
		public  string DisSummaryDclFlag
		{
			get { return disSummaryDclFlag; }
			set { disSummaryDclFlag = value; }
		}

		/// <summary>
		/// Gets or sets the DisSummaryDclTxt value.
		/// </summary>
		public  string DisSummaryDclTxt
		{
			get { return disSummaryDclTxt; }
			set { disSummaryDclTxt = value; }
		}

		/// <summary>
		/// Gets or sets the RegServiceID value.
		/// </summary>
		public  int RegServiceID
		{
			get { return regServiceID; }
			set { regServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the RegServiceName value.
		/// </summary>
		public  string RegServiceName
		{
			get { return regServiceName; }
			set { regServiceName = value; }
		}

		/// <summary>
		/// Gets or sets the RegDayValidity value.
		/// </summary>
		public  int RegDayValidity
		{
			get { return regDayValidity; }
			set { regDayValidity = value; }
		}

		/// <summary>
		/// Gets or sets the AllowBedLimit value.
		/// </summary>
		public  int AllowBedLimit
		{
			get { return allowBedLimit; }
			set { allowBedLimit = value; }
		}

		/// <summary>
		/// Gets or sets the MaxRetailDue value.
		/// </summary>
		public  decimal MaxRetailDue
		{
			get { return maxRetailDue; }
			set { maxRetailDue = value; }
		}

		/// <summary>
		/// Gets or sets the MaxCompanyDue value.
		/// </summary>
		public  decimal MaxCompanyDue
		{
			get { return maxCompanyDue; }
			set { maxCompanyDue = value; }
		}

		/// <summary>
		/// Gets or sets the EntityDesc value.
		/// </summary>
		public  string EntityDesc
		{
			get { return entityDesc; }
			set { entityDesc = value; }
		}

		/// <summary>
		/// Gets or sets the EntityHighlight value.
		/// </summary>
		public  string EntityHighlight
		{
			get { return entityHighlight; }
			set { entityHighlight = value; }
		}

		/// <summary>
		/// Gets or sets the MultiStikerPerRow value.
		/// </summary>
		public  int MultiStikerPerRow
		{
			get { return multiStikerPerRow; }
			set { multiStikerPerRow = value; }
		}

		/// <summary>
		/// Gets or sets the MultiStikerTotalRow value.
		/// </summary>
		public  int MultiStikerTotalRow
		{
			get { return multiStikerTotalRow; }
			set { multiStikerTotalRow = value; }
		}

		/// <summary>
		/// Gets or sets the IndentAutoAppFlag value.
		/// </summary>
		public  string IndentAutoAppFlag
		{
			get { return indentAutoAppFlag; }
			set { indentAutoAppFlag = value; }
		}

		/// <summary>
		/// Gets or sets the IndentMediAutoAppFlag value.
		/// </summary>
		public  string IndentMediAutoAppFlag
		{
			get { return indentMediAutoAppFlag; }
			set { indentMediAutoAppFlag = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountExcludeGroupFlag value.
		/// </summary>
		public  string DiscountExcludeGroupFlag
		{
			get { return discountExcludeGroupFlag; }
			set { discountExcludeGroupFlag = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountExcludeGroupID value.
		/// </summary>
		public  string DiscountExcludeGroupID
		{
			get { return discountExcludeGroupID; }
			set { discountExcludeGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountExcludeServiceFlag value.
		/// </summary>
		public  string DiscountExcludeServiceFlag
		{
			get { return discountExcludeServiceFlag; }
			set { discountExcludeServiceFlag = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountExcludeServiceID value.
		/// </summary>
		public  string DiscountExcludeServiceID
		{
			get { return discountExcludeServiceID; }
			set { discountExcludeServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the Custom_1 value.
		/// </summary>
		public  string Custom_1
		{
			get { return custom_1; }
			set { custom_1 = value; }
		}

		/// <summary>
		/// Gets or sets the Custom_2 value.
		/// </summary>
		public  string Custom_2
		{
			get { return custom_2; }
			set { custom_2 = value; }
		}

		/// <summary>
		/// Gets or sets the Custom_3 value.
		/// </summary>
		public  string Custom_3
		{
			get { return custom_3; }
			set { custom_3 = value; }
		}

		/// <summary>
		/// Gets or sets the UpdatedBy value.
		/// </summary>
		public  string UpdatedBy
		{
			get { return updatedBy; }
			set { updatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		public  DateTime CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}

		/// <summary>
		/// Gets or sets the UpdatedDate value.
		/// </summary>
		public  DateTime UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}

		#endregion
	}
}
