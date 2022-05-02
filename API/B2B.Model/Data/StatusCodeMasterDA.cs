using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

namespace B2B.Model.DA
{
	public class StatusCodeMasterDA
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors
		public StatusCodeMasterDA()
		{
		}

		public StatusCodeMasterDA(string connectionStringName)
		{
			ValidationUtility.ValidateArgument("connectionStringName", connectionStringName);

			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the StatusCodeMaster table.
		/// </summary>
		public  int Insert(StatusCodeMaster statusCodeMaster)
		{
			ValidationUtility.ValidateArgument("statusCodeMaster", statusCodeMaster);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@StatusID", statusCodeMaster.StatusID),
				new SqlParameter("@TenantID", statusCodeMaster.TenantID),
				new SqlParameter("@StatusCode", statusCodeMaster.StatusCode),
				new SqlParameter("@StatusShortName", statusCodeMaster.StatusShortName),
				new SqlParameter("@StatusLongName", statusCodeMaster.StatusLongName),
				new SqlParameter("@IsActive", statusCodeMaster.IsActive),
				new SqlParameter("@Process", statusCodeMaster.Process),
				new SqlParameter("@SubProcess", statusCodeMaster.SubProcess),
				new SqlParameter("@SubSubPro", statusCodeMaster.SubSubPro),
				new SqlParameter("@CreatedDate", statusCodeMaster.CreatedDate),
				new SqlParameter("@UpdatedDate", statusCodeMaster.UpdatedDate)
			};

			return(SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "StatusCodeMasterInsert", parameters));
		}

		/// <summary>
		/// Selects all records from the StatusCodeMaster table.
		/// </summary>
		public  List<StatusCodeMaster> SelectAll(int tenantID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenantID", tenantID)
			};
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "StatusCodeMasterSelectAll", parameters))
			{
				List<StatusCodeMaster> statusCodeMasterList = new List<StatusCodeMaster>();
				while (dataReader.Read())
				{
					StatusCodeMaster statusCodeMaster = MakeStatusCodeMaster(dataReader);
					statusCodeMasterList.Add(statusCodeMaster);
				}

				return statusCodeMasterList;
			}
		}

		/// <summary>
		/// Creates a new instance of the StatusCodeMaster class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected  StatusCodeMaster MakeStatusCodeMaster(SqlDataReader dataReader)
		{
			StatusCodeMaster statusCodeMaster = new StatusCodeMaster();
			statusCodeMaster.StatusID = SqlClientUtility.GetInt32(dataReader, "StatusID", 0);
			statusCodeMaster.TenantID = SqlClientUtility.GetInt32(dataReader, "TenantID", 0);
			statusCodeMaster.StatusCode = SqlClientUtility.GetString(dataReader, "StatusCode", String.Empty);
			statusCodeMaster.StatusShortName = SqlClientUtility.GetString(dataReader, "StatusShortName", String.Empty);
			statusCodeMaster.StatusLongName = SqlClientUtility.GetString(dataReader, "StatusLongName", String.Empty);
			statusCodeMaster.IsActive = SqlClientUtility.GetString(dataReader, "IsActive", String.Empty);
			statusCodeMaster.Process = SqlClientUtility.GetString(dataReader, "Process", String.Empty);
			statusCodeMaster.SubProcess = SqlClientUtility.GetString(dataReader, "SubProcess", String.Empty);
			statusCodeMaster.SubSubPro = SqlClientUtility.GetString(dataReader, "SubSubPro", String.Empty);
			statusCodeMaster.CreatedDate = SqlClientUtility.GetDateTime(dataReader, "CreatedDate", DateTime.Now);
			statusCodeMaster.UpdatedDate = SqlClientUtility.GetDateTime(dataReader, "UpdatedDate", DateTime.Now);

			return statusCodeMaster;
		}

		#endregion
	}
}
