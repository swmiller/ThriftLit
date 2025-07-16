SET IDENTITY_INSERT [media].[StoreOwner] ON;

INSERT INTO [media].[StoreOwner] ([Id], [StoreName], [Address], [PhoneNumber], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt])
VALUES
    (1, N'Central Books', N'123 Main St, Springfield', N'555-1234', N'admin', '2024-06-01T09:00:00', N'admin', '2024-06-01T09:00:00'),
    (2, N'Westside Music', N'456 Elm St, Springfield', N'555-5678', N'admin', '2024-06-02T10:30:00', NULL, NULL),
    (3, N'Tech Haven', N'789 Oak Ave, Springfield', NULL, N'admin', '2024-06-03T11:15:00', N'editor', '2024-06-04T08:45:00'),
    (4, N'Grocery Hub', N'321 Maple Rd, Springfield', N'555-8765', N'admin', '2024-06-05T14:20:00', NULL, NULL),
    (5, N'Fashion Point', N'654 Pine St, Springfield', N'555-4321', N'admin', '2024-06-06T16:00:00', N'admin', '2024-06-07T09:30:00');

SET IDENTITY_INSERT [media].[StoreOwner] OFF;
