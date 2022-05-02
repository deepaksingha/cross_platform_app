using System;

namespace B2B.Model
{
	[Serializable]
	public class StatusCodeMaster : BizObject
	{
		#region Fields

		private int statusID;
		private int tenantID;
		private string statusCode;
		private string statusShortName;
		private string statusLongName;
		private string isActive;
		private string process;
		private string subProcess;
		private string subSubPro;
		private DateTime createdDate;
		private DateTime updatedDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StatusCodeMaster class.
		/// </summary>
		public StatusCodeMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the StatusCodeMaster class.
		/// </summary>
		public StatusCodeMaster(int statusID, int tenantID, string statusCode, string statusShortName, string statusLongName, string isActive, string process, string subProcess, string subSubPro, DateTime createdDate, DateTime updatedDate)
		{
			this.statusID = statusID;
			this.tenantID = tenantID;
			this.statusCode = statusCode;
			this.statusShortName = statusShortName;
			this.statusLongName = statusLongName;
			this.isActive = isActive;
			this.process = process;
			this.subProcess = subProcess;
			this.subSubPro = subSubPro;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public  int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the TenantID value.
		/// </summary>
		public  int TenantID
		{
			get { return tenantID; }
			set { tenantID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusCode value.
		/// </summary>
		public  string StatusCode
		{
			get { return statusCode; }
			set { statusCode = value; }
		}

		/// <summary>
		/// Gets or sets the StatusShortName value.
		/// </summary>
		public  string StatusShortName
		{
			get { return statusShortName; }
			set { statusShortName = value; }
		}

		/// <summary>
		/// Gets or sets the StatusLongName value.
		/// </summary>
		public  string StatusLongName
		{
			get { return statusLongName; }
			set { statusLongName = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public  string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Process value.
		/// </summary>
		public  string Process
		{
			get { return process; }
			set { process = value; }
		}

		/// <summary>
		/// Gets or sets the SubProcess value.
		/// </summary>
		public  string SubProcess
		{
			get { return subProcess; }
			set { subProcess = value; }
		}

		/// <summary>
		/// Gets or sets the SubSubPro value.
		/// </summary>
		public  string SubSubPro
		{
			get { return subSubPro; }
			set { subSubPro = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		public  DateTime CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}

		/// <summary>
		/// Gets or sets the UpdatedDate value.
		/// </summary>
		public  DateTime UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}

		#endregion
	}
}
