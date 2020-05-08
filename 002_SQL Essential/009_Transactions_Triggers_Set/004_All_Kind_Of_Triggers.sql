USE MyFunkDB
GO

SELECT * FROM Employees
SELECT * FROM PersonalInfo
SELECT * FROM SalaryAndPosition
GO

--1) Триггеры на таблицу Employees
DROP TRIGGER dbo.EmployeesPhoneOperatorAndPosition
GO

CREATE TRIGGER dbo.EmployeesPhoneOperatorAndPosition	--// Схему указываем обязательно
	ON dbo.Employees
	FOR INSERT, UPDATE, DELETE
AS
	IF EXISTS -- Для INSERT, UPDATE
	(
		SELECT * FROM inserted 
			WHERE Phone LIKE '(044)' + '%' OR
			Phone LIKE '(057)' + '%'
	)
BEGIN
	RAISERROR ('В таблицу необходимо вносить только номера мобильных операторов, а не городские номера',1,15)
	ROLLBACK TRAN
END
	ELSE
	IF EXISTS -- Для DELETE - имеющиеся записи в таблице нельзя удалять - на них ссылаются внешние ключи других таблиц. Для работы этого триггера нужно добавить пару записей и не ссылаться на них из других таблиц.
	(
		SELECT * FROM deleted
			WHERE LName = 'Лиллипутов'
	)
BEGIN
	RAISERROR ('В данныый момент нельзя удалять данного сотрудника, у него "иммунитет"...',1,15)
	ROLLBACK TRAN
END
GO 

--2) Триггеры на таблицу PersonalInfo
DROP TRIGGER dbo.PersonalInfoAgeAddress
GO

CREATE TRIGGER dbo.PersonalInfoAgeAddress
	ON PersonalInfo
	FOR INSERT, UPDATE, DELETE
AS
	IF EXISTS -- Для INSERT
	(
	SELECT * FROM inserted
		WHERE BirthDate > '1994-01-01' -- нельзя внести сотрудника младше 1994-01-01
	)
BEGIN
	RAISERROR ('Не принимаются на работу сотрудники младше 22 лет',1,15)
	ROLLBACK TRAN
END
	IF EXISTS -- Для INSERT, UPDATE
	(
	SELECT * FROM inserted  
		WHERE Adress LIKE 'Петренко' + '%' -- нельзя внести адрес, содержащий название улицы Петренко
	)
BEGIN
	RAISERROR ('Адрес сотрудника слишком удалён от офиса. Необходимо решить вопрос с проживанием',1,15)
	ROLLBACK TRAN SavePointPersonalInfoTableIsDone -- откат к точке сохранения	// (Немного интересный триггер... А если не будет точки сохранения?)
END
	IF EXISTS -- Для DELETE
	(
	SELECT * FROM deleted
		WHERE BirthDate > '1956-01-01'	-- нельзя увольнять сотрудников с возрастом, меньше пенсионного
	)
BEGIN
	RAISERROR ('Нельзя увольнять сотрудников ниже пенсионного возраста',1,15)
	ROLLBACK TRAN SavePointPersonalInfoTableIsDone
END
GO

--3) Триггеры для таблицы SalaryAndPosition
DROP TRIGGER dbo.SalaryAndPositionBigSalaryDirector
GO

CREATE TRIGGER dbo.SalaryAndPositionBigSalaryDirector
	ON SalaryAndPosition
	FOR INSERT, UPDATE, DELETE
AS
	IF EXISTS --for INSERT, UPDATE
	(
		SELECT * FROM inserted
		WHERE Salary > 1500
	)
BEGIN
	RAISERROR ('Данная зарплата слишком велика для сотрудника - больше 1500 поднимать нельзя',1,15)
	ROLLBACK TRAN SavePointPersonalInfoIsDone	--// (Немного интересный триггер... А если не будет точки сохранения?)
END
	IF EXISTS --for DELETE
	(
		SELECT * FROM deleted
		WHERE Position = 'Главный директор'
	)
BEGIN
	RAISERROR ('Нельзя удалять данную должность', 1, 15)
	ROLLBACK TRAN SavePointPersonalInfoIsDone	--// (Немного интересный триггер... А если не будет точки сохранения?)
END
GO