import 'package:b2b/contstants/strings.dart';
import 'package:flutter/material.dart';

String GET_LOGIN=FETCH_API+"/GetUserInfo";
String GET_ITEM_CATEGORY=FETCH_API+"/GetItemCategoryList?itemcatid=";
String USER_INSERT=UPDATE_API+"/LoginUserInsert";
String ITEM_INSERT=UPDATE_API+"/ItemInsert";
String ORGANISATION_INSERT=UPDATE_API+"/CustomerInsert";
String ITEM_LISTS=FETCH_API+"/GetItemList?itemid=";
String USER_LISTS=FETCH_API+"/GetLoginUserList?orgID=";
String CUSTOMER_LISTS=FETCH_API+"/GetCustomerList?cusid=";
String PLACE_ORDER=UPDATE_API+"/ItemOrder";
String ORDER_LIST_BY_DATE=FETCH_API+"/GetOrderListsByDate?orgID=";
String DASHBOARD=FETCH_API+"/GetDashboardStatus?orgID=";
String ORDER_DETAILS=FETCH_API+"/GetOrderDtlLists?OrderID=";
String ORDER_UPDATE=UPDATE_API+"/UpdateOrder";