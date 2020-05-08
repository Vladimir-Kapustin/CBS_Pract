-- Самостоятельное задание: 1. Показать статистику по количеству проданых едениц товара в порядке убывания (от большего к меньшему)
--							2. Вывести общую суму продаж по каждому из товаров
--							3. Вывести общее количество продаж по каждому из сотрудиков
--							4. Вывести количество продаж по городам
--							5. Показать даты покупок по каждому из покупателей
--							6. Вывести кто из продавцов каких покупателей обслуживает.

--							++ Работа над ошибками.

USE ShopDB
GO

SELECT * FROM Orders
SELECT * FROM OrderDetails
GO

						-- 1. Показать статистику по количеству проданых едениц товара в порядке убывания (от большего к меньшему)
SELECT Qty, (SELECT [Description] FROM Products WHERE OrderDetails.ProdID = Products.ProdID) AS ProductName, 
	(SELECT LName FROM Customers WHERE Customers.CustomerNo = (SELECT CustomerNo FROM Orders WHERE OrderDetails.OrderID = Orders.OrderID)) AS CustomerLastName
		FROM OrderDetails
			ORDER BY Qty DESC
GO
-- Здесь не получится сгруппировать так, чтобы выводило сколько всего было продано единиц по одному наименованию товара. Т.к., со вложенными запросами в предложении SELECT этот фокус не пройдёт - их нельзя группировать, судя по всему...

-- Можно проще:
SELECT (SELECT [Description] FROM Products WHERE Products.ProdID = OrderDetails.ProdID) AS 'Name Of Product', Qty
	FROM OrderDetails
	ORDER BY Qty DESC
GO

-- А чтоб сгруппировало, можно так:
CREATE TABLE #GoodsTotalSold	--временная таблица
(
	[Description] varchar (40),
	Qty int
)
GO

SELECT (SELECT [Description] FROM Products WHERE Products.ProdID = OrderDetails.ProdID) as Name, Qty
	INTO GoodsTotalSold
	FROM OrderDetails
	ORDER BY Qty DESC
GO

SELECT Name, SUM (Qty) as Total 
FROM GoodsTotalSold
GROUP BY Name
ORDER BY Total DESC
GO

-- Или так:
WITH GoodsSold ([Description], Qty) AS		--Обобщённое табличное выражение
(
SELECT (SELECT [Description] FROM Products WHERE Products.ProdID = OrderDetails.ProdID), Qty
	FROM OrderDetails
)
SELECT [Description], SUM (Qty) as Total
	FROM GoodsSold
	GROUP BY [Description]
	ORDER BY Total DESC
GO

						-- 2. Вывести общую суму продаж по каждому из товаров
CREATE TABLE #TempProductSales	--Применяем временные таблицы
(
	Name varchar (40) NOT NULL,
	TotalPrice money NOT NULL
)
GO

SELECT (SELECT [Description] FROM Products WHERE 
		OrderDetails.ProdID = Products.ProdID) AS [Description], --алиас обязятелен.
		TotalPrice
	INTO TempProductSales
		FROM OrderDetails
GO

SELECT [Description], SUM(TotalPrice) AS TotalPrice
	FROM TempProductSales
		GROUP BY [Description]
GO

						-- 3. Вывести общее количество продаж по каждому из сотрудиков
WITH TotalEmpPrices (FName, LName, Qty, TotalPrice) AS		--Применяем обобщённые табличные выражения.
(
SELECT (SELECT FName FROM Employees 
		WHERE EmployeeID = (
							SELECT EmployeeID FROM Orders	
							WHERE Orders.OrderID = OrderDetails.OrderID)
							)AS FName,
	   (SELECT LName FROM Employees 
		WHERE EmployeeID = (
							SELECT EmployeeID FROM Orders	
							WHERE Orders.OrderID = OrderDetails.OrderID)
							)AS FName,
							Qty,
							TotalPrice
FROM OrderDetails
)
SELECT FName, LName, SUM(Qty) AS OverallQuantity, SUM (TotalPrice) as TotalPrice
	FROM TotalEmpPrices
	GROUP BY FName, LName
GO
--выводит только по тем, кто продавал, и не показывает NULL по тем, кто не продавал (как это можно было бы сделать с помощью JOINs). Я пока такого решения (с NULL) не нашёл -
--столкнулся с проблемой, что вложенные запросы возвращают список - там, где должно возвращаться только одно значение. Поэтому выдаётся ошибка. Сравнил с эталонным решением -
--оно такое же, как и приведено выше. Того, что я хотел сделать со вложенными запросами - в ответах нет. (more than 1 value is not permitted when the subquery is used as an 
--expression...)

--WITH SalesByManagers (Qty, TotalPrice, OrderID, FName, LName) AS
--(
--SELECT Qty, TotalPrice, (SELECT OrderID FROM Orders
--						WHERE Orders.OrderID = OrderDetails.OrderID), (SELECT FName FROM Employees
--																		WHERE Employees.EmployeeID = Orders.EmployeeID)
--																		............ FAIL SOLUTION .............. потратил 3,5 часа
--FROM OrderDetails
--)

						-- 4. Вывести количество продаж по городам
WITH QuantityByCities (City, Qty) AS
(
SELECT (
		SELECT City FROM Customers WHERE
		CustomerNo = (
						SELECT CustomerNo FROM Orders WHERE
						Orders.OrderID = OrderDetails.OrderID
					  )
		) AS City, 
		Qty
FROM OrderDetails
)
SELECT City, SUM (Qty) FROM QuantityByCities
GROUP BY City
GO

						-- 5. Показать даты покупок по каждому из покупателей
SELECT OrderDate, (SELECT FName FROM Customers WHERE
							Customers.CustomerNo = Orders.CustomerNo) AS FirstName,
					(SELECT LName FROM Customers WHERE
							Customers.CustomerNo = Orders.CustomerNo) AS LastName
FROM Orders
GO -- здесь не показаны покупатели, по которым вообще нет даты покупок.

-- вот правильное решение:
SELECT FName, MName, LName, 
							(SELECT OrderDate FROM Orders
							WHERE Cust.CustomerNo = Orders.CustomerNo) 
FROM Customers AS Cust
GO

						-- 6. Вывести кто из продавцов каких покупателей обслуживает.
SELECT	(SELECT FName FROM Employees WHERE 
				Employees.EmployeeID = (SELECT EmployeeID FROM Orders WHERE
										Orders.CustomerNo = Customers.CustomerNo)) AS EmpFirstName,
		(SELECT LName FROM Employees WHERE 
				Employees.EmployeeID = (SELECT EmployeeID FROM Orders WHERE
										Orders.CustomerNo = Customers.CustomerNo)) AS EmpLastName,
		Customers.FName AS ClientFirstName,
		Customers.LName AS ClientLastName
FROM Customers
GO --Здесь выводит и тех покупателей, которых не обслуживает никто.

--Вот более правильный, читабельный и элегантный вариант:
SELECT Orders.EmployeeID AS ID,
	(SELECT FName FROM Employees WHERE Employees.EmployeeID = Orders.EmployeeID) + ' ' +
	(SELECT LName FROM Employees WHERE Employees.EmployeeID = Orders.EmployeeID) AS 'Seller Who Serves',
	Orders.CustomerNo AS [No],
	(SELECT FName FROM Customers WHERE Customers.CustomerNo = Orders.CustomerNo) + ' ' +
	(SELECT LName FROM Customers WHERE Customers.CustomerNo = Orders.CustomerNo) AS 'Customer Served by Seller'
FROM Orders
GO