--------- Class Work. 003_Bases DDL. Constraints ----------

-- Самостоятельная работа:
-- 1. Создайте БД ShopDB
CREATE DATABASE NewShopDb
ON
(
	NAME = 'NewShopDb',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewShopDb.mdf',
	SIZE = 5 MB,
	MAXSIZE = 10 MB,
	FILEGROWTH = 500 KB
)
LOG ON
(
	NAME = 'LogNewShopDb',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewShopDb.ldf',
	SIZE = 3 Mb,
	MAXSIZE = 5 Mb,
	FILEGROWTH = 500 KB
)
COLLATE Cyrillic_General_CI_AS -- Задаем кодировку для базы данных по умолчанию

EXECUTE sp_helpdb NewShopDB;
GO

USE NewShopDb
GO
-- 2. Создайте таблицу Employees (смотрите 003_ClassWork_CREATE_TABLE.jpg).
CREATE TABLE Employees
(
	EmployeeID int IDENTITY NOT NULL
		PRIMARY KEY,
	FName nvarchar(15) NOT NULL,
	LName nvarchar(15) NOT NULL,
	MName nvarchar(15) NOT NULL,
	Salary money NOT NULL,
	PriorSaary money NOT NULL,
	HireDate date NOT NULL,
	TerminationDate date,
	ManagerEmpID int
)
GO

SELECT * FROM Employees
GO
-- 3. Допишите таблицы и задайте связи заданые на картинке 003_ClassWork_Constraints.jpg
CREATE TABLE Customers
(
	CustomerNo int IDENTITY NOT NULL
		PRIMARY KEY,
	FName nvarchar(15) NOT NULL,
	LName nvarchar(15) NOT NULL,
	MName nvarchar(15) NULL,
	Address1 nvarchar(50) NOT NULL,
	Address2 nvarchar(50) NULL,
	City nchar(10) NOT NULL,
	Phone char(12) CHECK (Phone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]') UNIQUE NOT NULL,
	DateInSystem date NULL
)
GO

EXEC sp_help Customers

SELECT * FROM Customers
GO

CREATE TABLE Orders
(
	OrderID int NOT NULL 
		PRIMARY KEY,		--// потому что так указано в схеме.
	CustomerNo int NULL
		FOREIGN KEY REFERENCES Customers (CustomerNo),
	OrderDate date NOT NULL,
	EmployeeID int NULL
		FOREIGN KEY REFERENCES Employees (EmployeeID)
)
GO

SELECT * FROM Orders

EXEC sp_help Orders
GO

-- 4. Удалите таблицы: Employees, Customers, Orders.
DROP TABLE Orders
DROP TABLE Employees
DROP TABLE Customers
