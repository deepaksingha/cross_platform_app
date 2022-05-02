import 'dart:async';
import 'dart:convert';
import 'dart:io';
import 'package:b2b/contstants/strings.dart';
import 'package:b2b/contstants/style.dart';
import 'package:b2b/customer/cust_dashboard.dart';
import 'package:b2b/helper/api_call.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/reuseable/global_widget.dart';
import 'package:b2b/supplier/supp_dashboard.dart';
import 'package:b2b/widgets/border_button.dart';
import 'package:b2b/widgets/loading_button.dart';
import 'package:b2b/widgets/custom_text.dart';
import 'package:flutter/material.dart';
import 'package:get/get_navigation/src/routes/get_route.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:shared_preferences/shared_preferences.dart';

class LoginScreen extends StatefulWidget {
  @override
  _ViewState createState() => _ViewState();
}

var isLoading = false;
final loginFormKey = GlobalKey<FormState>();
TextEditingController usernameController = new TextEditingController();
TextEditingController passwordController = new TextEditingController();

class _ViewState extends State<LoginScreen> {
  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  var _globalWidget = new GlobalWidget();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      body: Center(
          child: Container(
              constraints: BoxConstraints(maxWidth: 400),
              padding: EdgeInsets.all(24),
              child: Container(
                  child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [

                  Row(
                    children: [
                      Padding(
                        padding: EdgeInsets.only(right: 12),
                        child: Image.asset("assets/icons/logo.png"),
                      ),
                      Expanded(child:  Container(
                        child:  Text(
                          "B2B Order App",
                          style: GoogleFonts.roboto(
                            fontSize: 25,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ),)
                    ],
                  ),
                  SizedBox(
                    height: 30,
                  ),
                  Row(children: [
                    Text(
                      "Login",
                      style: GoogleFonts.roboto(
                        fontSize: 30,
                        fontWeight: FontWeight.bold,
                      ),
                    )
                  ]),
                  SizedBox(height:10),
                  Row(children: [
                    CustomText(
                      text: "Sign in to manage your Orders",
                      color: lightGrey,
                    ),
                  ]),
                  SizedBox(
                    height: 15,
                  ),
                  Container(
                      child: Form(
                    key: loginFormKey,
                    child: Column(
                      children: [
                        TextFormField(
                          controller: usernameController,
                          keyboardType: TextInputType.text,
                          decoration: InputDecoration(
                              labelText: "Username",
                              isDense: true,
                              hintText: "Enter username",
                              border: OutlineInputBorder(
                                  borderRadius: BorderRadius.circular(20))),
                        ),
                        SizedBox(
                          height: 15,
                        ),
                        TextFormField(
                          controller: passwordController,
                          obscureText: true,
                          decoration: InputDecoration(
                              labelText: "Password",
                              isDense: true,
                              hintText: "Enter your password",
                              border: OutlineInputBorder(
                                  borderRadius: BorderRadius.circular(20))),
                        ),
                      ],
                    ),
                  )),
                  SizedBox(
                    height: 15,
                  ),
                  Visibility(
                      visible: isLoading == false,
                      child: InkWell(
                          onTap: () {
                            loginUser();
                            // loginController.login();
                          },
                          child: BorderButton(text:"Login",color:active))),
                  Visibility(
                      visible: isLoading == true,
                      child: LoadingButton()),
                  SizedBox(
                    height: 15,
                  )
                ],
              )))),
    );
  }

  void loginUser() async {
    final SharedPreferences _pref = await SharedPreferences.getInstance();
    if (usernameController.text == "") {
      _globalWidget.showMessage("Please Insert Username", true, context);
    } else {
      if (passwordController.text == "") {
        _globalWidget.showMessage("Please Insert Password", true, context);
      } else {
        setState(() {
          isLoading = true;
        });
        var login = {
          "UserName": usernameController.text,
          "Passwrd": passwordController.text
        };
        print(login.toString() + " " + GET_LOGIN);
        postAPI(login, GET_LOGIN).then((result) {
          setState(() {
            isLoading = false;
          });
          var j_data = jsonDecode(result.body);
          var responseCode = j_data["responseCode"];
          if (responseCode == "S") {
            var login_info = j_data[RESPONSE_RESULT];
            Map<String, dynamic> user = login_info;
            LoginUser login = LoginUser.fromMap(j_data[RESPONSE_RESULT]);
            print(login.customerType);
            if (login.customerType == CUSTOMER) {
              _pref.setBool(IS_LOGIN, true);
              _pref.setString(LOGIN_TYPE, login.customerType);

              _pref.setString(USER_DETAILS, jsonEncode(user));
              Navigator.of(context).pushAndRemoveUntil(
                  MaterialPageRoute(
                      builder: (context) => CustDashboardScreen()),
                      (Route<dynamic> route) => false);
            } else if (login.customerType == SUPPLIER) {
              _pref.setBool(IS_LOGIN, true);
              _pref.setString(LOGIN_TYPE, login.customerType);
              _pref.setString(USER_DETAILS, jsonEncode(user));
              Navigator.of(context).pushAndRemoveUntil(
                  MaterialPageRoute(
                      builder: (context) => SuppDashboardScreen(pageID: 0)),
                      (Route<dynamic> route) => false);
            } else {
              _globalWidget.showMessage(
                  "Invalid Login Credentials", true, context);
            }
          }
          else{
            _globalWidget.showMessage(
                "Invalid Login Credentials", true, context);
          }
        });
      }
    }
  }
}
