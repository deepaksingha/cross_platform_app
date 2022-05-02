import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/model/OrganisationMaster.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/supplier/pages/users/user.dart';
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loader.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:badges/badges.dart';
import 'package:charts_flutter/flutter.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:flutter_typeahead/flutter_typeahead.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../supp_dashboard.dart';

class AddUserScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<AddUserScreen> {
  @override
  void initState() {
    _getUserDetails();
    _loadCustomers();
    super.initState();
  }

  TextEditingController customer = new TextEditingController();
  TextEditingController Fname = new TextEditingController();
  TextEditingController Lname = new TextEditingController();
  TextEditingController UserName = new TextEditingController();
  TextEditingController Password = new TextEditingController();
  int customerID = 0;

  @override
  void dispose() {
    super.dispose();
  }

  var _globalWidget = new GlobalWidget();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globalWidget.globalAppBar("Add Users"),
      backgroundColor: Colors.white,
      body: SafeArea(
          child: SingleChildScrollView(
        child: Container(
          margin: EdgeInsets.all(15),
          child: Column(
            children: [
              Container(
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(20),
                    border: Border.all(color: Colors.grey[400]!)),
                margin: EdgeInsets.symmetric(horizontal: 0),
                child: Padding(
                  padding: EdgeInsets.only(left: 10, right: 10),
                  child: TypeAheadFormField(
                      textFieldConfiguration: TextFieldConfiguration(
                        decoration: InputDecoration(
                          labelText: 'Customer/Organisation',
                          border: InputBorder.none,
                        ),
                        controller: this.customer,
                      ),
                      suggestionsCallback: (pattern) {
                        customerID = 0;
                        return _getSuggestions(pattern);
                      },
                      itemBuilder: (context, OrganisationMaster suggestion) {
                        return ListTile(
                          title: Text(suggestion.orgName),
                        );
                      },
                      transitionBuilder: (context, suggestionsBox, controller) {
                        return suggestionsBox;
                      },
                      onSuggestionSelected: (OrganisationMaster suggestion) {
                        customer.text = suggestion.orgName;
                        setState(() {
                          customerID = suggestion.orgID;
                          organisation = suggestion;
                        });
                      }),
                ),
              ),
              SizedBox(height: 15),
              Row(
                children: [
                  Expanded(
                    child: TextFormField(
                      controller: Fname,
                      decoration: InputDecoration(
                          labelText: "First Name",
                          hintText: "Enter first name",
                          isDense: true,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(20))),
                    ),
                  ),
                  SizedBox(width: 10),
                  Expanded(
                    child: TextFormField(
                      controller: Lname,
                      decoration: InputDecoration(
                          labelText: "Last Name",
                          hintText: "Enter last name",
                          isDense: true,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(20))),
                    ),
                  ),
                ],
              ),
              SizedBox(height: 15),
              TextFormField(
                controller: UserName,
                decoration: InputDecoration(
                    labelText: "Username",
                    hintText: "Enter username",
                    isDense: true,
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(20))),
              ),
              SizedBox(height: 15),
              TextFormField(
                controller: Password,
                decoration: InputDecoration(
                    labelText: "Password",
                    hintText: "Enter password",
                    isDense: true,
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(20))),
              ),
              SizedBox(height: 15),
              Visibility(
                  visible: isLoading == false,
                  child: InkWell(
                      onTap: () {
                        if (customerID == 0) {
                          _globalWidget.showMessage(
                              "Please Select Customer", true, context);
                        } else {
                          if (Fname.text == "") {
                            _globalWidget.showMessage(
                                "Please Enter First name", true, context);
                          } else {
                            if (Lname.text == "") {
                              _globalWidget.showMessage(
                                  "Please Enter Last Name", true, context);
                            } else {
                              if (UserName.text == "") {
                                _globalWidget.showMessage(
                                    "Please Enter Username", true, context);
                              } else {
                                if (Password.text == "") {
                                  _globalWidget.showMessage(
                                      "Please Enter Pssword", true, context);
                                } else {
                                  saveUsers();
                                }
                              }
                            }
                          }
                        }
                      },
                      child: BorderButton(color: active, text: "SAVE"))),
              Visibility(visible: isLoading == true, child: LoadingButton()),
            ],
          ),
        ),
      )),
    );
  }

  bool isLoading = false;
  bool itemLoading = true;
  OrganisationMaster? organisation;
  List<OrganisationMaster> _itemLists = <OrganisationMaster>[];

  void _loadCustomers() {
    getAPI(CUSTOMER_LISTS + "0").then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      setState(() {
        itemLoading = false;
      });
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          for (var a = 0; a < data_.length; a++) {
            setState(() {
              _itemLists.add(OrganisationMaster.fromMap(data_[a]));
            });
          }
        }
      }
    });
  }

  List<OrganisationMaster> _getSuggestions(String query) {
    List<OrganisationMaster> matches = <OrganisationMaster>[];
    matches.addAll(_itemLists);

    matches.retainWhere(
        (s) => s.orgName.toLowerCase().contains(query.toLowerCase()));
    return matches;
  }

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

  void saveUsers() {
    LoginUser login = new LoginUser(
        0,
        _loginUser.tenantID,
        _loginUser.isActive,
        1,
        "C",
        organisation!.orgTypeID,
        organisation!.orgType,
        customerID,
        customer.text,
        _loginUser.roleAccessID,
        _loginUser.roleName,
        Fname.text,
        "",
        Lname.text,
        UserName.text,
        Password.text,
        Fname.text + " " + Lname.text,
        "",
        "",
        "N",
        "",
        "",
        "",
        "",
        "",
        "",
        0,
        0,
        0,
        0,
        "",
        "0",
        "0",
        "0",
        "0",
        "",
        "",
        "",
        "N",
        0,
        "Y",
        0,
        "",
        "",
        0,
        "",
        0,
        "",
        0,
        "",
        "",
        0,
        "",
        "",
        "",
        "",
        "",
        _loginUser.userName,
        _loginUser.userName);

    print(jsonEncode(login));
    setState(() {
      isLoading = true;
    });
    LoginUserInsert(login).then((result) {
      setState(() {
        isLoading = false;
      });
      var j_data = jsonDecode(result.body);
      var responseCode = j_data["responseCode"];
      if (responseCode == "S") {
        _globalWidget.showMessage("User Successfully Created", false, context);
        Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(
                builder: (context) => SuppDashboardScreen(pageID: 0)),
            (Route<dynamic> route) => false);
        Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => UserScreen()),
            (Route<dynamic> route) => true);
      } else {
        _globalWidget.showMessage("Failed to save user", true, context);
      }
    });
  }
}
