CREATE TABLE [dbo].[Maintenance]
(
	[Id] INT NOT NULL IDENTITY , 
    [Date_maintenance] DATE NOT NULL, 
    [Room_Id] INT NOT NULL, 
    CONSTRAINT [PK_Maintenance] PRIMARY KEY ([Id]) 
)
