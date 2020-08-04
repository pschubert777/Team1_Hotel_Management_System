CREATE TABLE [dbo].[Rewards]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Room_type] NVARCHAR(50) NOT NULL, 
    [Points_recieved] INT NOT NULL
)
