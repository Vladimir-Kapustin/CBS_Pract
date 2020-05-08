USE MyFunkDB
GO

SELECT * FROM Employees
SELECT * FROM PersonalInfo
SELECT * FROM SalaryAndPosition
GO

-- Procedures:
-- 1) Требуется узнать контактные данные сотрудников (номера телефонов, место жительства). 
DROP PROC ContactsProc
GO

CREATE PROC ContactsProc
	@EmployeeID int = NULL
AS
	IF @EmployeeID IS NOT NULL
		SELECT FName, LName, Phone, Adress
		FROM Employees emp
			JOIN
			PersonalInfo [pi]
		ON emp.EmployeeID = [pi].EmployeeID
		WHERE emp.EmployeeID = @EmployeeID
	ELSE
	SELECT FName, LName, Phone, Adress
		FROM Employees emp
			JOIN
			PersonalInfo [pi]
		ON emp.EmployeeID = [pi].EmployeeID
GO

EXEC ContactsProc 5
GO

-- 2) Требуется узнать информацию о дате рождения всех не женатых сотрудников и номера телефонов этих сотрудников.
DROP PROC MarriageProc
GO

CREATE PROC MarriageProc
AS
	SELECT FName, LName, MartialStatus, BirthDate, Phone
	FROM Employees as e
		JOIN
		PersonalInfo as p
	ON e.EmployeeID = p.EmployeeID
	WHERE p.MartialStatus = 'Не женат'
	OR p.MartialStatus = 'Не замужем'
GO

EXEC MarriageProc
GO

-- 3) Требуется узнать информацию о дате рождения всех сотрудников с должностью менеджер и номера телефонов этих сотрудников.
DROP PROC ManagersProc
GO

CREATE PROC ManagersProc
AS
BEGIN
	SELECT FName, LName, Position, BirthDate, Phone
	FROM PersonalInfo p
		JOIN
		Employees e
	ON p.EmployeeID = e.EmployeeID 
		JOIN
		SalaryAndPosition s
	ON e.EmployeeID = s.EmployeeID
	WHERE Position = 'Менеджер'

	PRINT 'Сейчас посчитается количество менеджеров'
	DECLARE @Count int
	
	SET @Count = 
	(SELECT COUNT (*)
	FROM PersonalInfo p
		JOIN
		Employees e
	ON p.EmployeeID = e.EmployeeID 
		JOIN
		SalaryAndPosition s
	ON e.EmployeeID = s.EmployeeID
	WHERE Position = 'Менеджер')

	RETURN @Count		-- Хотя можно просто написать PRINT здесь и не делать потом сложных вызовов с объявлением переменных и т.п.
END
GO						-- // Ещё можно вложенную функцию сделать...

EXEC ManagersProc
GO

DECLARE @MyVar int
EXEC @MyVar = ManagersProc
PRINT 'Количество сотрудников с должностью Менеджер - ' + CAST(@MyVAR as varchar)+ ' человек(а)'
GO

-- Functions
-- 1) Требуется узнать контактные данные сотрудников (номера телефонов, место жительства). 
DROP FUNCTION ContactsFunc
GO

CREATE FUNCTION ContactsFunc (@Id int = NULL)
RETURNS @Result TABLE							-- только если возвращается переменная табличного типа функция может содержать в себе несколько команд в батче BEGIN - END.
	(
	Fname varchar (40),
	Lname varchar (40),
	Phone varchar (12),
	[Address] varchar (40)
	)
AS
BEGIN
	IF @Id IS NULL
	INSERT @Result SELECT FName, LName, Phone, Adress	-- заменить потом на [Address] - а то я в файле создания таблиц поковырялся уже после того как их создал. Чтоб не матюкнулось на поле Adress (с одной d).
				FROM Employees e
					JOIN
					PersonalInfo i
				ON e.EmployeeID = i.EmployeeID
	ELSE
	INSERT @Result SELECT FName, LName, Phone, Adress
				FROM Employees e
					JOIN
					PersonalInfo i
				ON e.EmployeeID = i.EmployeeID
				WHERE e.EmployeeID = @Id
RETURN	-- переменную @Result не пишем, иначе будет ошибка!
END
GO

SELECT * FROM dbo.ContactsFunc(default) -- вот оно как делается, когда в функции указываются необязательные параметры!
GO

SELECT * FROM dbo.ContactsFunc(5)
GO

-- 2) Требуется узнать информацию о дате рождения всех не женатых сотрудников и номера телефонов этих сотрудников. 
DROP FUNCTION MarriageFunc
GO

CREATE FUNCTION MarriageFunc ()
RETURNS TABLE
AS 
	RETURN (SELECT FName, LName, MartialStatus, BirthDate, Phone
	FROM Employees as e
		JOIN
		PersonalInfo as p
	ON e.EmployeeID = p.EmployeeID
	WHERE p.MartialStatus = 'Не женат'
	OR p.MartialStatus = 'Не замужем')
GO

SELECT * FROM dbo.MarriageFunc()
GO

-- 3) Требуется узнать информацию о дате рождения всех сотрудников с должностью менеджер и номера телефонов этих сотрудников.
DROP FUNCTION ManagersFunc
GO
DROP FUNCTION CountManagers
GO

CREATE FUNCTION ManagersFunc ()
RETURNS TABLE
AS
RETURN (SELECT FName, LName, Position, BirthDate, Phone
	FROM PersonalInfo p
		JOIN
		Employees e
	ON p.EmployeeID = e.EmployeeID 
		JOIN
		SalaryAndPosition s
	ON e.EmployeeID = s.EmployeeID
	WHERE Position = 'Менеджер')
GO

CREATE FUNCTION CountManagers ()	-- Дополнительная функция для подсчёта менеджеров
RETURNS int
AS
BEGIN
	DECLARE @Count int
	
	SET @Count = 
	(SELECT COUNT (*)
	FROM dbo.ManagersFunc())
	RETURN @Count
END									-- А вот и нет! (по поводу того, что только если функция возвращает переменную табличного типа то функция может содержать несколько команд в батче BEGIN-END). Может! На самом деле функция может содержать несколько команд в батче BEGIN-END в любом случае, переменную какого бы типа она не возвращала. Это наверное имелось ввиду по поводу оператора SELECT... или INSERT... тогда всё равно бред какой-то получается, но это я не проверял... Где я это неверное утверждение взял - не помню :)...
GO

SELECT * FROM dbo.ManagersFunc()
GO

PRINT 'Количество сотрудников с должностью Менеджер - ' + CAST (dbo.CountManagers() as varchar)