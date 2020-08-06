CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Room_type] NVARCHAR(50) NOT NULL, 
    [Num_guests_max] INT NOT NULL DEFAULT 5, 
    [Monetary_cost] INT NOT NULL DEFAULT 0, 
    [Hotel_id] INT NOT NULL, 
    [Package_types] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [Hotel_ID] FOREIGN KEY (Hotel_id) REFERENCES [Hotel]([Id])
)
