class OrderDetails {
  final int orderDtlID;

  final int tenantID;

  final String isActive;

  final int statusID;

  final int orderID;

  final int orgID;

  final int itemID;

  final String itemName;

  final String hSN;

  final int itemCatID;

  final String categoryName;

  final int orderQTY;

  final int deliverQTY;

  final int recQTY;

  final String uOM;

  final int packSize;

  final double itemRate;

  final double itemMRP;

  final double costPrice;

  final double gST;

  final double preTaxOrginalAmt;

  final double disc;

  final double taxableAmt;

  final double taxtAmt;

  final double totalAmt;

  final double netAmt;

  final double roundoff;

  final String priority;

  final String isOutStock;

  final String companyUser;

  final String companyUpdateDate;

  final String companyMessage;

  final String compMessageBy;

  final String supplierMessage;

  final String supplierMsgBy;

  final String ackBy;

  final String packedBy;

  final String deliveredBy;

  final String verifiedBy;

  final String cancelledBy;

  final String cancelRemark;

  final String cancelDate;

  final String ackDate;

  final String verifyDate;

  final String remark;

  final String createdBy;

  final String updatedBy;

  final String createdDate;

  final String updateDate;

  OrderDetails(
      this.orderDtlID,
      this.tenantID,
      this.isActive,
      this.statusID,
      this.orderID,
      this.orgID,
      this.itemID,
      this.itemName,
      this.hSN,
      this.itemCatID,
      this.categoryName,
      this.orderQTY,
      this.deliverQTY,
      this.recQTY,
      this.uOM,
      this.packSize,
      this.itemRate,
      this.itemMRP,
      this.costPrice,
      this.gST,
      this.preTaxOrginalAmt,
      this.disc,
      this.taxableAmt,
      this.taxtAmt,
      this.totalAmt,
      this.netAmt,
      this.roundoff,
      this.priority,
      this.isOutStock,
      this.companyUser,
      this.companyUpdateDate,
      this.companyMessage,
      this.compMessageBy,
      this.supplierMessage,
      this.supplierMsgBy,
      this.ackBy,
      this.packedBy,
      this.deliveredBy,
      this.verifiedBy,
      this.cancelledBy,
      this.cancelRemark,
      this.cancelDate,
      this.ackDate,
      this.verifyDate,
      this.remark,
      this.createdBy,
      this.updatedBy,
      this.createdDate,
      this.updateDate);

  Map toJson() => {
    "orderDtlID":orderDtlID,
    "tenantID":tenantID,
    "isActive":isActive,
    "statusID":statusID,
    "orderID":orderID,
    "orgID":orgID,
    "itemID":itemID,
    "itemName":itemName,
    "hSN":hSN,
    "itemCatID":itemCatID,
    "categoryName":categoryName,
    "orderQTY":orderQTY,
    "deliverQTY":deliverQTY,
    "recQTY":recQTY,
    "uOM":uOM,
    "packSize":packSize,
    "itemRate":itemRate,
    "itemMRP":itemMRP,
    "costPrice":costPrice,
    "gST":gST,
    "preTaxOrginalAmt":preTaxOrginalAmt,
    "disc":disc,
    "taxableAmt":taxableAmt,
    "taxtAmt":taxtAmt,
    "totalAmt":totalAmt,
    "netAmt":netAmt,
    "roundoff":roundoff,
    "priority":priority,
    "isOutStock":isOutStock,
    "companyUser":companyUser,
    "companyUpdateDate":companyUpdateDate,
    "companyMessage":companyMessage,
    "compMessageBy":compMessageBy,
    "supplierMessage":supplierMessage,
    "supplierMsgBy":supplierMsgBy,
    "ackBy":ackBy,
    "packedBy":packedBy,
    "deliveredBy":deliveredBy,
    "verifiedBy":verifiedBy,
    "cancelledBy":cancelledBy,
    "cancelRemark":cancelRemark,
    "cancelDate":cancelDate,
    "ackDate":ackDate,
    "verifyDate":verifyDate,
    "remark":remark,
    "createdBy":createdBy,
    "updatedBy":updatedBy,
    "createdDate":createdDate,
    "updateDate":updateDate
    

  };

  factory OrderDetails.fromMap(Map<String, dynamic> json) {
    return OrderDetails(
        json["orderDtlID"] ?? "",
        json["tenantID"] ?? "",
        json["isActive"] ?? "",
        json["statusID"] ?? "",
        json["orderID"] ?? "",
        json["orgID"] ?? "",
        json["itemID"] ?? "",
        json["itemName"] ?? "",
        json["hSN"] ?? "",
        json["itemCatID"] ?? "",
        json["categoryName"] ?? "",
        json["orderQTY"] ?? "",
        json["deliverQTY"] ?? "",
        json["recQTY"] ?? "",
        json["uOM"] ?? "",
        json["packSize"] ?? "",
        json["itemRate"] ?? "",
        json["itemMRP"] ?? "",
        json["costPrice"] ?? "",
        json["gST"] ?? "",
        json["preTaxOrginalAmt"] ?? "",
        json["disc"] ?? "",
        json["taxableAmt"] ?? "",
        json["taxtAmt"] ?? "",
        json["totalAmt"] ?? "",
        json["netAmt"] ?? "",
        json["roundoff"] ?? "",
        json["priority"] ?? "",
        json["isOutStock"] ?? "",
        json["companyUser"] ?? "",
        json["companyUpdateDate"] ?? "",
        json["companyMessage"] ?? "",
        json["compMessageBy"] ?? "",
        json["supplierMessage"] ?? "",
        json["supplierMsgBy"] ?? "",
        json["ackBy"] ?? "",
        json["packedBy"] ?? "",
        json["deliveredBy"] ?? "",
        json["verifiedBy"] ?? "",
        json["cancelledBy"] ?? "",
        json["cancelRemark"] ?? "",
        json["cancelDate"] ?? "",
        json["ackDate"] ?? "",
        json["verifyDate"] ?? "",
        json["remark"] ?? "",
        json["createdBy"] ?? "",
        json["updatedBy"] ?? "",
        json["createdDate"] ?? "",
        json["updateDate"] ?? ""
    );
  }
}
