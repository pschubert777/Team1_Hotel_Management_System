CREATE TABLE [dbo].[Package]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Package_number] INT NOT NULL,
    [Package_name] NVARCHAR(50) NOT NULL,
    [Cost] FLOAT NOT NULL, 
    [Description_amenities] NVARCHAR(MAX) NOT NULL
)
 