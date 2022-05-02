using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class OrderDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public OrderDA()
		{
		}

		public OrderDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Order table.
		/// </summary>
		public  long Insert(Order order)
		{
			ValidationUtility.ValidateArgument("order", order);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", order.TenantID),
				new SqlParameter("@IsActive", order.IsActive),
				new SqlParameter("@OrderStatusID", order.OrderStatusID),
				new SqlParameter("@OrderStatus", order.OrderStatus),
				new SqlParameter("@InternalStatusID", order.InternalStatusID),
				new SqlParameter("@InternalStatus", order.InternalStatus),
				new SqlParameter("@OrderQR", order.OrderQR),
				new SqlParameter("@OrderNO", order.OrderNO),
				new SqlParameter("@OrgID", order.OrgID),
				new SqlParameter("@OrderDateTxt", order.OrderDateTxt),
				new SqlParameter("@OrderDate", order.OrderDate),
				new SqlParameter("@AckDateTxt", order.AckDateTxt),
				new SqlParameter("@AckDate", order.AckDate),
				new SqlParameter("@ProcessDateTxt", order.ProcessDateTxt),
				new SqlParameter("@ProcessDate", order.ProcessDate),
				new SqlParameter("@DeliverDateTxt", order.DeliverDateTxt),
				new SqlParameter("@DeliverDate", order.DeliverDate),
				new SqlParameter("@PreTaxOrginalAmt", order.PreTaxOrginalAmt),
				new SqlParameter("@Discount", order.Discount),
				new SqlParameter("@TaxableOrginalAmt", order.TaxableOrginalAmt),
				new SqlParameter("@TaxAmt", order.TaxAmt),
				new SqlParameter("@BillAmt", order.BillAmt),
				new SqlParameter("@OtherAmt", order.OtherAmt),
				new SqlParameter("@CGST", order.CGST),
				new SqlParameter("@SGST", order.SGST),
				new SqlParameter("@CessAmt", order.CessAmt),
				new SqlParameter("@RoundOff", order.RoundOff),
				new SqlParameter("@NetAmt", order.NetAmt),
				new SqlParameter("@CancelledBy", order.CancelledBy),
				new SqlParameter("@CancelRemark", order.CancelRemark),
				new SqlParameter("@Priority", order.Priority),
				new SqlParameter("@CompanyMessage", order.CompanyMessage),
				new SqlParameter("@CompMessageBy", order.CompMessageBy),
				new SqlParameter("@SupplierMessage", order.SupplierMessage),
				new SqlParameter("@SupplierMsgBy", order.SupplierMsgBy),
				new SqlParameter("@Remark", order.Remark),
				new SqlParameter("@AckBy", order.AckBy),
				new SqlParameter("@PackedBy", order.PackedBy),
				new SqlParameter("@DeliveredBy", order.DeliveredBy),
				new SqlParameter("@VerifiedBy", order.VerifiedBy),
				new SqlParameter("@CreatedBy", order.CreatedBy),
				new SqlParameter("@UpdatedBy", order.UpdatedBy),
				new SqlParameter("@CreatedDate", order.CreatedDate),
				new SqlParameter("@UpdateDate", order.UpdateDate)
			};

			order.OrderID = Convert.ToInt64(SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "OrderInsert", parameters));
			return order.OrderID;
		}

		/// <summary>
		/// Updates a record in the Order table.
		/// </summary>
		public  int Update(Order order)
		{
			ValidationUtility.ValidateArgument("order", order);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderID", order.OrderID),
				new SqlParameter("@TenantID", order.TenantID),
				new SqlParameter("@IsActive", order.IsActive),
				new SqlParameter("@OrderStatusID", order.OrderStatusID),
				new SqlParameter("@OrderStatus", order.OrderStatus),
				new SqlParameter("@InternalStatusID", order.InternalStatusID),
				new SqlParameter("@InternalStatus", order.InternalStatus),
				new SqlParameter("@OrderQR", order.OrderQR),
				new SqlParameter("@OrderNO", order.OrderNO),
				new SqlParameter("@OrgID", order.OrgID),
				new SqlParameter("@OrderDateTxt", order.OrderDateTxt),
				new SqlParameter("@OrderDate", order.OrderDate),
				new SqlParameter("@AckDateTxt", order.AckDateTxt),
				new SqlParameter("@AckDate", order.AckDate),
				new SqlParameter("@ProcessDateTxt", order.ProcessDateTxt),
				new SqlParameter("@ProcessDate", order.ProcessDate),
				new SqlParameter("@DeliverDateTxt", order.DeliverDateTxt),
				new SqlParameter("@DeliverDate", order.DeliverDate),
				new SqlParameter("@PreTaxOrginalAmt", order.PreTaxOrginalAmt),
				new SqlParameter("@Discount", order.Discount),
				new SqlParameter("@TaxableOrginalAmt", order.TaxableOrginalAmt),
				new SqlParameter("@TaxAmt", order.TaxAmt),
				new SqlParameter("@BillAmt", order.BillAmt),
				new SqlParameter("@OtherAmt", order.OtherAmt),
				new SqlParameter("@CGST", order.CGST),
				new SqlParameter("@SGST", order.SGST),
				new SqlParameter("@CessAmt", order.CessAmt),
				new SqlParameter("@RoundOff", order.RoundOff),
				new SqlParameter("@NetAmt", order.NetAmt),
				new SqlParameter("@CancelledBy", order.CancelledBy),
				new SqlParameter("@CancelRemark", order.CancelRemark),
				new SqlParameter("@Priority", order.Priority),
				new SqlParameter("@CompanyMessage", order.CompanyMessage),
				new SqlParameter("@CompMessageBy", order.CompMessageBy),
				new SqlParameter("@SupplierMessage", order.SupplierMessage),
				new SqlParameter("@SupplierMsgBy", order.SupplierMsgBy),
				new SqlParameter("@Remark", order.Remark),
				new SqlParameter("@AckBy", order.AckBy),
				new SqlParameter("@PackedBy", order.PackedBy),
				new SqlParameter("@DeliveredBy", order.DeliveredBy),
				new SqlParameter("@VerifiedBy", order.VerifiedBy),
				new SqlParameter("@CreatedBy", order.CreatedBy),
				new SqlParameter("@UpdatedBy", order.UpdatedBy),
				new SqlParameter("@CreatedDate", order.CreatedDate),
				new SqlParameter("@UpdateDate", order.UpdateDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the Order table by its primary key.
		/// </summary>
		public  int Delete(long orderID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderID", orderID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "OrderDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the Order table.
		/// </summary>
		public  Order Select(long orderID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@OrderID", orderID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeOrder(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Order table.
		/// </summary>
		public  List<Order> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "OrderSelectAll", parameters))
			{
				List<Order> orderList = new List<Order>();
				while (dataReader.Read())
				{
					Order order = MakeOrder(dataReader);
					orderList.Add(order);
				}

				return orderList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Order class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  Order MakeOrder(SqlDataReader dataReader)
		{
			Order order = new Order();
			order.OrderID = SqlClientUtility.GetInt64(dataReader, "OrderID", 0);
			order.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			order.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			order.OrderStatusID = SqlClientUtility.GetInt32(dataReader, "OrderStatusID", 0);
			order.OrderStatus = SqlClientUtility.GetString(dataReader, "OrderStatus", String.Empty);
			order.InternalStatusID = SqlClientUtility.GetInt32(dataReader, "InternalStatusID", 0);
			order.InternalStatus = SqlClientUtility.GetString(dataReader, "InternalStatus", String.Empty);
			order.OrderQR = SqlClientUtility.GetString(dataReader, "OrderQR", String.Empty);
			order.OrderNO = SqlClientUtility.GetString(dataReader, "OrderNO", String.Empty);
			order.OrgID = SqlClientUtility.GetInt32(dataReader, "OrgID", 0);
			order.OrderDateTxt = SqlClientUtility.GetString(dataReader, "OrderDateTxt", String.Empty);
			order.OrderDate = SqlClientUtility.GetDateTime(dataReader, "OrderDate", DateTime.Now);
			order.AckDateTxt = SqlClientUtility.GetString(dataReader, "AckDateTxt", String.Empty);
			order.AckDate = SqlClientUtility.GetDateTime(dataReader, "AckDate", DateTime.Now);
			order.ProcessDateTxt = SqlClientUtility.GetString(dataReader, "ProcessDateTxt", String.Empty);
			order.ProcessDate = SqlClientUtility.GetDateTime(dataReader, "ProcessDate", DateTime.Now);
			order.DeliverDateTxt = SqlClientUtility.GetString(dataReader, "DeliverDateTxt", String.Empty);
			order.DeliverDate = SqlClientUtility.GetDateTime(dataReader, "DeliverDate", DateTime.Now);
			order.PreTaxOrginalAmt = SqlClientUtility.GetDecimal(dataReader, "PreTaxOrginalAmt", Decimal.Zero);
			order.Discount = SqlClientUtility.GetDecimal(dataReader, "Discount", Decimal.Zero);
			order.TaxableOrginalAmt = SqlClientUtility.GetDecimal(dataReader, "TaxableOrginalAmt", Decimal.Zero);
			order.TaxAmt = SqlClientUtility.GetDecimal(dataReader, "TaxAmt", Decimal.Zero);
			order.BillAmt = SqlClientUtility.GetDecimal(dataReader, "BillAmt", Decimal.Zero);
			order.OtherAmt = SqlClientUtility.GetDecimal(dataReader, "OtherAmt", Decimal.Zero);
			order.CGST = SqlClientUtility.GetDecimal(dataReader, "CGST", Decimal.Zero);
			order.SGST = SqlClientUtility.GetDecimal(dataReader, "SGST", Decimal.Zero);
			order.CessAmt = SqlClientUtility.GetDecimal(dataReader, "CessAmt", Decimal.Zero);
			order.RoundOff = SqlClientUtility.GetDecimal(dataReader, "RoundOff", Decimal.Zero);
			order.NetAmt = SqlClientUtility.GetDecimal(dataReader, "NetAmt", Decimal.Zero);
			order.CancelledBy = SqlClientUtility.GetString(dataReader, "CancelledBy", String.Empty);
			order.CancelRemark = SqlClientUtility.GetString(dataReader, "CancelRemark", String.Empty);
			order.Priority = SqlClientUtility.GetString(dataReader, "Priority", String.Empty);
			order.CompanyMessage = SqlClientUtility.GetString(dataReader, "CompanyMessage", String.Empty);
			order.CompMessageBy = SqlClientUtility.GetString(dataReader, "CompMessageBy", String.Empty);
			order.SupplierMessage = SqlClientUtility.GetString(dataReader, "SupplierMessage", String.Empty);
			order.SupplierMsgBy = SqlClientUtility.GetString(dataReader, "SupplierMsgBy", String.Empty);
			order.Remark = SqlClientUtility.GetString(dataReader, "Remark", String.Empty);
			order.AckBy = SqlClientUtility.GetString(dataReader, "AckBy", String.Empty);
			order.PackedBy = SqlClientUtility.GetString(dataReader, "PackedBy", String.Empty);
			order.DeliveredBy = SqlClientUtility.GetString(dataReader, "DeliveredBy", String.Empty);
			order.VerifiedBy = SqlClientUtility.GetString(dataReader, "VerifiedBy", String.Empty);
			order.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			order.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);
			order.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			order.UpdateDate = SqlClientUtility.GetDateTime(dataReader, "UpdateDate", DateTime.Now);

			return order;
		}

		#endregion
	}
}
