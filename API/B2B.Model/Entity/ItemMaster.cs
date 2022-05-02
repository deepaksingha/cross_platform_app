using System;

namespace B2B.Model
{
	[Serializable]
	public class ItemMaster : BizObject
	{
		#region Fields

		private int itemID;
		private int tenantID;
		private string isActive;
		private int orgID;
		private string itemName;
		private string itemCode;
		private string hSN;
		private int itemCatID;
		private string categoryName;
		private string uOM;
		private int packSize;
		private decimal itemRate;
		private decimal itemMRP;
		private decimal costPrice;
		private decimal gST;
		private string outofStcok;
		private string itemImageFlag;
		private string itemImage_1;
		private string itemImagePath_1;
		private string itemImage_2;
		private string itemImagePath_2;
		private string itemImage_3;
		private string itemImagePath_3;
		private string remark;
		private string createdBy;
		private string updatedBy;
		private DateTime createdDate;
		private DateTime updateDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ItemMaster class.
		/// </summary>
		public ItemMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ItemMaster class.
		/// </summary>
		public ItemMaster(int itemID, int tenantID, string isActive, int orgID, string itemName, string itemCode, string hSN, int itemCatID, string categoryName, string uOM, int packSize, decimal itemRate, decimal itemMRP, decimal costPrice, decimal gST, string outofStcok, string itemImageFlag, string itemImage_1, string itemImagePath_1, string itemImage_2, string itemImagePath_2, string itemImage_3, string itemImagePath_3, string remark, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.itemID = itemID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.orgID = orgID;
			this.itemName = itemName;
			this.itemCode = itemCode;
			this.hSN = hSN;
			this.itemCatID = itemCatID;
			this.categoryName = categoryName;
			this.uOM = uOM;
			this.packSize = packSize;
			this.itemRate = itemRate;
			this.itemMRP = itemMRP;
			this.costPrice = costPrice;
			this.gST = gST;
			this.outofStcok = outofStcok;
			this.itemImageFlag = itemImageFlag;
			this.itemImage_1 = itemImage_1;
			this.itemImagePath_1 = itemImagePath_1;
			this.itemImage_2 = itemImage_2;
			this.itemImagePath_2 = itemImagePath_2;
			this.itemImage_3 = itemImage_3;
			this.itemImagePath_3 = itemImagePath_3;
			this.remark = remark;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public  int ItemID
		{
			get { return itemID; }
			set { itemID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public  int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public  string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCode value.
		/// </summary>
		public  string ItemCode
		{
			get { return itemCode; }
			set { itemCode = value; }
		}

		/// <summary>
		/// Gets or sets the HSN value.
		/// </summary>
		public  string HSN
		{
			get { return hSN; }
			set { hSN = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCatID value.
		/// </summary>
		public  int ItemCatID
		{
			get { return itemCatID; }
			set { itemCatID = value; }
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
		/// Gets or sets the UOM value.
		/// </summary>
		public  string UOM
		{
			get { return uOM; }
			set { uOM = value; }
		}

		/// <summary>
		/// Gets or sets the PackSize value.
		/// </summary>
		public  int PackSize
		{
			get { return packSize; }
			set { packSize = value; }
		}

		/// <summary>
		/// Gets or sets the ItemRate value.
		/// </summary>
		public  decimal ItemRate
		{
			get { return itemRate; }
			set { itemRate = value; }
		}

		/// <summary>
		/// Gets or sets the ItemMRP value.
		/// </summary>
		public  decimal ItemMRP
		{
			get { return itemMRP; }
			set { itemMRP = value; }
		}

		/// <summary>
		/// Gets or sets the CostPrice value.
		/// </summary>
		public  decimal CostPrice
		{
			get { return costPrice; }
			set { costPrice = value; }
		}

		/// <summary>
		/// Gets or sets the GST value.
		/// </summary>
		public  decimal GST
		{
			get { return gST; }
			set { gST = value; }
		}

		/// <summary>
		/// Gets or sets the OutofStcok value.
		/// </summary>
		public  string OutofStcok
		{
			get { return outofStcok; }
			set { outofStcok = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImageFlag value.
		/// </summary>
		public  string ItemImageFlag
		{
			get { return itemImageFlag; }
			set { itemImageFlag = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImage_1 value.
		/// </summary>
		public  string ItemImage_1
		{
			get { return itemImage_1; }
			set { itemImage_1 = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImagePath_1 value.
		/// </summary>
		public  string ItemImagePath_1
		{
			get { return itemImagePath_1; }
			set { itemImagePath_1 = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImage_2 value.
		/// </summary>
		public  string ItemImage_2
		{
			get { return itemImage_2; }
			set { itemImage_2 = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImagePath_2 value.
		/// </summary>
		public  string ItemImagePath_2
		{
			get { return itemImagePath_2; }
			set { itemImagePath_2 = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImage_3 value.
		/// </summary>
		public  string ItemImage_3
		{
			get { return itemImage_3; }
			set { itemImage_3 = value; }
		}

		/// <summary>
		/// Gets or sets the ItemImagePath_3 value.
		/// </summary>
		public  string ItemImagePath_3
		{
			get { return itemImagePath_3; }
			set { itemImagePath_3 = value; }
		}

		/// <summary>
		/// Gets or sets the Remark value.
		/// </summary>
		public  string Remark
		{
			get { return remark; }
			set { remark = value; }
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
