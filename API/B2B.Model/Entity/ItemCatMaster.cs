using System;

namespace B2B.Model
{
	[Serializable]
	public class ItemCatMaster : BizObject
	{
		#region Fields

		private int itemCatID;
		private int tenantID;
		private string isActive;
		private string categoryName;
		private string storeType;
		private string issueTypeCode;
		private string issueTypeName;
		private string retailable;
		private string expiryFlag;
		private string discountFlag;
		private string identificationType;
		private string identification;
		private DateTime createdDate;
		private DateTime updatedDate;
		private string createdBy;
		private string updatedBy;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ItemCatMaster class.
		/// </summary>
		public ItemCatMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ItemCatMaster class.
		/// </summary>
		public ItemCatMaster(int tenantID, string isActive, string categoryName, string storeType, string issueTypeCode, string issueTypeName, string retailable, string expiryFlag, string discountFlag, string identificationType, string identification, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.categoryName = categoryName;
			this.storeType = storeType;
			this.issueTypeCode = issueTypeCode;
			this.issueTypeName = issueTypeName;
			this.retailable = retailable;
			this.expiryFlag = expiryFlag;
			this.discountFlag = discountFlag;
			this.identificationType = identificationType;
			this.identification = identification;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		/// <summary>
		/// Initializes a new instance of the ItemCatMaster class.
		/// </summary>
		public ItemCatMaster(int itemCatID, int tenantID, string isActive, string categoryName, string storeType, string issueTypeCode, string issueTypeName, string retailable, string expiryFlag, string discountFlag, string identificationType, string identification, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.itemCatID = itemCatID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.categoryName = categoryName;
			this.storeType = storeType;
			this.issueTypeCode = issueTypeCode;
			this.issueTypeName = issueTypeName;
			this.retailable = retailable;
			this.expiryFlag = expiryFlag;
			this.discountFlag = discountFlag;
			this.identificationType = identificationType;
			this.identification = identification;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemCatID value.
		/// </summary>
		public  int ItemCatID
		{
			get { return itemCatID; }
			set { itemCatID = value; }
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
		/// Gets or sets the CategoryName value.
		/// </summary>
		public  string CategoryName
		{
			get { return categoryName; }
			set { categoryName = value; }
		}

		/// <summary>
		/// Gets or sets the StoreType value.
		/// </summary>
		public  string StoreType
		{
			get { return storeType; }
			set { storeType = value; }
		}

		/// <summary>
		/// Gets or sets the IssueTypeCode value.
		/// </summary>
		public  string IssueTypeCode
		{
			get { return issueTypeCode; }
			set { issueTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the IssueTypeName value.
		/// </summary>
		public  string IssueTypeName
		{
			get { return issueTypeName; }
			set { issueTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the Retailable value.
		/// </summary>
		public  string Retailable
		{
			get { return retailable; }
			set { retailable = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryFlag value.
		/// </summary>
		public  string ExpiryFlag
		{
			get { return expiryFlag; }
			set { expiryFlag = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountFlag value.
		/// </summary>
		public  string DiscountFlag
		{
			get { return discountFlag; }
			set { discountFlag = value; }
		}

		/// <summary>
		/// Gets or sets the IdentificationType value.
		/// </summary>
		public  string IdentificationType
		{
			get { return identificationType; }
			set { identificationType = value; }
		}

		/// <summary>
		/// Gets or sets the Identification value.
		/// </summary>
		public  string Identification
		{
			get { return identification; }
			set { identification = value; }
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
