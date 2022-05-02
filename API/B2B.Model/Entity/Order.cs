using System;

namespace B2B.Model
{
	[Serializable]
	public class Order : BizObject
	{
		#region Fields

		private long orderID;
		private int tenantID;
		private string isActive;
		private int orderStatusID;
		private string orderStatus;
		private int internalStatusID;
		private string internalStatus;
		private string orderQR;
		private string orderNO;
		private int orgID;
		private string orderDateTxt;
		private DateTime orderDate;
		private string ackDateTxt;
		private DateTime ackDate;
		private string processDateTxt;
		private DateTime processDate;
		private string deliverDateTxt;
		private DateTime deliverDate;
		private decimal preTaxOrginalAmt;
		private decimal discount;
		private decimal taxableOrginalAmt;
		private decimal taxAmt;
		private decimal billAmt;
		private decimal otherAmt;
		private decimal cGST;
		private decimal sGST;
		private decimal cessAmt;
		private decimal roundOff;
		private decimal netAmt;
		private string cancelledBy;
		private string cancelRemark;
		private string priority;
		private string companyMessage;
		private string compMessageBy;
		private string supplierMessage;
		private string supplierMsgBy;
		private string remark;
		private string ackBy;
		private string packedBy;
		private string deliveredBy;
		private string verifiedBy;
		private string createdBy;
		private string updatedBy;
		private DateTime createdDate;
		private DateTime updateDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Order class.
		/// </summary>
		public Order()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Order class.
		/// </summary>
		public Order(int tenantID, string isActive, int orderStatusID, string orderStatus, int internalStatusID, string internalStatus, string orderQR, string orderNO, int orgID, string orderDateTxt, DateTime orderDate, string ackDateTxt, DateTime ackDate, string processDateTxt, DateTime processDate, string deliverDateTxt, DateTime deliverDate, decimal preTaxOrginalAmt, decimal discount, decimal taxableOrginalAmt, decimal taxAmt, decimal billAmt, decimal otherAmt, decimal cGST, decimal sGST, decimal cessAmt, decimal roundOff, decimal netAmt, string cancelledBy, string cancelRemark, string priority, string companyMessage, string compMessageBy, string supplierMessage, string supplierMsgBy, string remark, string ackBy, string packedBy, string deliveredBy, string verifiedBy, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.orderStatusID = orderStatusID;
			this.orderStatus = orderStatus;
			this.internalStatusID = internalStatusID;
			this.internalStatus = internalStatus;
			this.orderQR = orderQR;
			this.orderNO = orderNO;
			this.orgID = orgID;
			this.orderDateTxt = orderDateTxt;
			this.orderDate = orderDate;
			this.ackDateTxt = ackDateTxt;
			this.ackDate = ackDate;
			this.processDateTxt = processDateTxt;
			this.processDate = processDate;
			this.deliverDateTxt = deliverDateTxt;
			this.deliverDate = deliverDate;
			this.preTaxOrginalAmt = preTaxOrginalAmt;
			this.discount = discount;
			this.taxableOrginalAmt = taxableOrginalAmt;
			this.taxAmt = taxAmt;
			this.billAmt = billAmt;
			this.otherAmt = otherAmt;
			this.cGST = cGST;
			this.sGST = sGST;
			this.cessAmt = cessAmt;
			this.roundOff = roundOff;
			this.netAmt = netAmt;
			this.cancelledBy = cancelledBy;
			this.cancelRemark = cancelRemark;
			this.priority = priority;
			this.companyMessage = companyMessage;
			this.compMessageBy = compMessageBy;
			this.supplierMessage = supplierMessage;
			this.supplierMsgBy = supplierMsgBy;
			this.remark = remark;
			this.ackBy = ackBy;
			this.packedBy = packedBy;
			this.deliveredBy = deliveredBy;
			this.verifiedBy = verifiedBy;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		/// <summary>
		/// Initializes a new instance of the Order class.
		/// </summary>
		public Order(long orderID, int tenantID, string isActive, int orderStatusID, string orderStatus, int internalStatusID, string internalStatus, string orderQR, string orderNO, int orgID, string orderDateTxt, DateTime orderDate, string ackDateTxt, DateTime ackDate, string processDateTxt, DateTime processDate, string deliverDateTxt, DateTime deliverDate, decimal preTaxOrginalAmt, decimal discount, decimal taxableOrginalAmt, decimal taxAmt, decimal billAmt, decimal otherAmt, decimal cGST, decimal sGST, decimal cessAmt, decimal roundOff, decimal netAmt, string cancelledBy, string cancelRemark, string priority, string companyMessage, string compMessageBy, string supplierMessage, string supplierMsgBy, string remark, string ackBy, string packedBy, string deliveredBy, string verifiedBy, string createdBy, string updatedBy, DateTime createdDate, DateTime updateDate)
		{
			this.orderID = orderID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.orderStatusID = orderStatusID;
			this.orderStatus = orderStatus;
			this.internalStatusID = internalStatusID;
			this.internalStatus = internalStatus;
			this.orderQR = orderQR;
			this.orderNO = orderNO;
			this.orgID = orgID;
			this.orderDateTxt = orderDateTxt;
			this.orderDate = orderDate;
			this.ackDateTxt = ackDateTxt;
			this.ackDate = ackDate;
			this.processDateTxt = processDateTxt;
			this.processDate = processDate;
			this.deliverDateTxt = deliverDateTxt;
			this.deliverDate = deliverDate;
			this.preTaxOrginalAmt = preTaxOrginalAmt;
			this.discount = discount;
			this.taxableOrginalAmt = taxableOrginalAmt;
			this.taxAmt = taxAmt;
			this.billAmt = billAmt;
			this.otherAmt = otherAmt;
			this.cGST = cGST;
			this.sGST = sGST;
			this.cessAmt = cessAmt;
			this.roundOff = roundOff;
			this.netAmt = netAmt;
			this.cancelledBy = cancelledBy;
			this.cancelRemark = cancelRemark;
			this.priority = priority;
			this.companyMessage = companyMessage;
			this.compMessageBy = compMessageBy;
			this.supplierMessage = supplierMessage;
			this.supplierMsgBy = supplierMsgBy;
			this.remark = remark;
			this.ackBy = ackBy;
			this.packedBy = packedBy;
			this.deliveredBy = deliveredBy;
			this.verifiedBy = verifiedBy;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
			this.createdDate = createdDate;
			this.updateDate = updateDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrderID value.
		/// </summary>
		public  long OrderID
		{
			get { return orderID; }
			set { orderID = value; }
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
		/// Gets or sets the OrderStatusID value.
		/// </summary>
		public  int OrderStatusID
		{
			get { return orderStatusID; }
			set { orderStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderStatus value.
		/// </summary>
		public  string OrderStatus
		{
			get { return orderStatus; }
			set { orderStatus = value; }
		}

		/// <summary>
		/// Gets or sets the InternalStatusID value.
		/// </summary>
		public  int InternalStatusID
		{
			get { return internalStatusID; }
			set { internalStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the InternalStatus value.
		/// </summary>
		public  string InternalStatus
		{
			get { return internalStatus; }
			set { internalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the OrderQR value.
		/// </summary>
		public  string OrderQR
		{
			get { return orderQR; }
			set { orderQR = value; }
		}

		/// <summary>
		/// Gets or sets the OrderNO value.
		/// </summary>
		public  string OrderNO
		{
			get { return orderNO; }
			set { orderNO = value; }
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
		/// Gets or sets the OrderDateTxt value.
		/// </summary>
		public  string OrderDateTxt
		{
			get { return orderDateTxt; }
			set { orderDateTxt = value; }
		}

		/// <summary>
		/// Gets or sets the OrderDate value.
		/// </summary>
		public  DateTime OrderDate
		{
			get { return orderDate; }
			set { orderDate = value; }
		}

		/// <summary>
		/// Gets or sets the AckDateTxt value.
		/// </summary>
		public  string AckDateTxt
		{
			get { return ackDateTxt; }
			set { ackDateTxt = value; }
		}

		/// <summary>
		/// Gets or sets the AckDate value.
		/// </summary>
		public  DateTime AckDate
		{
			get { return ackDate; }
			set { ackDate = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessDateTxt value.
		/// </summary>
		public  string ProcessDateTxt
		{
			get { return processDateTxt; }
			set { processDateTxt = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessDate value.
		/// </summary>
		public  DateTime ProcessDate
		{
			get { return processDate; }
			set { processDate = value; }
		}

		/// <summary>
		/// Gets or sets the DeliverDateTxt value.
		/// </summary>
		public  string DeliverDateTxt
		{
			get { return deliverDateTxt; }
			set { deliverDateTxt = value; }
		}

		/// <summary>
		/// Gets or sets the DeliverDate value.
		/// </summary>
		public  DateTime DeliverDate
		{
			get { return deliverDate; }
			set { deliverDate = value; }
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
		/// Gets or sets the Discount value.
		/// </summary>
		public  decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableOrginalAmt value.
		/// </summary>
		public  decimal TaxableOrginalAmt
		{
			get { return taxableOrginalAmt; }
			set { taxableOrginalAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmt value.
		/// </summary>
		public  decimal TaxAmt
		{
			get { return taxAmt; }
			set { taxAmt = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmt value.
		/// </summary>
		public  decimal BillAmt
		{
			get { return billAmt; }
			set { billAmt = value; }
		}

		/// <summary>
		/// Gets or sets the OtherAmt value.
		/// </summary>
		public  decimal OtherAmt
		{
			get { return otherAmt; }
			set { otherAmt = value; }
		}

		/// <summary>
		/// Gets or sets the CGST value.
		/// </summary>
		public  decimal CGST
		{
			get { return cGST; }
			set { cGST = value; }
		}

		/// <summary>
		/// Gets or sets the SGST value.
		/// </summary>
		public  decimal SGST
		{
			get { return sGST; }
			set { sGST = value; }
		}

		/// <summary>
		/// Gets or sets the CessAmt value.
		/// </summary>
		public  decimal CessAmt
		{
			get { return cessAmt; }
			set { cessAmt = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOff value.
		/// </summary>
		public  decimal RoundOff
		{
			get { return roundOff; }
			set { roundOff = value; }
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
		/// Gets or sets the Priority value.
		/// </summary>
		public  string Priority
		{
			get { return priority; }
			set { priority = value; }
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
		/// Gets or sets the Remark value.
		/// </summary>
		public  string Remark
		{
			get { return remark; }
			set { remark = value; }
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
