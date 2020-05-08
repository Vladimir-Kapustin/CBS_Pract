--Задание 4  
--Сделайте выборку при помощи вложенных запросов для таких задач:  
--1) Требуется узнать контактные данные сотрудников (номера телефонов, место жительства).  
--2) Требуется узнать информацию о дате рождения всех не женатых сотрудников и номера телефонов этих сотрудников.  
--3) Требуется узнать информацию о дате рождения всех сотрудников с должностью менеджер и номера телефонов этих сотрудников. 

USE MyJoinsDB
GO

SELECT * FROM Employees
SELECT * FROM PersonalInfo
SELECT * FROM SalaryPosition

--1) Требуется узнать контактные данные сотрудников (номера телефонов, место жительства).  
SELECT FName,LName, Phone, (
							SELECT [Address] FROM PersonalInfo
							WHERE EmployeeID = Employees.EmployeeID
							) AS Adress
FROM Employees
GO

--2) Требуется узнать информацию о дате рождения всех не женатых сотрудников и номера телефонов этих сотрудников.  
SELECT (SELECT FName FROM Employees WHERE
		Employees.EmployeeID = PersonalInfo.EmployeeID 
		) AS FName, 
		(SELECT LName FROM Employees WHERE
		Employees.EmployeeID = PersonalInfo.EmployeeID 
		) AS LName,
		MarriageStatus as 'Martial Status',
		BirthDate,
		(SELECT Phone FROM Employees WHERE
		Employees.EmployeeID = PersonalInfo.EmployeeID 
		) AS Phone
FROM PersonalInfo WHERE 
MarriageStatus IN ('Не женат', 'Не замужем')
GO

--3) Требуется узнать информацию о дате рождения всех сотрудников с должностью менеджер и номера телефонов этих сотрудников. 
SELECT	(SELECT FName FROM Employees WHERE
		EmployeeID = SalaryPosition.EmployeeID) AS FName,
		(SELECT LName FROM Employees WHERE
		аEmployeeID = SalaryPosition.EmployeeID) AS LName,	--когда используется подзапрос, то нужно использовать алиас, иначе колонка выводится без названия.
		Position,
		(SELECT BirthDate FROM PersonalInfo WHERE
		EmployeeID = (SELECT EmployeeID FROM Employees WHERE
					 EmployeeID = SalaryPosition.EmployeeID)
					 ) AS BirthDate,
		(SELECT Phone FROM Employees WHERE 
		EmployeeID = SalaryPosition.EmployeeID) AS Phone
FROM SalaryPosition WHERE
Position = 'Менеджер'
GO
