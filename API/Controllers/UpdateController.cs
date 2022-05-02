using B2B.Model;
using B2B.Service;
using B2BOrdering.Helper;
using B2BOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace B2BOrdering.Controllers
{
    public class UpdateController : ApiController
    {
        #region Customer

        [HttpPost]
        public ResponseStatus CustomerInsert([FromBody]OrganisationMaster org)
        {
            
            bool flag = false;
            ResponseStatus rs = new ResponseStatus();

            try
            {
                ContentFetch cf = new ContentFetch();
                ContentUpdate cu = new ContentUpdate();

                org.TenantID = SiteUtil.Tenant;
                org.IsActive = SiteUtil.ACTIVE_TEXT;

                org.CreatedDate = DateTime.Now;
                org.UpdateDate = DateTime.Now;

                cu.OrganisationMasterInsert(org, SiteUtil.SecureCode);

                flag = true;

                if (flag)
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                }
                else
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR;
                }


            }
            catch (Exception ex)
            {

                rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                rs.responseMessage = ex.Message;

            }

            return rs;
        }

        #endregion

        #region Item

        [HttpPost]
        public ResponseStatus ItemInsert([FromBody]ItemMaster item)
        {

            bool flag = false;
            ResponseStatus rs = new ResponseStatus();

            try
            {
                ContentFetch cf = new ContentFetch();
                ContentUpdate cu = new ContentUpdate();

                item.TenantID = SiteUtil.Tenant;
                item.IsActive = SiteUtil.ACTIVE_TEXT;

                item.CreatedDate = DateTime.Now;
                item.UpdateDate = DateTime.Now;

                cu.ItemMasterInsert(item, SiteUtil.SecureCode);

                flag = true;

                if (flag)
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                }
                else
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR;
                }


            }
            catch (Exception ex)
            {

                rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                rs.responseMessage = ex.Message;

            }

            return rs;
        }

        #endregion
        #region Order
        [HttpPost]
        public ResponseStatus ItemOrder([FromBody] PlaceOrder order)
        {

            bool flag = false;
            ResponseStatus rs = new ResponseStatus();

            try
            {
                ContentFetch cf = new ContentFetch();
                ContentUpdate cu = new ContentUpdate();

                Order orderDetails= new Order();
                orderDetails.TenantID = SiteUtil.Tenant;
                orderDetails.IsActive = SiteUtil.ACTIVE_TEXT;

                orderDetails.OrderDate = DateTime.Now;
                orderDetails.OrderDateTxt = DateTime.Now.ToString("dd/MM/yyyy");

                orderDetails.AckDate = DateTime.Now;
                orderDetails.ProcessDate = DateTime.Now;
                orderDetails.DeliverDate = DateTime.Now;

                orderDetails.CreatedDate = DateTime.Now;
                orderDetails.UpdateDate = DateTime.Now;

                orderDetails.OrderStatusID = SiteUtil.OrderPendingID;
                orderDetails.OrderStatus = SiteUtil.OrderPendingName;

                orderDetails.InternalStatusID = SiteUtil.OrderPendingID;
                orderDetails.InternalStatus = SiteUtil.OrderPendingName;

                orderDetails.OrgID = order.orgID;
                orderDetails.CreatedBy = order.createdBy;
                orderDetails.UpdatedBy = order.updatedBy;
                orderDetails.Priority = order.priority;
                orderDetails.Remark = order.remarks;

                long ordeID = cu.OrderInsert(orderDetails, SiteUtil.SecureCode);
                if (ordeID > 0) {
                    for (int a = 0; a < order.items.Count; a++) { 
                        OrderDtl orderDtl= order.items[a];
                        orderDtl.StatusID= SiteUtil.OrderPendingID;
                        orderDtl.OrderID = ordeID;
                        orderDtl.CompanyUpdateDate = DateTime.Now;
                        orderDtl.CreatedDate = DateTime.Now;
                        orderDtl.UpdateDate = DateTime.Now;
                        long dID=cu.OrderDtlInsert(orderDtl, SiteUtil.SecureCode);

                    }
                }



                flag = true;

                if (flag)
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                }
                else
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR;
                }


            }
            catch (Exception ex)
            {

                rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                rs.responseMessage = ex.Message;

            }

            return rs;
        }

        [HttpPost]
        public ResponseStatus UpdateOrder([FromBody] Order order)
        {

            bool flag = false;
            ResponseStatus rs = new ResponseStatus();

            try
            {
                ContentFetch cf = new ContentFetch();
                ContentUpdate cu = new ContentUpdate();

                Order orderDetails = cf.OrderSelect(order.OrderID, SiteUtil.Tenant, SiteUtil.SecureCode);
                orderDetails.UpdateDate = DateTime.Now;
                orderDetails.UpdatedBy = order.UpdatedBy;
                orderDetails.OrderStatusID = order.OrderStatusID;
                orderDetails.OrderStatus = order.OrderStatus;
                orderDetails.UpdatedBy = order.UpdatedBy;
                long oid = cu.OrderUpdate(orderDetails, SiteUtil.SecureCode);


                flag = true;

                if (flag)
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_SUCCESS;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_SUCCESS;
                }
                else
                {
                    rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                    rs.responseMessage = B2BConstants.RESPONSE_MESSAGE_ERROR;
                }


            }
            catch (Exception ex)
            {

                rs.responseCode = B2BConstants.RESPONSE_CODE_ERROR;
                rs.responseMessage = ex.Message;

            }

            return rs;
        }
        #endregion

    }
}
