USE AdventureWorks2012
GO

DROP VIEW vContactList
GO

CREATE VIEW vContactList
WITH SCHEMABINDING
AS
SELECT LastName, FirstName, ModifiedDate
FROM Person.Person
GO

SELECT * FROM vContactList