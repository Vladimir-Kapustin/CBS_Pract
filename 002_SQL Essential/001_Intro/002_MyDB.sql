----- 002_Creating of MyDB -----

CREATE DATABASE MyDB
ON
(
	NAME = 'MyDB',
	FILENAME = 'd:\.NET Pract\002_SQL Essential\001_Intro\MyDB.mdf',
	SIZE = 5 MB,
	MAXSIZE = 10 MB,
	FILEGROWTH = 1 MB
)

LOG ON
(
	NAME = 'LogMyDB',
	FILENAME = 'd:\.NET Pract\002_SQL Essential\001_Intro\LogMyDB.ldf',
	SIZE = 1 MB,
	MAXSIZE = 5 MB,
	FILEGROWTH = 500 KB
)
EXECUTE sp_helpdb MyDB;
