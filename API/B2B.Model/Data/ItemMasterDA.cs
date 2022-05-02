using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class ItemMasterDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public ItemMasterDA()
		{
		}

		public ItemMasterDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the ItemMaster table.
		/// </summary>
		public  int Insert(ItemMaster itemMaster)
		{
			ValidationUtility.ValidateArgument("itemMaster", itemMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemID", itemMaster.ItemID),
				new SqlParameter("@TenantID", itemMaster.TenantID),
				new SqlParameter("@IsActive", itemMaster.IsActive),
				new SqlParameter("@OrgID", itemMaster.OrgID),
				new SqlParameter("@ItemName", itemMaster.ItemName),
				new SqlParameter("@ItemCode", itemMaster.ItemCode),
				new SqlParameter("@HSN", itemMaster.HSN),
				new SqlParameter("@ItemCatID", itemMaster.ItemCatID),
				new SqlParameter("@CategoryName", itemMaster.CategoryName),
				new SqlParameter("@UOM", itemMaster.UOM),
				new SqlParameter("@PackSize", itemMaster.PackSize),
				new SqlParameter("@ItemRate", itemMaster.ItemRate),
				new SqlParameter("@ItemMRP", itemMaster.ItemMRP),
				new SqlParameter("@CostPrice", itemMaster.CostPrice),
				new SqlParameter("@GST", itemMaster.GST),
				new SqlParameter("@OutofStcok", itemMaster.OutofStcok),
				new SqlParameter("@ItemImageFlag", itemMaster.ItemImageFlag),
				new SqlParameter("@ItemImage_1", itemMaster.ItemImage_1),
				new SqlParameter("@ItemImagePath_1", itemMaster.ItemImagePath_1),
				new SqlParameter("@ItemImage_2", itemMaster.ItemImage_2),
				new SqlParameter("@ItemImagePath_2", itemMaster.ItemImagePath_2),
				new SqlParameter("@ItemImage_3", itemMaster.ItemImage_3),
				new SqlParameter("@ItemImagePath_3", itemMaster.ItemImagePath_3),
				new SqlParameter("@Remark", itemMaster.Remark),
				new SqlParameter("@CreatedBy", itemMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", itemMaster.UpdatedBy),
				new SqlParameter("@CreatedDate", itemMaster.CreatedDate),
				new SqlParameter("@UpdateDate", itemMaster.UpdateDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ItemMasterInsert", parameters));
		}

		/// <summary>
		/// Updates a record in the ItemMaster table.
		/// </summary>
		public  int Update(ItemMaster itemMaster)
		{
			ValidationUtility.ValidateArgument("itemMaster", itemMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemID", itemMaster.ItemID),
				new SqlParameter("@TenantID", itemMaster.TenantID),
				new SqlParameter("@IsActive", itemMaster.IsActive),
				new SqlParameter("@OrgID", itemMaster.OrgID),
				new SqlParameter("@ItemName", itemMaster.ItemName),
				new SqlParameter("@ItemCode", itemMaster.ItemCode),
				new SqlParameter("@HSN", itemMaster.HSN),
				new SqlParameter("@ItemCatID", itemMaster.ItemCatID),
				new SqlParameter("@CategoryName", itemMaster.CategoryName),
				new SqlParameter("@UOM", itemMaster.UOM),
				new SqlParameter("@PackSize", itemMaster.PackSize),
				new SqlParameter("@ItemRate", itemMaster.ItemRate),
				new SqlParameter("@ItemMRP", itemMaster.ItemMRP),
				new SqlParameter("@CostPrice", itemMaster.CostPrice),
				new SqlParameter("@GST", itemMaster.GST),
				new SqlParameter("@OutofStcok", itemMaster.OutofStcok),
				new SqlParameter("@ItemImageFlag", itemMaster.ItemImageFlag),
				new SqlParameter("@ItemImage_1", itemMaster.ItemImage_1),
				new SqlParameter("@ItemImagePath_1", itemMaster.ItemImagePath_1),
				new SqlParameter("@ItemImage_2", itemMaster.ItemImage_2),
				new SqlParameter("@ItemImagePath_2", itemMaster.ItemImagePath_2),
				new SqlParameter("@ItemImage_3", itemMaster.ItemImage_3),
				new SqlParameter("@ItemImagePath_3", itemMaster.ItemImagePath_3),
				new SqlParameter("@Remark", itemMaster.Remark),
				new SqlParameter("@CreatedBy", itemMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", itemMaster.UpdatedBy),
				new SqlParameter("@CreatedDate", itemMaster.CreatedDate),
				new SqlParameter("@UpdateDate", itemMaster.UpdateDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ItemMasterUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the ItemMaster table by its primary key.
		/// </summary>
		public  int Delete(int itemID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemID", itemID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ItemMasterDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the ItemMaster table.
		/// </summary>
		public  ItemMaster Select(int itemID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemID", itemID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ItemMasterSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeItemMaster(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the ItemMaster table.
		/// </summary>
		public  List<ItemMaster> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ItemMasterSelectAll", parameters))
			{
				List<ItemMaster> itemMasterList = new List<ItemMaster>();
				while (dataReader.Read())
				{
					ItemMaster itemMaster = MakeItemMaster(dataReader);
					itemMasterList.Add(itemMaster);
				}

				return itemMasterList;
			}
		}

		/// <summary>
		/// Creates a new instance of the ItemMaster class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  ItemMaster MakeItemMaster(SqlDataReader dataReader)
		{
			ItemMaster itemMaster = new ItemMaster();
			itemMaster.ItemID = SqlClientUtility.GetInt32(dataReader, "ItemID", 0);
			itemMaster.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			itemMaster.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			itemMaster.OrgID = SqlClientUtility.GetInt32(dataReader, "OrgID", 0);
			itemMaster.ItemName = SqlClientUtility.GetString(dataReader, "ItemName", String.Empty);
			itemMaster.ItemCode = SqlClientUtility.GetString(dataReader, "ItemCode", String.Empty);
			itemMaster.HSN = SqlClientUtility.GetString(dataReader, "HSN", String.Empty);
			itemMaster.ItemCatID = SqlClientUtility.GetInt32(dataReader, "ItemCatID", 0);
			itemMaster.CategoryName = SqlClientUtility.GetString(dataReader, "CategoryName", String.Empty);
			itemMaster.UOM = SqlClientUtility.GetString(dataReader, "UOM", String.Empty);
			itemMaster.PackSize = SqlClientUtility.GetInt32(dataReader, "PackSize", 0);
			itemMaster.ItemRate = SqlClientUtility.GetDecimal(dataReader, "ItemRate", Decimal.Zero);
			itemMaster.ItemMRP = SqlClientUtility.GetDecimal(dataReader, "ItemMRP", Decimal.Zero);
			itemMaster.CostPrice = SqlClientUtility.GetDecimal(dataReader, "CostPrice", Decimal.Zero);
			itemMaster.GST = SqlClientUtility.GetDecimal(dataReader, "GST", Decimal.Zero);
			itemMaster.OutofStcok = SqlClientUtility.GetString(dataReader, "OutofStcok", String.Empty);
			itemMaster.ItemImageFlag = SqlClientUtility.GetString(dataReader, "ItemImageFlag", String.Empty);
			itemMaster.ItemImage_1 = SqlClientUtility.GetString(dataReader, "ItemImage_1", String.Empty);
			itemMaster.ItemImagePath_1 = SqlClientUtility.GetString(dataReader, "ItemImagePath_1", String.Empty);
			itemMaster.ItemImage_2 = SqlClientUtility.GetString(dataReader, "ItemImage_2", String.Empty);
			itemMaster.ItemImagePath_2 = SqlClientUtility.GetString(dataReader, "ItemImagePath_2", String.Empty);
			itemMaster.ItemImage_3 = SqlClientUtility.GetString(dataReader, "ItemImage_3", String.Empty);
			itemMaster.ItemImagePath_3 = SqlClientUtility.GetString(dataReader, "ItemImagePath_3", String.Empty);
			itemMaster.Remark = SqlClientUtility.GetString(dataReader, "Remark", String.Empty);
			itemMaster.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			itemMaster.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);
			itemMaster.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			itemMaster.UpdateDate = SqlClientUtility.GetDateTime(dataReader, "UpdateDate", DateTime.Now);

			return itemMaster;
		}

		#endregion
	}
}
