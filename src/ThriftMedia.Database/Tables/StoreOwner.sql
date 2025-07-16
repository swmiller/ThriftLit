CREATE TABLE [media].[StoreOwner]
(
    [Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [StoreName] NVARCHAR(200) NOT NULL,
    [Address] NVARCHAR(500) NOT NULL,
    [PhoneNumber] NVARCHAR(50) NULL,
    [CreatedBy] NVARCHAR(100) NOT NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT (GETDATE()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [UpdatedAt] DATETIME NULL
);
