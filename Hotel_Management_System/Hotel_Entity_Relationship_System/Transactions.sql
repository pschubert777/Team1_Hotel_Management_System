CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Reservation_Id] INT NOT NULL, 
    [Customer_Id] INT NOT NULL, 
    [Reward_points_spent] INT NOT NULL DEFAULT 0, 
    [Money_spent] FLOAT NOT NULL DEFAULT 0, 
    [Activity_type] NVARCHAR(MAX) NULL, 
    [Reward_points_gained] INT NOT NULL DEFAULT 0, 
    [Transaction_date] DATE NOT NULL, 
    CONSTRAINT [Reservation_ID] FOREIGN KEY ([Reservation_Id]) REFERENCES [Reservation]([Id]), 
    CONSTRAINT [Customeer_ID] FOREIGN KEY ([Customer_Id]) REFERENCES [Customer]([Id]) 
)
