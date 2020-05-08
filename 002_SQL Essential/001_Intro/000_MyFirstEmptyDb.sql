--- My First DataBase ---

CREATE DATABASE MyFirstEmptyDb
ON
(
	NAME = 'MyFirstEmptyDb',
	FILENAME = 'd:\.NET Pract\002_SQL Essential\001_Intro\MyFirstEmptyDb.mdf',
	SIZE = 5 MB,
	MAXSIZE = 10 MB,
	FILEGROWTH = 1 MB
)

LOG ON
(
	NAME = 'LogMyFirstEmptyDb',
	FILENAME = 'd:\.NET Pract\002_SQL Essential\001_Intro\LogMyFirstEmptyDb.ldf',
	SIZE = 2 MB,
	MAXSIZE = 5 MB,
	FILEGROWTH = 1 MB
)
EXECUTE sp_helpdb MyFirstEmptyDb;

