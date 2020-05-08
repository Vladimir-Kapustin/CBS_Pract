USE AdventureWorks2012
GO

SELECT * FROM Production.Product
GO

SELECT * FROM Production.Product
WHERE StandardCost > 100
GO

SELECT * FROM Production.Product
WHERE Name LIKE 'ML%' AND ProductNumber LIKE 'RM%'
GO