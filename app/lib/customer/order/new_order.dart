import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'dart:math';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/customer/order/orders.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/model/OrderDetails.dart';
import 'package:b2b/model/SelectModel.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/reuseable/global_function.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter/services.dart';
import 'package:flutter/widgets.dart';
import 'package:flutter_typeahead/flutter_typeahead.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../cust_dashboard.dart';

class NewOrderScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<NewOrderScreen> {
  @override
  void initState() {
    _getUserDetails();
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  var _globarWidget = new GlobalWidget();
  var _globalFunction = new GlobalFunction();
  List<SelectModel> _priority = [
    SelectModel(1, 'NORMAL'),
    SelectModel(2, 'HIGH'),
  ];
  int _priorityID = 1;
  String _priorityName = "NORMAL";

  int _item_priorityID = 1;
  String _item_priorityName = "NORMAL";

  List<ItemMaster> _itemLists = <ItemMaster>[];

  List<ItemMaster> _getSuggestions(String query) {
    List<ItemMaster> matches = [];
    matches.addAll(_itemLists);
    matches.retainWhere(
        (data) => data.itemName.toLowerCase().contains(query.toLowerCase()));
    return matches;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globarWidget.globalAppBar("Create New Order"),
      backgroundColor: light,
      body: SafeArea(
        child: SingleChildScrollView(
            child: Container(
          margin: EdgeInsets.all(0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Container(
                  margin: EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      CustomText(
                        text: "Priority",
                        size: 14,
                        color: Colors.black,
                        weight: FontWeight.normal,
                      ),
                      Wrap(
                        children: List.generate(_priority.length, (index) {
                          return ChoiceChip(
                              visualDensity:
                                  VisualDensity(horizontal: 0.0, vertical: -2),
                              labelPadding: EdgeInsets.fromLTRB(10, -0, 10, -0),
                              avatar: (_priorityID == _priority[index].id
                                  ? Icon(Icons.check, size: 15, color: active)
                                  : null),
                              shape: StadiumBorder(
                                  side: BorderSide(
                                      color:
                                          (_priorityID == _priority[index].id)
                                              ? active
                                              : Colors.grey,
                                      width: 1,
                                      style: BorderStyle.solid)),
                              label: Text(_priority[index].Name.toUpperCase(),
                                  style: TextStyle(
                                    color: (_priorityID == _priority[index].id)
                                        ? active
                                        : Colors.black,
                                    fontWeight:
                                        (_priorityID == _priority[index].id)
                                            ? FontWeight.bold
                                            : FontWeight.normal,
                                    fontSize: 12,
                                  )),
                              elevation: 2,
                              pressElevation: 2,
                              selectedColor: Colors.white,
                              backgroundColor: Colors.white,
                              selected: (_priorityID == 0)
                                  ? (_priority[index].id == 1 ? true : false)
                                  : _priorityID == _priority[index].id,
                              onSelected: (bool selected) {
                                setState(() {
                                  _priorityName = _priority[index].Name;
                                  _priorityID = _priority[index].id;
                                });
                              });
                        }),
                        spacing: 8,
                      ),
                      SizedBox(height: 10),
                      Container(
                        margin: EdgeInsets.symmetric(vertical: 8),
                        child: TypeAheadField(
                          textFieldConfiguration: TextFieldConfiguration(
                            decoration: InputDecoration(
                                border: OutlineInputBorder(),
                                hintText: 'Search Item'),
                          ),
                          suggestionsCallback: (pattern) {
                            return _getSuggestions(pattern);
                          },
                          itemBuilder: (context, ItemMaster suggestion) {
                            return ListTile(
                              title: Text(suggestion.itemName),
                              // subtitle: Text('\₹ ' +
                              //     _globalFunction
                              //         .removeDecimalZeroFormat(suggestion.itemMRP)),
                            );
                          },
                          onSuggestionSelected: (ItemMaster suggestion) {
                            itemDetails(suggestion);
                          },
                        ),
                      ),
                    ],
                  )),
              Visibility(
                  visible: _orderItems.isNotEmpty,
                  child: Container(
                    margin: EdgeInsets.only(left: 10, right: 10),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        SizedBox(height: 0),
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
                                    DataColumn(label: Text('')),
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
                                                    DataCell(InkWell(
                                                      onTap: () {
                                                        setState(() {
                                                          _orderItems.remove(element);
                                                        });
                                                      },
                                                      child: Icon(
                                                        Icons
                                                            .delete,
                                                        color: Colors.red,
                                                        size: 15,
                                                      ),
                                                    )),
                                                    DataCell(Text((_orderItems.indexOf(element)+1)
                                                        .toString())),
                                                    //Extracting from Map element the value
                                                    DataCell(
                                                        Text(element.itemName)),
                                                    //Extracting from Map element the value
                                                    DataCell(Text(element
                                                        .orderQTY
                                                        .toString())),
                                                    //Extracting from Map element the value
                                                    DataCell(Text(
                                                      element.priority,
                                                      style: TextStyle(
                                                          color:
                                                              element.priority ==
                                                                      "HIGH"
                                                                  ? Colors.red
                                                                  : Colors
                                                                      .black),
                                                    )),
                                                    //Extracting from Map element the value
                                                    DataCell(
                                                        Text(element.remark)),
                                                    //Extracting from Map element the value
                                                  ],
                                                )),
                                          )
                                          .toList(),
                                ),
                              )),
                        ),
                        SizedBox(height: 20),
                        TextFormField(
                          controller: remarks,
                          keyboardType: TextInputType.multiline,
                          maxLines: 4,
                          decoration: InputDecoration(
                              labelText: "Remarks",
                              alignLabelWithHint: true,
                              isDense: true,
                              hintText: "Enter remarks",
                              border: OutlineInputBorder(
                                  borderRadius: BorderRadius.circular(20))),
                        ),
                        SizedBox(height: 10),
                        Visibility(visible:isLoading==false,child: InkWell(
                          onTap: (){
                            placeOrder();
                          },
                          child: BorderButton(color:active,text:"PLACE ORDER"),
                        )),
                        Visibility(visible:isLoading==true,child: LoadingButton())
                      ],
                    ),
                  ))
            ],
          ),
        )),
      ),
    );
  }
  TextEditingController remarks = new TextEditingController();
  void itemDetails(ItemMaster item) {
    TextEditingController itemQuantity = new TextEditingController();
    TextEditingController remarks = new TextEditingController();
    showModalBottomSheet<void>(
      context: context,
      isDismissible: true,
      builder: (BuildContext context) {
        return StatefulBuilder(
            builder: (BuildContext context, setState) => Container(
                  child: Column(
                    children: [
                      Container(
                        width: MediaQuery.of(context).size.width,
                        color: Colors.black,
                        padding:
                            EdgeInsets.symmetric(vertical: 10, horizontal: 20),
                        child: Row(
                          children: [
                            InkWell(
                                onTap: () {
                                  Navigator.pop(context);
                                },
                                child: Icon(
                                  Icons.close,
                                  color: Colors.white,
                                  size: 20,
                                )),
                            SizedBox(width: 10),
                            Expanded(
                              child: MarqueeWidget(
                                  child: CustomText(
                                      text: item.itemName,
                                      color: Colors.white,
                                      weight: FontWeight.bold)),
                            )
                          ],
                        ),
                      ),
                      Container(
                        padding:
                            EdgeInsets.symmetric(vertical: 20, horizontal: 20),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            SizedBox(height: 5),
                            TextFormField(
                              controller: itemQuantity,
                              keyboardType: TextInputType.number,
                              inputFormatters: <TextInputFormatter>[
                                FilteringTextInputFormatter.allow(
                                    RegExp(r'[0-9]')),
                              ],
                              decoration: InputDecoration(
                                  labelText: "Item Quantity",
                                  hintText: "Enter item quantity",
                                  isDense: true,
                                  border: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(20))),
                            ),
                            SizedBox(height: 10),
                            SizedBox(height: 10),
                            CustomText(
                              text: "Priority",
                              size: 12,
                            ),
                            Wrap(
                              children:
                                  List.generate(_priority.length, (index) {
                                return ChoiceChip(
                                    visualDensity: VisualDensity(
                                        horizontal: 0.0, vertical: -2),
                                    labelPadding:
                                        EdgeInsets.fromLTRB(10, -0, 10, -0),
                                    avatar:
                                        (_item_priorityID == _priority[index].id
                                            ? Icon(Icons.check,
                                                size: 15, color: active)
                                            : null),
                                    shape: StadiumBorder(
                                        side: BorderSide(
                                            color: (_item_priorityID ==
                                                    _priority[index].id)
                                                ? active
                                                : Colors.grey,
                                            width: 1,
                                            style: BorderStyle.solid)),
                                    label: Text(
                                        _priority[index].Name.toUpperCase(),
                                        style: TextStyle(
                                          color: (_item_priorityID ==
                                                  _priority[index].id)
                                              ? active
                                              : Colors.black,
                                          fontWeight: (_item_priorityID ==
                                                  _priority[index].id)
                                              ? FontWeight.bold
                                              : FontWeight.normal,
                                          fontSize: 12,
                                        )),
                                    elevation: 2,
                                    pressElevation: 2,
                                    selectedColor: Colors.white,
                                    backgroundColor: Colors.white,
                                    selected: (_item_priorityID == 0)
                                        ? (_priority[index].id == 1
                                            ? true
                                            : false)
                                        : _item_priorityID ==
                                            _priority[index].id,
                                    onSelected: (bool selected) {
                                      setState(() {
                                        _item_priorityName =
                                            _priority[index].Name;
                                        _item_priorityID = _priority[index].id;
                                      });
                                    });
                              }),
                              spacing: 8,
                            ),
                            SizedBox(height: 20),
                            TextFormField(
                              controller: remarks,
                              keyboardType: TextInputType.multiline,
                              maxLines: 4,
                              decoration: InputDecoration(
                                  labelText: "Remarks",
                                  alignLabelWithHint: true,
                                  isDense: true,
                                  hintText: "Enter remarks",
                                  border: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(20))),
                            ),
                            SizedBox(height: 30),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                SizedBox(
                                  width: 10,
                                ),
                                _globarWidget.createButton(
                                    buttonName: 'ADD',
                                    backgroundColor: Colors.green,
                                    onPressed: () {
                                      if (itemQuantity.text == "") {
                                        _globarWidget.showMessage(
                                            "Please enter quantity",
                                            true,
                                            context);
                                      } else {
                                        addItem(
                                            itemQuantity.text,
                                            remarks.text,
                                            _item_priorityName,
                                            _item_priorityID,
                                            item);
                                        Navigator.of(context).pop();
                                      }
                                    }),
                              ],
                            )
                          ],
                        ),
                      )
                    ],
                  ),
                ));
      },
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
      });
      _loadItemLists();
    } catch (ee) {
      print(ee.toString());
    }
  }

  bool itemLoading = false;

  void _loadItemLists() async {
    _itemLists.clear();
    setState(() {
      itemLoading = true;
    });
    print(ITEM_LISTS + "0");
    getAPI(ITEM_LISTS + "0").then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      setState(() {
        itemLoading = true;
      });
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          for (var a = 0; a < data_.length; a++) {
            setState(() {
              _itemLists.add(ItemMaster.fromMap(data_[a]));
            });
          }
        }
      }
    });
  }

  List<OrderDetails> _orderItems = <OrderDetails>[];

  void addItem(String itemQuantity, String remarks, String priority,
      int priorityName, ItemMaster item) {
    setState(() {
      _orderItems.add(new OrderDetails(
          _orderItems.length + 1,
          _loginUser.tenantID,
          "Y",
          //isActive
          1,
          //statusID
          0,
          //orderID
          _loginUser.orgID,
          item.itemID,
          item.itemName,
          item.hSN,
          item.itemCatID,
          item.categoryName,
          int.parse(itemQuantity),
          int.parse(itemQuantity),
          int.parse(itemQuantity),
          item.uOM,
          item.packSize,
          item.itemRate,
          item.itemMRP,
          item.costPrice,
          item.gST,
          0,
          //preTaxOrginalAmt
          0,
          //disc
          0,
          //taxableAmt
          0,
          //taxtAmt
          0,
          //totalAmt
          0,
          //netAmt
          0,
          //roundoff
          priority,
          item.outofStcok,
          _loginUser.userName,
          "",
          //companyUpdateDate
          remarks,
          //companyMessage
          "",
          //compMessageBy
          "",
          //supplierMessage
          "",
          //supplierMsgBy
          "",
          //ackBy
          "",
          //packedBy
          "",
          //deliveredBy
          "",
          //verifiedBy
          "",
          //cancelledBy
          "",
          //cancelRemark
          "",
          //cancelDate
          "",
          //ackDate
          "",
          //verifyDate
          remarks,
          //remark
          _loginUser.userName,
          _loginUser.userName,
          "",
          //createdDate
          "" //updateDate
          ));
    });
  }

  bool isLoading=false;
  void placeOrder() {

    var array = {
      "items": _orderItems,
      "createdBy":_loginUser.firstN+" "+_loginUser.middleN+" "+_loginUser.lastN,
      "updatedBy":_loginUser.userName,
      "priority":_priorityName,
      "priorityID":_priorityID,
      "remarks":remarks.text,
      "orgID":_loginUser.orgID,
    };
    String jsonTags = jsonEncode(array);
    print(jsonTags);

    postAPI(array, PLACE_ORDER).then((result) {
      setState(() {
        isLoading = false;
      });
      var j_data = jsonDecode(result.body);
      var responseCode = j_data["responseCode"];
      if (responseCode == "null") {
        _globarWidget.showMessage(
            "Failed to save", true, context);
      } else {
        if (responseCode == "S") {
          _globarWidget.showMessage(
              "Order Placed", false, context);
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(builder: (context) => CustDashboardScreen()),
                  (Route<dynamic> route) => false);
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(builder: (context) => OrderScreen(orgID: _loginUser.orgID,)),
                  (Route<dynamic> route) => true);
        }
      }
    });
  }
}
