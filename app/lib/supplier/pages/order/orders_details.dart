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
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

class OrderDetailsScreen extends StatefulWidget {
  final int orgID;
  final Order order;

  OrderDetailsScreen({required this.order, required this.orgID});

  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<OrderDetailsScreen> {
  TextEditingController remarks = new TextEditingController();
  var _status = [
    'Submitted',
    'Processed',
    'Delivered',
    'Cancelled',
  ];
  var _statusID = [
    '1',
    '2',
    '3',
    '4',
  ];

  @override
  void initState() {
    _getUserDetails();
    loadOrderDetails();
    setState(() {
      dropdownValue = widget.order.orderStatus;
      orderStatus = widget.order.orderStatus;
    });

    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  var _globarWidget = new GlobalWidget();
  bool isLoading = false;
  String dropdownValue = "";
  String orderStatus = "";

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globarWidget.globalAppBar("Order Details"),
      backgroundColor: light,
      body: SafeArea(
        child: Container(
          margin: EdgeInsets.all(10),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Expanded(
                  child: SingleChildScrollView(
                child: Column(
                  children: [
                    Card(
                      child: Container(
                        margin: EdgeInsets.all(10),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Expanded(child: CustomText(text: "Date :")),
                                Expanded(
                                    child: MarqueeWidget(
                                  child: CustomText(
                                      text: widget.order.orderDateTxt),
                                )),
                              ],
                            ),
                            SizedBox(
                              height: 10,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Expanded(child: CustomText(text: "Customer :")),
                                Expanded(
                                    child: MarqueeWidget(
                                  child: CustomText(text: widget.order.orgName),
                                )),
                              ],
                            ),
                            SizedBox(
                              height: 10,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Expanded(
                                    child: CustomText(text: "Order No. :")),
                                Expanded(
                                    child: MarqueeWidget(
                                  child: CustomText(text: widget.order.orderNO),
                                )),
                              ],
                            ),
                            SizedBox(
                              height: 10,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Expanded(child: CustomText(text: "Status :")),
                                Expanded(
                                    child: MarqueeWidget(
                                  child: CustomText(
                                      text: orderStatus),
                                )),
                              ],
                            )
                          ],
                        ),
                      ),
                    ),
                    SizedBox(height: 20),
                    Visibility(
                        visible: isLoading == true,
                        child: Center(
                          child: Padding(
                            padding: EdgeInsets.all(0),
                            child: SizedBox(
                              child: CircularProgressIndicator(
                                color: active,
                              ),
                              height: 20.0,
                              width: 20.0,
                            ),
                          ),
                        )),
                    Visibility(
                        visible: isLoading == false,
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Container(
                              margin: EdgeInsets.only(left: 15, right: 15),
                              child: CustomText(
                                text: "No. Of Item(s): " +
                                    _orderItems.length.toString(),
                                size: 14,
                                color: Colors.black,
                                weight: FontWeight.bold,
                              ),
                            ),
                            Card(
                              child: Container(
                                  margin: EdgeInsets.symmetric(vertical: 0),
                                  child: SingleChildScrollView(
                                    scrollDirection: Axis.horizontal,
                                    child: DataTable(
                                      columns: <DataColumn>[
                                        DataColumn(label: Text('Sl No.')),
                                        DataColumn(label: Text('Item')),
                                        DataColumn(label: Text('Qty')),
                                        DataColumn(label: Text('Priority')),
                                        DataColumn(label: Text('Remarks')),
                                      ],
                                      rows:
                                          _orderItems // Loops through dataColumnText, each iteration assigning the value to element
                                              .map(
                                                ((element) => DataRow(
                                                      cells: <DataCell>[
                                                        DataCell(Text(
                                                            (_orderItems.indexOf(
                                                                        element) +
                                                                    1)
                                                                .toString())),
                                                        //Extracting from Map element the value
                                                        DataCell(Text(
                                                            element.itemName)),
                                                        //Extracting from Map element the value
                                                        DataCell(Text(element
                                                            .orderQTY
                                                            .toString())),
                                                        //Extracting from Map element the value
                                                        DataCell(Text(
                                                          element.priority ==
                                                                  "N"
                                                              ? "Normal"
                                                              : "High",
                                                          style: TextStyle(
                                                              color: element
                                                                          .priority ==
                                                                      "H"
                                                                  ? Colors.red
                                                                  : Colors
                                                                      .black),
                                                        )),
                                                        //Extracting from Map element the value
                                                        DataCell(Text(
                                                            element.remark)),
                                                        //Extracting from Map element the value
                                                      ],
                                                    )),
                                              )
                                              .toList(),
                                    ),
                                  )),
                            ),
                          ],
                        ))
                  ],
                ),
              )),
             Visibility(visible: widget.orgID==0,child:  Container(
               width: MediaQuery.of(context).size.width,
               color: Colors.white,
               child: Padding(
                 padding: EdgeInsets.all(10),
                 child: Column(
                     crossAxisAlignment: CrossAxisAlignment.start,
                     children: [
                       Text("Change Status"),
                       SizedBox(height: 5),
                       Row(
                         mainAxisAlignment: MainAxisAlignment.spaceBetween,
                         children: [
                           DropdownButton(
                             value: dropdownValue,
                             icon: const Icon(Icons.keyboard_arrow_down),
                             items: _status.map((String items) {
                               return DropdownMenuItem(
                                 value: items,
                                 child: Text(items),
                               );
                             }).toList(),
                             onChanged: (newValue) {
                               setState(() {
                                 dropdownValue = newValue.toString();
                               });
                             },
                           ),
                           InkWell(
                             onTap: () {
                               changeStatus();
                             },
                             child: Container(
                               decoration: BoxDecoration(
                                   color: active,
                                   borderRadius: BorderRadius.circular(20)),
                               child: Padding(
                                 padding: EdgeInsets.only(
                                     left: 10, right: 10, top: 5, bottom: 5),
                                 child: Text("UPDATE",
                                     style: TextStyle(
                                         fontSize: 12, color: Colors.white)),
                               ),
                             ),
                           )
                         ],
                       ),
                     ]),
               ),
             ))
            ],
          ),
        ),
      ),
    );
  }

  List<OrderDetails> _orderItems = <OrderDetails>[];

  void loadOrderDetails() async {
    setState(() {
      isLoading = true;
    });
    _orderItems.clear();
    print(ORDER_DETAILS + widget.order.orderID.toString());
    getAPI(ORDER_DETAILS + widget.order.orderID.toString()).then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      setState(() {
        isLoading = false;
      });
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          for (var a = 0; a < data_.length; a++) {
            setState(() {
              _orderItems.add(OrderDetails.fromMap(data_[a]));
            });
          }
        }
      }
    });
  }

  void changeStatus() {
    Widget cancelButton = TextButton(
        onPressed: () {
          Navigator.pop(context);
        },
        child: Text('Cancel', style: TextStyle(color: Colors.grey)));
    Widget continueButton = TextButton(
        onPressed: () {
          Navigator.pop(context);
          saveStatus();
        },
        child: Text('Yes', style: TextStyle(color: Colors.red)));

    AlertDialog alert = AlertDialog(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10),
      ),
      title: Text(
        'Change Status',
        style: TextStyle(fontSize: 18),
      ),
      content: Text(
          'Are you sure you want to change the status to ' +
              dropdownValue +
              "?",
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

  void saveStatus() {
    final index = _status.indexWhere((element) => element == dropdownValue);
    var update = {
      "OrderID": widget.order.orderID.toString(),
      "OrderStatusID": _statusID[index],
      "OrderStatus": dropdownValue,
      "UpdatedBy": _loginUser.userName
    };
    print(update.toString() + " " + ORDER_UPDATE);
    postAPI(update, ORDER_UPDATE).then((result) {
      setState(() {
        isLoading = false;
      });
      var j_data = jsonDecode(result.body);
      var responseCode = j_data["responseCode"];
      if (responseCode == "S") {
        setState(() {
          orderStatus = dropdownValue;
        });
        _globarWidget.showMessage("Successfully Updated", false, context);
      }
    });
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
}
