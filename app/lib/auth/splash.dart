import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/customer/cust_dashboard.dart';
import 'package:b2b/supplier/supp_dashboard.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'dart:developer';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:url_launcher/url_launcher.dart';

import 'login.dart';

class SplashScreen extends StatefulWidget {
  @override
  _SplashScreenState createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  @override
  void initState() {
    super.initState();
    _loadFunctionality();
  }

  @override
  void dispose() {
    super.dispose();
  }

  void _loadFunctionality() async {
    final SharedPreferences _pref = await SharedPreferences.getInstance();
    _checkLogin();
  }

  void _checkLogin() async {
    final SharedPreferences _pref = await SharedPreferences.getInstance();
  //_pref.setBool(IS_LOGIN, false);
    bool? isLogin = _pref.getBool(IS_LOGIN);
    if (isLogin != null) {
      if (isLogin == true) {
        String? loginType = _pref.getString(LOGIN_TYPE);
        if (loginType == SUPPLIER) {
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(builder: (context) => SuppDashboardScreen(pageID: 0)),
                  (Route<dynamic> route) => false);
        } else if (loginType == CUSTOMER) {
          Navigator.of(context).pushAndRemoveUntil(
              MaterialPageRoute(builder: (context) => CustDashboardScreen()),
                  (Route<dynamic> route) => false);
        }
        //checkVersion();
      } else {
        Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => LoginScreen()),
            (Route<dynamic> route) => false);
      }
    } else {
      Navigator.of(context).pushAndRemoveUntil(
          MaterialPageRoute(builder: (context) => LoginScreen()),
          (Route<dynamic> route) => false);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      body: Center(
        child: Container(
          child: Padding(
            padding: const EdgeInsets.symmetric(vertical: 120),
            child: Column(
              children: [
                Center(
                  child: Padding(
                    padding: EdgeInsets.all(5),
                    child: SizedBox(
                      child: CircularProgressIndicator(
                        color: active,
                      ),
                      height: 20.0,
                      width: 20.0,
                    ),
                  ),
                )
              ],
            ),
          ),
        ),
      ),
    );
  }

  // void checkVersion() async {
  //   final SharedPreferences _pref = await SharedPreferences.getInstance();
  //   var orgID = _pref.getString(ORG_ID);
  //   getAPI(API + orgID.toString()).then((data) {
  //     var _data = data.body;
  //     var j_data = jsonDecode(_data);
  //     try {
  //       Organisation org = Organisation.fromMap(j_data["orgurlinfo"][0]);
  //       _pref.setString(MAIN_API, org.ApiURL);
  //       _pref.setString(SOFTWARE_URL, org.SoftwareURL);
  //       int minIOSAppVersion = 0;
  //       try {
  //         minIOSAppVersion = int.parse(org.Custom_3);
  //       } catch (e) {}
  //       int minAndroidAppVersion = 0;
  //       try {
  //         minAndroidAppVersion = int.parse(org.AppVersion);
  //       } catch (e) {}
  //
  //       print("IOS_VERSION : " +
  //           minIOSAppVersion.toString() +
  //           " " +
  //           APP_VERSION.toString());
  //       print("ANDROID_VERSION : " +
  //           minAndroidAppVersion.toString() +
  //           " " +
  //           APP_VERSION.toString());
  //       if (Platform.isIOS) {
  //         if (APP_VERSION >= minIOSAppVersion) {
  //           Navigator.of(context).pushAndRemoveUntil(
  //               MaterialPageRoute(builder: (context) => HomeScreen()),
  //                   (Route<dynamic> route) => false);
  //         } else {
  //           showUpdate(
  //               context, "", "https://apps.apple.com/gb/app/" + org.ApkUrl);
  //         }
  //       } else {
  //         if (ANDROID_VERSION >= minAndroidAppVersion) {
  //           Navigator.of(context).pushAndRemoveUntil(
  //               MaterialPageRoute(builder: (context) => HomeScreen()),
  //                   (Route<dynamic> route) => false);
  //         } else {
  //           showUpdate(
  //               context,
  //               "https://play.google.com/store/apps/details?id=com.relytech.hrm",
  //               "");
  //         }
  //       }
  //     } catch (ex) {
  //     }
  //   });
  // }
  // void showUpdate(BuildContext context,android,ios) {
  //   showModalBottomSheet<void>(
  //     isDismissible: false,
  //     context: context,
  //     builder: (BuildContext context) {
  //       return SingleChildScrollView(
  //         child: Container(
  //           padding: EdgeInsets.only(top: 15, bottom: 30),
  //           child: Column(
  //             crossAxisAlignment: CrossAxisAlignment.start,
  //             children: [
  //               Padding(
  //                 padding: EdgeInsets.only(top: 0, left: 20, bottom: 10),
  //                 child: Text("New Update Available"),
  //               ),
  //               Container(
  //                 height: 1,
  //                 color: SOFT_GREY,
  //               ),
  //               Container(
  //                 margin: EdgeInsets.only(left: 20, right: 20, top: 15),
  //                 child: Column(
  //                   crossAxisAlignment: CrossAxisAlignment.start,
  //                   children: [
  //                     RichText(
  //                       text: TextSpan(
  //                         text:
  //                         "You are using an old version of this app, Please upgrade your app to continue using Rely HRM",
  //                         style: TextStyle(color: Colors.black),
  //                       ),
  //                     ),
  //                     SizedBox(height: 10),
  //                     Container(
  //                       margin: EdgeInsets.only(left: 25, right: 25, top: 10),
  //                       child: InkWell(
  //                         onTap: () {
  //                           if (Platform.isIOS) {
  //                             _launchInBrowser(ios);
  //                           } else {
  //                             _launchInBrowser(android);
  //                           }
  //                         },
  //                         child: Container(
  //                           height: 36,
  //                           decoration: BoxDecoration(
  //                               borderRadius: BorderRadius.circular(50),
  //                               gradient: LinearGradient(colors: [
  //                                 PRIMARY_COLOR,
  //                                 PRIMARY_COLOR,
  //                               ])),
  //                           child: Center(
  //                             child: Text(
  //                               "UPDATE NOW",
  //                               style: TextStyle(
  //                                   fontSize: 15,
  //                                   color: Colors.white,
  //                                   fontWeight: FontWeight.normal),
  //                             ),
  //                           ),
  //                         ),
  //                       ),
  //                     ),
  //                   ],
  //                 ),
  //               )
  //             ],
  //           ),
  //         ),
  //       );
  //     },
  //   );
  // }
  Future<void> _launchInBrowser(String url) async {
    print("my_url: " + url);
    if (await canLaunch(url)) {
      await launch(
        url,
        forceSafariVC: false,
        forceWebView: false,
        headers: <String, String>{'my_header_key': 'my_header_value'},
      );
    } else {
      // _globalWidget.showMessage("Could not launch", true, context);
    }
  }
}
