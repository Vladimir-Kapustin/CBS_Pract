CREATE DATABASE ShopDb_004_Design_HomeWork
drop DATABASE ShopDb_004_Design_HomeWork
ON
(
	NAME = 'ShopDb_004_Design_HomeWork',
	FILENAME = 'f:\Courses .NET\CBS\Fourth - Online\002_SQL Essential\Practice\004_Design\ShopDb_004_Design_HomeWork.mdf',
	SIZE = 10 Mb,
	MAXSIZE = 23 Mb,
	FILEGROWTH = 2 Mb
)
LOG ON
(
	NAME = 'LogShopDb_004_Design_HomeWork',
	FILENAME = 'f:\Courses .NET\CBS\Fourth - Online\002_SQL Essential\Practice\004_Design\ShopDb_004_Design_HomeWork.ldf',
	SIZE = 5 Mb,
	MAXSIZE = 10 Mb,
	FILEGROWTH = 1 Mb
)

EXEC sp_helpdb ShopDb_004_Design_HomeWork

USE ShopDb_004_Design_HomeWork
GO

CREATE TABLE Orders
(
OrderId int NOT NULL
	PRIMARY KEY,
OrderDate date NOT NULL,
CustomerNo int NOT NULL,
FName char (20) NOT NULL,
LName char (20) NOT NULL,
MName char (20) NOT NULL,
Address1 char (30) NOT NULL,
Address2 char (30) NOT NULL,
City char (30) NOT NULL,
Phone char (12) NOT NULL
	CHECK (Phone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
DateInSystem date NOT NULL,
--Products
ProductInfo varchar (300) NOT NULL, 
--ProdId int NOT NULL,
--Qty int NOT NULL,
--UnitPrice smallmoney NULL,
--Description nchar (50) NOT NULL,
--Weight numeric (18,0) NULL,
--Emps
EmployeeID int NOT NULL,
FirstName char (20) NOT NULL,
LastName char (20) NOT NULL,
MiddleName char (20) NOT NULL,
Salary int NOT NULL,
PriorSalary int NOT NULL,
HireDate date NOT NULL,
TerminationDate date NOT NULL,
ManagerEmpID int NOT NULL
)
GO

INSERT Orders
VALUES
(55, '2011-11-01', 166, 'Акакий','Шевцов','Николаевич','Комсомольская 4','Большевиков 12','Львов','(093)4564545','2008-05-05','1003, 5, 500, Косилка, 9',205, 'Иван','Иванов','Иванович', 500, 400, '2009-08-29', '2011-08-05', 305),

(57, '2011-11-03', 177, 'Зигмунд','Унакий','Фёдорович','Петренко 2','Строителей 14','Комсомольск-на-Амуре','(050)9875454','2011-06-06','',205, '','','', 500, 400, '', '', 305),

(71, '2011-11-06', 188, 'Дункан','Иванович','Маклаков','','','','','','',205, '','','', 500, 400, '', '', 305),

(77, '2011-11-07', 199, 'Петр','Петров','Петрович','','','','','','',205, '','','', 500, 400, '', '', 305),

(85, '2011-11-17', 155, 'Сидор','Сидоров','Сидорович','','','','','','',205, '','','', 500, 400, '', '', 305),

(93, '2011-11-18', 133, 'Мустафа','Рахман','Алибабаевич','','','','','','',205, '','','', 500, 400, '', '', 305),

(97, '2011-11-27', 166, 'Николай','Васильев','Александрович','','','','','','',205, '','','', 500, 400, '', '', 305)