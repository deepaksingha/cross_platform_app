using System;

namespace B2B.Model
{
	[Serializable]
	public class LoginUser : BizObject
	{
		#region Fields

		private int loginID;
		private int tenantID;
		private string isActive;
		private int customerTypeID;
		private string customerType;
		private int orgTypeID;
		private string orgType;
		private int orgID;
		private string orgname;
		private int roleAccessID;
		private string roleName;
		private string firstN;
		private string middleN;
		private string lastN;
		private string userName;
		private string passwrd;
		private string displayN;
		private string email;
		private string mobile;
		private string photoFlag;
		private string photo;
		private string photoPath;
		private DateTime lastLogin;
		private DateTime lastPasswrdChgedDate;
		private string sharedLogin;
		private string loginIP;
		private int finanFromMonth;
		private int financialYearFrom;
		private int financialToMonth;
		private int financialYearTo;
		private string billingCounterFlag;
		private string billingCounterID;
		private string pharmacyCounterFlag;
		private string pharmacyCounterID;
		private string otherCounterFlag;
		private string otherCounterID;
		private string billSeriesFlag;
		private string phBillSeries;
		private string linkDoctorFlag;
		private int linkeDoctorID;
		private string appLoginFlag;
		private int assignedWardID;
		private string assignedWard;
		private string redirectLogin;
		private int linkedIncLocationID;
		private string linkedIncLocation;
		private int linkIncCategoryID;
		private string linkIncCategory;
		private int linkIncSubCategoryID;
		private string linkIncSubCategory;
		private string financialKey;
		private int linkAccCustomerID;
		private string linkAccCustomerName;
		private string custom_1;
		private string custom_2;
		private DateTime createdDate;
		private DateTime updatedDate;
		private string createdBy;
		private string updatedBy;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoginUser class.
		/// </summary>
		public LoginUser()
		{
		}

		/// <summary>
		/// Initializes a new instance of the LoginUser class.
		/// </summary>
		public LoginUser(int tenantID, string isActive, int customerTypeID, string customerType, int orgTypeID, string orgType, int orgID, string orgname, int roleAccessID, string roleName, string firstN, string middleN, string lastN, string userName, string passwrd, string displayN, string email, string mobile, string photoFlag, string photo, string photoPath, DateTime lastLogin, DateTime lastPasswrdChgedDate, string sharedLogin, string loginIP, int finanFromMonth, int financialYearFrom, int financialToMonth, int financialYearTo, string billingCounterFlag, string billingCounterID, string pharmacyCounterFlag, string pharmacyCounterID, string otherCounterFlag, string otherCounterID, string billSeriesFlag, string phBillSeries, string linkDoctorFlag, int linkeDoctorID, string appLoginFlag, int assignedWardID, string assignedWard, string redirectLogin, int linkedIncLocationID, string linkedIncLocation, int linkIncCategoryID, string linkIncCategory, int linkIncSubCategoryID, string linkIncSubCategory, string financialKey, int linkAccCustomerID, string linkAccCustomerName, string custom_1, string custom_2, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.customerTypeID = customerTypeID;
			this.customerType = customerType;
			this.orgTypeID = orgTypeID;
			this.orgType = orgType;
			this.orgID = orgID;
			this.orgname = orgname;
			this.roleAccessID = roleAccessID;
			this.roleName = roleName;
			this.firstN = firstN;
			this.middleN = middleN;
			this.lastN = lastN;
			this.userName = userName;
			this.passwrd = passwrd;
			this.displayN = displayN;
			this.email = email;
			this.mobile = mobile;
			this.photoFlag = photoFlag;
			this.photo = photo;
			this.photoPath = photoPath;
			this.lastLogin = lastLogin;
			this.lastPasswrdChgedDate = lastPasswrdChgedDate;
			this.sharedLogin = sharedLogin;
			this.loginIP = loginIP;
			this.finanFromMonth = finanFromMonth;
			this.financialYearFrom = financialYearFrom;
			this.financialToMonth = financialToMonth;
			this.financialYearTo = financialYearTo;
			this.billingCounterFlag = billingCounterFlag;
			this.billingCounterID = billingCounterID;
			this.pharmacyCounterFlag = pharmacyCounterFlag;
			this.pharmacyCounterID = pharmacyCounterID;
			this.otherCounterFlag = otherCounterFlag;
			this.otherCounterID = otherCounterID;
			this.billSeriesFlag = billSeriesFlag;
			this.phBillSeries = phBillSeries;
			this.linkDoctorFlag = linkDoctorFlag;
			this.linkeDoctorID = linkeDoctorID;
			this.appLoginFlag = appLoginFlag;
			this.assignedWardID = assignedWardID;
			this.assignedWard = assignedWard;
			this.redirectLogin = redirectLogin;
			this.linkedIncLocationID = linkedIncLocationID;
			this.linkedIncLocation = linkedIncLocation;
			this.linkIncCategoryID = linkIncCategoryID;
			this.linkIncCategory = linkIncCategory;
			this.linkIncSubCategoryID = linkIncSubCategoryID;
			this.linkIncSubCategory = linkIncSubCategory;
			this.financialKey = financialKey;
			this.linkAccCustomerID = linkAccCustomerID;
			this.linkAccCustomerName = linkAccCustomerName;
			this.custom_1 = custom_1;
			this.custom_2 = custom_2;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		/// <summary>
		/// Initializes a new instance of the LoginUser class.
		/// </summary>
		public LoginUser(int loginID, int tenantID, string isActive, int customerTypeID, string customerType, int orgTypeID, string orgType, int orgID, string orgname, int roleAccessID, string roleName, string firstN, string middleN, string lastN, string userName, string passwrd, string displayN, string email, string mobile, string photoFlag, string photo, string photoPath, DateTime lastLogin, DateTime lastPasswrdChgedDate, string sharedLogin, string loginIP, int finanFromMonth, int financialYearFrom, int financialToMonth, int financialYearTo, string billingCounterFlag, string billingCounterID, string pharmacyCounterFlag, string pharmacyCounterID, string otherCounterFlag, string otherCounterID, string billSeriesFlag, string phBillSeries, string linkDoctorFlag, int linkeDoctorID, string appLoginFlag, int assignedWardID, string assignedWard, string redirectLogin, int linkedIncLocationID, string linkedIncLocation, int linkIncCategoryID, string linkIncCategory, int linkIncSubCategoryID, string linkIncSubCategory, string financialKey, int linkAccCustomerID, string linkAccCustomerName, string custom_1, string custom_2, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.loginID = loginID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.customerTypeID = customerTypeID;
			this.customerType = customerType;
			this.orgTypeID = orgTypeID;
			this.orgType = orgType;
			this.orgID = orgID;
			this.orgname = orgname;
			this.roleAccessID = roleAccessID;
			this.roleName = roleName;
			this.firstN = firstN;
			this.middleN = middleN;
			this.lastN = lastN;
			this.userName = userName;
			this.passwrd = passwrd;
			this.displayN = displayN;
			this.email = email;
			this.mobile = mobile;
			this.photoFlag = photoFlag;
			this.photo = photo;
			this.photoPath = photoPath;
			this.lastLogin = lastLogin;
			this.lastPasswrdChgedDate = lastPasswrdChgedDate;
			this.sharedLogin = sharedLogin;
			this.loginIP = loginIP;
			this.finanFromMonth = finanFromMonth;
			this.financialYearFrom = financialYearFrom;
			this.financialToMonth = financialToMonth;
			this.financialYearTo = financialYearTo;
			this.billingCounterFlag = billingCounterFlag;
			this.billingCounterID = billingCounterID;
			this.pharmacyCounterFlag = pharmacyCounterFlag;
			this.pharmacyCounterID = pharmacyCounterID;
			this.otherCounterFlag = otherCounterFlag;
			this.otherCounterID = otherCounterID;
			this.billSeriesFlag = billSeriesFlag;
			this.phBillSeries = phBillSeries;
			this.linkDoctorFlag = linkDoctorFlag;
			this.linkeDoctorID = linkeDoctorID;
			this.appLoginFlag = appLoginFlag;
			this.assignedWardID = assignedWardID;
			this.assignedWard = assignedWard;
			this.redirectLogin = redirectLogin;
			this.linkedIncLocationID = linkedIncLocationID;
			this.linkedIncLocation = linkedIncLocation;
			this.linkIncCategoryID = linkIncCategoryID;
			this.linkIncCategory = linkIncCategory;
			this.linkIncSubCategoryID = linkIncSubCategoryID;
			this.linkIncSubCategory = linkIncSubCategory;
			this.financialKey = financialKey;
			this.linkAccCustomerID = linkAccCustomerID;
			this.linkAccCustomerName = linkAccCustomerName;
			this.custom_1 = custom_1;
			this.custom_2 = custom_2;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public  int LoginID
		{
			get { return loginID; }
			set { loginID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public  int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Orgname value.
		/// </summary>
		public  string Orgname
		{
			get { return orgname; }
			set { orgname = value; }
		}

		/// <summary>
		/// Gets or sets the RoleAccessID value.
		/// </summary>
		public  int RoleAccessID
		{
			get { return roleAccessID; }
			set { roleAccessID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		public  string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}

		/// <summary>
		/// Gets or sets the FirstN value.
		/// </summary>
		public  string FirstN
		{
			get { return firstN; }
			set { firstN = value; }
		}

		/// <summary>
		/// Gets or sets the MiddleN value.
		/// </summary>
		public  string MiddleN
		{
			get { return middleN; }
			set { middleN = value; }
		}

		/// <summary>
		/// Gets or sets the LastN value.
		/// </summary>
		public  string LastN
		{
			get { return lastN; }
			set { lastN = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		public  string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		/// <summary>
		/// Gets or sets the Passwrd value.
		/// </summary>
		public  string Passwrd
		{
			get { return passwrd; }
			set { passwrd = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayN value.
		/// </summary>
		public  string DisplayN
		{
			get { return displayN; }
			set { displayN = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public  string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Mobile value.
		/// </summary>
		public  string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		/// <summary>
		/// Gets or sets the PhotoFlag value.
		/// </summary>
		public  string PhotoFlag
		{
			get { return photoFlag; }
			set { photoFlag = value; }
		}

		/// <summary>
		/// Gets or sets the Photo value.
		/// </summary>
		public  string Photo
		{
			get { return photo; }
			set { photo = value; }
		}

		/// <summary>
		/// Gets or sets the PhotoPath value.
		/// </summary>
		public  string PhotoPath
		{
			get { return photoPath; }
			set { photoPath = value; }
		}

		/// <summary>
		/// Gets or sets the LastLogin value.
		/// </summary>
		public  DateTime LastLogin
		{
			get { return lastLogin; }
			set { lastLogin = value; }
		}

		/// <summary>
		/// Gets or sets the LastPasswrdChgedDate value.
		/// </summary>
		public  DateTime LastPasswrdChgedDate
		{
			get { return lastPasswrdChgedDate; }
			set { lastPasswrdChgedDate = value; }
		}

		/// <summary>
		/// Gets or sets the SharedLogin value.
		/// </summary>
		public  string SharedLogin
		{
			get { return sharedLogin; }
			set { sharedLogin = value; }
		}

		/// <summary>
		/// Gets or sets the LoginIP value.
		/// </summary>
		public  string LoginIP
		{
			get { return loginIP; }
			set { loginIP = value; }
		}

		/// <summary>
		/// Gets or sets the FinanFromMonth value.
		/// </summary>
		public  int FinanFromMonth
		{
			get { return finanFromMonth; }
			set { finanFromMonth = value; }
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
		/// Gets or sets the FinancialToMonth value.
		/// </summary>
		public  int FinancialToMonth
		{
			get { return financialToMonth; }
			set { financialToMonth = value; }
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
		/// Gets or sets the BillingCounterFlag value.
		/// </summary>
		public  string BillingCounterFlag
		{
			get { return billingCounterFlag; }
			set { billingCounterFlag = value; }
		}

		/// <summary>
		/// Gets or sets the BillingCounterID value.
		/// </summary>
		public  string BillingCounterID
		{
			get { return billingCounterID; }
			set { billingCounterID = value; }
		}

		/// <summary>
		/// Gets or sets the PharmacyCounterFlag value.
		/// </summary>
		public  string PharmacyCounterFlag
		{
			get { return pharmacyCounterFlag; }
			set { pharmacyCounterFlag = value; }
		}

		/// <summary>
		/// Gets or sets the PharmacyCounterID value.
		/// </summary>
		public  string PharmacyCounterID
		{
			get { return pharmacyCounterID; }
			set { pharmacyCounterID = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCounterFlag value.
		/// </summary>
		public  string OtherCounterFlag
		{
			get { return otherCounterFlag; }
			set { otherCounterFlag = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCounterID value.
		/// </summary>
		public  string OtherCounterID
		{
			get { return otherCounterID; }
			set { otherCounterID = value; }
		}

		/// <summary>
		/// Gets or sets the BillSeriesFlag value.
		/// </summary>
		public  string BillSeriesFlag
		{
			get { return billSeriesFlag; }
			set { billSeriesFlag = value; }
		}

		/// <summary>
		/// Gets or sets the PhBillSeries value.
		/// </summary>
		public  string PhBillSeries
		{
			get { return phBillSeries; }
			set { phBillSeries = value; }
		}

		/// <summary>
		/// Gets or sets the LinkDoctorFlag value.
		/// </summary>
		public  string LinkDoctorFlag
		{
			get { return linkDoctorFlag; }
			set { linkDoctorFlag = value; }
		}

		/// <summary>
		/// Gets or sets the LinkeDoctorID value.
		/// </summary>
		public  int LinkeDoctorID
		{
			get { return linkeDoctorID; }
			set { linkeDoctorID = value; }
		}

		/// <summary>
		/// Gets or sets the AppLoginFlag value.
		/// </summary>
		public  string AppLoginFlag
		{
			get { return appLoginFlag; }
			set { appLoginFlag = value; }
		}

		/// <summary>
		/// Gets or sets the AssignedWardID value.
		/// </summary>
		public  int AssignedWardID
		{
			get { return assignedWardID; }
			set { assignedWardID = value; }
		}

		/// <summary>
		/// Gets or sets the AssignedWard value.
		/// </summary>
		public  string AssignedWard
		{
			get { return assignedWard; }
			set { assignedWard = value; }
		}

		/// <summary>
		/// Gets or sets the RedirectLogin value.
		/// </summary>
		public  string RedirectLogin
		{
			get { return redirectLogin; }
			set { redirectLogin = value; }
		}

		/// <summary>
		/// Gets or sets the LinkedIncLocationID value.
		/// </summary>
		public  int LinkedIncLocationID
		{
			get { return linkedIncLocationID; }
			set { linkedIncLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the LinkedIncLocation value.
		/// </summary>
		public  string LinkedIncLocation
		{
			get { return linkedIncLocation; }
			set { linkedIncLocation = value; }
		}

		/// <summary>
		/// Gets or sets the LinkIncCategoryID value.
		/// </summary>
		public  int LinkIncCategoryID
		{
			get { return linkIncCategoryID; }
			set { linkIncCategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the LinkIncCategory value.
		/// </summary>
		public  string LinkIncCategory
		{
			get { return linkIncCategory; }
			set { linkIncCategory = value; }
		}

		/// <summary>
		/// Gets or sets the LinkIncSubCategoryID value.
		/// </summary>
		public  int LinkIncSubCategoryID
		{
			get { return linkIncSubCategoryID; }
			set { linkIncSubCategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the LinkIncSubCategory value.
		/// </summary>
		public  string LinkIncSubCategory
		{
			get { return linkIncSubCategory; }
			set { linkIncSubCategory = value; }
		}

		/// <summary>
		/// Gets or sets the FinancialKey value.
		/// </summary>
		public  string FinancialKey
		{
			get { return financialKey; }
			set { financialKey = value; }
		}

		/// <summary>
		/// Gets or sets the LinkAccCustomerID value.
		/// </summary>
		public  int LinkAccCustomerID
		{
			get { return linkAccCustomerID; }
			set { linkAccCustomerID = value; }
		}

		/// <summary>
		/// Gets or sets the LinkAccCustomerName value.
		/// </summary>
		public  string LinkAccCustomerName
		{
			get { return linkAccCustomerName; }
			set { linkAccCustomerName = value; }
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

		#endregion
	}
}
