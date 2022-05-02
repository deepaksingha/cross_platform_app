using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class OrderDtlDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public OrderDtlDA()
		{
		}

		public OrderDtlDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the OrderDtl table.
		/// </summary>
		public  long Insert(OrderDtl orderDtl)
		{
			ValidationUtility.ValidateArgument("orderDtl", orderDtl);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", orderDtl.TenantID),
				new SqlParameter("@IsActive", orderDtl.IsActive),
				new SqlParameter("@StatusID", orderDtl.StatusID),
				new SqlParameter("@OrderID", orderDtl.OrderID),
				new SqlParameter("@OrgID", orderDtl.OrgID),
				new SqlParameter("@ItemID", orderDtl.ItemID),
				new SqlParameter("@ItemName", orderDtl.ItemName),
				new SqlParameter("@HSN", orderDtl.HSN),
				new SqlParameter("@ItemCatID", orderDtl.ItemCatID),
				new SqlParameter("@CategoryName", orderDtl.CategoryName),
				new SqlParameter("@OrderQTY", orderDtl.OrderQTY),
				new SqlParameter("@DeliverQTY", orderDtl.DeliverQTY),
				new SqlParameter("@RecQTY", orderDtl.RecQTY),
				new SqlParameter("@UOM", orderDtl.UOM),
				new SqlParameter("@PackSize", orderDtl.PackSize),
				new SqlParameter("@ItemRate", orderDtl.ItemRate),
				new SqlParameter("@ItemMRP", orderDtl.ItemMRP),
				new SqlParameter("@CostPrice", orderDtl.CostPrice),
				new SqlParameter("@GST", orderDtl.GST),
				new SqlParameter("@PreTaxOrginalAmt", orderDtl.PreTaxOrginalAmt),
				new SqlParameter("@Disc", orderDtl.Disc),
				new SqlParameter("@TaxableAmt", orderDtl.TaxableAmt),
				new SqlParameter("@TaxtAmt", orderDtl.TaxtAmt),
				new SqlParameter("@TotalAmt", orderDtl.TotalAmt),
				new SqlParameter("@NetAmt", orderDtl.NetAmt),
				new SqlParameter("@Roundoff", orderDtl.Roundoff),
				new SqlParameter("@Priority", orderDtl.Priority),
				new SqlParameter("@IsOutStock", orderDtl.IsOutStock),
				new SqlParameter("@CompanyUser", orderDtl.CompanyUser),
				new SqlParameter("@CompanyUpdateDate", orderDtl.CompanyUpdateDate),
				new SqlParameter("@CompanyMessage", orderDtl.CompanyMessage),
				new SqlParameter("@CompMessageBy", orderDtl.CompMessageBy),
				new SqlParameter("@SupplierMessage", orderDtl.SupplierMessage),
				new SqlParameter("@SupplierMsgBy", orderDtl.SupplierMsgBy),
				new SqlParameter("@AckBy", orderDtl.AckBy),
				new SqlParameter("@PackedBy", orderDtl.PackedBy),
				new SqlParameter("@DeliveredBy", orderDtl.DeliveredBy),
				new SqlParameter("@VerifiedBy", orderDtl.VerifiedBy),
				new SqlParameter("@CancelledBy", orderDtl.CancelledBy),
				new SqlParameter("@CancelRemark", orderDtl.CancelRemark),
				new SqlParameter("@CancelDate", orderDtl.CancelDate),
				new SqlParameter("@AckDate", orderDtl.AckDate),
				new SqlParameter("@VerifyDate", orderDtl.VerifyDate),
				new SqlParameter("@Remark", orderDtl.Remark),
				new SqlParameter("@CreatedBy", orderDtl.CreatedBy),
				new SqlParameter("@UpdatedBy", orderDtl.UpdatedBy),
				new SqlParameter("@CreatedDate", orderDtl.CreatedDate),
				new SqlParameter("@UpdateDate", orderDtl.UpdateDate)
			};

			orderDtl.OrderDtlID = Convert.ToInt64(SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "OrderDtlInsert", parameters));
			return orderDtl.OrderDtlID;
		}

		/// <summary>
		/// Updates a record in the OrderDtl table.
		/// </summary>
		public  int Update(OrderDtl orderDtl)
		{
			ValidationUtility.ValidateArgument("orderDtl", orderDtl);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderDtlID", orderDtl.OrderDtlID),
				new SqlParameter("@TenantID", orderDtl.TenantID),
				new SqlParameter("@IsActive", orderDtl.IsActive),
				new SqlParameter("@StatusID", orderDtl.StatusID),
				new SqlParameter("@OrderID", orderDtl.OrderID),
				new SqlParameter("@OrgID", orderDtl.OrgID),
				new SqlParameter("@ItemID", orderDtl.ItemID),
				new SqlParameter("@ItemName", orderDtl.ItemName),
				new SqlParameter("@HSN", orderDtl.HSN),
				new SqlParameter("@ItemCatID", orderDtl.ItemCatID),
				new SqlParameter("@CategoryName", orderDtl.CategoryName),
				new SqlParameter("@OrderQTY", orderDtl.OrderQTY),
				new SqlParameter("@DeliverQTY", orderDtl.DeliverQTY),
				new SqlParameter("@RecQTY", orderDtl.RecQTY),
				new SqlParameter("@UOM", orderDtl.UOM),
				new SqlParameter("@PackSize", orderDtl.PackSize),
				new SqlParameter("@ItemRate", orderDtl.ItemRate),
				new SqlParameter("@ItemMRP", orderDtl.ItemMRP),
				new SqlParameter("@CostPrice", orderDtl.CostPrice),
				new SqlParameter("@GST", orderDtl.GST),
				new SqlParameter("@PreTaxOrginalAmt", orderDtl.PreTaxOrginalAmt),
				new SqlParameter("@Disc", orderDtl.Disc),
				new SqlParameter("@TaxableAmt", orderDtl.TaxableAmt),
				new SqlParameter("@TaxtAmt", orderDtl.TaxtAmt),
				new SqlParameter("@TotalAmt", orderDtl.TotalAmt),
				new SqlParameter("@NetAmt", orderDtl.NetAmt),
				new SqlParameter("@Roundoff", orderDtl.Roundoff),
				new SqlParameter("@Priority", orderDtl.Priority),
				new SqlParameter("@IsOutStock", orderDtl.IsOutStock),
				new SqlParameter("@CompanyUser", orderDtl.CompanyUser),
				new SqlParameter("@CompanyUpdateDate", orderDtl.CompanyUpdateDate),
				new SqlParameter("@CompanyMessage", orderDtl.CompanyMessage),
				new SqlParameter("@CompMessageBy", orderDtl.CompMessageBy),
				new SqlParameter("@SupplierMessage", orderDtl.SupplierMessage),
				new SqlParameter("@SupplierMsgBy", orderDtl.SupplierMsgBy),
				new SqlParameter("@AckBy", orderDtl.AckBy),
				new SqlParameter("@PackedBy", orderDtl.PackedBy),
				new SqlParameter("@DeliveredBy", orderDtl.DeliveredBy),
				new SqlParameter("@VerifiedBy", orderDtl.VerifiedBy),
				new SqlParameter("@CancelledBy", orderDtl.CancelledBy),
				new SqlParameter("@CancelRemark", orderDtl.CancelRemark),
				new SqlParameter("@CancelDate", orderDtl.CancelDate),
				new SqlParameter("@AckDate", orderDtl.AckDate),
				new SqlParameter("@VerifyDate", orderDtl.VerifyDate),
				new SqlParameter("@Remark", orderDtl.Remark),
				new SqlParameter("@CreatedBy", orderDtl.CreatedBy),
				new SqlParameter("@UpdatedBy", orderDtl.UpdatedBy),
				new SqlParameter("@CreatedDate", orderDtl.CreatedDate),
				new SqlParameter("@UpdateDate", orderDtl.UpdateDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderDtlUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the OrderDtl table by its primary key.
		/// </summary>
		public  int Delete(long orderDtlID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderDtlID", orderDtlID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderDtlDelete", parameters));
		}

		/// <summary>
		/// Deletes a record from the OrderDtl table by a foreign key.
		/// </summary>
		public  int DeleteAllByOrderID(long orderID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderID", orderID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderDtlDeleteAllByOrderID", parameters));
		}

		/// <summary>
		/// Deletes a record from the OrderDtl table by a foreign key.
		/// </summary>
		public  int DeleteAllByOrgID(int orgID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrgID", orgID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderDtlDeleteAllByOrgID", parameters));
		}

		/// <summary>
		/// Selects a single record from the OrderDtl table.
		/// </summary>
		public  OrderDtl Select(long orderDtlID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderDtlID", orderDtlID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderDtlSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeOrderDtl(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the OrderDtl table.
		/// </summary>
		public  List<OrderDtl> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderDtlSelectAll", parameters))
			{
				List<OrderDtl> orderDtlList = new List<OrderDtl>();
				while (dataReader.Read())
				{
					OrderDtl orderDtl = MakeOrderDtl(dataReader);
					orderDtlList.Add(orderDtl);
				}

				return orderDtlList;
			}
		}

		/// <summary>
		/// Selects all records from the OrderDtl table by a foreign key.
		/// </summary>
		public  List<OrderDtl> SelectAllByOrderID(long orderID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderID", orderID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderDtlSelectAllByOrderID", parameters))
			{
				List<OrderDtl> orderDtlList = new List<OrderDtl>();
				while (dataReader.Read())
				{
					OrderDtl orderDtl = MakeOrderDtl(dataReader);
					orderDtlList.Add(orderDtl);
				}

				return orderDtlList;
			}
		}

		/// <summary>
		/// Selects all records from the OrderDtl table by a foreign key.
		/// </summary>
		public  List<OrderDtl> SelectAllByOrgID(int orgID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrgID", orgID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderDtlSelectAllByOrgID", parameters))
			{
				List<OrderDtl> orderDtlList = new List<OrderDtl>();
				while (dataReader.Read())
				{
					OrderDtl orderDtl = MakeOrderDtl(dataReader);
					orderDtlList.Add(orderDtl);
				}

				return orderDtlList;
			}
		}

		/// <summary>
		/// Creates a new instance of the OrderDtl class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  OrderDtl MakeOrderDtl(SqlDataReader dataReader)
		{
			OrderDtl orderDtl = new OrderDtl();
			orderDtl.OrderDtlID = SqlClientUtility.GetInt64(dataReader, "OrderDtlID", 0);
			orderDtl.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			orderDtl.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			orderDtl.StatusID = SqlClientUtility.GetInt32(dataReader, "StatusID", 0);
			orderDtl.OrderID = SqlClientUtility.GetInt64(dataReader, "OrderID", 0);
			orderDtl.OrgID = SqlClientUtility.GetInt32(dataReader, "OrgID", 0);
			orderDtl.ItemID = SqlClientUtility.GetInt32(dataReader, "ItemID", 0);
			orderDtl.ItemName = SqlClientUtility.GetString(dataReader, "ItemName", String.Empty);
			orderDtl.HSN = SqlClientUtility.GetString(dataReader, "HSN", String.Empty);
			orderDtl.ItemCatID = SqlClientUtility.GetInt32(dataReader, "ItemCatID", 0);
			orderDtl.CategoryName = SqlClientUtility.GetString(dataReader, "CategoryName", String.Empty);
			orderDtl.OrderQTY = SqlClientUtility.GetInt32(dataReader, "OrderQTY", 0);
			orderDtl.DeliverQTY = SqlClientUtility.GetInt32(dataReader, "DeliverQTY", 0);
			orderDtl.RecQTY = SqlClientUtility.GetInt32(dataReader, "RecQTY", 0);
			orderDtl.UOM = SqlClientUtility.GetString(dataReader, "UOM", String.Empty);
			orderDtl.PackSize = SqlClientUtility.GetInt32(dataReader, "PackSize", 0);
			orderDtl.ItemRate = SqlClientUtility.GetDecimal(dataReader, "ItemRate", Decimal.Zero);
			orderDtl.ItemMRP = SqlClientUtility.GetDecimal(dataReader, "ItemMRP", Decimal.Zero);
			orderDtl.CostPrice = SqlClientUtility.GetDecimal(dataReader, "CostPrice", Decimal.Zero);
			orderDtl.GST = SqlClientUtility.GetDecimal(dataReader, "GST", Decimal.Zero);
			orderDtl.PreTaxOrginalAmt = SqlClientUtility.GetDecimal(dataReader, "PreTaxOrginalAmt", Decimal.Zero);
			orderDtl.Disc = SqlClientUtility.GetDecimal(dataReader, "Disc", Decimal.Zero);
			orderDtl.TaxableAmt = SqlClientUtility.GetDecimal(dataReader, "TaxableAmt", Decimal.Zero);
			orderDtl.TaxtAmt = SqlClientUtility.GetDecimal(dataReader, "TaxtAmt", Decimal.Zero);
			orderDtl.TotalAmt = SqlClientUtility.GetDecimal(dataReader, "TotalAmt", Decimal.Zero);
			orderDtl.NetAmt = SqlClientUtility.GetDecimal(dataReader, "NetAmt", Decimal.Zero);
			orderDtl.Roundoff = SqlClientUtility.GetDecimal(dataReader, "Roundoff", Decimal.Zero);
			orderDtl.Priority = SqlClientUtility.GetString(dataReader, "Priority", String.Empty);
			orderDtl.IsOutStock = SqlClientUtility.GetString(dataReader, "IsOutStock", String.Empty);
			orderDtl.CompanyUser = SqlClientUtility.GetString(dataReader, "CompanyUser", String.Empty);
			orderDtl.CompanyUpdateDate = SqlClientUtility.GetDateTime(dataReader, "CompanyUpdateDate", DateTime.Now);
			orderDtl.CompanyMessage = SqlClientUtility.GetString(dataReader, "CompanyMessage", String.Empty);
			orderDtl.CompMessageBy = SqlClientUtility.GetString(dataReader, "CompMessageBy", String.Empty);
			orderDtl.SupplierMessage = SqlClientUtility.GetString(dataReader, "SupplierMessage", String.Empty);
			orderDtl.SupplierMsgBy = SqlClientUtility.GetString(dataReader, "SupplierMsgBy", String.Empty);
			orderDtl.AckBy = SqlClientUtility.GetString(dataReader, "AckBy", String.Empty);
			orderDtl.PackedBy = SqlClientUtility.GetString(dataReader, "PackedBy", String.Empty);
			orderDtl.DeliveredBy = SqlClientUtility.GetString(dataReader, "DeliveredBy", String.Empty);
			orderDtl.VerifiedBy = SqlClientUtility.GetString(dataReader, "VerifiedBy", String.Empty);
			orderDtl.CancelledBy = SqlClientUtility.GetString(dataReader, "CancelledBy", String.Empty);
			orderDtl.CancelRemark = SqlClientUtility.GetString(dataReader, "CancelRemark", String.Empty);
			orderDtl.CancelDate = SqlClientUtility.GetString(dataReader, "CancelDate", String.Empty);
			orderDtl.AckDate = SqlClientUtility.GetString(dataReader, "AckDate", String.Empty);
			orderDtl.VerifyDate = SqlClientUtility.GetString(dataReader, "VerifyDate", String.Empty);
			orderDtl.Remark = SqlClientUtility.GetString(dataReader, "Remark", String.Empty);
			orderDtl.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			orderDtl.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);
			orderDtl.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			orderDtl.UpdateDate = SqlClientUtility.GetDateTime(dataReader, "UpdateDate", DateTime.Now);

			return orderDtl;
		}

		#endregion
	}
}
