CREATE TABLE [dbo].CryptoCurrencyTable

(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Symbol] NCHAR(10) NOT NULL, 
    [Market Cap] NCHAR(10) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Circuleating Supply] INT NULL, 
    [Volume (24hr)] MONEY NULL, 
    [1 Hour change] FLOAT NULL, 
    [24 Hour change] FLOAT NULL, 
    [7 Day change] FLOAT NULL
)
