import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/reuseable/MarqueeWidget.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:badges/badges.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';

class ReportScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

class _ViewState extends State<ReportScreen> {
  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      body: SafeArea(
        child: Text("Report"),
      ),
    );
  }
}
