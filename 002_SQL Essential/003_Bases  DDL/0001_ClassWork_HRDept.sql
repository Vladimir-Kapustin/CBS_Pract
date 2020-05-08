--------------- HR Department ----------------------

CREATE DATABASE HRDept
ON
(
	NAME = 'HRDept',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HRDept.mdf',
	SIZE = 5 MB,
	MAXSIZE = 10 MB,
	FILEGROWTH = 5%
)
LOG ON
(
	NAME = 'LogHRDept',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HRDeptLog.ldf',
	SIZE = 3 MB,
	MAXSIZE = 5 MB,
	FILEGROWTH = 2%
)
GO

EXEC sp_helpdb HRDept

USE HRDept
GO

CREATE TABLE HRDept
(
ManagerId int NOT NULL
	PRIMARY KEY,
ManagerName char (40) NOT NULL,
ManagerPosition char (20) NOT NULL
)
GO

CREATE TABLE Employees
(
EmployeeId int NOT NULL PRIMARY KEY,
EmpName char (40) NOT NULL,
Salary int NOT NULL,
Department char (30) NOT NULL
)
GO

CREATE TABLE Candidates
(
CandidateId int NOT NULL PRIMARY KEY,
ManagerId int NOT NULL FOREIGN KEY REFERENCES HRDept (ManagerId),
CandName char (40) NOT NULL
)
GO

CREATE TABLE HRDeptEmployees
(
ManagerId int NOT NULL FOREIGN KEY REFERENCES HRDept (ManagerId),
EmployeeId int NOT NULL FOREIGN KEY REFERENCES Employees (EmployeeId),
PRIMARY KEY (ManagerId, EmployeeId)
)
GO

SELECT * FROM HRDept
SELECT * FROM Employees
SELECT * FROM Candidates
SELECT * FROM HRDeptEmployees
