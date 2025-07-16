CREATE TABLE [media].[MediaItems] (
    [MediaId]        INT            IDENTITY (1, 1) NOT NULL,
    [StoreOwnerId]   INT            NOT NULL,
    [MediaType]      NVARCHAR(50)   NOT NULL,
    [ImageUrl]       NVARCHAR(500)  NOT NULL,
    [OcrPayloadJson] NVARCHAR(MAX)  NOT NULL,
    [CreatedBy]      NVARCHAR(100)  NOT NULL,
    [CreatedAt]      DATETIME       NOT NULL DEFAULT (GETDATE()),
    [UpdatedBy]      NVARCHAR(100)  NULL,
    [UpdatedAt]      DATETIME       NULL, 
    CONSTRAINT PK_MediaItems PRIMARY KEY ([MediaId]),
    CONSTRAINT [FK_MediaItems_StoreOwner] FOREIGN KEY ([StoreOwnerId]) REFERENCES [media].[StoreOwner]([Id])
);
