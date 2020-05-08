--Заданиче аналогично заданию 2 в предыдущей теме - JOINs. Это копия.
CREATE DATABASE MyJoinsDB
ON
(
	NAME = 'MyJoinsDB',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MyJoinsDB.mdf',
	SIZE = 5 Mb,
	MAXSIZE = 15 Mb,
	FILEGROWTH = 3 Mb
)
LOG
ON
(
	NAME = 'LogMyJoinsDB',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MyJoinsDB_Log.ldf',
	SIZE = 3 Mb,
	MAXSIZE = 9 Mb,
	FILEGROWTH = 1 Mb
)
GO