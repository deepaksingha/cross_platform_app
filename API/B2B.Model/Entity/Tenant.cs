using System;

namespace B2B.Model
{
	[Serializable]
	public class Tenant : BizObject
	{
		#region Fields

		private int tenantID;
		private string tenantCode;
		private string tenantName;
		private string shortName;
		private string pAN;
		private string tIN;
		private string serviceRef;
		private string address1;
		private string address2;
		private string address3;
		private string tenantDesc;
		private string fax;
		private string email;
		private string vATno;
		private string dLNo;
		private string cSTNo;
		private string gST;
		private string lanline;
		private string mobile;
		private string website;
		private string isActive;
		private int statusID;
		private DateTime suscriptionStartDate;
		private DateTime suscriptionEndDate;
		private string tenantRemark;
		private int financialYear;
		private DateTime createdDate;
		private DateTime updatedDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Tenant class.
		/// </summary>
		public Tenant()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Tenant class.
		/// </summary>
		public Tenant(int tenantID, string tenantCode, string tenantName, string shortName, string pAN, string tIN, string serviceRef, string address1, string address2, string address3, string tenantDesc, string fax, string email, string vATno, string dLNo, string cSTNo, string gST, string lanline, string mobile, string website, string isActive, int statusID, DateTime suscriptionStartDate, DateTime suscriptionEndDate, string tenantRemark, int financialYear, DateTime createdDate, DateTime updatedDate)
		{
			this.tenantID = tenantID;
			this.tenantCode = tenantCode;
			this.tenantName = tenantName;
			this.shortName = shortName;
			this.pAN = pAN;
			this.tIN = tIN;
			this.serviceRef = serviceRef;
			this.address1 = address1;
			this.address2 = address2;
			this.address3 = address3;
			this.tenantDesc = tenantDesc;
			this.fax = fax;
			this.email = email;
			this.vATno = vATno;
			this.dLNo = dLNo;
			this.cSTNo = cSTNo;
			this.gST = gST;
			this.lanline = lanline;
			this.mobile = mobile;
			this.website = website;
			this.isActive = isActive;
			this.statusID = statusID;
			this.suscriptionStartDate = suscriptionStartDate;
			this.suscriptionEndDate = suscriptionEndDate;
			this.tenantRemark = tenantRemark;
			this.financialYear = financialYear;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TenantID value.
		/// </summary>
		public  int TenantID
		{
			get { return tenantID; }
			set { tenantID = value; }
		}

		/// <summary>
		/// Gets or sets the TenantCode value.
		/// </summary>
		public  string TenantCode
		{
			get { return tenantCode; }
			set { tenantCode = value; }
		}

		/// <summary>
		/// Gets or sets the TenantName value.
		/// </summary>
		public  string TenantName
		{
			get { return tenantName; }
			set { tenantName = value; }
		}

		/// <summary>
		/// Gets or sets the ShortName value.
		/// </summary>
		public  string ShortName
		{
			get { return shortName; }
			set { shortName = value; }
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
		/// Gets or sets the TIN value.
		/// </summary>
		public  string TIN
		{
			get { return tIN; }
			set { tIN = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceRef value.
		/// </summary>
		public  string ServiceRef
		{
			get { return serviceRef; }
			set { serviceRef = value; }
		}

		/// <summary>
		/// Gets or sets the Address1 value.
		/// </summary>
		public  string Address1
		{
			get { return address1; }
			set { address1 = value; }
		}

		/// <summary>
		/// Gets or sets the Address2 value.
		/// </summary>
		public  string Address2
		{
			get { return address2; }
			set { address2 = value; }
		}

		/// <summary>
		/// Gets or sets the Address3 value.
		/// </summary>
		public  string Address3
		{
			get { return address3; }
			set { address3 = value; }
		}

		/// <summary>
		/// Gets or sets the TenantDesc value.
		/// </summary>
		public  string TenantDesc
		{
			get { return tenantDesc; }
			set { tenantDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Fax value.
		/// </summary>
		public  string Fax
		{
			get { return fax; }
			set { fax = value; }
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
		/// Gets or sets the VATno value.
		/// </summary>
		public  string VATno
		{
			get { return vATno; }
			set { vATno = value; }
		}

		/// <summary>
		/// Gets or sets the DLNo value.
		/// </summary>
		public  string DLNo
		{
			get { return dLNo; }
			set { dLNo = value; }
		}

		/// <summary>
		/// Gets or sets the CSTNo value.
		/// </summary>
		public  string CSTNo
		{
			get { return cSTNo; }
			set { cSTNo = value; }
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
		/// Gets or sets the Lanline value.
		/// </summary>
		public  string Lanline
		{
			get { return lanline; }
			set { lanline = value; }
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
		/// Gets or sets the Website value.
		/// </summary>
		public  string Website
		{
			get { return website; }
			set { website = value; }
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
		/// Gets or sets the StatusID value.
		/// </summary>
		public  int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the SuscriptionStartDate value.
		/// </summary>
		public  DateTime SuscriptionStartDate
		{
			get { return suscriptionStartDate; }
			set { suscriptionStartDate = value; }
		}

		/// <summary>
		/// Gets or sets the SuscriptionEndDate value.
		/// </summary>
		public  DateTime SuscriptionEndDate
		{
			get { return suscriptionEndDate; }
			set { suscriptionEndDate = value; }
		}

		/// <summary>
		/// Gets or sets the TenantRemark value.
		/// </summary>
		public  string TenantRemark
		{
			get { return tenantRemark; }
			set { tenantRemark = value; }
		}

		/// <summary>
		/// Gets or sets the FinancialYear value.
		/// </summary>
		public  int FinancialYear
		{
			get { return financialYear; }
			set { financialYear = value; }
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
