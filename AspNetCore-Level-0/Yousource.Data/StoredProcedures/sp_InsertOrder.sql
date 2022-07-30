CREATE PROCEDURE [dbo].[sp_InsertOrder]
    @item nvarchar(50),
    @price decimal = 0,
    @senderemail nvarchar(50),
    @sendername nvarchar(50),
    @recipientname nvarchar(50),
    @recipientsurname nvarchar(50),
    @recipientemail nvarchar(50),
    @voucher integer = 0
AS
DECLARE @id uniqueidentifier = NEWID();
    Insert INTO
        [dbo].[Orders] ([Item], [Price],[SenderEmail], [SenderName],  [RecipientName], [RecipientSurname], [RecipientEmail], [Voucher], [Id])
    VALUES
        (@item, @price, @senderemail, @sendername, @recipientname, @recipientsurname, @recipientemail, @voucher, @id)
RETURN 0