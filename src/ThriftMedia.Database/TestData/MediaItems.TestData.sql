INSERT INTO [media].[MediaItems] (
    [StoreOwnerId],
    [MediaType],
    [ImageUrl],
    [OcrPayloadJson],
    [CreatedBy],
    [CreatedAt],
    [UpdatedBy],
    [UpdatedAt]
) VALUES
(1, 'Image', 'https://example.com/images/1.jpg', '{"text":"Sample OCR 1"}', 'admin', GETDATE(), NULL, NULL),
(2, 'Video', 'https://example.com/videos/2.mp4', '{"text":"Sample OCR 2"}', 'user1', GETDATE(), 'user2', DATEADD(day, 1, GETDATE())),
(3, 'Document', 'https://example.com/docs/3.pdf', '{"text":"Sample OCR 3"}', 'user2', GETDATE(), NULL, NULL),
(4, 'Image', 'https://example.com/images/4.jpg', '{"text":"Sample OCR 4"}', 'admin', GETDATE(), 'admin', DATEADD(hour, 2, GETDATE())),
(5, 'Audio', 'https://example.com/audio/5.mp3', '{"text":"Sample OCR 5"}', 'user3', GETDATE(), NULL, NULL),
(1, 'Image', 'https://example.com/images/6.jpg', '{"text":"Sample OCR 6"}', 'user1', GETDATE(), 'user3', DATEADD(day, 2, GETDATE())),
(2, 'Video', 'https://example.com/videos/7.mp4', '{"text":"Sample OCR 7"}', 'user2', GETDATE(), NULL, NULL),
(3, 'Document', 'https://example.com/docs/8.pdf', '{"text":"Sample OCR 8"}', 'admin', GETDATE(), 'user1', DATEADD(hour, 3, GETDATE())),
(4, 'Image', 'https://example.com/images/9.jpg', '{"text":"Sample OCR 9"}', 'user3', GETDATE(), NULL, NULL),
(5, 'Audio', 'https://example.com/audio/10.mp3', '{"text":"Sample OCR 10"}', 'user2', GETDATE(), 'admin', DATEADD(day, 3, GETDATE()));
