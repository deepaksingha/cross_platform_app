import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:b2b/widgets/loader.dart';
import 'package:badges/badges.dart';
import 'package:charts_flutter/flutter.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';

import 'add_items.dart';

class ItemScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<ItemScreen> {
  @override
  void initState() {
    _loadItemLists();
    super.initState();
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
        child:Container(
          child: Column(
            children: [
              Container(
                child:  Padding(
                  padding:EdgeInsets.all(10),
                  child: CustomText(text:"ITEMS ("+_itemLists.length.toString()+")" ),
                ),
              ),
              Visibility(child: Loader(color:active),visible: itemLoading==true,),
              Expanded(child: ListView.builder(
                  reverse: false,
                  itemCount: _itemLists.length,
                  itemBuilder: (context, index) {
                    return Card(
                      margin: EdgeInsets.only(bottom:1),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Padding(
                            padding:EdgeInsets.all(10),
                            child: CustomText(text:_itemLists[index].itemName),
                          )
                        ],
                      ),
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
                  builder: (context) => AddItemScreen()),
                  (Route<dynamic> route) => true);
        },
        label: const Text('ADD'),
        icon: const Icon(Icons.add),
        backgroundColor: active,
      ),
    );
  }


  bool itemLoading = true;
  List<ItemMaster> _itemLists = <ItemMaster>[];
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
        itemLoading = false;
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
}
