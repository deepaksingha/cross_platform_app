using B2BOrdering.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace B2BOrdering.Service
{
    public class ServiceCall
    {
        public string MyConnectionString
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString(); }

        }

        public DataSet GetItemDetailsByItemName(string itemname)
        {
            SqlParameter parameter;
            DataSet dataSet = new DataSet();
            SqlCommand selectCommand = new SqlCommand();
            SqlConnection connection = new SqlConnection(MyConnectionString);
            try
            {
                connection.Open();
                selectCommand.Connection = connection;
                selectCommand.CommandType = CommandType.StoredProcedure;
                selectCommand.CommandText = "GetItemDtlByItemName";
                parameter = new SqlParameter("@TenantID", SiteUtil.Tenant)
                {
                    Direction = ParameterDirection.Input,
                    DbType = DbType.Int32
                };
                selectCommand.Parameters.Add(parameter);

                parameter = new SqlParameter("@ITEMNAME", itemname)
                {
                    Direction = ParameterDirection.Input,
                    DbType = DbType.String
                };
                selectCommand.Parameters.Add(parameter);


                new SqlDataAdapter(selectCommand).Fill(dataSet);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                selectCommand = null;
                parameter = null;
            }

            return dataSet;
        }


        public DataTable GetOrderByDate(int orgID, string from, string to)
        {
            SqlParameter parameter;
            DataTable dataTable = new DataTable();
            SqlCommand selectCommand = new SqlCommand();
            SqlConnection connection = new SqlConnection(MyConnectionString);
            try
            {
                connection.Open();
                selectCommand.Connection = connection;
                selectCommand.CommandType = CommandType.StoredProcedure;
                selectCommand.CommandText = "OrderSelectAllByDate";
                selectCommand.Parameters.AddWithValue("@TenantID", SiteUtil.Tenant);
                selectCommand.Parameters.AddWithValue("@OrgID", orgID);
                selectCommand.Parameters.AddWithValue("@From", from);
                selectCommand.Parameters.AddWithValue("@To", to);


                new SqlDataAdapter(selectCommand).Fill(dataTable);
            }
            catch (Exception ex)
            {
                dataTable.Columns.Add("Error");
                dataTable.Rows.Add(ex.ToString());
                ex.ToString();
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                selectCommand = null;
                parameter = null;
            }

            return dataTable;
        }
        public DataTable GetDashboardInfo(int orgID, string from, string to)
        {
            SqlParameter parameter;
            DataTable dataTable = new DataTable();
            SqlCommand selectCommand = new SqlCommand();
            SqlConnection connection = new SqlConnection(MyConnectionString);
            try
            {
                connection.Open();
                selectCommand.Connection = connection;
                selectCommand.CommandType = CommandType.StoredProcedure;
                selectCommand.CommandText = "DashboardInfo";
                selectCommand.Parameters.AddWithValue("@TenantID", SiteUtil.Tenant);
                selectCommand.Parameters.AddWithValue("@OrgID", orgID);
                selectCommand.Parameters.AddWithValue("@From", from);
                selectCommand.Parameters.AddWithValue("@To", to);


                new SqlDataAdapter(selectCommand).Fill(dataTable);
            }
            catch (Exception ex)
            {
                dataTable.Columns.Add("Error");
                dataTable.Rows.Add(ex.ToString());
                ex.ToString();
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                selectCommand = null;
                parameter = null;
            }

            return dataTable;
        }


    }
}