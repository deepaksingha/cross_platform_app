class OrganisationMaster {
  final int orgID;

  final int tenantID;

  final String isActive;

  final int orgTypeID;

  final String orgType;

  final int customerTypeID;

  final String customerType;

  final String orgName;

  final String orgCode;

  final String phone;

  final String entityAddress_1;

  final String entityAddress_2;

  final String entityAddress_3;

  final String entityAddress_4;

  final String entityAddress_5;

  final String entityMobile_1;

  final String entityMobile_2;

  final String entityLanline_1;

  final String entityLanline_2;

  final String logoFlag;

  final String orgLogo;

  final String tIN;

  final String pAN;

  final String gST;

  final String regNPrefix;

  final String moneyRecPrefix;

  final String billRefPrefix;

  final double creditLimit;

  final double openingBal;

  final double closingBal;

  final String website;

  final String custom_1;

  final String custom_2;

  final String custom_3;

  final String createdBy;

  final String updatedBy;

  final String createdDate;

  final String updateDate;

  OrganisationMaster(
      this.orgID,
      this.tenantID,
      this.isActive,
      this.orgTypeID,
      this.orgType,
      this.customerTypeID,
      this.customerType,
      this.orgName,
      this.orgCode,
      this.phone,
      this.entityAddress_1,
      this.entityAddress_2,
      this.entityAddress_3,
      this.entityAddress_4,
      this.entityAddress_5,
      this.entityMobile_1,
      this.entityMobile_2,
      this.entityLanline_1,
      this.entityLanline_2,
      this.logoFlag,
      this.orgLogo,
      this.tIN,
      this.pAN,
      this.gST,
      this.regNPrefix,
      this.moneyRecPrefix,
      this.billRefPrefix,
      this.creditLimit,
      this.openingBal,
      this.closingBal,
      this.website,
      this.custom_1,
      this.custom_2,
      this.custom_3,
      this.createdBy,
      this.updatedBy,
      this.createdDate,
      this.updateDate);

  Map toJson() => {
        "orgID": orgID,
        "tenantID": tenantID,
        "isActive": isActive,
        "orgTypeID": orgTypeID,
        "orgType": orgType,
        "customerTypeID": customerTypeID,
        "customerType": customerType,
        "orgName": orgName,
        "orgCode": orgCode,
        "phone": phone,
        "entityAddress_1": entityAddress_1,
        "entityAddress_2": entityAddress_2,
        "entityAddress_3": entityAddress_3,
        "entityAddress_4": entityAddress_4,
        "entityAddress_5": entityAddress_5,
        "entityMobile_1": entityMobile_1,
        "entityMobile_2": entityMobile_2,
        "entityLanline_1": entityLanline_1,
        "entityLanline_2": entityLanline_2,
        "logoFlag": logoFlag,
        "orgLogo": orgLogo,
        "tIN": tIN,
        "pAN": pAN,
        "gST": gST,
        "regNPrefix": regNPrefix,
        "moneyRecPrefix": moneyRecPrefix,
        "billRefPrefix": billRefPrefix,
        "creditLimit": creditLimit,
        "openingBal": openingBal,
        "closingBal": closingBal,
        "website": website,
        "custom_1": custom_1,
        "custom_2": custom_2,
        "custom_3": custom_3,
        "createdBy": createdBy,
        "updatedBy": updatedBy,
        "createdDate": createdDate,
        "updateDate": updateDate
      };

  factory OrganisationMaster.fromMap(Map<String, dynamic> json) {
    return OrganisationMaster(
        json["orgID"] ?? "",
        json["tenantID"] ?? "",
        json["isActive"] ?? "",
        json["orgTypeID"] ?? "",
        json["orgType"] ?? "",
        json["customerTypeID"] ?? "",
        json["customerType"] ?? "",
        json["orgName"] ?? "",
        json["orgCode"] ?? "",
        json["phone"] ?? "",
        json["entityAddress_1"] ?? "",
        json["entityAddress_2"] ?? "",
        json["entityAddress_3"] ?? "",
        json["entityAddress_4"] ?? "",
        json["entityAddress_5"] ?? "",
        json["entityMobile_1"] ?? "",
        json["entityMobile_2"] ?? "",
        json["entityLanline_1"] ?? "",
        json["entityLanline_2"] ?? "",
        json["logoFlag"] ?? "",
        json["orgLogo"] ?? "",
        json["tIN"] ?? "",
        json["pAN"] ?? "",
        json["gST"] ?? "",
        json["regNPrefix"] ?? "",
        json["moneyRecPrefix"] ?? "",
        json["billRefPrefix"] ?? "",
        json["creditLimit"] ?? "",
        json["openingBal"] ?? "",
        json["closingBal"] ?? "",
        json["website"] ?? "",
        json["custom_1"] ?? "",
        json["custom_2"] ?? "",
        json["custom_3"] ?? "",
        json["createdBy"] ?? "",
        json["updatedBy"] ?? "",
        json["createdDate"] ?? "",
        json["updateDate"] ?? "");
  }
}
