CREATE TABLE [media].[Media] (
    [MediaId]        INT            IDENTITY (1, 1) NOT NULL,
    [StoreId]        INT            NOT NULL,
    [MediaType]      NVARCHAR (50)  NOT NULL,
    [ImageUrl]       NVARCHAR (500) NOT NULL,
    [OcrPayloadJson] NVARCHAR (MAX) NOT NULL,
    [CreatedBy]      NVARCHAR (100) NOT NULL,
    [CreatedAt]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]      NVARCHAR (100) NULL,
    [UpdatedAt]      DATETIME       NULL,
    CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED ([MediaId] ASC),
    CONSTRAINT [FK_Media_Store] FOREIGN KEY ([StoreId]) REFERENCES [media].[Store] ([Id])
);


GO

CREATE NONCLUSTERED INDEX [IX_Media_StoreId]
    ON [media].[Media]([StoreId] ASC);


GO

