using System;

namespace B2B.Model
{
	[Serializable]
	public class OrganisationMaster : BizObject
	{
		#region Fields

		private int orgID;
		private int tenantID;
		private string isActive;
		private int orgTypeID;
		private string orgType;
		private int customerTypeID;
		private string customerType;
		private string orgName;
		private string orgCode;
		private string phone;
		private string entityAddress_1;
		private string entityAddress_2;
		private string entityAddress_3;
		private string entityAddress_4;
		private string entityAddress_5;
		private string entityMobile_1;
		private string entityMobile_2;
		private string entityLanline_1;
		private string entityLanline_2;
		private string logoFlag;
		private string orgLogo;
		private string tIN;
		private string pAN;
		private string gST;
		private string regNPrefix;
		private string moneyRecPrefix;
		private string billRefPrefix;
		private decimal creditLimit;
		private decimal openingBal;
		private decimal closingBal;
		private string website;
		private string custom_1;
		private string custom_2;
		private string custom_3;
		private string createdBy;
		private string updatedBy;
		private DateTime createdDate;
		private DateTime updateDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OrganisationMaster class.
		/// </summary>
		public OrganisationMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the OrganisationMaster class.
		/// </summary>
		public OrganisationMaster(int tenantID, string isActive, int orgTypeID, string orgType, int customerTypeID, string customerType, string orgName, string orgCode, string phone, string entityAddress_1, string entityAddress_2, string entityAddress_3, string entityAddress_4, string entityAddress_5, string entityMobile_1, string entityMobile_2, string entityLanline_1, string entityLanline_2, string logoFlag, string orgLogo, string tIN, string pAN, string gST, string regNPrefix, string moneyRecPrefix, string billRefPrefix, decimal creditLimit, decimal openingBal, decimal closingBal, string website, string custom_1, string custom_2, string custom_3, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.orgTypeID = orgTypeID;
			this.orgType = orgType;
			this.customerTypeID = customerTypeID;
			this.customerType = customerType;
			this.orgName = orgName;
			this.orgCode = orgCode;
			this.phone = phone;
			this.entityAddress_1 = entityAddress_1;
			this.entityAddress_2 = entityAddress_2;
			this.entityAddress_3 = entityAddress_3;
			this.entityAddress_4 = entityAddress_4;
			this.entityAddress_5 = entityAddress_5;
			this.entityMobile_1 = entityMobile_1;
			this.entityMobile_2 = entityMobile_2;
			this.entityLanline_1 = entityLanline_1;
			this.entityLanline_2 = entityLanline_2;
			this.logoFlag = logoFlag;
			this.orgLogo = orgLogo;
			this.tIN = tIN;
			this.pAN = pAN;
			this.gST = gST;
			this.regNPrefix = regNPrefix;
			this.moneyRecPrefix = moneyRecPrefix;
			this.billRefPrefix = billRefPrefix;
			this.creditLimit = creditLimit;
			this.openingBal = openingBal;
			this.closingBal = closingBal;
			this.website = website;
			this.custom_1 = custom_1;
			this.custom_2 = custom_2;
			this.custom_3 = custom_3;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		/// <summary>
		/// Initializes a new instance of the OrganisationMaster class.
		/// </summary>
		public OrganisationMaster(int orgID, int tenantID, string isActive, int orgTypeID, string orgType, int customerTypeID, string customerType, string orgName, string orgCode, string phone, string entityAddress_1, string entityAddress_2, string entityAddress_3, string entityAddress_4, string entityAddress_5, string entityMobile_1, string entityMobile_2, string entityLanline_1, string entityLanline_2, string logoFlag, string orgLogo, string tIN, string pAN, string gST, string regNPrefix, string moneyRecPrefix, string billRefPrefix, decimal creditLimit, decimal openingBal, decimal closingBal, string website, string custom_1, string custom_2, string custom_3, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.orgID = orgID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.orgTypeID = orgTypeID;
			this.orgType = orgType;
			this.customerTypeID = customerTypeID;
			this.customerType = customerType;
			this.orgName = orgName;
			this.orgCode = orgCode;
			this.phone = phone;
			this.entityAddress_1 = entityAddress_1;
			this.entityAddress_2 = entityAddress_2;
			this.entityAddress_3 = entityAddress_3;
			this.entityAddress_4 = entityAddress_4;
			this.entityAddress_5 = entityAddress_5;
			this.entityMobile_1 = entityMobile_1;
			this.entityMobile_2 = entityMobile_2;
			this.entityLanline_1 = entityLanline_1;
			this.entityLanline_2 = entityLanline_2;
			this.logoFlag = logoFlag;
			this.orgLogo = orgLogo;
			this.tIN = tIN;
			this.pAN = pAN;
			this.gST = gST;
			this.regNPrefix = regNPrefix;
			this.moneyRecPrefix = moneyRecPrefix;
			this.billRefPrefix = billRefPrefix;
			this.creditLimit = creditLimit;
			this.openingBal = openingBal;
			this.closingBal = closingBal;
			this.website = website;
			this.custom_1 = custom_1;
			this.custom_2 = custom_2;
			this.custom_3 = custom_3;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public  int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public  string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the OrgTypeID value.
		/// </summary>
		public  int OrgTypeID
		{
			get { return orgTypeID; }
			set { orgTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgType value.
		/// </summary>
		public  string OrgType
		{
			get { return orgType; }
			set { orgType = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerTypeID value.
		/// </summary>
		public  int CustomerTypeID
		{
			get { return customerTypeID; }
			set { customerTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerType value.
		/// </summary>
		public  string CustomerType
		{
			get { return customerType; }
			set { customerType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		public  string OrgName
		{
			get { return orgName; }
			set { orgName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgCode value.
		/// </summary>
		public  string OrgCode
		{
			get { return orgCode; }
			set { orgCode = value; }
		}

		/// <summary>
		/// Gets or sets the Phone value.
		/// </summary>
		public  string Phone
		{
			get { return phone; }
			set { phone = value; }
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
		/// Gets or sets the LogoFlag value.
		/// </summary>
		public  string LogoFlag
		{
			get { return logoFlag; }
			set { logoFlag = value; }
		}

		/// <summary>
		/// Gets or sets the OrgLogo value.
		/// </summary>
		public  string OrgLogo
		{
			get { return orgLogo; }
			set { orgLogo = value; }
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
		/// Gets or sets the GST value.
		/// </summary>
		public  string GST
		{
			get { return gST; }
			set { gST = value; }
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
		/// Gets or sets the CreditLimit value.
		/// </summary>
		public  decimal CreditLimit
		{
			get { return creditLimit; }
			set { creditLimit = value; }
		}

		/// <summary>
		/// Gets or sets the OpeningBal value.
		/// </summary>
		public  decimal OpeningBal
		{
			get { return openingBal; }
			set { openingBal = value; }
		}

		/// <summary>
		/// Gets or sets the ClosingBal value.
		/// </summary>
		public  decimal ClosingBal
		{
			get { return closingBal; }
			set { closingBal = value; }
		}

		/// <summary>
		/// Gets or sets the Website value.
		/// </summary>
		public  string Website
		{
			get { return website; }
			set { website = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public  string CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the UpdateDate value.
		/// </summary>
		public  DateTime UpdateDate
		{
			get { return updateDate; }
			set { updateDate = value; }
		}

		#endregion
	}
}
