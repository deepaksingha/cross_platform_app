using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class LoginUserDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public LoginUserDA()
		{
		}

		public LoginUserDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the LoginUser table.
		/// </summary>
		public  int Insert(LoginUser loginUser)
		{
			ValidationUtility.ValidateArgument("loginUser", loginUser);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", loginUser.TenantID),
				new SqlParameter("@IsActive", loginUser.IsActive),
				new SqlParameter("@CustomerTypeID", loginUser.CustomerTypeID),
				new SqlParameter("@CustomerType", loginUser.CustomerType),
				new SqlParameter("@OrgTypeID", loginUser.OrgTypeID),
				new SqlParameter("@OrgType", loginUser.OrgType),
				new SqlParameter("@OrgID", loginUser.OrgID),
				new SqlParameter("@Orgname", loginUser.Orgname),
				new SqlParameter("@RoleAccessID", loginUser.RoleAccessID),
				new SqlParameter("@RoleName", loginUser.RoleName),
				new SqlParameter("@FirstN", loginUser.FirstN),
				new SqlParameter("@MiddleN", loginUser.MiddleN),
				new SqlParameter("@LastN", loginUser.LastN),
				new SqlParameter("@UserName", loginUser.UserName),
				new SqlParameter("@Passwrd", loginUser.Passwrd),
				new SqlParameter("@DisplayN", loginUser.DisplayN),
				new SqlParameter("@Email", loginUser.Email),
				new SqlParameter("@Mobile", loginUser.Mobile),
				new SqlParameter("@PhotoFlag", loginUser.PhotoFlag),
				new SqlParameter("@Photo", loginUser.Photo),
				new SqlParameter("@PhotoPath", loginUser.PhotoPath),
				new SqlParameter("@LastLogin", loginUser.LastLogin),
				new SqlParameter("@LastPasswrdChgedDate", loginUser.LastPasswrdChgedDate),
				new SqlParameter("@SharedLogin", loginUser.SharedLogin),
				new SqlParameter("@LoginIP", loginUser.LoginIP),
				new SqlParameter("@FinanFromMonth", loginUser.FinanFromMonth),
				new SqlParameter("@FinancialYearFrom", loginUser.FinancialYearFrom),
				new SqlParameter("@FinancialToMonth", loginUser.FinancialToMonth),
				new SqlParameter("@FinancialYearTo", loginUser.FinancialYearTo),
				new SqlParameter("@BillingCounterFlag", loginUser.BillingCounterFlag),
				new SqlParameter("@BillingCounterID", loginUser.BillingCounterID),
				new SqlParameter("@PharmacyCounterFlag", loginUser.PharmacyCounterFlag),
				new SqlParameter("@PharmacyCounterID", loginUser.PharmacyCounterID),
				new SqlParameter("@OtherCounterFlag", loginUser.OtherCounterFlag),
				new SqlParameter("@OtherCounterID", loginUser.OtherCounterID),
				new SqlParameter("@BillSeriesFlag", loginUser.BillSeriesFlag),
				new SqlParameter("@PhBillSeries", loginUser.PhBillSeries),
				new SqlParameter("@LinkDoctorFlag", loginUser.LinkDoctorFlag),
				new SqlParameter("@LinkeDoctorID", loginUser.LinkeDoctorID),
				new SqlParameter("@AppLoginFlag", loginUser.AppLoginFlag),
				new SqlParameter("@AssignedWardID", loginUser.AssignedWardID),
				new SqlParameter("@AssignedWard", loginUser.AssignedWard),
				new SqlParameter("@RedirectLogin", loginUser.RedirectLogin),
				new SqlParameter("@LinkedIncLocationID", loginUser.LinkedIncLocationID),
				new SqlParameter("@LinkedIncLocation", loginUser.LinkedIncLocation),
				new SqlParameter("@LinkIncCategoryID", loginUser.LinkIncCategoryID),
				new SqlParameter("@LinkIncCategory", loginUser.LinkIncCategory),
				new SqlParameter("@LinkIncSubCategoryID", loginUser.LinkIncSubCategoryID),
				new SqlParameter("@LinkIncSubCategory", loginUser.LinkIncSubCategory),
				new SqlParameter("@FinancialKey", loginUser.FinancialKey),
				new SqlParameter("@LinkAccCustomerID", loginUser.LinkAccCustomerID),
				new SqlParameter("@LinkAccCustomerName", loginUser.LinkAccCustomerName),
				new SqlParameter("@Custom_1", loginUser.Custom_1),
				new SqlParameter("@Custom_2", loginUser.Custom_2),
				new SqlParameter("@CreatedDate", loginUser.CreatedDate),
				new SqlParameter("@UpdatedDate", loginUser.UpdatedDate),
				new SqlParameter("@CreatedBy", loginUser.CreatedBy),
				new SqlParameter("@UpdatedBy", loginUser.UpdatedBy)
			};

			loginUser.LoginID = Convert.ToInt32(SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "LoginUserInsert", parameters));
			return loginUser.LoginID;
		}

		/// <summary>
		/// Updates a record in the LoginUser table.
		/// </summary>
		public  int Update(LoginUser loginUser)
		{
			ValidationUtility.ValidateArgument("loginUser", loginUser);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@LoginID", loginUser.LoginID),
				new SqlParameter("@TenantID", loginUser.TenantID),
				new SqlParameter("@IsActive", loginUser.IsActive),
				new SqlParameter("@CustomerTypeID", loginUser.CustomerTypeID),
				new SqlParameter("@CustomerType", loginUser.CustomerType),
				new SqlParameter("@OrgTypeID", loginUser.OrgTypeID),
				new SqlParameter("@OrgType", loginUser.OrgType),
				new SqlParameter("@OrgID", loginUser.OrgID),
				new SqlParameter("@Orgname", loginUser.Orgname),
				new SqlParameter("@RoleAccessID", loginUser.RoleAccessID),
				new SqlParameter("@RoleName", loginUser.RoleName),
				new SqlParameter("@FirstN", loginUser.FirstN),
				new SqlParameter("@MiddleN", loginUser.MiddleN),
				new SqlParameter("@LastN", loginUser.LastN),
				new SqlParameter("@UserName", loginUser.UserName),
				new SqlParameter("@Passwrd", loginUser.Passwrd),
				new SqlParameter("@DisplayN", loginUser.DisplayN),
				new SqlParameter("@Email", loginUser.Email),
				new SqlParameter("@Mobile", loginUser.Mobile),
				new SqlParameter("@PhotoFlag", loginUser.PhotoFlag),
				new SqlParameter("@Photo", loginUser.Photo),
				new SqlParameter("@PhotoPath", loginUser.PhotoPath),
				new SqlParameter("@LastLogin", loginUser.LastLogin),
				new SqlParameter("@LastPasswrdChgedDate", loginUser.LastPasswrdChgedDate),
				new SqlParameter("@SharedLogin", loginUser.SharedLogin),
				new SqlParameter("@LoginIP", loginUser.LoginIP),
				new SqlParameter("@FinanFromMonth", loginUser.FinanFromMonth),
				new SqlParameter("@FinancialYearFrom", loginUser.FinancialYearFrom),
				new SqlParameter("@FinancialToMonth", loginUser.FinancialToMonth),
				new SqlParameter("@FinancialYearTo", loginUser.FinancialYearTo),
				new SqlParameter("@BillingCounterFlag", loginUser.BillingCounterFlag),
				new SqlParameter("@BillingCounterID", loginUser.BillingCounterID),
				new SqlParameter("@PharmacyCounterFlag", loginUser.PharmacyCounterFlag),
				new SqlParameter("@PharmacyCounterID", loginUser.PharmacyCounterID),
				new SqlParameter("@OtherCounterFlag", loginUser.OtherCounterFlag),
				new SqlParameter("@OtherCounterID", loginUser.OtherCounterID),
				new SqlParameter("@BillSeriesFlag", loginUser.BillSeriesFlag),
				new SqlParameter("@PhBillSeries", loginUser.PhBillSeries),
				new SqlParameter("@LinkDoctorFlag", loginUser.LinkDoctorFlag),
				new SqlParameter("@LinkeDoctorID", loginUser.LinkeDoctorID),
				new SqlParameter("@AppLoginFlag", loginUser.AppLoginFlag),
				new SqlParameter("@AssignedWardID", loginUser.AssignedWardID),
				new SqlParameter("@AssignedWard", loginUser.AssignedWard),
				new SqlParameter("@RedirectLogin", loginUser.RedirectLogin),
				new SqlParameter("@LinkedIncLocationID", loginUser.LinkedIncLocationID),
				new SqlParameter("@LinkedIncLocation", loginUser.LinkedIncLocation),
				new SqlParameter("@LinkIncCategoryID", loginUser.LinkIncCategoryID),
				new SqlParameter("@LinkIncCategory", loginUser.LinkIncCategory),
				new SqlParameter("@LinkIncSubCategoryID", loginUser.LinkIncSubCategoryID),
				new SqlParameter("@LinkIncSubCategory", loginUser.LinkIncSubCategory),
				new SqlParameter("@FinancialKey", loginUser.FinancialKey),
				new SqlParameter("@LinkAccCustomerID", loginUser.LinkAccCustomerID),
				new SqlParameter("@LinkAccCustomerName", loginUser.LinkAccCustomerName),
				new SqlParameter("@Custom_1", loginUser.Custom_1),
				new SqlParameter("@Custom_2", loginUser.Custom_2),
				new SqlParameter("@CreatedDate", loginUser.CreatedDate),
				new SqlParameter("@UpdatedDate", loginUser.UpdatedDate),
				new SqlParameter("@CreatedBy", loginUser.CreatedBy),
				new SqlParameter("@UpdatedBy", loginUser.UpdatedBy)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "LoginUserUpdate", parameters));
		}

		/// <summary>
		/// Deletes a record from the LoginUser table by its primary key.
		/// </summary>
		public  int Delete(int loginID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@LoginID", loginID)
,				new SqlParameter("@TenantID", tenantID)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "LoginUserDelete", parameters));
		}

		/// <summary>
		/// Selects a single record from the LoginUser table.
		/// </summary>
		public  LoginUser Select(int loginID, int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@LoginID", loginID)
,				new SqlParameter("@TenantID", tenantID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "LoginUserSelect", parameters))
			{
				if (dataReader.Read())
				{
					return MakeLoginUser(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the LoginUser table.
		/// </summary>
		public  List<LoginUser> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "LoginUserSelectAll", parameters))
			{
				List<LoginUser> loginUserList = new List<LoginUser>();
				while (dataReader.Read())
				{
					LoginUser loginUser = MakeLoginUser(dataReader);
					loginUserList.Add(loginUser);
				}

				return loginUserList;
			}
		}

		/// <summary>
		/// Creates a new instance of the LoginUser class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  LoginUser MakeLoginUser(SqlDataReader dataReader)
		{
			LoginUser loginUser = new LoginUser();
			loginUser.LoginID = SqlClientUtility.GetInt32(dataReader, "LoginID", 0);
			loginUser.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			loginUser.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			loginUser.CustomerTypeID = SqlClientUtility.GetInt32(dataReader, "CustomerTypeID", 0);
			loginUser.CustomerType = SqlClientUtility.GetString(dataReader, "CustomerType", String.Empty);
			loginUser.OrgTypeID = SqlClientUtility.GetInt32(dataReader, "OrgTypeID", 0);
			loginUser.OrgType = SqlClientUtility.GetString(dataReader, "OrgType", String.Empty);
			loginUser.OrgID = SqlClientUtility.GetInt32(dataReader, "OrgID", 0);
			loginUser.Orgname = SqlClientUtility.GetString(dataReader, "Orgname", String.Empty);
			loginUser.RoleAccessID = SqlClientUtility.GetInt32(dataReader, "RoleAccessID", 0);
			loginUser.RoleName = SqlClientUtility.GetString(dataReader, "RoleName", String.Empty);
			loginUser.FirstN = SqlClientUtility.GetString(dataReader, "FirstN", String.Empty);
			loginUser.MiddleN = SqlClientUtility.GetString(dataReader, "MiddleN", String.Empty);
			loginUser.LastN = SqlClientUtility.GetString(dataReader, "LastN", String.Empty);
			loginUser.UserName = SqlClientUtility.GetString(dataReader, "UserName", String.Empty);
			loginUser.Passwrd = SqlClientUtility.GetString(dataReader, "Passwrd", String.Empty);
			loginUser.DisplayN = SqlClientUtility.GetString(dataReader, "DisplayN", String.Empty);
			loginUser.Email = SqlClientUtility.GetString(dataReader, "Email", String.Empty);
			loginUser.Mobile = SqlClientUtility.GetString(dataReader, "Mobile", String.Empty);
			loginUser.PhotoFlag = SqlClientUtility.GetString(dataReader, "PhotoFlag", String.Empty);
			loginUser.Photo = SqlClientUtility.GetString(dataReader, "Photo", String.Empty);
			loginUser.PhotoPath = SqlClientUtility.GetString(dataReader, "PhotoPath", String.Empty);
			loginUser.LastLogin = SqlClientUtility.GetDateTime(dataReader, "LastLogin", DateTime.Now);
			loginUser.LastPasswrdChgedDate = SqlClientUtility.GetDateTime(dataReader, "LastPasswrdChgedDate", DateTime.Now);
			loginUser.SharedLogin = SqlClientUtility.GetString(dataReader, "SharedLogin", String.Empty);
			loginUser.LoginIP = SqlClientUtility.GetString(dataReader, "LoginIP", String.Empty);
			loginUser.FinanFromMonth = SqlClientUtility.GetInt32(dataReader, "FinanFromMonth", 0);
			loginUser.FinancialYearFrom = SqlClientUtility.GetInt32(dataReader, "FinancialYearFrom", 0);
			loginUser.FinancialToMonth = SqlClientUtility.GetInt32(dataReader, "FinancialToMonth", 0);
			loginUser.FinancialYearTo = SqlClientUtility.GetInt32(dataReader, "FinancialYearTo", 0);
			loginUser.BillingCounterFlag = SqlClientUtility.GetString(dataReader, "BillingCounterFlag", String.Empty);
			loginUser.BillingCounterID = SqlClientUtility.GetString(dataReader, "BillingCounterID", String.Empty);
			loginUser.PharmacyCounterFlag = SqlClientUtility.GetString(dataReader, "PharmacyCounterFlag", String.Empty);
			loginUser.PharmacyCounterID = SqlClientUtility.GetString(dataReader, "PharmacyCounterID", String.Empty);
			loginUser.OtherCounterFlag = SqlClientUtility.GetString(dataReader, "OtherCounterFlag", String.Empty);
			loginUser.OtherCounterID = SqlClientUtility.GetString(dataReader, "OtherCounterID", String.Empty);
			loginUser.BillSeriesFlag = SqlClientUtility.GetString(dataReader, "BillSeriesFlag", String.Empty);
			loginUser.PhBillSeries = SqlClientUtility.GetString(dataReader, "PhBillSeries", String.Empty);
			loginUser.LinkDoctorFlag = SqlClientUtility.GetString(dataReader, "LinkDoctorFlag", String.Empty);
			loginUser.LinkeDoctorID = SqlClientUtility.GetInt32(dataReader, "LinkeDoctorID", 0);
			loginUser.AppLoginFlag = SqlClientUtility.GetString(dataReader, "AppLoginFlag", String.Empty);
			loginUser.AssignedWardID = SqlClientUtility.GetInt32(dataReader, "AssignedWardID", 0);
			loginUser.AssignedWard = SqlClientUtility.GetString(dataReader, "AssignedWard", String.Empty);
			loginUser.RedirectLogin = SqlClientUtility.GetString(dataReader, "RedirectLogin", String.Empty);
			loginUser.LinkedIncLocationID = SqlClientUtility.GetInt32(dataReader, "LinkedIncLocationID", 0);
			loginUser.LinkedIncLocation = SqlClientUtility.GetString(dataReader, "LinkedIncLocation", String.Empty);
			loginUser.LinkIncCategoryID = SqlClientUtility.GetInt32(dataReader, "LinkIncCategoryID", 0);
			loginUser.LinkIncCategory = SqlClientUtility.GetString(dataReader, "LinkIncCategory", String.Empty);
			loginUser.LinkIncSubCategoryID = SqlClientUtility.GetInt32(dataReader, "LinkIncSubCategoryID", 0);
			loginUser.LinkIncSubCategory = SqlClientUtility.GetString(dataReader, "LinkIncSubCategory", String.Empty);
			loginUser.FinancialKey = SqlClientUtility.GetString(dataReader, "FinancialKey", String.Empty);
			loginUser.LinkAccCustomerID = SqlClientUtility.GetInt32(dataReader, "LinkAccCustomerID", 0);
			loginUser.LinkAccCustomerName = SqlClientUtility.GetString(dataReader, "LinkAccCustomerName", String.Empty);
			loginUser.Custom_1 = SqlClientUtility.GetString(dataReader, "Custom_1", String.Empty);
			loginUser.Custom_2 = SqlClientUtility.GetString(dataReader, "Custom_2", String.Empty);
			loginUser.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			loginUser.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);
			loginUser.CreatedBy = SqlClientUtility.GetString(dataReader, "CreatedBy", String.Empty);
			loginUser.UpdatedBy = SqlClientUtility.GetString(dataReader, "UpdatedBy", String.Empty);

			return loginUser;
		}

		#endregion
	}
}
