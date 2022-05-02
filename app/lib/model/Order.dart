class Order {
  final int orderID;

  final int tenantID;

  final String isActive;

  final int orderStatusID;

  final String orderStatus;

  final int internalStatusID;

  final String internalStatus;

  final String orderQR;

  final String orderNO;

  final int orgID;

  final String orderDateTxt;

  final String orderDate;

  final String ackDateTxt;

  final String ackDate;

  final String processDateTxt;

  final String processDate;

  final String deliverDateTxt;

  final String deliverDate;

  final double preTaxOrginalAmt;

  final double discount;

  final double taxableOrginalAmt;

  final double taxAmt;

  final double billAmt;

  final double otherAmt;

  final double cGST;

  final double sGST;

  final double cessAmt;

  final double roundOff;

  final double netAmt;

  final String cancelledBy;

  final String cancelRemark;

  final String priority;

  final String companyMessage;

  final String compMessageBy;

  final String supplierMessage;

  final String supplierMsgBy;

  final String remark;

  final String ackBy;

  final String packedBy;

  final String deliveredBy;

  final String verifiedBy;

  final String createdBy;

  final String updatedBy;

  final String createdDate;

  final String updateDate;
  final String orgName;

  Order(
      this.orderID,
      this.tenantID,
      this.isActive,
      this.orderStatusID,
      this.orderStatus,
      this.internalStatusID,
      this.internalStatus,
      this.orderQR,
      this.orderNO,
      this.orgID,
      this.orderDateTxt,
      this.orderDate,
      this.ackDateTxt,
      this.ackDate,
      this.processDateTxt,
      this.processDate,
      this.deliverDateTxt,
      this.deliverDate,
      this.preTaxOrginalAmt,
      this.discount,
      this.taxableOrginalAmt,
      this.taxAmt,
      this.billAmt,
      this.otherAmt,
      this.cGST,
      this.sGST,
      this.cessAmt,
      this.roundOff,
      this.netAmt,
      this.cancelledBy,
      this.cancelRemark,
      this.priority,
      this.companyMessage,
      this.compMessageBy,
      this.supplierMessage,
      this.supplierMsgBy,
      this.remark,
      this.ackBy,
      this.packedBy,
      this.deliveredBy,
      this.verifiedBy,
      this.createdBy,
      this.updatedBy,
      this.createdDate,
      this.updateDate,this.orgName);

  factory Order.fromMap(Map<String, dynamic> json) {
    return Order(
        json["orderID"] ?? "",
        json["tenantID"] ?? "",
        json["isActive"] ?? "",
        json["orderStatusID"] ?? "",
        json["orderStatus"] ?? "",
        json["internalStatusID"] ?? "",
        json["internalStatus"] ?? "",
        json["orderQR"] ?? "",
        json["orderNO"] ?? "",
        json["orgID"] ?? "",
        json["orderDateTxt"] ?? "",
        json["orderDate"] ?? "",
        json["ackDateTxt"] ?? "",
        json["ackDate"] ?? "",
        json["processDateTxt"] ?? "",
        json["processDate"] ?? "",
        json["deliverDateTxt"] ?? "",
        json["deliverDate"] ?? "",
        json["preTaxOrginalAmt"] ?? "",
        json["discount"] ?? "",
        json["taxableOrginalAmt"] ?? "",
        json["taxAmt"] ?? "",
        json["billAmt"] ?? "",
        json["otherAmt"] ?? "",
        json["cGST"] ?? "",
        json["sGST"] ?? "",
        json["cessAmt"] ?? "",
        json["roundOff"] ?? "",
        json["netAmt"] ?? "",
        json["cancelledBy"] ?? "",
        json["cancelRemark"] ?? "",
        json["priority"] ?? "",
        json["companyMessage"] ?? "",
        json["compMessageBy"] ?? "",
        json["supplierMessage"] ?? "",
        json["supplierMsgBy"] ?? "",
        json["remark"] ?? "",
        json["ackBy"] ?? "",
        json["packedBy"] ?? "",
        json["deliveredBy"] ?? "",
        json["verifiedBy"] ?? "",
        json["createdBy"] ?? "",
        json["updatedBy"] ?? "",
        json["createdDate"] ?? "",
        json["updateDate"] ?? "",
        json["orgName"] ?? "",
    );
  }
}
