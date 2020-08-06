CREATE TABLE [dbo].[Maintenance]
(
	[Id] INT NOT NULL , 
    [Date_maintenance] DATE NOT NULL, 
    CONSTRAINT [Room_ID] FOREIGN KEY ([Id]) REFERENCES [Room]([Id])
)
