SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemMaster](
	[ItemID] [int] NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[OrgID] [int] NULL,
	[ItemName] [nvarchar](150) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[HSN] [nvarchar](50) NULL,
	[ItemCatID] [int] NOT NULL,
	[CategoryName] [nvarchar](150) NULL,
	[UOM] [nvarchar](50) NULL,
	[PackSize] [int] NULL,
	[ItemRate] [numeric](18, 2) NULL,
	[ItemMRP] [numeric](18, 2) NULL,
	[CostPrice] [numeric](18, 2) NULL,
	[GST] [numeric](18, 2) NULL,
	[OutofStcok] [nchar](1) NULL,
	[ItemImageFlag] [nchar](1) NULL,
	[ItemImage_1] [nvarchar](750) NULL,
	[ItemImagePath_1] [nvarchar](750) NULL,
	[ItemImage_2] [nvarchar](750) NULL,
	[ItemImagePath_2] [nvarchar](750) NULL,
	[ItemImage_3] [nvarchar](750) NULL,
	[ItemImagePath_3] [nvarchar](750) NULL,
	[Remark] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ItemMaster] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganisationMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrganisationMaster](
	[OrgID] [int] IDENTITY(1,1) NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[OrgTypeID] [int] NULL,
	[OrgType] [nvarchar](50) NULL,
	[CustomerTypeID] [int] NULL,
	[CustomerType] [nvarchar](50) NULL,
	[OrgName] [nvarchar](250) NULL,
	[OrgCode] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[EntityAddress_1] [nvarchar](150) NULL,
	[EntityAddress_2] [nvarchar](150) NULL,
	[EntityAddress_3] [nvarchar](150) NULL,
	[EntityAddress_4] [nvarchar](150) NULL,
	[EntityAddress_5] [nvarchar](150) NULL,
	[EntityMobile_1] [nvarchar](50) NULL,
	[EntityMobile_2] [nvarchar](50) NULL,
	[EntityLanline_1] [nvarchar](50) NULL,
	[EntityLanline_2] [nvarchar](50) NULL,
	[LogoFlag] [nchar](1) NULL,
	[OrgLogo] [nvarchar](250) NULL,
	[TIN] [nvarchar](50) NULL,
	[PAN] [nvarchar](50) NULL,
	[GST] [nvarchar](50) NULL,
	[RegNPrefix] [nvarchar](50) NULL,
	[MoneyRecPrefix] [nvarchar](50) NULL,
	[BillRefPrefix] [nvarchar](50) NULL,
	[CreditLimit] [decimal](18, 2) NULL,
	[OpeningBal] [decimal](18, 2) NULL,
	[ClosingBal] [decimal](18, 2) NULL,
	[Website] [nvarchar](50) NULL,
	[Custom_1] [nvarchar](50) NULL,
	[Custom_2] [nvarchar](50) NULL,
	[Custom_3] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_OrganisationMaster] PRIMARY KEY CLUSTERED 
(
	[OrgID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemCatMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemCatMaster](
	[ItemCatID] [int] IDENTITY(1,1) NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[CategoryName] [nvarchar](150) NULL,
	[StoreType] [nchar](1) NULL,
	[IssueTypeCode] [nchar](1) NULL,
	[IssueTypeName] [nvarchar](250) NULL,
	[Retailable] [nchar](1) NULL,
	[ExpiryFlag] [nchar](1) NULL,
	[DiscountFlag] [nchar](1) NULL,
	[IdentificationType] [nchar](1) NULL,
	[Identification] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) NULL,
	[UpdatedBy] [nvarchar](250) NULL,
 CONSTRAINT [PK_ItemCatMaster] PRIMARY KEY CLUSTERED 
(
	[ItemCatID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleMaster](
	[RoleID] [int] NOT NULL,
	[TenantID] [int] NOT NULL,
	[IsActive] [nchar](1) NOT NULL,
	[RoleCode] [nvarchar](50) NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[RoleRemark] [nvarchar](750) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) NULL,
	[UpdatedBy] [nvarchar](250) NULL,
 CONSTRAINT [PK_RoleMaster] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tenant]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tenant](
	[TenantID] [int] NOT NULL,
	[TenantCode] [nvarchar](1000) NULL,
	[TenantName] [nvarchar](250) NOT NULL,
	[ShortName] [nvarchar](50) NULL,
	[PAN] [nvarchar](50) NOT NULL,
	[TIN] [nvarchar](50) NULL,
	[ServiceRef] [nvarchar](50) NULL,
	[Address1] [nvarchar](250) NULL,
	[Address2] [nvarchar](250) NULL,
	[Address3] [nvarchar](250) NULL,
	[TenantDesc] [nvarchar](1000) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[VATno] [nvarchar](50) NULL,
	[DLNo] [nvarchar](50) NULL,
	[CSTNo] [nvarchar](50) NULL,
	[GST] [nvarchar](50) NULL,
	[Lanline] [nvarchar](50) NOT NULL,
	[Mobile] [nvarchar](250) NULL,
	[Website] [nvarchar](750) NULL,
	[IsActive] [nchar](1) NULL,
	[StatusID] [int] NULL,
	[SuscriptionStartDate] [datetime] NULL,
	[SuscriptionEndDate] [datetime] NULL,
	[TenantRemark] [nvarchar](750) NULL,
	[FinancialYear] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Tenant] PRIMARY KEY CLUSTERED 
(
	[TenantID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoginUser](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[CustomerTypeID] [int] NULL,
	[CustomerType] [nvarchar](50) NULL,
	[OrgTypeID] [int] NULL,
	[OrgType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[Orgname] [nvarchar](50) NULL,
	[RoleAccessID] [int] NULL,
	[RoleName] [nvarchar](50) NULL,
	[FirstN] [nvarchar](50) NULL,
	[MiddleN] [nvarchar](50) NULL,
	[LastN] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Passwrd] [nvarchar](1000) NOT NULL,
	[DisplayN] [nvarchar](250) NULL,
	[Email] [nvarchar](150) NULL,
	[Mobile] [nvarchar](50) NULL,
	[PhotoFlag] [nchar](1) NULL,
	[Photo] [nvarchar](750) NULL,
	[PhotoPath] [nvarchar](750) NULL,
	[LastLogin] [datetime] NULL,
	[LastPasswrdChgedDate] [datetime] NULL,
	[SharedLogin] [nchar](1) NULL,
	[LoginIP] [nvarchar](50) NULL,
	[FinanFromMonth] [int] NULL,
	[FinancialYearFrom] [int] NULL,
	[FinancialToMonth] [int] NULL,
	[FinancialYearTo] [int] NULL,
	[BillingCounterFlag] [nchar](1) NULL,
	[BillingCounterID] [nvarchar](50) NULL,
	[PharmacyCounterFlag] [nchar](1) NULL,
	[PharmacyCounterID] [nvarchar](2000) NULL,
	[OtherCounterFlag] [nchar](1) NULL,
	[OtherCounterID] [nvarchar](2000) NULL,
	[BillSeriesFlag] [nchar](1) NULL,
	[PhBillSeries] [nchar](1) NULL,
	[LinkDoctorFlag] [nchar](1) NULL,
	[LinkeDoctorID] [int] NULL,
	[AppLoginFlag] [nchar](1) NULL,
	[AssignedWardID] [int] NULL,
	[AssignedWard] [nvarchar](50) NULL,
	[RedirectLogin] [nvarchar](250) NULL,
	[LinkedIncLocationID] [int] NULL,
	[LinkedIncLocation] [nvarchar](250) NULL,
	[LinkIncCategoryID] [int] NULL,
	[LinkIncCategory] [nvarchar](250) NULL,
	[LinkIncSubCategoryID] [int] NULL,
	[LinkIncSubCategory] [nvarchar](250) NULL,
	[FinancialKey] [nvarchar](50) NULL,
	[LinkAccCustomerID] [int] NULL,
	[LinkAccCustomerName] [nvarchar](250) NULL,
	[Custom_1] [nvarchar](50) NULL,
	[Custom_2] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) NULL,
	[UpdatedBy] [nvarchar](250) NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[OrderID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[OrderStatusID] [int] NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[InternalStatusID] [int] NULL,
	[InternalStatus] [nvarchar](50) NULL,
	[OrderQR] [nvarchar](250) NULL,
	[OrderNO] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[OrderDateTxt] [nvarchar](50) NULL,
	[OrderDate] [datetime] NULL,
	[AckDateTxt] [nvarchar](50) NULL,
	[AckDate] [datetime] NULL,
	[ProcessDateTxt] [nvarchar](50) NULL,
	[ProcessDate] [datetime] NULL,
	[DeliverDateTxt] [nvarchar](50) NULL,
	[DeliverDate] [datetime] NULL,
	[PreTaxOrginalAmt] [numeric](18, 2) NULL,
	[Discount] [numeric](18, 2) NULL,
	[TaxableOrginalAmt] [numeric](18, 2) NULL,
	[TaxAmt] [numeric](18, 2) NULL,
	[BillAmt] [numeric](18, 2) NULL,
	[OtherAmt] [numeric](18, 2) NULL,
	[CGST] [numeric](18, 2) NULL,
	[SGST] [numeric](18, 2) NULL,
	[CessAmt] [numeric](18, 2) NULL,
	[RoundOff] [numeric](18, 2) NULL,
	[NetAmt] [numeric](18, 2) NULL,
	[CancelledBy] [nvarchar](50) NULL,
	[CancelRemark] [nvarchar](250) NULL,
	[Priority] [nchar](1) NULL,
	[CompanyMessage] [nvarchar](450) NULL,
	[CompMessageBy] [nvarchar](50) NULL,
	[SupplierMessage] [nvarchar](450) NULL,
	[SupplierMsgBy] [nvarchar](50) NULL,
	[Remark] [nvarchar](250) NULL,
	[AckBy] [nvarchar](50) NULL,
	[PackedBy] [nvarchar](50) NULL,
	[DeliveredBy] [nvarchar](50) NULL,
	[VerifiedBy] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TenantSetting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TenantSetting](
	[SettingID] [int] NOT NULL,
	[TenantID] [int] NULL,
	[EntityName] [nvarchar](150) NULL,
	[EntityAddress_1] [nvarchar](150) NULL,
	[EntityAddress_2] [nvarchar](150) NULL,
	[EntityAddress_3] [nvarchar](150) NULL,
	[EntityAddress_4] [nvarchar](150) NULL,
	[EntityAddress_5] [nvarchar](150) NULL,
	[EntityMobile_1] [nvarchar](50) NULL,
	[EntityMobile_2] [nvarchar](50) NULL,
	[EntityLanline_1] [nvarchar](50) NULL,
	[EntityLanline_2] [nvarchar](50) NULL,
	[EntityLogoFlag] [nchar](1) NULL,
	[EntityLogo] [nvarchar](250) NULL,
	[TIN] [nvarchar](50) NULL,
	[PAN] [nvarchar](50) NULL,
	[ServiceRegNo] [nvarchar](50) NULL,
	[IsActive] [nchar](1) NULL,
	[FinancialYearFrom] [int] NULL,
	[FinancialYearTo] [int] NULL,
	[RegNPrefix] [nvarchar](50) NULL,
	[MoneyRecPrefix] [nvarchar](50) NULL,
	[BillRefPrefix] [nvarchar](50) NULL,
	[SampleCollectFlag] [nchar](1) NULL,
	[LabDoctorFlag] [nchar](1) NULL,
	[LabDoctorList] [nvarchar](2000) NULL,
	[RadioDoctorFlag] [nchar](1) NULL,
	[RadioDoctorList] [nvarchar](2000) NULL,
	[RadReportHeadPrintFlag] [nchar](1) NULL,
	[LabReportHeadPrintFlag] [nchar](1) NULL,
	[KeyActivateFlag] [nchar](1) NULL,
	[ActivateDate] [nvarchar](50) NULL,
	[KeyCode] [nvarchar](450) NULL,
	[DischargeHeadPrintFlag] [nchar](1) NULL,
	[LabFooterEnable] [nchar](1) NULL,
	[DigitalSignatureFlag] [nchar](1) NULL,
	[LabDispDateTime] [nchar](1) NULL,
	[RadDispDateTime] [nchar](1) NULL,
	[CurrencyFlag] [nchar](1) NULL,
	[CurrencyName] [nvarchar](50) NULL,
	[DisSummaryDclFlag] [nchar](1) NULL,
	[DisSummaryDclTxt] [nvarchar](2000) NULL,
	[RegServiceID] [int] NULL,
	[RegServiceName] [nvarchar](50) NULL,
	[RegDayValidity] [int] NULL,
	[AllowBedLimit] [int] NULL,
	[MaxRetailDue] [numeric](18, 2) NULL,
	[MaxCompanyDue] [numeric](18, 2) NULL,
	[EntityDesc] [ntext] NULL,
	[EntityHighlight] [nvarchar](2000) NULL,
	[MultiStikerPerRow] [int] NULL,
	[MultiStikerTotalRow] [int] NULL,
	[IndentAutoAppFlag] [nchar](1) NULL,
	[IndentMediAutoAppFlag] [nchar](1) NULL,
	[DiscountExcludeGroupFlag] [nchar](1) NULL,
	[DiscountExcludeGroupID] [nvarchar](250) NULL,
	[DiscountExcludeServiceFlag] [nchar](1) NULL,
	[DiscountExcludeServiceID] [nvarchar](250) NULL,
	[Custom_1] [nvarchar](50) NULL,
	[Custom_2] [nvarchar](50) NULL,
	[Custom_3] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TenantSetting] PRIMARY KEY CLUSTERED 
(
	[SettingID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusCodeMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StatusCodeMaster](
	[StatusID] [int] NOT NULL,
	[TenantID] [int] NOT NULL,
	[StatusCode] [nvarchar](5) NOT NULL,
	[StatusShortName] [nvarchar](50) NOT NULL,
	[StatusLongName] [nvarchar](250) NULL,
	[IsActive] [nchar](1) NULL,
	[Process] [nvarchar](50) NULL,
	[SubProcess] [nvarchar](250) NULL,
	[SubSubPro] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderDtl]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderDtl](
	[OrderDtlID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenantID] [int] NULL,
	[IsActive] [nchar](1) NULL,
	[StatusID] [int] NULL,
	[OrderID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[ItemName] [nvarchar](150) NULL,
	[HSN] [nvarchar](50) NULL,
	[ItemCatID] [int] NOT NULL,
	[CategoryName] [nvarchar](150) NULL,
	[OrderQTY] [int] NULL,
	[DeliverQTY] [int] NULL,
	[RecQTY] [int] NULL,
	[UOM] [nvarchar](50) NULL,
	[PackSize] [int] NULL,
	[ItemRate] [numeric](18, 2) NULL,
	[ItemMRP] [numeric](18, 2) NULL,
	[CostPrice] [numeric](18, 2) NULL,
	[GST] [numeric](18, 2) NULL,
	[PreTaxOrginalAmt] [numeric](18, 2) NULL,
	[Disc] [numeric](18, 2) NULL,
	[TaxableAmt] [numeric](18, 2) NULL,
	[TaxtAmt] [numeric](18, 2) NULL,
	[TotalAmt] [numeric](18, 2) NULL,
	[NetAmt] [numeric](18, 2) NULL,
	[Roundoff] [numeric](18, 2) NULL,
	[Priority] [nchar](1) NULL,
	[IsOutStock] [nchar](1) NULL,
	[CompanyUser] [nvarchar](50) NULL,
	[CompanyUpdateDate] [datetime] NULL,
	[CompanyMessage] [nvarchar](450) NULL,
	[CompMessageBy] [nvarchar](50) NULL,
	[SupplierMessage] [nvarchar](450) NULL,
	[SupplierMsgBy] [nvarchar](50) NULL,
	[AckBy] [nvarchar](50) NULL,
	[PackedBy] [nvarchar](50) NULL,
	[DeliveredBy] [nvarchar](50) NULL,
	[VerifiedBy] [nvarchar](50) NULL,
	[CancelledBy] [nvarchar](50) NULL,
	[CancelRemark] [nvarchar](250) NULL,
	[CancelDate] [nvarchar](50) NULL,
	[AckDate] [nvarchar](50) NULL,
	[VerifyDate] [nvarchar](50) NULL,
	[Remark] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_OrderDtl] PRIMARY KEY CLUSTERED 
(
	[OrderDtlID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderDtl_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderDtl]'))
ALTER TABLE [dbo].[OrderDtl]  WITH CHECK ADD  CONSTRAINT [FK_OrderDtl_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderDtl_OrganisationMaster]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderDtl]'))
ALTER TABLE [dbo].[OrderDtl]  WITH CHECK ADD  CONSTRAINT [FK_OrderDtl_OrganisationMaster] FOREIGN KEY([OrgID])
REFERENCES [dbo].[OrganisationMaster] ([OrgID])
