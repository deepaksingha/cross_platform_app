import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/auth/splash.dart';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/supplier/pages/item/add_items.dart';
import 'package:b2b/supplier/pages/users/add_users.dart';
import 'package:b2b/supplier/pages/users/user.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../supp_dashboard.dart';
import 'customer/add_customer.dart';

class HomeScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

var isLoading = false;

class _ViewState extends State<HomeScreen> {
  String _timeString = "";

  @override
  void initState() {
    super.initState();
    _getUserDetails();
    _timeString = _formatDateTime(DateTime.now());
    Timer.periodic(Duration(seconds: 1), (Timer t) => _getTime());
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: light,
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Container(
                margin: EdgeInsets.only(left: 20, right: 20, top: 20),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        child: MarqueeWidget(
                      child: Row(
                        children: [
                          CustomText(
                              text: "Welcome, ",
                              size: 17,
                              color: Colors.black,
                              weight: FontWeight.bold),
                          CustomText(
                            text: _loginUser.firstN +
                                " " +
                                _loginUser.middleN +
                                " " +
                                _loginUser.lastN,
                            size: 17,
                            color: Colors.black,
                            weight: FontWeight.bold,
                          ),
                        ],
                      ),
                    )),
                    InkWell(
                      child: Badge(
                        badgeContent: CustomText(
                          text: "0",
                          color: light,
                          size: 14,
                        ),
                        child: Icon(
                          Icons.circle_notifications,
                          color: Colors.black,
                          size: 30,
                        ),
                      ),
                    ),
                    SizedBox(
                      width: 15,
                    ),
                    InkWell(
                      onTap: () {
                        logMeOut();
                      },
                      child: Icon(
                        Icons.logout,
                        color: Colors.black,
                        size: 25,
                      ),
                    )
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 20, right: 20, top: 2),
                child: MarqueeWidget(
                  child: Row(
                    children: [
                      CustomText(text: _timeString, size: 10, color: dark),
                    ],
                  ),
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 20, right: 20, top: 25),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    CustomText(
                        text: "Today's Status",
                        size: 12,
                        color: Colors.black,
                        weight: FontWeight.bold),
                    // InkWell(
                    //   child: CustomText(
                    //       text: "All Report",
                    //       size: 12,
                    //       color: Colors.blue,
                    //       weight: FontWeight.bold),
                    // ),
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 10, right: 10, top: 15),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        child: InkWell(
                      onTap: () {
                        Navigator.of(context).pushAndRemoveUntil(
                            MaterialPageRoute(
                                builder: (context) =>
                                    SuppDashboardScreen(pageID: 3)),
                            (Route<dynamic> route) => false);
                      },
                      child: Card(
                        elevation: 3,
                        child: Container(
                          margin: EdgeInsets.all(10),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Card(
                                      shape: RoundedRectangleBorder(
                                        borderRadius:
                                            BorderRadius.circular(20.0),
                                      ),
                                      elevation: 0,
                                      color: blue,
                                      child: Padding(
                                        padding: EdgeInsets.all(9),
                                        child: Image.asset(
                                            "assets/icons/new_order.png",
                                            width: 22,
                                            color: Colors.white),
                                      )),
                                  MarqueeWidget(
                                      child: Icon(
                                    Icons.chevron_right,
                                    color: active,
                                    size: 20,
                                  ))
                                ],
                              ),
                              SizedBox(height: 10),
                              CustomText(
                                  text: newOrders.toString(),
                                  weight: FontWeight.bold,
                                  size: 20,
                                  color: blue),
                              SizedBox(height: 5),
                              CustomText(
                                text: "New Orders",
                                weight: FontWeight.bold,
                                size: 12,
                                color: Colors.grey[700]!,
                              )
                            ],
                          ),
                        ),
                      ),
                    )),
                    SizedBox(
                      width: 10,
                    ),
                    Expanded(
                        child: InkWell(
                            onTap: () {
                              Navigator.of(context).pushAndRemoveUntil(
                                  MaterialPageRoute(
                                      builder: (context) =>
                                          SuppDashboardScreen(pageID: 3)),
                                  (Route<dynamic> route) => false);
                            },
                            child: Card(
                              elevation: 3,
                              child: Container(
                                margin: EdgeInsets.all(10),
                                child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Row(
                                      mainAxisAlignment:
                                          MainAxisAlignment.spaceBetween,
                                      children: [
                                        Card(
                                            shape: RoundedRectangleBorder(
                                              borderRadius:
                                                  BorderRadius.circular(20.0),
                                            ),
                                            elevation: 0,
                                            color: green,
                                            child: Padding(
                                              padding: EdgeInsets.all(9),
                                              child: Image.asset(
                                                  "assets/icons/completed_orders.png",
                                                  width: 22,
                                                  color: Colors.white),
                                            )),
                                        MarqueeWidget(
                                            child: Icon(
                                          Icons.chevron_right,
                                          color: active,
                                          size: 20,
                                        ))
                                      ],
                                    ),
                                    SizedBox(height: 10),
                                    CustomText(
                                        text: compltedOrders.toString(),
                                        weight: FontWeight.bold,
                                        size: 20,
                                        color: green),
                                    SizedBox(height: 5),
                                    CustomText(
                                        text: "Completed Orders",
                                        weight: FontWeight.bold,
                                        size: 12,
                                        color: Colors.grey[700]!)
                                  ],
                                ),
                              ),
                            ))),
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 10, right: 10, top: 15),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        child: InkWell(
                            onTap: () {
                              Navigator.of(context).pushAndRemoveUntil(
                                  MaterialPageRoute(
                                      builder: (context) =>
                                          SuppDashboardScreen(pageID: 3)),
                                  (Route<dynamic> route) => false);
                            },
                            child: Card(
                              elevation: 3,
                              child: Container(
                                margin: EdgeInsets.all(10),
                                child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Row(
                                      mainAxisAlignment:
                                          MainAxisAlignment.spaceBetween,
                                      children: [
                                        Card(
                                            shape: RoundedRectangleBorder(
                                              borderRadius:
                                                  BorderRadius.circular(20.0),
                                            ),
                                            elevation: 0,
                                            color: orange,
                                            child: Padding(
                                              padding: EdgeInsets.all(9),
                                              child: Image.asset(
                                                  "assets/icons/pending_orders.png",
                                                  width: 22,
                                                  color: Colors.white),
                                            )),
                                        MarqueeWidget(
                                            child: Icon(
                                          Icons.chevron_right,
                                          color: active,
                                          size: 20,
                                        ))
                                      ],
                                    ),
                                    SizedBox(height: 10),
                                    CustomText(
                                        text: pendingOrders.toString(),
                                        weight: FontWeight.bold,
                                        size: 20,
                                        color: orange),
                                    SizedBox(height: 5),
                                    CustomText(
                                      text: "Pending Orders",
                                      weight: FontWeight.bold,
                                      size: 12,
                                      color: Colors.grey[700]!,
                                    )
                                  ],
                                ),
                              ),
                            ))),
                    SizedBox(
                      width: 10,
                    ),
                    Expanded(child: Container()),
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 20, right: 20, top: 30),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    CustomText(
                        text: "To Do",
                        size: 12,
                        color: Colors.black,
                        weight: FontWeight.bold),
                    Icon(
                      Icons.reorder,
                      color: Colors.black,
                      size: 15,
                    )
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 10, right: 10, top: 10),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        child: InkWell(
                            onTap: () {
                              Navigator.of(context).pushAndRemoveUntil(
                                  MaterialPageRoute(
                                      builder: (context) => AddItemScreen()),
                                  (Route<dynamic> route) => true);
                            },
                            child: Card(
                              elevation: 1,
                              child: Container(
                                decoration: BoxDecoration(
                                    borderRadius: BorderRadius.circular(5),
                                    border:
                                        Border.all(color: Colors.grey[200]!)),
                                child: Padding(
                                  padding: EdgeInsets.all(10),
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      Row(
                                        mainAxisAlignment:
                                            MainAxisAlignment.spaceBetween,
                                        children: [
                                          Expanded(
                                            child: CustomText(
                                                text: "Add Items",
                                                weight: FontWeight.bold,
                                                color: Colors.grey[800]!,
                                                size: 14),
                                          ),
                                          MarqueeWidget(
                                              child: Icon(
                                            Icons.post_add_outlined,
                                            color: Colors.black,
                                            size: 25,
                                          ))
                                        ],
                                      ),
                                      SizedBox(height: 0),
                                      CustomText(
                                        text: "$itemCount Item(s) added",
                                        weight: FontWeight.bold,
                                        size: 11,
                                        color: blue,
                                      )
                                    ],
                                  ),
                                ),
                              ),
                            ))),
                    SizedBox(width: 5),
                    Expanded(
                        child: InkWell(
                      onTap: () {
                        Navigator.of(context).pushAndRemoveUntil(
                            MaterialPageRoute(
                                builder: (context) => AddCustomerScreen()),
                            (Route<dynamic> route) => true);
                      },
                      child: Card(
                        elevation: 1,
                        child: Container(
                          decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(5),
                              border: Border.all(color: Colors.grey[200]!)),
                          child: Padding(
                            padding: EdgeInsets.all(10),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Expanded(
                                      child: CustomText(
                                          text: "Add Customers",
                                          weight: FontWeight.bold,
                                          size: 14,
                                          color: Colors.grey[800]!),
                                    ),
                                    MarqueeWidget(
                                        child: Icon(
                                      Icons.group_add,
                                      color: Colors.black,
                                      size: 25,
                                    ))
                                  ],
                                ),
                                SizedBox(height: 0),
                                CustomText(
                                  text: "$customerCount Customer(s) added",
                                  weight: FontWeight.bold,
                                  size: 11,
                                  color: blue,
                                )
                              ],
                            ),
                          ),
                        ),
                      ),
                    )),
                  ],
                ),
              ),
              Container(
                margin: EdgeInsets.only(left: 10, right: 10, top: 10),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        child: InkWell(
                            onTap: () {
                              Navigator.of(context).pushAndRemoveUntil(
                                  MaterialPageRoute(
                                      builder: (context) => UserScreen()),
                                      (Route<dynamic> route) => true);
                            },
                            child: Card(
                              elevation: 1,
                              child: Container(
                                decoration: BoxDecoration(
                                    borderRadius: BorderRadius.circular(5),
                                    border:
                                    Border.all(color: Colors.grey[200]!)),
                                child: Padding(
                                  padding: EdgeInsets.all(10),
                                  child: Column(
                                    crossAxisAlignment:
                                    CrossAxisAlignment.start,
                                    children: [
                                      Row(
                                        mainAxisAlignment:
                                        MainAxisAlignment.spaceBetween,
                                        children: [
                                          Expanded(
                                            child: CustomText(
                                                text: "Users",
                                                weight: FontWeight.bold,
                                                color: Colors.grey[800]!,
                                                size: 14),
                                          ),
                                          MarqueeWidget(
                                              child: Icon(
                                                Icons.people,
                                                color: Colors.black,
                                                size: 25,
                                              ))
                                        ],
                                      ),
                                      SizedBox(height: 0),
                                      CustomText(
                                        text: "View Users",
                                        weight: FontWeight.bold,
                                        size: 11,
                                        color: blue,
                                      )
                                    ],
                                  ),
                                ),
                              ),
                            ))),
                    SizedBox(width: 5),
                    Expanded(
                        child: InkWell(
                          onTap: () {
                            Navigator.of(context).pushAndRemoveUntil(
                                MaterialPageRoute(
                                    builder: (context) => AddUserScreen()),
                                    (Route<dynamic> route) => true);
                          },
                          child: Card(
                            elevation: 1,
                            child: Container(
                              decoration: BoxDecoration(
                                  borderRadius: BorderRadius.circular(5),
                                  border: Border.all(color: Colors.grey[200]!)),
                              child: Padding(
                                padding: EdgeInsets.all(10),
                                child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Row(
                                      mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                      children: [
                                        Expanded(
                                          child: CustomText(
                                              text: "Add Users",
                                              weight: FontWeight.bold,
                                              size: 14,
                                              color: Colors.grey[800]!),
                                        ),
                                        MarqueeWidget(
                                            child: Icon(
                                              Icons.add,
                                              color: Colors.black,
                                              size: 25,
                                            ))
                                      ],
                                    ),
                                    SizedBox(height: 0),
                                    CustomText(
                                      text: "Add/Edit Users",
                                      weight: FontWeight.bold,
                                      size: 11,
                                      color: blue,
                                    )
                                  ],
                                ),
                              ),
                            ),
                          ),
                        )),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  void _getTime() {
    final DateTime now = DateTime.now();
    final String formattedDateTime = _formatDateTime(now);
    setState(() {
      _timeString = formattedDateTime;
    });
  }

  void logMeOut() async {
    final SharedPreferences _pref = await SharedPreferences.getInstance();
    _pref.remove(USER_DETAILS);
    _pref.remove(LOGIN_TYPE);
    _pref.setBool(IS_LOGIN, false);
    Widget cancelButton = TextButton(
        onPressed: () {
          Navigator.pop(context);
        },
        child: Text('No', style: TextStyle(color: Colors.grey)));
    Widget continueButton = TextButton(
        onPressed: () {
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(builder: (context) => SplashScreen()),
              (Route<dynamic> route) => false);
        },
        child: Text('Yes', style: TextStyle(color: Colors.red)));

    AlertDialog alert = AlertDialog(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10),
      ),
      title: Text(
        'Log Out',
        style: TextStyle(fontSize: 18),
      ),
      content: Text('Are you sure you want to log out?',
          style: TextStyle(fontSize: 13, color: active)),
      actions: [
        cancelButton,
        continueButton,
      ],
    );
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return alert;
      },
    );
  }

  String _formatDateTime(DateTime dateTime) {
    return DateFormat('MMM, dd yyyy hh:mm:ss a').format(dateTime);
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
      _loadDashboardInfo();
    } catch (ee) {
      print(ee.toString());
    }
  }

  DateTime fromDate_ = DateTime.now();
  DateTime toDate_ = DateTime.now();

  String fromDate = "";
  String toDate = "";

  int newOrders = 0;
  int compltedOrders = 0;
  int pendingOrders = 0;
  int itemCount = 0;
  int customerCount = 0;

  void _loadDashboardInfo() {
    setState(() {
      toDate = DateFormat('dd/MM/yyyy').format(toDate_);
      fromDate = DateFormat('dd/MM/yyyy').format(fromDate_);
    });
    setState(() {
      isLoading = true;
    });
    print(
        DASHBOARD + _loginUser.orgID.toString() + "&from=$fromDate&to=$toDate");
    getAPI(DASHBOARD +
            _loginUser.orgID.toString() +
            "&from=$fromDate&to=$toDate")
        .then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      setState(() {
        isLoading = false;
      });
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          print(data_[0]["newOrders"].toString());
          setState(() {
            newOrders = data_[0]["newOrders"];
            compltedOrders = data_[0]["compltedOrders"];
            pendingOrders = data_[0]["pendingOrders"];
            itemCount = data_[0]["itemCount"];
            customerCount = data_[0]["customerCount"];
          });
        }
      }
    });
  }
}
