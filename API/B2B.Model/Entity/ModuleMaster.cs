using System;

namespace B2B.Model
{
	[Serializable]
	public class ModuleMaster : BizObject
	{
		#region Fields

		private int moduleID;
		private int tenantID;
		private string isActive;
		private int parentMenuID;
		private string moduleName;
		private string menuUrl;
		private string cusName;
		private string homeIconFlag;
		private string imageURL;
		private string imageHeight;
		private string version;
		private int displayOrder;
		private int homeIconDispOrder;
		private int childIconDisplayOrder;
		private DateTime createdDate;
		private DateTime updatedDate;
		private string createdBy;
		private string updatedBy;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModuleMaster class.
		/// </summary>
		public ModuleMaster()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ModuleMaster class.
		/// </summary>
		public ModuleMaster(int moduleID, int tenantID, string isActive, int parentMenuID, string moduleName, string menuUrl, string cusName, string homeIconFlag, string imageURL, string imageHeight, string version, int displayOrder, int homeIconDispOrder, int childIconDisplayOrder, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy)
		{
			this.moduleID = moduleID;
			this.tenantID = tenantID;
			this.isActive = isActive;
			this.parentMenuID = parentMenuID;
			this.moduleName = moduleName;
			this.menuUrl = menuUrl;
			this.cusName = cusName;
			this.homeIconFlag = homeIconFlag;
			this.imageURL = imageURL;
			this.imageHeight = imageHeight;
			this.version = version;
			this.displayOrder = displayOrder;
			this.homeIconDispOrder = homeIconDispOrder;
			this.childIconDisplayOrder = childIconDisplayOrder;
			this.createdDate = createdDate;
			this.updatedDate = updatedDate;
			this.createdBy = createdBy;
			this.updatedBy = updatedBy;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModuleID value.
		/// </summary>
		public  int ModuleID
		{
			get { return moduleID; }
			set { moduleID = value; }
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
		/// Gets or sets the ParentMenuID value.
		/// </summary>
		public  int ParentMenuID
		{
			get { return parentMenuID; }
			set { parentMenuID = value; }
		}

		/// <summary>
		/// Gets or sets the ModuleName value.
		/// </summary>
		public  string ModuleName
		{
			get { return moduleName; }
			set { moduleName = value; }
		}

		/// <summary>
		/// Gets or sets the MenuUrl value.
		/// </summary>
		public  string MenuUrl
		{
			get { return menuUrl; }
			set { menuUrl = value; }
		}

		/// <summary>
		/// Gets or sets the CusName value.
		/// </summary>
		public  string CusName
		{
			get { return cusName; }
			set { cusName = value; }
		}

		/// <summary>
		/// Gets or sets the HomeIconFlag value.
		/// </summary>
		public  string HomeIconFlag
		{
			get { return homeIconFlag; }
			set { homeIconFlag = value; }
		}

		/// <summary>
		/// Gets or sets the ImageURL value.
		/// </summary>
		public  string ImageURL
		{
			get { return imageURL; }
			set { imageURL = value; }
		}

		/// <summary>
		/// Gets or sets the ImageHeight value.
		/// </summary>
		public  string ImageHeight
		{
			get { return imageHeight; }
			set { imageHeight = value; }
		}

		/// <summary>
		/// Gets or sets the Version value.
		/// </summary>
		public  string Version
		{
			get { return version; }
			set { version = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayOrder value.
		/// </summary>
		public  int DisplayOrder
		{
			get { return displayOrder; }
			set { displayOrder = value; }
		}

		/// <summary>
		/// Gets or sets the HomeIconDispOrder value.
		/// </summary>
		public  int HomeIconDispOrder
		{
			get { return homeIconDispOrder; }
			set { homeIconDispOrder = value; }
		}

		/// <summary>
		/// Gets or sets the ChildIconDisplayOrder value.
		/// </summary>
		public  int ChildIconDisplayOrder
		{
			get { return childIconDisplayOrder; }
			set { childIconDisplayOrder = value; }
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
