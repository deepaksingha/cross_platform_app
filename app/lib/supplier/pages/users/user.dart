import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loader.dart';
import 'package:badges/badges.dart';
import 'package:charts_flutter/flutter.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';

import 'add_users.dart';


class UserScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<UserScreen> {
  @override
  void initState() {
    _loadItemLists();
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }
  var _globalWidget= new GlobalWidget();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _globalWidget.globalAppBar("Users"),
      backgroundColor: light,
      body: SafeArea(
          child:Container(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Container(
                  child:  Padding(
                    padding:EdgeInsets.all(10),
                    child: CustomText(text:"Total Users :  "+_itemLists.length.toString()),
                  ),
                ),
                Visibility(child: Loader(color:active),visible: itemLoading==true,),
                Expanded(child: ListView.builder(
                    reverse: false,
                    itemCount: _itemLists.length,
                    itemBuilder: (context, index) {
                      return Card(
                        margin: EdgeInsets.only(bottom:1),
                        child:
                            //
                        Padding(
                          padding:EdgeInsets.all(15),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Row(
                                children: [
                                  Padding(
                                    padding:EdgeInsets.only(top:12),
                                    child: Icon(
                                      Icons.account_circle_outlined,
                                      color: Colors.black,
                                      size: 15,
                                    ),
                                  ),
                                  SizedBox(width:5),
                                  Expanded(child:
                                  Column(
                                    crossAxisAlignment: CrossAxisAlignment.start,
                                    children: [
                                      CustomText(text:"Name",color:Colors.grey[600]!,size:10),
                                      CustomText(text:_itemLists[index].firstN+" "+_itemLists[index].lastN)
                                    ],
                                  )),
                                  Expanded(child: Column(
                                    crossAxisAlignment: CrossAxisAlignment.start,
                                    children: [
                                      CustomText(text:"Organisation",color:Colors.grey[600]!,size:10),
                                      CustomText(text:_itemLists[index].orgname,color:Colors.green,weight: FontWeight.bold,),
                                    ],
                                  )),
                                ],
                              ),


                            ],
                          )
                        )
                       ,
                      );
                    }))
              ],
            ),
          )
      ),
      floatingActionButton: FloatingActionButton.extended(
        onPressed: () {
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(
                  builder: (context) => AddUserScreen()),
                  (Route<dynamic> route) => true);
        },
        label: const Text('ADD'),
        icon: const Icon(Icons.add),
        backgroundColor: active,
      ),
    );
  }


  bool itemLoading = true;
  List<LoginUser> _itemLists = <LoginUser>[];
  void _loadItemLists() async {
    _itemLists.clear();
    setState(() {
      itemLoading = true;
    });
    print(USER_LISTS + "0");
    getAPI(USER_LISTS + "0").then((data) {
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
              _itemLists.add(LoginUser.fromMap(data_[a]));
            });
          }
        }
      }
    });
  }
}
