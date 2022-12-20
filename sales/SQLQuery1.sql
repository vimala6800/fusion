CREATE TABLE [dbo].[Currencies] (
    [CurrencyID]   UNIQUEIDENTIFIER NOT NULL,
    [CurrencyName] NVARCHAR (100)   NULL,
    PRIMARY KEY CLUSTERED ([CurrencyID] ASC)
);

CREATE TABLE [dbo].[Departments] (
    [DepartmentID]   UNIQUEIDENTIFIER NOT NULL,
    [DepartmentName] NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);

CREATE TABLE [dbo].[ProjectManagers] (
    [ProjectManagerID]   UNIQUEIDENTIFIER NOT NULL,
    [ProjectManagerName] NVARCHAR (100)   NOT NULL,
    [EmployeeID]         NVARCHAR (10)    NOT NULL,
    [JoiningDate]        DATETIME2 (7)    NOT NULL,
    [PMEmailID]          NVARCHAR (100)   NOT NULL,
    [PMPhoneNumber]      NVARCHAR (50)    NOT NULL,
    [PMPhoto]            IMAGE            NOT NULL,
    [PMUserID]           UNIQUEIDENTIFIER NOT NULL,
    [PMStatus]           SMALLINT         NOT NULL,
    [CreatedBy]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedOn]          DATETIME2 (7)    NOT NULL,
    [LastUpdatedBy]      UNIQUEIDENTIFIER NOT NULL,
    [LastUpdatedOn]      DATETIME2 (7)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectManagerID] ASC)
);

CREATE TABLE [dbo].[RequisitionFiles] (
    [RequisitionFileID]   UNIQUEIDENTIFIER NOT NULL,
    [RequisitionID]       UNIQUEIDENTIFIER NOT NULL,
    [Filename]            NVARCHAR (100)   NOT NULL,
    [FileTypeDescription] NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RequisitionFileID] ASC)
);

CREATE TABLE [dbo].[RequisitionJD] (
    [RequisitionJDID]    UNIQUEIDENTIFIER NOT NULL,
    [RequisitionID]      UNIQUEIDENTIFIER NOT NULL,
    [JobDescription]     NVARCHAR (100)   NOT NULL,
    [Duration]           INT              NOT NULL,
    [DurationUnits]      NVARCHAR (50)    NOT NULL,
    [ShiftTimings]       NVARCHAR (100)   NOT NULL,
    [NoOfResources]      INT              NOT NULL,
    [OpenPositions]      INT              NOT NULL,
    [KeyDescription]     NVARCHAR (MAX)   NOT NULL,
    [PreferredEducation] NVARCHAR (200)   NOT NULL,
    [MinExperience]      INT              NOT NULL,
    [MaxExperience]      INT              NOT NULL,
    [JDFileName]         NVARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([RequisitionJDID] ASC)
);

CREATE TABLE [dbo].[RequisitionPartners] (
    [RequisitionPartnerID] UNIQUEIDENTIFIER NOT NULL,
    [RequisitionID]        UNIQUEIDENTIFIER NOT NULL,
    [PartnerID]            UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([RequisitionPartnerID] ASC)
);

CREATE TABLE [dbo].[Requisitions] (
    [RequisitionID]      UNIQUEIDENTIFIER NOT NULL,
    [RequisitionCode]    NVARCHAR (10)    NOT NULL,
    [RequisitionDate]    DATETIME2 (7)    NOT NULL,
    [PotentialNumber]    NVARCHAR (10)    NOT NULL,
    [Complexity]         NVARCHAR (10)    NOT NULL,
    [DeadlineDate]       DATETIME2 (7)    NOT NULL,
    [ClientName]         NVARCHAR (100)   NOT NULL,
    [ClientCountryID]    UNIQUEIDENTIFIER NOT NULL,
    [ProjectType]        NVARCHAR (10)    NOT NULL,
    [SalesPersonUserID]  UNIQUEIDENTIFIER NOT NULL,
    [ProjectManagerID]   UNIQUEIDENTIFIER NOT NULL,
    [RequisitionStatus]  SMALLINT    NOT NULL,
    [ExpectedStartDate]  DATETIME2 (7)    NOT NULL,
    [DepartmentID]       UNIQUEIDENTIFIER NOT NULL,
    [EstimatedBudget]    BIGINT           NOT NULL,
    [CurrencyID]         UNIQUEIDENTIFIER NOT NULL,
    [ProjectDescription] NVARCHAR (MAX)   NOT NULL,
    [CreatedBy]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedOn]          DATETIME2 (7)    NOT NULL,
    [LastUpdatedBy]      UNIQUEIDENTIFIER NOT NULL,
    [LastUpdatedOn]      DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Requisitions] PRIMARY KEY CLUSTERED ([RequisitionID] ASC)
);