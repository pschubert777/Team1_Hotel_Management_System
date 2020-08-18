CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Room_type] NVARCHAR(50) NOT NULL, 
    [Room_number] INT NOT NULL, 
    [Num_guests_max] INT NOT NULL DEFAULT 5, 
    [Monetary_cost] INT NOT NULL DEFAULT 0, 
    [Hotel_id] INT NOT NULL, 
    [Maintenance_status] NVARCHAR(50) NOT NULL DEFAULT 'Available', 
    CONSTRAINT [Hotel_ID] FOREIGN KEY (Hotel_id) REFERENCES [Hotel]([Id])
)
