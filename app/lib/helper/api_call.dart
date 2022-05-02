import 'dart:convert';
import 'dart:developer';
import 'dart:io';

import 'package:b2b/contstants/strings.dart';
import 'package:b2b/helper/api_strings.dart';
import 'package:b2b/model/ItemMaster.dart';
import 'package:b2b/model/LoginUser.dart';
import 'package:b2b/model/OrganisationMaster.dart';
import 'package:http/http.dart' as http;


Future<http.Response> getAPI(API_URL) {
  return http.get(Uri.parse(API_URL));
}
Future<http.Response> postAPI(var post, API_URL) async {
  final response = await http.post(Uri.parse(API_URL),
      headers: {"Content-type": "application/json"}, body: jsonEncode(post));
  return response;
}

Future<http.Response> InsertItem(ItemMaster item) async {
  print(ITEM_INSERT);
  final response = await http.post(Uri.parse(ITEM_INSERT),
      headers: {"Content-type": "application/json"}, body: jsonEncode(item));
  return response;
}
Future<http.Response> LoginUserInsert(LoginUser item) async {
  print(ITEM_INSERT);
  final response = await http.post(Uri.parse(USER_INSERT),
      headers: {"Content-type": "application/json"}, body: jsonEncode(item));
  return response;
}
Future<http.Response> InsertOrganisation(OrganisationMaster item) async {
  print(ITEM_INSERT);
  final response = await http.post(Uri.parse(ORGANISATION_INSERT),
      headers: {"Content-type": "application/json"}, body: jsonEncode(item));
  return response;
}