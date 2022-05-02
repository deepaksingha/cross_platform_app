using B2B.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace B2BOrdering.Models
{
    public class ViewModels
    {
    }

    public class LoginUserInfo
    {
        public LoginUser responseResult { get; set; }
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
        public LoginUserInfo()
        {

        }

    }

    public class ResponseStatus
    {
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
        public DataTable responseResult { get; set; }
    }

    
    public class DataResult
    {
        public int count { get; set; }
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
        public DataTable responseResult { get; set; }

    }

    public class CustomerList
    {

        List<OrganisationMaster> _cuslist = null;

        public List<OrganisationMaster> responseResult
        {
            get { return _cuslist; }
            set { _cuslist = value; }
        }

        public CustomerList(List<OrganisationMaster> _list)
        {
            _cuslist = _list;
        }

        public CustomerList()
        {

        }

        public int count;
        public string responseMessage { get; set; }
        public string responseCode { get; set; }

    }

    public class ItemCategoryList
    {

        List<ItemCatMaster> _itemcatlist = null;

        public List<ItemCatMaster> responseResult
        {
            get { return _itemcatlist; }
            set { _itemcatlist = value; }
        }

        public ItemCategoryList(List<ItemCatMaster> _list)
        {
            _itemcatlist = _list;
        }

        public ItemCategoryList()
        {

        }

        public int count;
        public string responseMessage { get; set; }
        public string responseCode { get; set; }

    }

    public class ItemList
    {

        List<ItemMaster> _itemlist = null;

        public List<ItemMaster> responseResult
        {
            get { return _itemlist; }
            set { _itemlist = value; }
        }

        public ItemList(List<ItemMaster> _list)
        {
            _itemlist = _list;
        }

        public ItemList()
        {

        }

        public int count;
        public string responseMessage { get; set; }
        public string responseCode { get; set; }

    }

    public class ItemListByName
    {
        List<ItemMasterViewModel> _itemnamelist = null;

        /// <summary> 
        /// get/set SearchResults list 
        /// </summary> 
        public List<ItemMasterViewModel> responseResult
        {
            get { return _itemnamelist; }
            set { _itemnamelist = value; }
        }

        /// <summary> 
        /// constructor with SearchResults list 
        /// </summary> 
        /// <param name="_list"></param> 
        public ItemListByName(List<ItemMasterViewModel> _list)
        {
            _itemnamelist = _list;
        }

        public ItemListByName()
        {

        }

        public int count = 0;

        public string responseMessage { get; set; }
        public string responseCode { get; set; }
    }

    public class OrderList {
        public List<Order> responseResult;
        public int count = 0;
        public string responseMessage { get; set; }
        public string responseCode { get; set; }

    }

    public class OrderDtlList
    {
        public List<OrderDtl> responseResult;
        public int count = 0;
        public string responseMessage { get; set; }
        public string responseCode { get; set; }

    }

    public class ItemMasterViewModel
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string HSN { get; set; }
        public int ItemCatID { get; set; }
        public string CategoryName { get; set; }
        public int PackSize { get; set; }

    }

    public class PlaceOrder
    {
        public List<OrderDtl> items { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public string priority { get; set; }
        public int priorityID { get; set; }
        public string remarks { get; set; }
        public int orgID { get; set; }

    }
}