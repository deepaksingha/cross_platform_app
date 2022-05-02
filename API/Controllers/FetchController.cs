using B2B.Model;
using B2B.Service;
using B2BOrdering.Helper;
using B2BOrdering.Models;
using B2BOrdering.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2BOrdering.Controllers
{
    public class FetchController : ApiController
    {
        #region Login_Info

        [HttpPost]
        public LoginUserInfo GetUserInfo([FromBody] LoginUser login)
        {

            LoginUserInfo loginuserinfo = new LoginUserInfo();
            ContentFetch cf = new ContentFetch();

            try
            {

                List<LoginUser> list = cf.LoginUserSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT && d.AppLoginFlag == SiteUtil.ACTIVE_TEXT).ToList();

                if (list != null && list.Count > 0)
                {
                    list = list.Where(d => d.UserName == login.UserName && d.Passwrd == login.Passwrd).ToList<LoginUser>();

                    if (list.Count > 0)
                    {
                        loginuserinfo.responseResult = list[0];
                        loginuserinfo.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                        loginuserinfo.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                    }
                }

            }

            catch (Exception ex)
            {
                loginuserinfo.responseCode = B2BConstants.RESPONSE_MESSAGE_ERROR;
                loginuserinfo.responseMessage = ex.Message;
            }

            return loginuserinfo;


        }
        public LoginUserList GetLoginUserList(int orgID)
        {
            LoginUserList lscustomer = new LoginUserList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<LoginUser> list = cf.LoginUserSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT && d.CustomerType == SiteUtil.CUSTOMER_TYPE).ToList();

                var filter = list;


                if (orgID != 0)
                {
                    filter = filter.Where(d => d.OrgID == orgID).ToList();
                }

                LoginUserList pLists = new LoginUserList();
                pLists.responseResult = filter.ToList();
                pLists.count = filter.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                lscustomer = pLists;

            }
            catch (Exception e)
            {
                lscustomer.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                lscustomer.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return lscustomer;
        }


        #endregion

        #region Customer

        public CustomerList GetCustomerList(int cusid)
        {
            CustomerList lscustomer = new CustomerList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<OrganisationMaster> list = cf.OrganisationMasterSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT).ToList();

                var filter = list;


                if (cusid != 0)
                {
                    filter = filter.Where(d => d.OrgID == cusid).ToList();
                }

                CustomerList pLists = new CustomerList(filter.ToList());
                pLists.count = filter.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                lscustomer = pLists;

            }
            catch (Exception e)
            {
                lscustomer.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                lscustomer.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return lscustomer;
        }

        #endregion

        #region Item

        public ItemCategoryList GetItemCategoryList(int itemcatid)
        {
            ItemCategoryList lsitems = new ItemCategoryList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<ItemCatMaster> list = cf.ItemCatMasterSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT).ToList();

                var filter = list;


                if (itemcatid != 0)
                {
                    filter = filter.Where(d => d.ItemCatID == itemcatid).ToList();
                }

                ItemCategoryList pLists = new ItemCategoryList(filter.ToList());
                pLists.count = filter.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                lsitems = pLists;

            }
            catch (Exception e)
            {
                lsitems.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                lsitems.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return lsitems;
        }

        public ItemList GetItemList(int itemid)
        {
            ItemList lsitems = new ItemList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<ItemMaster> list = cf.ItemMasterSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT).ToList();

                var filter = list;


                if (itemid != 0)
                {
                    filter = filter.Where(d => d.ItemID == itemid).ToList();
                }

                ItemList pLists = new ItemList(filter.ToList());
                pLists.count = filter.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                lsitems = pLists;

            }
            catch (Exception e)
            {
                lsitems.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                lsitems.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return lsitems;
        }

        //for Item search by Name
        public ItemListByName GetItemListByName(string itemname)
        {
            ItemListByName lsitems = new ItemListByName();

            ContentFetch cf = new ContentFetch();
            ServiceCall pcf = new ServiceCall();

            try
            {
                    List<ItemMasterViewModel> itemdtlList = new List<ItemMasterViewModel>();

                    string iname = "";
                    if (itemname == null) iname = "";
                    else iname = itemname;

                    DataSet data = pcf.GetItemDetailsByItemName(iname);

                    int num = 0;
                    if (data.Tables.Count > 0)
                    {

                        for (num = 0; num <= (data.Tables[0].Rows.Count - 1); num++)
                        {

                            ItemMasterViewModel vm = new ItemMasterViewModel();

                            vm.ItemName = data.Tables[0].Rows[num]["ItemName"].ToString();
                            vm.HSN = data.Tables[0].Rows[num]["HSN"].ToString();
                            vm.CategoryName = data.Tables[0].Rows[num]["CategoryName"].ToString();
                            vm.ItemID = Convert.ToInt16(data.Tables[0].Rows[num]["ItemID"].ToString());
                            vm.PackSize = Convert.ToInt16(data.Tables[0].Rows[num]["PackSize"].ToString());
                            vm.ItemCatID = Convert.ToInt16(data.Tables[0].Rows[num]["ItemCatID"].ToString());

                            itemdtlList.Add(vm);

                        }

                        var filter = itemdtlList.ToList();


                        ItemListByName pLists = new ItemListByName(filter.ToList());
                        pLists.count = filter.ToList().Count;
                        lsitems = pLists;

                        lsitems.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;

                    }

            }
            catch (Exception e)
            {
                lsitems.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                lsitems.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return lsitems;
        }

        #endregion

        #region Order
        public OrderList GetOrderLists(int orgID, string from , string to)
        {
            OrderList orderLists = new OrderList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<Order> list = cf.OrderSelectAll(SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT).ToList();


                var filter = list;
                if (from != null && to != null) {
                    filter = filter.Where(d => (Convert.ToDateTime(d.OrderDate.ToString("dd/MM/yyyy")) >= Convert.ToDateTime(from) && Convert.ToDateTime(d.OrderDate.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(to))).ToList<Order>();
                }
                if (orgID != 0)
                {
                    filter = filter.Where(d => d.OrgID == orgID).ToList();
                }

                OrderList pLists = new OrderList();
                pLists.responseResult = filter.ToList();
                pLists.count = filter.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                orderLists = pLists;

            }
            catch (Exception e)
            {
                orderLists.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                orderLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return orderLists;
        }

        public DataResult GetOrderListsByDate(int orgID, string from, string to)
        {
            DataResult orderLists = new DataResult();

            ServiceCall sc = new ServiceCall();

            try
            {
                DataTable dt = sc.GetOrderByDate(orgID, from, to);  

                DataResult pLists = new DataResult();
                pLists.responseResult = dt;
                pLists.count = dt.Rows.Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                orderLists = pLists;

            }
            catch (Exception e)
            {
                orderLists.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                orderLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return orderLists;
        }

        public OrderDtlList GetOrderDtlLists(int OrderID)
        {
            OrderDtlList orderLists = new OrderDtlList();

            ContentFetch cf = new ContentFetch();

            try
            {
                List<OrderDtl> list = cf.OrderDtlSelectAllByOrderID(OrderID,SiteUtil.Tenant, SiteUtil.SecureCode).Where(d => d.IsActive == SiteUtil.ACTIVE_TEXT).ToList();
                OrderDtlList pLists = new OrderDtlList();
                pLists.responseResult = list;
                pLists.count = list.ToList().Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                orderLists = pLists;

            }
            catch (Exception e)
            {
                orderLists.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                orderLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return orderLists;
        }
        #endregion

        #region Dashboard

        public DataResult GetDashboardStatus(int orgID, string from, string to)
        {
            DataResult orderLists = new DataResult();

            ServiceCall sc = new ServiceCall();

            try
            {
                DataTable dt = sc.GetDashboardInfo(orgID, from, to);

                DataResult pLists = new DataResult();
                pLists.responseResult = dt;
                pLists.count = dt.Rows.Count;
                pLists.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                pLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                orderLists = pLists;

            }
            catch (Exception e)
            {
                orderLists.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                orderLists.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR + e.Message;
            }

            return orderLists;
        }

        #endregion
    }
}
