USE HomeWork_004_Weapons
GO

-- Исходная таблица

DROP TABLE Armory
GO

CREATE TABLE Armory
(
	Name varchar (40) NOT NULL,
	Platoon int NOT NULL,
	Weapon varchar (20) NOT NULL,
	WeaponGiver varchar (40) NOT NULL
)
GO

INSERT Armory
VALUES
('Петров В.А., оф.205', 222, 'АК-47', 'Буров О.С., майор'),
('Петров В.А., оф.205', 222, 'Глок20', 'Рыбаков Н.Г., майор'),
('Лодарев П.С., оф.221 ', 232, 'АК-74', 'Деребанов В.Я., подполковник'),
('Лодарев П.С., оф.221 ', 232, 'Глок20', 'Рыбаков Н.Г., майор'),
('Леонтьев К.В., оф.201', 212, 'АК-47', 'Буров О.С., майор'),
('Леонтьев К.В., оф.201', 212, 'Глок20', 'Рыбаков Н.Г., майор'),
('Духов Р.М.', 200, 'АК-47', 'Буров О.С., майор')
GO

SELECT * FROM Armory
GO

---------------------------------------------------------
--						  1 NF 						   --
---------------------------------------------------------

DROP TABLE Armory
DROP TABLE Soldiers
GO

-- Убираем повторяющиеся данные (Platoon (Взвод))
CREATE TABLE Soldiers
(
	Soldier varchar (30) NOT NULL
		PRIMARY KEY,
	Platoon int NOT NULL
)
GO

CREATE TABLE Armory
(
	Soldier varchar (30) NOT NULL
		FOREIGN KEY REFERENCES Soldiers (Soldier)
				ON DELETE CASCADE
					ON UPDATE CASCADE,
	Weapon varchar (20) NOT NULL,
	WeaponGiver varchar (30) NOT NULL
)
GO

INSERT INTO Soldiers
VALUES
('Петров В.А., оф.205', 222),
('Лодарев П.С., оф.221', 232),
('Леонтьев К.В., оф.201', 212),
('Духов Р.М.', 200)
GO

INSERT INTO Armory
VALUES
('Петров В.А., оф.205', 'АК-47', 'Буров О.С., майор'),
('Петров В.А., оф.205', 'Глок20', 'Рыбаков Н.Г., майор'),
('Лодарев П.С., оф.221 ', 'АК-74', 'Деребанов В.Я., подполковник'),
('Лодарев П.С., оф.221 ', 'Глок20', 'Рыбаков Н.Г., майор'),
('Леонтьев К.В., оф.201', 'АК-47', 'Буров О.С., майор'),
('Леонтьев К.В., оф.201', 'Глок20', 'Рыбаков Н.Г., майор'),
('Духов Р.М.', 'АК-47', 'Буров О.С., майор')
GO

SELECT * FROM Armory
SELECT * FROM Soldiers
GO

-- Разбиваем сложные столбцы на атомарные:

DROP TABLE Armory
DROP TABLE Soldiers
GO

CREATE TABLE Soldiers
(
	Soldier varchar (30) NOT NULL
		PRIMARY KEY,
	Office int,		-- Добавляем колонку Office.
	Platoon int NOT NULL
)
GO


CREATE TABLE Armory
(
	Soldier varchar (30) NOT NULL
		FOREIGN KEY REFERENCES Soldiers (Soldier)
				ON DELETE CASCADE
					ON UPDATE CASCADE,
	Weapon varchar (20) NOT NULL,
	WeaponGiver varchar (30) NOT NULL,
	[Rank] varchar (20) NOT NULL	-- Добавляем колонку Rank (Звание) для выдавшего оружие.
)
GO

INSERT INTO Soldiers
VALUES
('Петров В.А.', 205, 222),
('Лодарев П.С.', 221, 232),
('Леонтьев К.В.', 201, 212),
('Духов Р.М.', NULL, 200)
GO

INSERT INTO Armory
VALUES
('Петров В.А.', 'АК-47', 'Буров О.С.', 'майор'),		-- текст "оф.205" и т.п. везде убираем, т.к. данные об офисе уже есть в таблице Soldiers
('Петров В.А.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Лодарев П.С.', 'АК-74', 'Деребанов В.Я.', 'подполковник'),
('Лодарев П.С.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Леонтьев К.В.', 'АК-47', 'Буров О.С.', 'майор'),
('Леонтьев К.В.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Духов Р.М.', 'АК-47', 'Буров О.С.', 'майор')
GO

SELECT * FROM Armory
SELECT * FROM Soldiers
GO

-- Добавляем колонку Line и первичный ключ в таблицу Armory - для последующего приведения ко 2НФ.
DROP TABLE Armory
GO

CREATE TABLE Armory
(
	Line int IDENTITY NOT NULL		-- Добавленный столбец и первичный ключ на нём.
		PRIMARY KEY,
	Soldier varchar (30) NOT NULL
		FOREIGN KEY REFERENCES Soldiers (Soldier)
				ON DELETE CASCADE
					ON UPDATE CASCADE,
	Weapon varchar (20) NOT NULL,
	WeaponGiver varchar (30) NOT NULL,
	[Rank] varchar (20) NOT NULL
)
GO

INSERT INTO Armory
VALUES
('Петров В.А.', 'АК-47', 'Буров О.С.', 'майор'),
('Петров В.А.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Лодарев П.С.', 'АК-74', 'Деребанов В.Я.', 'подполковник'),
('Лодарев П.С.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Леонтьев К.В.', 'АК-47', 'Буров О.С.', 'майор'),
('Леонтьев К.В.', 'Глок20', 'Рыбаков Н.Г.', 'майор'),
('Духов Р.М.', 'АК-47', 'Буров О.С.', 'майор')
GO

SELECT * FROM Armory
SELECT * FROM Soldiers
GO

---------------------------------------------------------
--						  2 NF 						   --
---------------------------------------------------------

-- Условие 2-й НФ "каждый не ключевой столбец должен зависеть от всего ключа" соблюдается для всех таблиц.

---------------------------------------------------------
--						  3 NF 						   --
---------------------------------------------------------

-- Условия 3 НФ:
-- Любой не ключевой столбец не должен зависеть от другого не ключевого столбца - не выполняется.
-- Не должно быть столбцов с производными данными - выполняется.

-- Есть зависимость между не ключевыми столбцами WeaponGiver и Rank, поэтому создаём новую таблицу Officers и изменяем таблицу Armory.

DROP TABLE Armory
DROP TABLE Officers
GO

CREATE TABLE Officers
(
	Officer varchar (30) NOT NULL
		PRIMARY KEY,
	[Rank] varchar (30) NOT NULL
)
GO

CREATE TABLE Armory
(
	Line int IDENTITY NOT NULL
		PRIMARY KEY,
	Soldier varchar (30) NOT NULL
		FOREIGN KEY REFERENCES Soldiers (Soldier)
				ON DELETE CASCADE
					ON UPDATE CASCADE,
	Weapon varchar (20) NOT NULL,
	WeaponGiver varchar (30) NOT NULL
		FOREIGN KEY REFERENCES Officers (Officer)
)
GO

INSERT INTO Officers
VALUES
('Буров О.С.', 'майор'),
('Рыбаков Н.Г.', 'майор'),
('Деребанов В.Я.', 'подполковник')
GO

INSERT INTO Armory
VALUES
('Петров В.А.', 'АК-47', 'Буров О.С.'),
('Петров В.А.', 'Глок20', 'Рыбаков Н.Г.'),
('Лодарев П.С.', 'АК-74', 'Деребанов В.Я.'),
('Лодарев П.С.', 'Глок20', 'Рыбаков Н.Г.'),
('Леонтьев К.В.', 'АК-47', 'Буров О.С.'),
('Леонтьев К.В.', 'Глок20', 'Рыбаков Н.Г.'),
('Духов Р.М.', 'АК-47', 'Буров О.С.')
GO

-- Все условия 3 НФ выполняются.

SELECT * FROM Armory
SELECT * FROM Soldiers
SELECT * FROM Officers
GO