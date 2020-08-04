CREATE TABLE [dbo].[Reservation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Customer_Id] INT NOT NULL, 
    [Room_type] NVARCHAR(50) NOT NULL, 
    [Num_guests] INT NOT NULL, 
    [Start_date] DATE NOT NULL, 
    [End_date] DATE NOT NULL, 
    [Hotel_location_Id] INT NOT NULL, 
    [Points_earned] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [Customer_Id] FOREIGN KEY ([Customer_Id]) REFERENCES [Customer]([Id]), 
    CONSTRAINT [Hotel_Location_ID] FOREIGN KEY ([Hotel_location_Id]) REFERENCES [Hotel]([Id])
)
