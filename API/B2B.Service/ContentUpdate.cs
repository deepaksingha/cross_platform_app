using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model.DA;
using B2B.Model;

namespace B2B.Service
{
    public class ContentUpdate
    {
        
        public int FuctionalityMasterInsert(FuctionalityMaster fuctionalityMaster, string secureCode)
        {

           
               

            FuctionalityMasterDA obj = new FuctionalityMasterDA("ConnectionString");
            return obj.Insert(fuctionalityMaster);
        }


        
        public int FuctionalityMasterUpdate(FuctionalityMaster fuctionalityMaster, string secureCode)
        {

           
               

            FuctionalityMasterDA obj = new FuctionalityMasterDA("ConnectionString");
            return obj.Update(fuctionalityMaster);
        }


        public int FuctionalityMasterDelete(int funcID, int tenantID, string secureCode)
        {

            
               

            FuctionalityMasterDA obj = new FuctionalityMasterDA("ConnectionString");
            return obj.Delete(funcID, tenantID);
        }



        
        public int FuncRoleAccessInsert(FuncRoleAccess funcRoleAccess, string secureCode)
        {

           
               

            FuncRoleAccessDA obj = new FuncRoleAccessDA("ConnectionString");
            return obj.Insert(funcRoleAccess);
        }


        
        public int FuncRoleAccessUpdate(FuncRoleAccess funcRoleAccess, string secureCode)
        {

               

            FuncRoleAccessDA obj = new FuncRoleAccessDA("ConnectionString");
            return obj.Update(funcRoleAccess);
        }


        public int FuncRoleAccessDelete(int accessID, int tenantID, string secureCode)
        {

            
               

            FuncRoleAccessDA obj = new FuncRoleAccessDA("ConnectionString");
            return obj.Delete(accessID, tenantID);
        }



        
        public int ItemCatMasterInsert(ItemCatMaster itemCatMaster, string secureCode)
        {

          
               

            ItemCatMasterDA obj = new ItemCatMasterDA("ConnectionString");
            return obj.Insert(itemCatMaster);
        }


        
        public int ItemCatMasterUpdate(ItemCatMaster itemCatMaster, string secureCode)
        {

         
               

            ItemCatMasterDA obj = new ItemCatMasterDA("ConnectionString");
            return obj.Update(itemCatMaster);
        }


        public int ItemCatMasterDelete(int itemCatID, int tenantID, string secureCode)
        {

            
               

            ItemCatMasterDA obj = new ItemCatMasterDA("ConnectionString");
            return obj.Delete(itemCatID, tenantID);
        }



        
        public int ItemMasterInsert(ItemMaster itemMaster, string secureCode)
        {

           
               

            ItemMasterDA obj = new ItemMasterDA("ConnectionString");
            return obj.Insert(itemMaster);
        }


        
        public int ItemMasterUpdate(ItemMaster itemMaster, string secureCode)
        {

            
               

            ItemMasterDA obj = new ItemMasterDA("ConnectionString");
            return obj.Update(itemMaster);
        }


        public int ItemMasterDelete(int itemID, int tenantID, string secureCode)
        {

            
               

            ItemMasterDA obj = new ItemMasterDA("ConnectionString");
            return obj.Delete(itemID, tenantID);
        }



        
        public int LoginUserInsert(LoginUser loginUser, string secureCode)
        {

            
               

            LoginUserDA obj = new LoginUserDA("ConnectionString");
            return obj.Insert(loginUser);
        }


        
        public int LoginUserUpdate(LoginUser loginUser, string secureCode)
        {

          
               

            LoginUserDA obj = new LoginUserDA("ConnectionString");
            return obj.Update(loginUser);
        }


        public int LoginUserDelete(int loginID, int tenantID, string secureCode)
        {

            
               

            LoginUserDA obj = new LoginUserDA("ConnectionString");
            return obj.Delete(loginID, tenantID);
        }



        
        public int ModuleMasterInsert(ModuleMaster moduleMaster, string secureCode)
        {

           
               

            ModuleMasterDA obj = new ModuleMasterDA("ConnectionString");
            return obj.Insert(moduleMaster);
        }


        
        public int ModuleMasterUpdate(ModuleMaster moduleMaster, string secureCode)
        {

           
               

            ModuleMasterDA obj = new ModuleMasterDA("ConnectionString");
            return obj.Update(moduleMaster);
        }


        public int ModuleMasterDelete(int moduleID, int tenantID, string secureCode)
        {

            
               

            ModuleMasterDA obj = new ModuleMasterDA("ConnectionString");
            return obj.Delete(moduleID, tenantID);
        }



        
        public long OrderInsert(Order order, string secureCode)
        {

           
               

            OrderDA obj = new OrderDA("ConnectionString");
            return obj.Insert(order);
        }


        
        public int OrderUpdate(Order order, string secureCode)
        {

           
               

            OrderDA obj = new OrderDA("ConnectionString");
            return obj.Update(order);
        }


        public int OrderDelete(long orderID, int tenantID, string secureCode)
        {

            
               

            OrderDA obj = new OrderDA("ConnectionString");
            return obj.Delete(orderID, tenantID);
        }



        
        public long OrderDtlInsert(OrderDtl orderDtl, string secureCode)
        {

            
               

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.Insert(orderDtl);
        }


        
        public int OrderDtlUpdate(OrderDtl orderDtl, string secureCode)
        {

            
               

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.Update(orderDtl);
        }


        public int OrderDtlDelete(long orderDtlID, int tenantID, string secureCode)
        {

            
               

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.Delete(orderDtlID, tenantID);
        }


        public int OrderDtlDeleteAllByOrderID(long orderID, int tenantID, string secureCode)
        {

            
               

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.DeleteAllByOrderID(orderID, tenantID);
        }

        public int OrderDtlDeleteAllByOrgID(int orgID, int tenantID, string secureCode)
        {

            
               

            OrderDtlDA obj = new OrderDtlDA("ConnectionString");
            return obj.DeleteAllByOrgID(orgID, tenantID);
        }


        
        public int OrganisationMasterInsert(OrganisationMaster organisationMaster, string secureCode)
        {

           
               

            OrganisationMasterDA obj = new OrganisationMasterDA("ConnectionString");
            return obj.Insert(organisationMaster);
        }


        
        public int OrganisationMasterUpdate(OrganisationMaster organisationMaster, string secureCode)
        {

           
               

            OrganisationMasterDA obj = new OrganisationMasterDA("ConnectionString");
            return obj.Update(organisationMaster);
        }


        public int OrganisationMasterDelete(int orgID, int tenantID, string secureCode)
        {

            
               

            OrganisationMasterDA obj = new OrganisationMasterDA("ConnectionString");
            return obj.Delete(orgID, tenantID);
        }



        
        public int RoleMasterInsert(RoleMaster roleMaster, string secureCode)
        {

               

            RoleMasterDA obj = new RoleMasterDA("ConnectionString");
            return obj.Insert(roleMaster);
        }


        
        public int RoleMasterUpdate(RoleMaster roleMaster, string secureCode)
        {

            
               

            RoleMasterDA obj = new RoleMasterDA("ConnectionString");
            return obj.Update(roleMaster);
        }


        public int RoleMasterDelete(int roleID, int tenantID, string secureCode)
        {

            
               

            RoleMasterDA obj = new RoleMasterDA("ConnectionString");
            return obj.Delete(roleID, tenantID);
        }



        
        public int RoleMenuMappingInsert(RoleMenuMapping roleMenuMapping, string secureCode)
        {

           
               

            RoleMenuMappingDA obj = new RoleMenuMappingDA("ConnectionString");
            return obj.Insert(roleMenuMapping);
        }


        
        public int RoleMenuMappingUpdate(RoleMenuMapping roleMenuMapping, string secureCode)
        {

           
               

            RoleMenuMappingDA obj = new RoleMenuMappingDA("ConnectionString");
            return obj.Update(roleMenuMapping);
        }


        public int RoleMenuMappingDelete(int mappingID, int tenantID, string secureCode)
        {

            
               

            RoleMenuMappingDA obj = new RoleMenuMappingDA("ConnectionString");
            return obj.Delete(mappingID, tenantID);
        }



        
        public int StatusCodeMasterInsert(StatusCodeMaster statusCodeMaster, string secureCode)
        {

           
               

            StatusCodeMasterDA obj = new StatusCodeMasterDA("ConnectionString");
            return obj.Insert(statusCodeMaster);
        }





        
        public int TenantInsert(Tenant tenant, string secureCode)
        {

            
               

            TenantDA obj = new TenantDA("ConnectionString");
            return obj.Insert(tenant);
        }


        
        public int TenantUpdate(Tenant tenant, string secureCode)
        {

           
               

            TenantDA obj = new TenantDA("ConnectionString");
            return obj.Update(tenant);
        }


        public int TenantDelete(int tenantID, string secureCode)
        {

            
               

            TenantDA obj = new TenantDA("ConnectionString");
            return obj.Delete(tenantID);
        }



        
        public int TenantSettingInsert(TenantSetting tenantSetting, string secureCode)
        {

           
               

            TenantSettingDA obj = new TenantSettingDA("ConnectionString");
            return obj.Insert(tenantSetting);
        }


        
        public int TenantSettingUpdate(TenantSetting tenantSetting, string secureCode)
        {

            
               

            TenantSettingDA obj = new TenantSettingDA("ConnectionString");
            return obj.Update(tenantSetting);
        }


        public int TenantSettingDelete(int settingID, int tenantID, string secureCode)
        {

            
               

            TenantSettingDA obj = new TenantSettingDA("ConnectionString");
            return obj.Delete(settingID, tenantID);
        }
    }
}
