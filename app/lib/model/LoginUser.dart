class LoginUser {
  final int loginID;

  final int tenantID;

  final String isActive;

  final int customerTypeID;

  final String customerType;

  final int orgTypeID;

  final String orgType;

  final int orgID;

  final String orgname;

  final int roleAccessID;

  final String roleName;

  final String firstN;

  final String middleN;

  final String lastN;

  final String userName;

  final String passwrd;

  final String displayN;

  final String email;

  final String mobile;

  final String photoFlag;

  final String photo;

  final String photoPath;

  final String lastLogin;

  final String lastPasswrdChgedDate;

  final String sharedLogin;

  final String loginIP;

  final int finanFromMonth;

  final int financialYearFrom;

  final int financialToMonth;

  final int financialYearTo;

  final String billingCounterFlag;

  final String billingCounterID;

  final String pharmacyCounterFlag;

  final String pharmacyCounterID;

  final String otherCounterFlag;

  final String otherCounterID;

  final String billSeriesFlag;

  final String phBillSeries;

  final String linkDoctorFlag;

  final int linkeDoctorID;

  final String appLoginFlag;

  final int assignedWardID;

  final String assignedWard;

  final String redirectLogin;

  final int linkedIncLocationID;

  final String linkedIncLocation;

  final int linkIncCategoryID;

  final String linkIncCategory;

  final int linkIncSubCategoryID;

  final String linkIncSubCategory;

  final String financialKey;

  final int linkAccCustomerID;

  final String linkAccCustomerName;

  final String custom_1;

  final String custom_2;

  final String createdDate;

  final String updatedDate;

  final String createdBy;

  final String updatedBy;

  LoginUser(
      this.loginID,
      this.tenantID,
      this.isActive,
      this.customerTypeID,
      this.customerType,
      this.orgTypeID,
      this.orgType,
      this.orgID,
      this.orgname,
      this.roleAccessID,
      this.roleName,
      this.firstN,
      this.middleN,
      this.lastN,
      this.userName,
      this.passwrd,
      this.displayN,
      this.email,
      this.mobile,
      this.photoFlag,
      this.photo,
      this.photoPath,
      this.lastLogin,
      this.lastPasswrdChgedDate,
      this.sharedLogin,
      this.loginIP,
      this.finanFromMonth,
      this.financialYearFrom,
      this.financialToMonth,
      this.financialYearTo,
      this.billingCounterFlag,
      this.billingCounterID,
      this.pharmacyCounterFlag,
      this.pharmacyCounterID,
      this.otherCounterFlag,
      this.otherCounterID,
      this.billSeriesFlag,
      this.phBillSeries,
      this.linkDoctorFlag,
      this.linkeDoctorID,
      this.appLoginFlag,
      this.assignedWardID,
      this.assignedWard,
      this.redirectLogin,
      this.linkedIncLocationID,
      this.linkedIncLocation,
      this.linkIncCategoryID,
      this.linkIncCategory,
      this.linkIncSubCategoryID,
      this.linkIncSubCategory,
      this.financialKey,
      this.linkAccCustomerID,
      this.linkAccCustomerName,
      this.custom_1,
      this.custom_2,
      this.createdDate,
      this.updatedDate,
      this.createdBy,
      this.updatedBy);

  Map toJson() => {
        "loginID": loginID,
        "tenantID": tenantID,
        "isActive": isActive,
        "customerTypeID": customerTypeID,
        "customerType": customerType,
        "orgTypeID": orgTypeID,
        "orgType": orgType,
        "orgID": orgID,
        "orgname": orgname,
        "roleAccessID": roleAccessID,
        "roleName": roleName,
        "firstN": firstN,
        "middleN": middleN,
        "lastN": lastN,
        "userName": userName,
        "passwrd": passwrd,
        "displayN": displayN,
        "email": email,
        "mobile": mobile,
        "photoFlag": photoFlag,
        "photo": photo,
        "photoPath": photoPath,
        "lastLogin": lastLogin,
        "lastPasswrdChgedDate": lastPasswrdChgedDate,
        "sharedLogin": sharedLogin,
        "loginIP": loginIP,
        "finanFromMonth": finanFromMonth,
        "financialYearFrom": financialYearFrom,
        "financialToMonth": financialToMonth,
        "financialYearTo": financialYearTo,
        "billingCounterFlag": billingCounterFlag,
        "billingCounterID": billingCounterID,
        "pharmacyCounterFlag": pharmacyCounterFlag,
        "pharmacyCounterID": pharmacyCounterID,
        "otherCounterFlag": otherCounterFlag,
        "otherCounterID": otherCounterID,
        "billSeriesFlag": billSeriesFlag,
        "phBillSeries": phBillSeries,
        "linkDoctorFlag": linkDoctorFlag,
        "linkeDoctorID": linkeDoctorID,
        "appLoginFlag": appLoginFlag,
        "assignedWardID": assignedWardID,
        "assignedWard": assignedWard,
        "redirectLogin": redirectLogin,
        "linkedIncLocationID": linkedIncLocationID,
        "linkedIncLocation": linkedIncLocation,
        "linkIncCategoryID": linkIncCategoryID,
        "linkIncCategory": linkIncCategory,
        "linkIncSubCategoryID": linkIncSubCategoryID,
        "linkIncSubCategory": linkIncSubCategory,
        "financialKey": financialKey,
        "linkAccCustomerID": linkAccCustomerID,
        "linkAccCustomerName": linkAccCustomerName,
        "custom_1": custom_1,
        "custom_2": custom_2,
        "createdDate": createdDate,
        "updatedDate": updatedDate,
        "createdBy": createdBy,
        "updatedBy": createdBy,
      };

  factory LoginUser.fromMap(Map<String, dynamic> json) {
    return LoginUser(
        json["loginID"] ?? "",
        json["tenantID"] ?? "",
        json["isActive"] ?? "",
        json["customerTypeID"] ?? "",
        json["customerType"] ?? "",
        json["orgTypeID"] ?? "",
        json["orgType"] ?? "",
        json["orgID"] ?? "",
        json["orgname"] ?? "",
        json["roleAccessID"] ?? "",
        json["roleName"] ?? "",
        json["firstN"] ?? "",
        json["middleN"] ?? "",
        json["lastN"] ?? "",
        json["userName"] ?? "",
        json["passwrd"] ?? "",
        json["displayN"] ?? "",
        json["email"] ?? "",
        json["mobile"] ?? "",
        json["photoFlag"] ?? "",
        json["photo"] ?? "",
        json["photoPath"] ?? "",
        json["lastLogin"] ?? "",
        json["lastPasswrdChgedDate"] ?? "",
        json["sharedLogin"] ?? "",
        json["loginIP"] ?? "",
        json["finanFromMonth"] ?? "",
        json["financialYearFrom"] ?? "",
        json["financialToMonth"] ?? "",
        json["financialYearTo"] ?? "",
        json["billingCounterFlag"] ?? "",
        json["billingCounterID"] ?? "",
        json["pharmacyCounterFlag"] ?? "",
        json["pharmacyCounterID"] ?? "",
        json["otherCounterFlag"] ?? "",
        json["otherCounterID"] ?? "",
        json["billSeriesFlag"] ?? "",
        json["phBillSeries"] ?? "",
        json["linkDoctorFlag"] ?? "",
        json["linkeDoctorID"] ?? "",
        json["appLoginFlag"] ?? "",
        json["assignedWardID"] ?? "",
        json["assignedWard"] ?? "",
        json["redirectLogin"] ?? "",
        json["linkedIncLocationID"] ?? "",
        json["linkedIncLocation"] ?? "",
        json["linkIncCategoryID"] ?? "",
        json["linkIncCategory"] ?? "",
        json["linkIncSubCategoryID"] ?? "",
        json["linkIncSubCategory"] ?? "",
        json["financialKey"] ?? "",
        json["linkAccCustomerID"] ?? "",
        json["linkAccCustomerName"] ?? "",
        json["custom_1"] ?? "",
        json["custom_2"] ?? "",
        json["createdDate"] ?? "",
        json["updatedDate"] ?? "",
        json["createdBy"] ?? "",
        json["updatedBy"] ?? "");
  }
}
