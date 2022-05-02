import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/model/Order.dart';
import 'package:b2b/model/OrderDetails.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/supplier/pages/order/orders_details.dart';
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:flutter_datetime_picker/flutter_datetime_picker.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

class OrderScreen extends StatefulWidget {

  final int orgID;

  OrderScreen({required this.orgID});
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<OrderScreen> {

  DateTime fromDate_ = DateTime.now();
  DateTime toDate_ = DateTime.now();

  DateTime minDate = DateTime.now();
  DateTime maxDate = DateTime.now();

  String fromDateShow = "--";
  String fromDate = "";
  String toDate = "";
  String toDateShow = "--";


  @override
  void initState() {
    super.initState();
    setState(() {
      toDate = DateFormat('dd/MM/yyyy')
          .format(toDate_);
      toDateShow =
          DateFormat('dd MMM yyyy')
              .format(toDate_);

      fromDate = DateFormat('dd/MM/yyyy')
          .format(fromDate_);
      fromDateShow =
          DateFormat('dd MMM yyyy')
              .format(fromDate_);
    });
    _getUserDetails();
  }

  @override
  void dispose() {
    super.dispose();
  }

  var _globarWidget = new GlobalWidget();
  bool isLoading=false;


  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: light,
      appBar: widget.orgID>0?_globarWidget.globalAppBar("Orders"):null,
      body: SafeArea(
        child: SingleChildScrollView(
            child: Container(
              margin: EdgeInsets.all(15),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Expanded(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                "From",
                                style: TextStyle(
                                    fontSize: 12,
                                    color: lightGrey,
                                    fontWeight: FontWeight.normal),
                              ),
                              GestureDetector(
                                onTap: () {
                                  DatePicker.showDatePicker(context,
                                      showTitleActions: true,
                                      //maxTime: maxDate,
                                      onChanged: (date) {},
                                      onConfirm: (date) {
                                        setState(() {
                                          fromDate_ = date;
                                          fromDate = DateFormat('dd/MM/yyyy')
                                              .format(date);
                                          fromDateShow =
                                              DateFormat('dd MMM yyyy')
                                                  .format(date);
                                          toDateShow = "---";
                                          toDate_ = date;
                                          // maxDate = fromDate_.add(Duration(
                                          //     days: leaveBalance.toInt()-1));

                                        });
                                      },
                                      currentTime: fromDate_,
                                      locale: LocaleType.en);
                                },
                                child: Container(
                                  margin: EdgeInsets.only(top: 3),
                                  decoration: BoxDecoration(
                                    border: Border.all(
                                      color: lightGrey,
                                      style: BorderStyle.solid,
                                      width: 0.5,
                                    ),
                                    color: Colors.transparent,
                                    borderRadius:
                                    BorderRadius.circular(4.0),
                                  ),
                                  child: Container(
                                    padding: EdgeInsets.only(
                                        left: 10,
                                        right: 10,
                                        top: 7,
                                        bottom: 7),
                                    child: Row(
                                      mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                      children: [
                                        Text(
                                          fromDateShow,
                                          style: TextStyle(
                                              color: Colors.black,
                                              fontSize: 12,
                                              fontWeight:
                                              FontWeight.normal),
                                        ),
                                        Icon(Icons.calendar_today,
                                            size: 15,
                                            color: active)
                                      ],
                                    ),
                                  ),
                                ),
                              ),
                            ],
                          )),
                      SizedBox(
                        width: 25,
                      ),
                      Expanded(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Row(
                                mainAxisAlignment:
                                MainAxisAlignment.spaceBetween,
                                children: [
                                  Text(
                                    "To",
                                    style: TextStyle(
                                        fontSize: 12,
                                        color: lightGrey,
                                        fontWeight: FontWeight.normal),
                                  ),
                                ],
                              ),
                              GestureDetector(
                                onTap: () {

                                    DatePicker.showDatePicker(context,
                                        showTitleActions: true,
                                        minTime: fromDate_,
                                        onChanged: (date) {},
                                        onConfirm: (date) {

                                          setState(() {
                                            toDate_ = date;
                                            toDate = DateFormat('dd/MM/yyyy')
                                                .format(date);
                                            toDateShow =
                                                DateFormat('dd MMM yyyy')
                                                    .format(date);

                                          });
                                        },
                                        currentTime: toDate_,
                                        locale: LocaleType.en);

                                },
                                child: Container(
                                  margin: EdgeInsets.only(top: 3),
                                  decoration: BoxDecoration(
                                    border: Border.all(
                                      color: lightGrey,
                                      style: BorderStyle.solid,
                                      width: 0.5,
                                    ),
                                    color: Colors.transparent,
                                    borderRadius:
                                    BorderRadius.circular(4.0),
                                  ),
                                  child: Container(
                                    padding: EdgeInsets.only(
                                        left: 10,
                                        right: 10,
                                        top: 7,
                                        bottom: 7),
                                    child: Row(
                                      mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                      children: [
                                        Text(
                                          toDateShow,
                                          style: TextStyle(
                                              color: Colors.black,
                                              fontSize: 12,
                                              fontWeight:
                                              FontWeight.normal),
                                        ),
                                        Icon(Icons.calendar_today,
                                            size: 15,
                                            color: active)
                                      ],
                                    ),
                                  ),
                                ),
                              ),
                            ],
                          ))
                    ],
                  ),
                  SizedBox(height:10),
                 Visibility(child: InkWell(child: BorderButton(color:active,text:"REFRESH"),onTap: (){refreshOrders();},),visible: isLoading==false,),
                 Visibility(child: LoadingButton(),visible: isLoading==true,),
                  SizedBox(height:10),
                  Container(
                    margin:EdgeInsets.only(left:10,right:10),
                    child:CustomText(text:"Total Record(s) :" +_orderList.length.toString(),size: 13,),
                  ),
                  Visibility(child:
                  Card(
                    child: Container(
                        margin: EdgeInsets.symmetric(vertical: 0),
                        child: SingleChildScrollView(
                          scrollDirection: Axis.horizontal,
                          child: DataTable(
                            showCheckboxColumn: false,
                            columns: <DataColumn>[
                              DataColumn(label: Text('Order No.')),
                              DataColumn(label: Text('Status')),
                              DataColumn(label: Text('Date')),
                              DataColumn(label: Text('Priority')),
                              DataColumn(label: Text('Remarks')),
                              DataColumn(label: Text('')),

                            ],
                            rows:
                            _orderList // Loops through dataColumnText, each iteration assigning the value to element
                                .map(
                              ((element) => DataRow(
                                onSelectChanged: (value) {
                                   showOrderDetails(element);
                                },
                                cells: <DataCell>[

                                  DataCell(Text(element
                                      .orderNO
                                      .toString())),
                                  //Extracting from Map element the value
                                  DataCell(
                                      Text(element.orderStatus)),
                                  //Extracting from Map element the value
                                  DataCell(Text(element
                                      .orderDateTxt
                                      .toString())),
                                  //Extracting from Map element the value
                                  DataCell(Text(
                                    element.priority=="N"?"Normal":"High",
                                    style: TextStyle(
                                        color:
                                        element.priority ==
                                            "H"
                                            ? Colors.red
                                            : Colors
                                            .black),
                                  )),
                                  //Extracting from Map element the value
                                  DataCell(
                                      Text(element.remark)),
                                  DataCell(
                                      InkWell(
                                        onTap: () {

                                        },
                                        child: Icon(
                                          Icons
                                              .remove_red_eye,
                                          color: Colors.green,
                                          size: 15,
                                        ),
                                      )
                                  ),
                                  //Extracting from Map element the value
                                ],
                              )),
                            )
                                .toList(),
                          ),
                        )),
                  )
                      ,visible: _orderList.length>0)

                ],
              ),
            )),
      ),
    );
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
        refreshOrders();
      });
    } catch (ee) {
      print(ee.toString());
    }
  }
  List<Order>_orderList=<Order>[];
  void refreshOrders() async {
    setState(() {
      isLoading=true;
    });
    _orderList.clear();
    print(ORDER_LIST_BY_DATE +widget.orgID.toString()+"&from=$fromDate&to=$toDate");
    getAPI(ORDER_LIST_BY_DATE +widget.orgID.toString()+"&from=$fromDate&to=$toDate").then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      setState(() {
        isLoading=false;
      });
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          for (var a = 0; a < data_.length; a++) {
            setState(() {
              _orderList.add(Order.fromMap(data_[a]));
            });
          }
        }
      }
    });

  }

  void showOrderDetails(Order element) {
    print(element.orderID.toString());
    Navigator.of(context).pushAndRemoveUntil(
        MaterialPageRoute(
            builder: (context) => OrderDetailsScreen(order: element,orgID: widget.orgID,)),
            (Route<dynamic> route) => true);
  }
}