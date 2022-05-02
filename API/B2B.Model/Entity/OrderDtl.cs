using System;

namespace B2B.Model
{
	[Serializable]
	public class OrderDtl : BizObject
	{
		#region Fields

		private long orderDtlID;
		private int tenantID;
		private string isActive;
		private int statusID;
		private long orderID;
		private int orgID;
		private int itemID;
		private string itemName;
		private string hSN;
		private int itemCatID;
		private string categoryName;
		private int orderQTY;
		private int deliverQTY;
		private int recQTY;
		private string uOM;
		private int packSize;
		private decimal itemRate;
		private decimal itemMRP;
		private decimal costPrice;
		private decimal gST;
		private decimal preTaxOrginalAmt;
		private decimal disc;
		private decimal taxableAmt;
		private decimal taxtAmt;
		private decimal totalAmt;
		private decimal netAmt;
		private decimal roundoff;
		private string priority;
		private string isOutStock;
		private string companyUser;
		private DateTime companyUpdateDate;
		private string companyMessage;
		private string compMessageBy;
		private string supplierMessage;
		private string supplierMsgBy;
		private string ackBy;
		private string packedBy;
		private string deliveredBy;
		private string verifiedBy;
		private string cancelledBy;
		private string cancelRemark;
		private string cancelDate;
		private string ackDate;
		private string verifyDate;
		private string remark;
		private string createdBy;
		private string updatedBy;
		private DateTime createdDate;
		private DateTime updateDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OrderDtl class.
		/// </summary>
		public OrderDtl()
		{
		}

		/// <summary>
		/// Initializes a new instance of the OrderDtl class.
		/// </summary>
		public OrderDtl(int tenantID, string isActive, int statusID, long orderID, int orgID, int itemID, string itemName, string hSN, int itemCatID, string categoryName, int orderQTY, int deliverQTY, int recQTY, string uOM, int packSize, decimal itemRate, decimal itemMRP, decimal costPrice, decimal gST, decimal preTaxOrginalAmt, decimal disc, decimal taxableAmt, decimal taxtAmt, decimal totalAmt, decimal netAmt, decimal roundoff, string priority, string isOutStock, string companyUser, DateTime companyUpdateDate, string companyMessage, string compMessageBy, string supplierMessage, string supplierMsgBy, string ackBy, string packedBy, string deliveredBy, string verifiedBy, string cancelledBy, string cancelRemark, string cancelDate, string ackDate, string verifyDate, string remark, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.statusID = statusID;
			this.orderID = orderID;
			this.orgID = orgID;
			this.itemID = itemID;
			this.itemName = itemName;
			this.hSN = hSN;
			this.itemCatID = itemCatID;
			this.categoryName = categoryName;
			this.orderQTY = orderQTY;
			this.deliverQTY = deliverQTY;
			this.recQTY = recQTY;
			this.uOM = uOM;
			this.packSize = packSize;
			this.itemRate = itemRate;
			this.itemMRP = itemMRP;
			this.costPrice = costPrice;
			this.gST = gST;
			this.preTaxOrginalAmt = preTaxOrginalAmt;
			this.disc = disc;
			this.taxableAmt = taxableAmt;
			this.taxtAmt = taxtAmt;
			this.totalAmt = totalAmt;
			this.netAmt = netAmt;
			this.roundoff = roundoff;
			this.priority = priority;
			this.isOutStock = isOutStock;
			this.companyUser = companyUser;
			this.companyUpdateDate = companyUpdateDate;
			this.companyMessage = companyMessage;
			this.compMessageBy = compMessageBy;
			this.supplierMessage = supplierMessage;
			this.supplierMsgBy = supplierMsgBy;
			this.ackBy = ackBy;
			this.packedBy = packedBy;
			this.deliveredBy = deliveredBy;
			this.verifiedBy = verifiedBy;
			this.cancelledBy = cancelledBy;
			this.cancelRemark = cancelRemark;
			this.cancelDate = cancelDate;
			this.ackDate = ackDate;
			this.verifyDate = verifyDate;
			this.remark = remark;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		/// <summary>
		/// Initializes a new instance of the OrderDtl class.
		/// </summary>
		public OrderDtl(long orderDtlID, int tenantID, string isActive, int statusID, long orderID, int orgID, int itemID, string itemName, string hSN, int itemCatID, string categoryName, int orderQTY, int deliverQTY, int recQTY, string uOM, int packSize, decimal itemRate, decimal itemMRP, decimal costPrice, decimal gST, decimal preTaxOrginalAmt, decimal disc, decimal taxableAmt, decimal taxtAmt, decimal totalAmt, decimal netAmt, decimal roundoff, string priority, string isOutStock, string companyUser, DateTime companyUpdateDate, string companyMessage, string compMessageBy, string supplierMessage, string supplierMsgBy, string ackBy, string packedBy, string deliveredBy, string verifiedBy, string cancelledBy, string cancelRemark, string cancelDate, string ackDate, string verifyDate, string remark, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.orderDtlID = orderDtlID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.statusID = statusID;
			this.orderID = orderID;
			this.orgID = orgID;
			this.itemID = itemID;
			this.itemName = itemName;
			this.hSN = hSN;
			this.itemCatID = itemCatID;
			this.categoryName = categoryName;
			this.orderQTY = orderQTY;
			this.deliverQTY = deliverQTY;
			this.recQTY = recQTY;
			this.uOM = uOM;
			this.packSize = packSize;
			this.itemRate = itemRate;
			this.itemMRP = itemMRP;
			this.costPrice = costPrice;
			this.gST = gST;
			this.preTaxOrginalAmt = preTaxOrginalAmt;
			this.disc = disc;
			this.taxableAmt = taxableAmt;
			this.taxtAmt = taxtAmt;
			this.totalAmt = totalAmt;
			this.netAmt = netAmt;
			this.roundoff = roundoff;
			this.priority = priority;
			this.isOutStock = isOutStock;
			this.companyUser = companyUser;
			this.companyUpdateDate = companyUpdateDate;
			this.companyMessage = companyMessage;
			this.compMessageBy = compMessageBy;
			this.supplierMessage = supplierMessage;
			this.supplierMsgBy = supplierMsgBy;
			this.ackBy = ackBy;
			this.packedBy = packedBy;
			this.deliveredBy = deliveredBy;
			this.verifiedBy = verifiedBy;
			this.cancelledBy = cancelledBy;
			this.cancelRemark = cancelRemark;
			this.cancelDate = cancelDate;
			this.ackDate = ackDate;
			this.verifyDate = verifyDate;
			this.remark = remark;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrderDtlID value.
		/// </summary>
		public  long OrderDtlID
		{
			get { return orderDtlID; }
			set { orderDtlID = value; }
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
		/// Gets or sets the StatusID value.
		/// </summary>
		public  int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderID value.
		/// </summary>
		public  long OrderID
		{
			get { return orderID; }
			set { orderID = value; }
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
		/// Gets or sets the ItemID value.
		/// </summary>
		public  int ItemID
		{
			get { return itemID; }
			set { itemID = value; }
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
		/// Gets or sets the OrderQTY value.
		/// </summary>
		public  int OrderQTY
		{
			get { return orderQTY; }
			set { orderQTY = value; }
		}

		/// <summary>
		/// Gets or sets the DeliverQTY value.
		/// </summary>
		public  int DeliverQTY
		{
			get { return deliverQTY; }
			set { deliverQTY = value; }
		}

		/// <summary>
		/// Gets or sets the RecQTY value.
		/// </summary>
		public  int RecQTY
		{
			get { return recQTY; }
			set { recQTY = value; }
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
		/// Gets or sets the PreTaxOrginalAmt value.
		/// </summary>
		public  decimal PreTaxOrginalAmt
		{
			get { return preTaxOrginalAmt; }
			set { preTaxOrginalAmt = value; }
		}

		/// <summary>
		/// Gets or sets the Disc value.
		/// </summary>
		public  decimal Disc
		{
			get { return disc; }
			set { disc = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmt value.
		/// </summary>
		public  decimal TaxableAmt
		{
			get { return taxableAmt; }
			set { taxableAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TaxtAmt value.
		/// </summary>
		public  decimal TaxtAmt
		{
			get { return taxtAmt; }
			set { taxtAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TotalAmt value.
		/// </summary>
		public  decimal TotalAmt
		{
			get { return totalAmt; }
			set { totalAmt = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmt value.
		/// </summary>
		public  decimal NetAmt
		{
			get { return netAmt; }
			set { netAmt = value; }
		}

		/// <summary>
		/// Gets or sets the Roundoff value.
		/// </summary>
		public  decimal Roundoff
		{
			get { return roundoff; }
			set { roundoff = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public  string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the IsOutStock value.
		/// </summary>
		public  string IsOutStock
		{
			get { return isOutStock; }
			set { isOutStock = value; }
		}

		/// <summary>
		/// Gets or sets the CompanyUser value.
		/// </summary>
		public  string CompanyUser
		{
			get { return companyUser; }
			set { companyUser = value; }
		}

		/// <summary>
		/// Gets or sets the CompanyUpdateDate value.
		/// </summary>
		public  DateTime CompanyUpdateDate
		{
			get { return companyUpdateDate; }
			set { companyUpdateDate = value; }
		}

		/// <summary>
		/// Gets or sets the CompanyMessage value.
		/// </summary>
		public  string CompanyMessage
		{
			get { return companyMessage; }
			set { companyMessage = value; }
		}

		/// <summary>
		/// Gets or sets the CompMessageBy value.
		/// </summary>
		public  string CompMessageBy
		{
			get { return compMessageBy; }
			set { compMessageBy = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierMessage value.
		/// </summary>
		public  string SupplierMessage
		{
			get { return supplierMessage; }
			set { supplierMessage = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierMsgBy value.
		/// </summary>
		public  string SupplierMsgBy
		{
			get { return supplierMsgBy; }
			set { supplierMsgBy = value; }
		}

		/// <summary>
		/// Gets or sets the AckBy value.
		/// </summary>
		public  string AckBy
		{
			get { return ackBy; }
			set { ackBy = value; }
		}

		/// <summary>
		/// Gets or sets the PackedBy value.
		/// </summary>
		public  string PackedBy
		{
			get { return packedBy; }
			set { packedBy = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveredBy value.
		/// </summary>
		public  string DeliveredBy
		{
			get { return deliveredBy; }
			set { deliveredBy = value; }
		}

		/// <summary>
		/// Gets or sets the VerifiedBy value.
		/// </summary>
		public  string VerifiedBy
		{
			get { return verifiedBy; }
			set { verifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the CancelledBy value.
		/// </summary>
		public  string CancelledBy
		{
			get { return cancelledBy; }
			set { cancelledBy = value; }
		}

		/// <summary>
		/// Gets or sets the CancelRemark value.
		/// </summary>
		public  string CancelRemark
		{
			get { return cancelRemark; }
			set { cancelRemark = value; }
		}

		/// <summary>
		/// Gets or sets the CancelDate value.
		/// </summary>
		public  string CancelDate
		{
			get { return cancelDate; }
			set { cancelDate = value; }
		}

		/// <summary>
		/// Gets or sets the AckDate value.
		/// </summary>
		public  string AckDate
		{
			get { return ackDate; }
			set { ackDate = value; }
		}

		/// <summary>
		/// Gets or sets the VerifyDate value.
		/// </summary>
		public  string VerifyDate
		{
			get { return verifyDate; }
			set { verifyDate = value; }
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
