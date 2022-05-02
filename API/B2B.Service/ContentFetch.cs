using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model.DA;
using B2B.Model;


namespace B2B.Service
{
    public class ContentFetch
    {
       
        


       
        public ItemCatMaster ItemCatMasterSelect(int itemCatID, int tenantID, string secureCode)
        {

            
                

            ItemCatMasterDA obj = new ItemCatMasterDA("ConnectionString");
            return obj.Select(itemCatID, tenantID);
        }


       
        public List<ItemCatMaster> ItemCatMasterSelectAll(int tenantID, string secureCode)
        {

            
                

            ItemCatMasterDA obj = new ItemCatMasterDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public ItemMaster ItemMasterSelect(int itemID, int tenantID, string secureCode)
        {

            
                

            ItemMasterDA obj = new ItemMasterDA("ConnectionString");
            return obj.Select(itemID, tenantID);
        }


       
        public List<ItemMaster> ItemMasterSelectAll(int tenantID, string secureCode)
        {

            
                

            ItemMasterDA obj = new ItemMasterDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public LoginUser LoginUserSelect(int loginID, int tenantID, string secureCode)
        {

            
                

            LoginUserDA obj = new LoginUserDA("ConnectionString");
            return obj.Select(loginID, tenantID);
        }


       
        public List<LoginUser> LoginUserSelectAll(int tenantID, string secureCode)
        {

            
                

            LoginUserDA obj = new LoginUserDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
       


       
        public Order OrderSelect(long orderID, int tenantID, string secureCode)
        {

            
                

            OrderDA obj = new OrderDA("ConnectionString");
            return obj.Select(orderID, tenantID);
        }


       
        public List<Order> OrderSelectAll(int tenantID, string secureCode)
        {

            
                

            OrderDA obj = new OrderDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public OrderDtl OrderDtlSelect(long orderDtlID, int tenantID, string secureCode)
        {

            
                

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.Select(orderDtlID, tenantID);
        }


       
        public List<OrderDtl> OrderDtlSelectAll(int tenantID, string secureCode)
        {

            
                

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }


       
        public List<OrderDtl> OrderDtlSelectAllByOrderID(long orderID, int tenantID, string secureCode)
        {

            
                

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.SelectAllByOrderID(orderID, tenantID);
        }

       
        public List<OrderDtl> OrderDtlSelectAllByOrgID(int orgID, int tenantID, string secureCode)
        {

            
                

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.SelectAllByOrgID(orgID, tenantID);
        }


       
        public OrganisationMaster OrganisationMasterSelect(int orgID, int tenantID, string secureCode)
        {

            
                

            OrganisationMasterDA obj = new OrganisationMasterDA("ConnectionString");
            return obj.Select(orgID, tenantID);
        }


       
        public List<OrganisationMaster> OrganisationMasterSelectAll(int tenantID, string secureCode)
        {

            
                

            OrganisationMasterDA obj = new OrganisationMasterDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public RoleMaster RoleMasterSelect(int roleID, int tenantID, string secureCode)
        {

            
                

            RoleMasterDA obj = new RoleMasterDA("ConnectionString");
            return obj.Select(roleID, tenantID);
        }


       
        public List<RoleMaster> RoleMasterSelectAll(int tenantID, string secureCode)
        {

            
                

            RoleMasterDA obj = new RoleMasterDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
       

       
        public List<StatusCodeMaster> StatusCodeMasterSelectAll(int tenantID, string secureCode)
        {

            
                

            StatusCodeMasterDA obj = new StatusCodeMasterDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public Tenant TenantSelect(int tenantID, string secureCode)
        {

            
                

            TenantDA obj = new TenantDA("ConnectionString");
            return obj.Select(tenantID);
        }


       
        public List<Tenant> TenantSelectAll(int tenantID, string secureCode)
        {

            
                

            TenantDA obj = new TenantDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }



       
        public TenantSetting TenantSettingSelect(int settingID, int tenantID, string secureCode)
        {

            
                

            TenantSettingDA obj = new TenantSettingDA("ConnectionString");
            return obj.Select(settingID, tenantID);
        }


       
        public List<TenantSetting> TenantSettingSelectAll(int tenantID, string secureCode)
        {

            
                

            TenantSettingDA obj = new TenantSettingDA("ConnectionString");
            return obj.SelectAll(tenantID);
        }
    }
}
