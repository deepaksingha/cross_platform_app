import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemCategoryMaster.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/model/LoginUser.dart';
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
import 'package:flutter_typeahead/flutter_typeahead.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../supp_dashboard.dart';

class AddItemScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<AddItemScreen> {
  @override
  void initState() {
    super.initState();
    _getUserDetails();
    _getItemCategory();
  }

  @override
  void dispose() {
    super.dispose();
  }

  List<ItemCategoryMaster> _itemCategory = <ItemCategoryMaster>[];
  TextEditingController itemName = new TextEditingController();
  TextEditingController itemCode = new TextEditingController();
  TextEditingController hSn = new TextEditingController();
  TextEditingController category = new TextEditingController();
  TextEditingController uOm = new TextEditingController();
  TextEditingController packetSize = new TextEditingController();
  TextEditingController itemRate = new TextEditingController();
  TextEditingController itemMrp = new TextEditingController();
  TextEditingController costPrice = new TextEditingController();
  TextEditingController gst = new TextEditingController();
  TextEditingController remarks = new TextEditingController();

  void _getItemCategory() {
    _itemCategory.clear();
    print(GET_ITEM_CATEGORY + "0");
    getAPI(GET_ITEM_CATEGORY + "0").then((data) {
      var j_data = jsonDecode(data.body);
      var count = j_data["count"];
      if (count > 0) {
        var data_ = j_data[RESPONSE_RESULT];
        if (data_ != null) {
          for (var a = 0; a < data_.length; a++) {
            setState(() {
              _itemCategory.add(ItemCategoryMaster.fromMap(data_[a]));
            });
          }
        }
      }
    });
  }

  List<ItemCategoryMaster> _getSuggestions(String query) {

    List<ItemCategoryMaster> matches = <ItemCategoryMaster>[];
    matches.addAll(_itemCategory);

    matches.retainWhere(
        (s) => s.categoryName.toLowerCase().contains(query.toLowerCase()));
    return matches;
  }

  var _globarWidget = new GlobalWidget();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globarWidget.globalAppBar("Add Items"),
      backgroundColor: Colors.white,
      body: SafeArea(
        child: SingleChildScrollView(
          child: Container(
            margin: EdgeInsets.all(15),
            child: Column(
              children: [
                TextFormField(
                  controller: itemName,
                  decoration: InputDecoration(
                      labelText: "Item Name",
                      hintText: "Enter item name",
                      isDense: true,
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: itemCode,
                  decoration: InputDecoration(
                      labelText: "Item Code",
                      isDense: true,
                      hintText: "Enter item code",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: hSn,
                  decoration: InputDecoration(
                      labelText: "HSN",
                      isDense: true,
                      hintText: "Enter HSN",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
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
                            labelText: 'Category',
                            border: InputBorder.none,
                          ),
                          controller: this.category,
                        ),
                        suggestionsCallback: (pattern) {
                          itemCatID=0;
                          return _getSuggestions(pattern);
                        },
                        itemBuilder: (context, ItemCategoryMaster suggestion) {
                          return ListTile(
                            title: Text(suggestion.categoryName),
                          );
                        },
                        transitionBuilder:
                            (context, suggestionsBox, controller) {
                          return suggestionsBox;
                        },
                        onSuggestionSelected: (ItemCategoryMaster suggestion) {
                          category.text = suggestion.categoryName;
                        setState(() {
                          itemCatID=suggestion.itemCatID;
                        });
                        }),
                  ),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: uOm,
                  decoration: InputDecoration(
                      labelText: "UOM",
                      isDense: true,
                      hintText: "Enter UOM",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: packetSize,
                  keyboardType: TextInputType.number,
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.allow(RegExp(r'[0-9]')),
                  ],
                  decoration: InputDecoration(
                      labelText: "Packet Size",
                      isDense: true,
                      hintText: "Enter packet size",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: itemRate,
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  decoration: InputDecoration(
                      labelText: "Item Rate",
                      isDense: true,
                      hintText: "Enter item rate",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: itemMrp,
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  decoration: InputDecoration(
                      labelText: "Item MRP",
                      isDense: true,
                      hintText: "Enter Item mrp",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: costPrice,
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  decoration: InputDecoration(
                      labelText: "Cost Price",
                      isDense: true,
                      hintText: "Enter cost price",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: gst,
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  decoration: InputDecoration(
                      labelText: "GST",
                      isDense: true,
                      hintText: "Enter gst",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(height: 15),
                TextFormField(
                  controller: remarks,
                  keyboardType: TextInputType.multiline,
                  maxLines: 4,
                  decoration: InputDecoration(
                      alignLabelWithHint: true,
                      labelText: "Remark",
                      isDense: true,
                      hintText: "Enter remark",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(20))),
                ),
                SizedBox(
                  height: 15,
                ),
                Visibility(visible: isLoading==false,child: InkWell(
                    onTap: () {
                      chekFields();
                    },
                    child: BorderButton(color:active,text:"SAVE"))
                ),
                Visibility(visible: isLoading==true,child: InkWell(
                    onTap: () {
                      chekFields();
                    },
                    child: LoadingButton())
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
  bool isLoading=false;
  void chekFields() {
    print(itemCatID.toString());
    if(itemName.text==""){
      _globarWidget.showMessage("Please insert item name", true, context);
    }
    else{
      if(itemCatID==0){
        _globarWidget.showMessage("Please select item category", true, context);
      }
      else{
        if(packetSize.text==""){
          _globarWidget.showMessage("Please insert packet size", true, context);
        }
        else{
          if(itemRate.text==""){
            _globarWidget.showMessage("Please insert item rate", true, context);
          }
          else{
            if(itemMrp.text==""){
              _globarWidget.showMessage("Please insert item MRP", true, context);
            }
            else{
              if(costPrice.text==""){
                _globarWidget.showMessage("Please insert cost price", true, context);
              }
              else{
                if(gst.text==""){
                  gst.text="0";
                  saveItem();
                }
               else{
                  saveItem();
                }
              }
            }
          }
        }
      }
    }
  }

  int itemCatID = 0;

  void saveItem() async {
    ItemMaster item = new ItemMaster(
        0,
        _loginUser.tenantID,
        "Y",
        _loginUser.orgID,
        itemName.text,
        itemCode.text,
        hSn.text,
        itemCatID,
        category.text,
        uOm.text,
        int.parse(packetSize.text),
        double.parse(itemRate.text),
        double.parse(itemMrp.text),
        double.parse(costPrice.text),
        double.parse(gst.text),
        "",
        "N",
        "",
        "",
        "",
        "",
        "",
        "",
        remarks.text,
        _loginUser.userName,
        _loginUser.userName,
        "",
        "");
    print(jsonEncode(item));
    setState(() {
      isLoading=true;
    });
    InsertItem(item).then((result) {
      setState(() {
        isLoading = false;
      });
      var j_data = jsonDecode(result.body);
      var responseCode = j_data["responseCode"];
      if(responseCode=="S"){
        _globarWidget.showMessage("Item saved Successfully", false, context);
        Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => SuppDashboardScreen(pageID: 1)),
                (Route<dynamic> route) => false);
      }
      else{
        _globarWidget.showMessage("Failed to save item", true, context);
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
