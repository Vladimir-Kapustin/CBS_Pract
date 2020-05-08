USE MyFunkDB
GO

CREATE TABLE Employees
(
	EmployeeID int IDENTITY NOT NULL
		PRIMARY KEY,
	FName varchar (40) NOT NULL,
	LName varchar (40) NOT NULL,
	Phone char (12) NOT NULL,
		CHECK (Phone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

CREATE TABLE SalaryAndPosition
(
	EmployeeID int NOT NULL
		PRIMARY KEY
		FOREIGN KEY REFERENCES Employees (EmployeeID),
	Salary smallmoney NOT NULL,
	Position varchar (40) NOT NULL
)
GO

CREATE TABLE PersonalInfo
(
	EmployeeID int NOT NULL
		PRIMARY KEY
		FOREIGN KEY REFERENCES Employees (EmployeeID),
	MartialStatus varchar (40) NOT NULL,
	BirthDate date NOT NULL,
	[Address] varchar (40) NOT NULL
)
GO

INSERT INTO Employees
VALUES
	('Александр',	'Котляров',	'(093)9874545'),
	('Иван',	'Петров',	'(050)4542412'),
	('Андрей',	'Супрунов',	'(066)7874545'),
	('Глеб',	'Кристофоров',	'(097)2312424'),
	('Анна',	'Белкина',	'(099)5554447'),
	('Ольга',	'Коваленко',	'(068)4457788'),
	('Зигмунд',	'Унакий',	'(098)5547799'),
	('Елена',	'Протопопова',	'(093)3215487'),
	('Хуан',	'Эспиноза',	'(095)4856712'),
	('Jose',	'Del Villiar',	'(098)5557788')
GO

INSERT INTO	SalaryAndPosition
VALUES
	(1,1500,'Главный директор'),
	(2,700,	'Менеджер'),
	(3,600,	'Менеджер'),
	(4,500,	'Менеджер'),
	(5,120,	'Рабочий'),
	(6,140,	'Рабочий'),
	(7,90,	'Рабочий'),
	(8,130,	'Рабочий'),
	(9,150,	'Рабочий'),
	(10,100,'Рабочий')

GO

INSERT INTO	PersonalInfo
VALUES
	(1,  'Женат', '1968-05-05', 'Петрова, 65'),
	(2,  'Не Женат', '1975-06-06', 'Иванова 45'),
	(3,  'Женат', '1974-07-04', 'Сидорова, 23'),
	(4,  'Не Женат', '1973-06-08', 'Пякина, 67'),
	(5,  'Замужем', '1985-03-04', 'Сидоренко, 56'),
	(6,  'Не замужем', '1987-07-12', 'Ленина, 4'),
	(7,  'Женат', '1983-12-25', 'Киквидзе, 9'),
	(8,  'Замужем', '1980-11-09', 'Гончарная, 8'),
	(9,  'Не Женат', '1981-09-29', 'Дмитриеусская, 77'),
	(10, 'Женат', '1980-10-23', 'Лётчиков, 76')
GO

SELECT * FROM Employees
SELECT * FROM SalaryAndPosition
SELECT * FROM PersonalInfo
GO