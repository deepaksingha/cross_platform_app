class ItemMaster {
  final int itemID;

  final int tenantID;

  final String isActive;

  final int orgID;

  final String itemName;

  final String itemCode;

  final String hSN;

  final int itemCatID;

  final String categoryName;

  final String uOM;

  final int packSize;

  final double itemRate;

  final double itemMRP;

  final double costPrice;

  final double gST;

  final String outofStcok;

  final String itemImageFlag;

  final String itemImage_1;

  final String itemImagePath_1;

  final String itemImage_2;

  final String itemImagePath_2;

  final String itemImage_3;

  final String itemImagePath_3;

  final String remark;

  final String createdBy;

  final String updatedBy;

  final String createdDate;

  final String updateDate;

  ItemMaster(
      this.itemID,
      this.tenantID,
      this.isActive,
      this.orgID,
      this.itemName,
      this.itemCode,
      this.hSN,
      this.itemCatID,
      this.categoryName,
      this.uOM,
      this.packSize,
      this.itemRate,
      this.itemMRP,
      this.costPrice,
      this.gST,
      this.outofStcok,
      this.itemImageFlag,
      this.itemImage_1,
      this.itemImagePath_1,
      this.itemImage_2,
      this.itemImagePath_2,
      this.itemImage_3,
      this.itemImagePath_3,
      this.remark,
      this.createdBy,
      this.updatedBy,
      this.createdDate,
      this.updateDate);

  Map toJson() => {
        "itemID": itemID,
        "tenantID": tenantID,
        "isActive": isActive,
        "orgID": orgID,
        "itemName": itemName,
        "itemCode": itemCode,
        "hSN": hSN,
        "itemCatID": itemCatID,
        "categoryName": categoryName,
        "uOM": uOM,
        "packSize": packSize,
        "itemRate": itemRate,
        "itemMRP": itemMRP,
        "costPrice": costPrice,
        "gST": gST,
        "outofStcok": outofStcok,
        "itemImageFlag": itemImageFlag,
        "itemImage_1": itemImage_1,
        "itemImagePath_1": itemImagePath_1,
        "itemImage_2": itemImage_2,
        "itemImagePath_2": itemImagePath_2,
        "itemImage_3": itemImage_3,
        "itemImagePath_3": itemImagePath_3,
        "remark": remark,
        "createdBy": createdBy,
        "updatedBy": updatedBy,
        "createdDate": createdDate,
        "updateDate": updateDate
      };

  factory ItemMaster.fromMap(Map<String, dynamic> json) {
    return ItemMaster(
      json["itemID"] ?? "",
      json["tenantID"] ?? "",
      json["isActive"] ?? "",
      json["orgID"] ?? "",
      json["itemName"] ?? "",
      json["itemCode"] ?? "",
      json["hSN"] ?? "",
      json["itemCatID"] ?? "",
      json["categoryName"] ?? "",
      json["uOM"] ?? "",
      json["packSize"] ?? "",
      json["itemRate"] ?? "",
      json["itemMRP"] ?? "",
      json["costPrice"] ?? "",
      json["gST"] ?? "",
      json["outofStcok"] ?? "",
      json["itemImageFlag"] ?? "",
      json["itemImage_1"] ?? "",
      json["itemImagePath_1"] ?? "",
      json["itemImage_2"] ?? "",
      json["itemImagePath_2"] ?? "",
      json["itemImage_3"] ?? "",
      json["itemImagePath_3"] ?? "",
      json["remark"] ?? "",
      json["createdBy"] ?? "",
      json["updatedBy"] ?? "",
      json["createdDate"] ?? "",
      json["updateDate"] ?? "",
    );
  }
}
