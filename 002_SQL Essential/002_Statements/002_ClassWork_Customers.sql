-- 002_ClassWork

CREATE DATABASE ClassWork
ON
(
	NAME = 'ClassWork',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ClassWork.mdf',
	SIZE = 5 MB,
	MAXSIZE = 7 MB,
	FILEGROWTH = 500 KB
)

LOG ON
(
	NAME = 'ClassWorkLog',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ClassWork.ldf',
	SIZE = 2 MB,
	MAXSIZE = 5 MB,
	FILEGROWTH = 500 KB
)
GO

EXEC sp_helpdb ClassWork
GO

USE ClassWork
GO

CREATE TABLE Customers
(
	CustomerNo int IDENTITY NOT NULL,
	FName nvarchar (15) NOT NULL,
	MName nvarchar (15) NULL,
	LName nvarchar (15) NOT NULL,
	Address1 nvarchar (50) NOT NULL,
	Address2 nvarchar (50) NULL,
	City nchar (10) NOT NULL,
	Phone char (12) NOT NULL,
	DateInSystem date NULL
)
GO

EXEC sp_help Customers
GO

SELECT * FROM Customers
GO