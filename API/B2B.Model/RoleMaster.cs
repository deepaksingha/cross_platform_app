using System;

namespace B2B.Model
{
	[Serializable]
	public class RoleMaster : BizObject
	{
		#region Fields

		private int roleID;
		private int tenantID;
		private string isActive;
		private string roleCode;
		private string roleName;
		private string roleRemark;
		private DateTime createdDate;
		private DateTime updatedDate;
		private string createdBy;
		private string updatedBy;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RoleMaster class.
		/// </summary>
		public RoleMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the RoleMaster class.
		/// </summary>
		public RoleMaster(int roleID, int tenantID, string isActive, string roleCode, string roleName, string roleRemark, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.roleID = roleID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.roleCode = roleCode;
			this.roleName = roleName;
			this.roleRemark = roleRemark;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public  int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public  string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the RoleCode value.
		/// </summary>
		public  string RoleCode
		{
			get { return roleCode; }
			set { roleCode = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		public  string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleRemark value.
		/// </summary>
		public  string RoleRemark
		{
			get { return roleRemark; }
			set { roleRemark = value; }
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

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public  string CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the UpdatedBy value.
		/// </summary>
		public  string UpdatedBy
		{
			get { return updatedBy; }
			set { updatedBy = value; }
		}

		#endregion
	}
}
