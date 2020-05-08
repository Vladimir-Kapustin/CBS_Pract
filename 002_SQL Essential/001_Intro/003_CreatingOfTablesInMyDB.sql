---- 003_Creating of Tables in MyDB ----


USE MyDB
GO

CREATE TABLE Employees
(
	EmployeeId Smallint IDENTITY NOT NULL,
	EmployeeFirstName VarChar (25) NOT NULL,
	EmployeeLastName VarChar (30) NULL,
	PhoneNumber Char (10) NOT NULL
)
GO

CREATE TABLE EmpSalaryPosition
(
	Salary int NOT NULL,
	Position VarChar (60) NOT NULL,
)
GO

CREATE TABLE EmpPirvateInfo
(
	MarriageStatus VarChar (11) NULL,
	BirthDate Date NULL,
	Location VarChar (60) NULL
)
GO

EXECUTE sp_helpdb MyDB;