USE HomeWorkDb
GO

CREATE TABLE Customers
(
	CustomerNo int IDENTITY NOT NULL
		PRIMARY KEY,
	CusnomerName varchar(30) NOT NULL,
	CustomerAddress varchar(50) NOT NULL,
	CustomerPhone char(12) UNIQUE NOT NULL
)
GO

ALTER TABLE Customers
ADD CONSTRAINT CHK_PhoneNumber
CHECK (CustomerPhone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO

CREATE TABLE Employees
(
	EmpID int IDENTITY NOT NULL
		PRIMARY KEY,
	EmpName varchar(40) NOT NULL,
	EmpAdress varchar (50) NOT NULL,
	EmpBirthdate date NULL,
	EmpPhoneNo char (12) NOT NULL
		UNIQUE CHECK (EmpPhoneNo LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

ALTER TABLE Customers
ADD
ManagerOfCustomerID int NOT NULL
	FOREIGN	KEY REFERENCES Employees (EmpID)
GO

CREATE TABLE Suppliers
(
	SupplierNo int IDENTITY NOT NULL
		PRIMARY KEY,
	SupplierName varchar(30) NOT NULL,
	SupplierAddress varchar(50) NOT NULL,
	SupplierPhone char(12) UNIQUE NOT NULL,
		CHECK (SupplierPhone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	ManagerOfSupplierID int NOT NULL
		FOREIGN	KEY REFERENCES Employees (EmpID)
)
GO

CREATE TABLE Goods
(
	GoodId int	IDENTITY NOT NULL
		PRIMARY KEY,
	GoodName varchar (30) NOT NULL,
	Price int NOT NULL,
	Amount int NOT NULL
)
GO

CREATE TABLE OrdersOfCustomers		--// С помощью этой таблицы НЕ устанавливается связь многие ко многим таблиц Customers и Goods, потому что...
(
	OrderOfCustomerId int IDENTITY NOT NULL
		PRIMARY KEY,
	CustomerNo int NOT NULL
		FOREIGN KEY REFERENCES Customers (CustomerNo),
	GoodId int NOT NULL									--// ...здесь может повторяться связующая пара CustomerNo-GoodId - т.е. здесь не задан составной первичный ключ одновременно на столбцах CustomerNo и GoodId.
		FOREIGN KEY REFERENCES Goods (GoodId),
	OrderDate date NOT NULL,
	OrderAmount int	NOT NULL,
)
GO

CREATE TABLE SuppliersGoods		--// С помощью этой таблицы УСТАНАВЛИВАЕТСЯ связь многие ко многим таблиц Suppliers и Goods, т.к....
(
	SupplierNo int NOT NULL
		FOREIGN KEY REFERENCES Suppliers (SupplierNo),
	GoodId int NOT NULL
		FOREIGN KEY REFERENCES Goods (GoodId),
	PRIMARY KEY (SupplierNo, GoodId)					--// ...здесь пары Supplier-Good уникальны - составной PRIMARY KEY задан на столбцах SupplierNo и GoodId.
)
GO

EXEC sp_helpdb HomeWorkDb
GO

SELECT * FROM Customers
SELECT * FROM Employees
SELECT * FROM Suppliers
SELECT * FROM OrdersOfCustomers
SELECT * FROM Goods
SELECT * FROM SuppliersGoods
GO

DROP TABLE Employees
DROP TABLE Suppliers
DROP TABLE OrdersOfCustomers
DROP TABLE Goods
DROP TABLE SuppliersGoods
DROP TABLE Customers
