CREATE TABLE [media].[Store] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [StoreName]       NVARCHAR (200) NOT NULL,
    [PhoneNumber]     NVARCHAR (50)  NULL,
    [CreatedBy]       NVARCHAR (100) NOT NULL,
    [CreatedAt]       DATETIME       DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]       NVARCHAR (100) NULL,
    [UpdatedAt]       DATETIME       NULL,
    [Address_City]    NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [Address_Country] NVARCHAR (50)  DEFAULT (N'') NOT NULL,
    [Address_State]   NVARCHAR (2)   DEFAULT (N'') NOT NULL,
    [Address_Street]  NVARCHAR (100) DEFAULT (N'') NOT NULL,
    [Address_ZipCode] NVARCHAR (10)  DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK__Store__3214EC07271D525F] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO

