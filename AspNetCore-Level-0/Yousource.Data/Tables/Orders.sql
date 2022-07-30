CREATE TABLE [dbo].[Orders]
(
    [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [Item] NVARCHAR(50) NOT NULL,
    [Price] DECIMAL NOT NULL,
    [PlacedOn] DATETIME NOT NULL DEFAULT GETUTCDATE(),
    [SenderEmail] NVARCHAR(50) NOT NULL,
    [SenderName] NVARCHAR(50) NOT NULL,
    [RecipientName] NCHAR(50) NOT NULL,
    [RecipientSurname] NCHAR(50) NOT NULL,
    [RecipientEmail] NCHAR(50) NOT NULL,
    [Voucher] INT NOT NULL
)