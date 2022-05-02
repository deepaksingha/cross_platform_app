import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/model/OrganisationMaster.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:flutter/services.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../supp_dashboard.dart';

class AddCustomerScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<AddCustomerScreen> {
  @override
  void initState() {
    _getUserDetails();
    super.initState();
  }

  TextEditingController customerName = new TextEditingController();
  TextEditingController customerCode = new TextEditingController();
  TextEditingController phone = new TextEditingController();
  TextEditingController address1 = new TextEditingController();
  TextEditingController address2 = new TextEditingController();
  TextEditingController address3 = new TextEditingController();
  TextEditingController tin = new TextEditingController();
  TextEditingController pan = new TextEditingController();
  TextEditingController gst = new TextEditingController();
  TextEditingController creditLimit = new TextEditingController();
  TextEditingController openingBalance = new TextEditingController();
  TextEditingController closingBalance = new TextEditingController();
  TextEditingController website = new TextEditingController();

  @override
  void dispose() {
    super.dispose();
  }

  var _globarWidget = new GlobalWidget();


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globarWidget.globalAppBar("Add Customers"),
      backgroundColor: Colors.white,
      body: SafeArea(
        child: SingleChildScrollView(
          child: Container(
            margin: EdgeInsets.all(15),
            child: Column(
              children: [
                TextFormField(
                  controller: customerName,
                  decoration: InputDecoration(
                      labelText: "Customer Name",
                      hintText: "Enter customer name",
                      isDense: true,
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: customerCode,
                  decoration: InputDecoration(
                      labelText: "Customer Code",
                      isDense: true,
                      hintText: "Enter customer code",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  keyboardType: TextInputType.number,
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.allow(RegExp(r'[0-9]')),
                  ],
                  controller: phone,
                  maxLines: 1,
                  decoration: InputDecoration(
                      labelText: "Phone Number",
                      isDense: true,

                      hintText: "Enter phone number",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: address1,
                  keyboardType: TextInputType.multiline,
                  maxLines: 1,
                  decoration: InputDecoration(
                      labelText: "Address 1",
                      isDense: true,

                      hintText: "Enter address",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),

                TextFormField(
                  controller: address2,
                  keyboardType: TextInputType.multiline,
                  maxLines: 1,
                  decoration: InputDecoration(

                      labelText: "Address 2",
                      isDense: true,
                      hintText: "Enter address",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: address3,
                  keyboardType: TextInputType.multiline,
                  maxLines: 1,
                  decoration: InputDecoration(

                      labelText: "Address 3",
                      isDense: true,
                      hintText: "Enter address",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),

                SizedBox(height: 15),
                TextFormField(
                  controller: tin,
                  decoration: InputDecoration(
                      labelText: "TIN",
                      isDense: true,
                      hintText: "Enter tin",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),

                SizedBox(height: 15),
                TextFormField(
                  controller: pan,
                  decoration: InputDecoration(
                      labelText: "PAN",
                      isDense: true,
                      hintText: "Enter pan",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),

                SizedBox(height: 15),
                TextFormField(
                  controller: gst,
                  decoration: InputDecoration(
                      labelText: "GST",
                      isDense: true,
                      hintText: "Enter gst",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),

                SizedBox(height: 15),
                TextFormField(
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  controller: creditLimit,
                  decoration: InputDecoration(
                      labelText: "Credit Limit",
                      isDense: true,
                      hintText: "Enter credit limit",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),

                SizedBox(height: 15),
                TextFormField(
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  controller: openingBalance,
                  decoration: InputDecoration(
                      labelText: "Opening Balance",
                      isDense: true,
                      hintText: "Enter opening balance",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  controller: closingBalance,
                  decoration: InputDecoration(
                      labelText: "Closing Balance",
                      isDense: true,
                      hintText: "Enter closing balance",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: website,
                  decoration: InputDecoration(
                      labelText: "Website",
                      isDense: true,
                      hintText: "Enter website",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),


                SizedBox(
                  height: 15,
                ),
                Visibility(visible: isLoading == false, child: InkWell(
                    onTap: () {
                      checkFields();
                    },
                    child: BorderButton(color:active,text: "SAVE"))),
                Visibility(visible: isLoading == true, child: LoadingButton())
              ],
            ),
          ),
        ),
      ),
    );
  }

  void checkFields() {
    if (customerName.text == "") {
      _globarWidget.showMessage("Please insert customer name", false, context);
    }
    else {
      if (address1.text == "") {
        _globarWidget.showMessage("Please insert address 1", false, context);
      }
      else {
        if (address2.text == "") {
          _globarWidget.showMessage("Please insert address 2", false, context);
        }
        else {
          if (tin.text == "") {
            _globarWidget.showMessage("Please insert tin", false, context);
          }
          else {
            if (creditLimit.text == "") {
              _globarWidget.showMessage(
                  "Please insert credit limit", false, context);
            }
            else {
              if (openingBalance.text == "") {
                _globarWidget.showMessage(
                    "Please insert opening balance", false, context);
              }
              else {
                if (closingBalance.text == "") {
                  _globarWidget.showMessage(
                      "Please insert closing balance", false, context);
                }
                else {
                  saveCustomer();
                }
              }
            }
          }
        }
      }
    }
  }

  void saveCustomer() async {
    setState(() {
      isLoading = true;
    });
    OrganisationMaster item= OrganisationMaster(
       0,
        _loginUser.tenantID,
        "Y",
        1,
        "",
        1,
        "",
        customerName.text,
        customerCode.text,
        phone.text,
        address1.text,
        address2.text,
        address3.text,
        "",//entityAddress_4
        "",//entityAddress_5
        "",//entityMobile_1
        "",//entityMobile_2
        "",//entityLanline_1
        "",//entityLanline_2
        "N",//logoFlag
        "",//orgLogo
        tin.text,
        pan.text,
        gst.text,
        "",//regNPrefix
        "",//moneyRecPrefix
        "",//billRefPrefix
        double.parse(creditLimit.text),
        double.parse(openingBalance.text),
        double.parse(closingBalance.text),
        website.text,
        "",//custom_1
        "",//custom_2
        "",//custom_3
        _loginUser.userName,
        _loginUser.userName,
        "",//createdDate
        ""//updateDate
    );
    print(jsonEncode(item));
    setState(() {
      isLoading=true;
    });
    InsertOrganisation(item).then((result) {
      setState(() {
        isLoading = false;
      });
      var j_data = jsonDecode(result.body);
      var responseCode = j_data["responseCode"];
      if(responseCode=="S"){
        _globarWidget.showMessage("Customer saved Successfully", false, context);
        Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => SuppDashboardScreen(pageID: 2)),
                (Route<dynamic> route) => false);
      }
      else{
        _globarWidget.showMessage("Failed to save customer", true, context);
      }



      print(j_data.toString());
    });
  }

  bool isLoading = false;
  late LoginUser _loginUser;

  void _getUserDetails() async {
    final SharedPreferences _pref = await SharedPreferences.getInstance();
    var loginUser = _pref.getString(USER_DETAILS);
    try {
      Map<String, dynamic> userMap =
      jsonDecode(loginUser!) as Map<String, dynamic>;
      print(userMap.toString());
      setState(() {
        _loginUser = LoginUser.fromMap(userMap);
      });
    } catch (ee) {
      print(ee.toString());
    }
  }


}
