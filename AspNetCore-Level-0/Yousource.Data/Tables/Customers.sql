﻿CREATE TABLE [dbo].[Customers]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 

    [Name] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(), 
    [UpdatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE()
)