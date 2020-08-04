CREATE TABLE [dbo].[Logs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [User_id] INT NOT NULL, 
    [Action_date] DATE NOT NULL, 
    [User_type] NVARCHAR(50) NOT NULL, 
    [Action_type] NVARCHAR(MAX) NOT NULL
)
