CREATE PROCEDURE [dbo].[sp_GetOrdersByEmail]
    @senderemail nvarchar(50)
AS
    SELECT * FROM [dbo].[Orders] WHERE SenderEmail = @senderemail
RETURN 0