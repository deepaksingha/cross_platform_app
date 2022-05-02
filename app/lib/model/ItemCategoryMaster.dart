class ItemCategoryMaster {
  final int itemCatID;

  final int tenantID;

  final String isActive;

  final String categoryName;

  final String storeType;

  final String issueTypeCode;

  final String issueTypeName;

  final String retailable;

  final String expiryFlag;

  final String discountFlag;

  final String identificationType;

  final String identification;

  final String createdDate;

  final String updatedDate;

  final String createdBy;

  final String updatedBy;

  ItemCategoryMaster(
      this.itemCatID,
      this.tenantID,
      this.isActive,
      this.categoryName,
      this.storeType,
      this.issueTypeCode,
      this.issueTypeName,
      this.retailable,
      this.expiryFlag,
      this.discountFlag,
      this.identificationType,
      this.identification,
      this.createdDate,
      this.updatedDate,
      this.createdBy,
      this.updatedBy);

  factory ItemCategoryMaster.fromMap(Map<String, dynamic> json) {
    return ItemCategoryMaster(
        json["itemCatID"] ?? "",
        json["tenantID"] ?? "",
        json["isActive"] ?? "",
        json["categoryName"] ?? "",
        json["storeType"] ?? "",
        json["issueTypeCode"] ?? "",
        json["issueTypeName"] ?? "",
        json["retailable"] ?? "",
        json["expiryFlag"] ?? "",
        json["discountFlag"] ?? "",
        json["identificationType"] ?? "",
        json["identification"] ?? "",
        json["createdDate"] ?? "",
        json["updatedDate"] ?? "",
        json["createdBy"] ?? "",
        json["updatedBy"] ?? "");
  }
}
