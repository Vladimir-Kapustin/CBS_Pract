USE MyJoinsDB
GO

SELECT * FROM Employees
SELECT * FROM PersonalInfo
SELECT * FROM SalaryPosition
GO

-- 1. Необходимо узнать контактные данные сотрудников (номера телефонов, место жительства). 
CREATE VIEW ContactData
AS SELECT FName, LName, Phone, [Address]
	FROM Employees
		INNER JOIN
		PersonalInfo
ON Employees.EmployeeID = PersonalInfo.EmployeeID
GO

SELECT * FROM ContactData
GO

-- 2. Необходимо узнать информацию о дате рождения всех не женатых сотрудников и номера телефонов этих сотрудников.
CREATE VIEW NotMarried
AS SELECT FName, LName, MarriageStatus, BirthDate, Phone
	FROM Employees as e
		JOIN
		PersonalInfo as p
ON e.EmployeeID = p.EmployeeID
	WHERE MarriageStatus = 'Не женат' OR MarriageStatus = 'Не Замужем'
GO

SELECT * FROM NotMarried
GO

-- 3. Необходимо узнать информацию о дате рождения всех сотрудников с должностью менеджер и номера телефонов этих сотрудников. 
CREATE VIEW Managers
WITH SCHEMABINDING
AS SELECT FName, LName, Position, BirthDate, Phone
		FROM dbo.Employees as e		-- Двухкомпонентная структура имени таблицы с которой связано представление.	// Обязательно указывать! при использовании WITH SCHEMABINDING. Иначе выдаст ошибку: Cannot schema bind view 'Managers' because name 'Employees' is invalid for schema binding. Names must be in two-part format and an object cannot reference itself.
			JOIN
			dbo.PersonalInfo as p
ON e.EmployeeID = p.EmployeeID
			JOIN
			dbo.SalaryPosition as s
ON p.EmployeeID = s.EmployeeID
WHERE Position = 'Менеджер'
GO

SELECT * FROM Managers
GO

UPDATE Employees	-- Здесь используется DML, а не DDL. Я сначала лоханулся - написал ALTER TABLE...
SET LName = 'Вася' 
WHERE FName = 'Иван';
GO					-- Таким образом, при 'WITH SCHEMABINDING' возможно менять данные в таблице, которая лежит в основе. Нельзя только удалять её. 

SELECT * FROM Managers
GO

-- Обратно:
UPDATE Employees	
SET LName = 'Петров' 
WHERE FName = 'Иван';
GO					

DROP TABLE PersonalInfo	-- Ошибка. Cannot DROP TABLE 'PersonalInfo' because it is being referenced by object 'Managers'. (результат SCHEMABINDING).

-----------------------------------------------------------------------------------------------------------------------------------
--		ПРОВЕРКА ПОСЛЕДНЕГО ВОПРОСА К ТЕСТУ	- можно ли вставлять данные в представление, если оно задано на нескольких таблицах.
-----------------------------------------------------------------------------------------------------------------------------------

INSERT INTO Managers
(FName, LName, Position, BirthDate, Phone)
VALUES
('Vasiliy', 'Pupkin', 'General Director', '1981-11-24', '(050)33322211')	-- Ошибка: View or function 'Managers' is not updatable because the modification affects multiple base tables.
GO