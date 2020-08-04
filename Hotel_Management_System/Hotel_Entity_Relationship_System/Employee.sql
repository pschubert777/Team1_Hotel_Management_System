CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [Salary_Weekly] INT NULL DEFAULT 400
)
