import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/customer/order/orders.dart';
import 'package:b2b/supplier/pages/customer/customer.dart';
import 'package:b2b/supplier/pages/home.dart';
import 'package:b2b/supplier/pages/item/items.dart';
import 'package:b2b/supplier/pages/report/reports.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';

class SuppDashboardScreen extends StatefulWidget {
  final int pageID;

  SuppDashboardScreen({required this.pageID});

  @override
  _ViewState createState() => _ViewState();
}

var isLoading = false;
late PageController _pageController;
int _currentIndex = 0;

final List<Widget> _contentPages = <Widget>[
  HomeScreen(),
  ItemScreen(),
  CustomerScreen(),
  OrderScreen(orgID: 0),
  //ReportScreen(),
];

class _ViewState extends State<SuppDashboardScreen> {
  @override
  void initState() {
    _pageController = PageController(initialPage: widget.pageID);
    _pageController.addListener(_handleTabSelection);
    setState(() {
      _currentIndex = widget.pageID;
    });
    super.initState();
  }

  void _handleTabSelection() {
    setState(() {});
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.white,
        body: PageView(
          controller: _pageController,
          physics: NeverScrollableScrollPhysics(),
          children: _contentPages.map((Widget content) {
            return content;
          }).toList(),
        ),
        bottomNavigationBar: BottomNavigationBar(
          type: BottomNavigationBarType.fixed,
          currentIndex: _currentIndex,
          onTap: (value) {
            _currentIndex = value;
            _pageController.jumpToPage(value);

            // this unfocus is to prevent show keyboard in the text field
            FocusScope.of(context).unfocus();
          },
          selectedFontSize: 8,
          unselectedFontSize: 8,
          iconSize: 28,
          items: [
            BottomNavigationBarItem(
                // ignore: deprecated_member_use
                title: Text('Dashboard',
                    style: TextStyle(
                        color: _currentIndex == 0 ? active : lightGrey,
                        fontWeight: FontWeight.bold)),
                icon: Icon(Icons.dashboard,
                    color: _currentIndex == 0 ? active : lightGrey)),
            BottomNavigationBarItem(
                // ignore: deprecated_member_use
                title: Text('Items',
                    style: TextStyle(
                        color: _currentIndex == 1 ? active : lightGrey,
                        fontWeight: FontWeight.bold)),
                icon: Icon(Icons.art_track,
                    color: _currentIndex == 1 ? active : lightGrey)),
            BottomNavigationBarItem(
                // ignore: deprecated_member_use
                title: Text('Customers',
                    style: TextStyle(
                        color: _currentIndex == 2 ? active : lightGrey,
                        fontWeight: FontWeight.bold)),
                icon: Icon(Icons.group,
                    color: _currentIndex == 2 ? active : lightGrey)),
            BottomNavigationBarItem(
                // ignore: deprecated_member_use
                title: Text('Orders',
                    style: TextStyle(
                        color: _currentIndex == 3 ? active : lightGrey,
                        fontWeight: FontWeight.bold)),
                icon: Icon(Icons.add_shopping_cart_outlined,
                    color: _currentIndex == 3 ? active : lightGrey)),
            // BottomNavigationBarItem(
            //     // ignore: deprecated_member_use
            //     title: Text('Reports',
            //         style: TextStyle(
            //             color: _currentIndex == 4 ? active : lightGrey,
            //             fontWeight: FontWeight.bold)),
            //     icon: Icon(Icons.picture_as_pdf,
            //         color: _currentIndex == 4 ? active : lightGrey)),
          ],
        ));
  }
}
