CREATE DATABASE HomeWorkDb
ON
(
	NAME = 'HomeWorkDb',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeWorkDb.mdf',
	SIZE = 30 MB,
	MAXSIZE = 100 MB,
	FILEGROWTH = 500 KB
)
LOG ON
(
	NAME = 'LogHomeWorkDb',
	FILENAME = 'd:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HomeWorkDbLog.ldf',
	SIZE = 5 MB,
	MAXSIZE = 10 MB,
	FILEGROWTH = 2%
)
GO

EXEC sp_helpdb HomeWorkDb