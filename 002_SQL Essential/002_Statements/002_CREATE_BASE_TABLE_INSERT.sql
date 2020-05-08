CREATE DATABASE HomeWork
ON 
(
	NAME = 'HomeWork',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeWork.mdf',
	SIZE = 5 MB,
	MAXSIZE = 8 MB,
	FILEGROWTH = 500 KB
)
LOG ON
(
	NAME = 'HomeWorkLog',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeWork.ldf',
	SIZE = 2 MB,
	MAXSIZE = 5 MB,
	FILEGROWTH = 500 KB
)
GO

EXECUTE sp_helpdb HomeWork;
GO

USE HomeWork
GO

CREATE TABLE Product
(
	ProductId smallint IDENTITY NOT NULL,
	Name Varchar (50) NULL,
	ProductNumber Varchar (30) NOT NULL,
	Cost_$ Money NOT NULL,
	[Count] smallint NOT NULL,
	SellStartDate date NOT NULL
)
GO

--DROP TABLE Product

SELECT * FROM Product
GO

INSERT INTO Product
VALUES
('Корона', 'AK-53818', '5', '50', '08/15/2011'),
('Милка', 'АМ-51122', '6.1', '50', '07/15/2011'),
('Аленка', 'АА-52211', '2.5', '20', '06/15/2011'),
('Snickers', 'BS-32118', '2.8', '50', '08/15/2011'),
('Snickers', 'BSL-3818', '5', '100', '08/20/2011'),
('Bounty', 'BB-38218', '3', '100', '08/01/2011'),
('Nuts', 'BN-37818', '3', '100', '08/21/2011'),
('Mars', 'BM-3618', '2.5', '50', '08/24/2011'),
('Свиточ', 'AS-54181', '5', '100', '08/12/2011'),
('Свиточ', 'AS-54182', '5', '100', '08/12/2011');
GO

SELECT * FROM Product