USE MyJoinsDB
GO

SELECT * FROM Employees
SELECT * FROM SalaryPosition
SELECT * FROM PersonalInfo
GO

--1.
SELECT FName, MName, LName, Phone, [Address] FROM
								Employees
								LEFT JOIN
								PersonalInfo
ON Employees.EmployeeID = PersonalInfo.EmployeeID
GO

--2.
SELECT BirthDate, FName, LName, Phone FROM
									PersonalInfo
									JOIN
									Employees
ON Employees.EmployeeID = PersonalInfo.EmployeeID
AND MarriageStatus = 'Не Женат' 
OR Employees.EmployeeID = PersonalInfo.EmployeeID
AND MarriageStatus = 'Не замужем'
ORDER BY LName
GO

-- Или так (лаконичнее):
SELECT BirthDate, FName, LName, MarriageStatus as 'Семейное положение', Phone FROM	--поизвращался, добавил 1 колонку и сортировку по убыванию.
									PersonalInfo
									JOIN
									Employees
ON Employees.EmployeeID = PersonalInfo.EmployeeID
WHERE MarriageStatus = 'Не Женат' OR MarriageStatus ='Не замужем'
ORDER BY LName DESC
GO

--3.
SELECT FName, LName, Position, BirthDate, Phone FROM
								Employees
								JOIN
								SalaryPosition
ON Employees.EmployeeID = SalaryPosition.EmployeeID
								JOIN
								PersonalInfo
ON SalaryPosition.EmployeeID = PersonalInfo.EmployeeID
WHERE Position = 'Менеджер'
GO