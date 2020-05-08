USE HomeWork
GO

SELECT * FROM Product
GO

SELECT * FROM Product
WHERE [Count] > 59
GO

-- Или --

SELECT ProductId, Name, ProductNumber, [Count]
FROM Product
WHERE [Count]> 59
GO

--DECLARE @VerifyDate Date = CAST ('2011-08-19' AS Date)

SELECT * FROM Product
WHERE Cost_$ > 3
AND SellStartDate > '2011-08-19'
GO

UPDATE Product
SET Cost_$=Cost_$+0.25
WHERE Name='Свиточ'
GO

SELECT * FROM Product
GO
