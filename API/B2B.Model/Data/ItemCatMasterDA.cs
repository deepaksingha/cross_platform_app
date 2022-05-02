using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class ItemCatMasterDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public ItemCatMasterDA()
		{
		}

		public ItemCatMasterDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the ItemCatMaster table.
		/// </summary>
		public  int Insert(ItemCatMaster itemCatMaster)
		{
			ValidationUtility.ValidateArgument("itemCatMaster", itemCatMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", itemCatMaster.TenantID),
				new SqlParameter("@IsActive", itemCatMaster.IsActive),
				new SqlParameter("@CategoryName", itemCatMaster.CategoryName),
				new SqlParameter("@StoreType", itemCatMaster.StoreType),
				new SqlParameter("@IssueTypeCode", itemCatMaster.IssueTypeCode),
				new SqlParameter("@IssueTypeName", itemCatMaster.IssueTypeName),
				new SqlParameter("@Retailable", itemCatMaster.Retailable),
				new SqlParameter("@ExpiryFlag", itemCatMaster.ExpiryFlag),
				new SqlParameter("@DiscountFlag", itemCatMaster.DiscountFlag),
				new SqlParameter("@IdentificationType", itemCatMaster.IdentificationType),
				new SqlParameter("@Identification", itemCatMaster.Identification),
				new SqlParameter("@CreatedDate", itemCatMaster.CreatedDate),
				new SqlParameter("@UpdatedDate", itemCatMaster.UpdatedDate),
				new SqlParameter("@CreatedBy", itemCatMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", itemCatMaster.UpdatedBy)
			};

			itemCatMaster.ItemCatID = Convert.ToInt32(SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "ItemCatMasterInsert", parameters));
			return itemCatMaster.ItemCatID;
		}

		/// <summary>
		/// Updates a record in the ItemCatMaster table.
		/// </summary>
		public  int Update(ItemCatMaster itemCatMaster)
		{
			ValidationUtility.ValidateArgument("itemCatMaster", itemCatMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemCatID", itemCatMaster.ItemCatID),
				new SqlParameter("@TenantID", itemCatMaster.TenantID),
				new SqlParameter("@IsActive", itemCatMaster.IsActive),
				new SqlParameter("@CategoryName", itemCatMaster.CategoryName),
				new SqlParameter("@StoreType", itemCatMaster.StoreType),
				new SqlParameter("@IssueTypeCode", itemCatMaster.IssueTypeCode),
				new SqlParameter("@IssueTypeName", itemCatMaster.IssueTypeName),
				new SqlParameter("@Retailable", itemCatMaster.Retailable),
				new SqlParameter("@ExpiryFlag", itemCatMaster.ExpiryFlag),
				new SqlParameter("@DiscountFlag", itemCatMaster.DiscountFlag),
				new SqlParameter("@IdentificationType", itemCatMaster.IdentificationType),
				new SqlParameter("@Identification", itemCatMaster.Identification),
				new SqlParameter("@CreatedDate", itemCatMaster.CreatedDate),
				new SqlParameter("@UpdatedDate", itemCatMaster.UpdatedDate),
				new SqlParameter("@CreatedBy", itemCatMaster.CreatedBy),
				new SqlParameter("@UpdatedBy", itemCatMaster.UpdatedBy)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ItemCatMasterUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the ItemCatMaster table by its primary key.
		/// </summary>
		public  int Delete(int itemCatID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemCatID", itemCatID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ItemCatMasterDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the ItemCatMaster table.
		/// </summary>
		public  ItemCatMaster Select(int itemCatID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ItemCatID", itemCatID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ItemCatMasterSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeItemCatMaster(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the ItemCatMaster table.
		/// </summary>
		public  List<ItemCatMaster> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ItemCatMasterSelectAll", parameters))
			{
				List<ItemCatMaster> itemCatMasterList = new List<ItemCatMaster>();
				while (dataReader.Read())
				{
					ItemCatMaster itemCatMaster = MakeItemCatMaster(dataReader);
					itemCatMasterList.Add(itemCatMaster);
				}

				return itemCatMasterList;
			}
		}

		/// <summary>
		/// Creates a new instance of the ItemCatMaster class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  ItemCatMaster MakeItemCatMaster(SqlDataReader dataReader)
		{
			ItemCatMaster itemCatMaster = new ItemCatMaster();
			itemCatMaster.ItemCatID = SqlClientUtility.GetInt32(dataReader, "ItemCatID", 0);
			itemCatMaster.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			itemCatMaster.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			itemCatMaster.CategoryName = SqlClientUtility.GetString(dataReader, "CategoryName", String.Empty);
			itemCatMaster.StoreType = SqlClientUtility.GetString(dataReader, "StoreType", String.Empty);
			itemCatMaster.IssueTypeCode = SqlClientUtility.GetString(dataReader, "IssueTypeCode", String.Empty);
			itemCatMaster.IssueTypeName = SqlClientUtility.GetString(dataReader, "IssueTypeName", String.Empty);
			itemCatMaster.Retailable = SqlClientUtility.GetString(dataReader, "Retailable", String.Empty);
			itemCatMaster.ExpiryFlag = SqlClientUtility.GetString(dataReader, "ExpiryFlag", String.Empty);
			itemCatMaster.DiscountFlag = SqlClientUtility.GetString(dataReader, "DiscountFlag", String.Empty);
			itemCatMaster.IdentificationType = SqlClientUtility.GetString(dataReader, "IdentificationType", String.Empty);
			itemCatMaster.Identification = SqlClientUtility.GetString(dataReader, "Identification", String.Empty);
			itemCatMaster.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			itemCatMaster.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);
			itemCatMaster.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			itemCatMaster.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);

			return itemCatMaster;
		}

		#endregion
	}
}
