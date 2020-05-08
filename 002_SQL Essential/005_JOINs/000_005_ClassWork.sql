USE ShopDB
GO

SELECT * FROM Customers
SELECT * FROM Employees
SELECT * FROM OrderDetails
SELECT * FROM Orders
SELECT * FROM Products
GO

-- Самостоятельное задание: 1. Показать статистику по количеству проданых едениц товара в порядке убывания (от большего к меньшему)

SELECT Qty, OrderDetails.ProdID, [Description], Orders.CustomerNo, Customers.FName, Customers.LName, Orders.EmployeeID, Employees.FName, Employees.LName FROM 
									OrderDetails
									JOIN
									Products
ON OrderDetails.ProdID = Products.ProdID
									JOIN
									Orders
ON OrderDetails.OrderID = Orders.OrderID
									JOIN
									Employees
ON Orders.EmployeeID = Employees.EmployeeID
									JOIN
									Customers
ON Orders.CustomerNo = Customers.CustomerNo
ORDER BY Qty
GO 

-- Вот накрутил... Вот оно, правильное:
SELECT [Description],  SUM (OrderDetails.Qty) as TotalQuantity FROM
									Products
									JOIN
									OrderDetails
ON Products.ProdID = OrderDetails.ProdID
GROUP BY [Description]
ORDER BY TotalQuantity DESC
GO
		
--							2. Вывести общую суму продаж по каждому из товаров

SELECT SUM(Qty) AS Quantity, Products.UnitPrice, SUM(TotalPrice) AS '-=!!! Total Price !!!=-', OrderDetails.ProdID, Products.[Description] FROM 
										OrderDetails
										JOIN
										Products
ON OrderDetails.ProdID = Products.ProdID
GROUP BY OrderDetails.ProdID, [Description], Products.UnitPrice
GO

-- Опять усложнил. И не правильно... Вот проще (и правильнее):
SELECT [Description], SUM (TotalPrice) as '-=! Total Price !=-' FROM
							Products
							LEFT JOIN
							OrderDetails
ON Products.ProdID = OrderDetails.ProdID
GROUP BY [Description]
GO

--							3. Вывести общее количество продаж по каждому из сотрудиков

SELECT Employees.EmployeeID, Employees.FName, Employees.LName, SUM(Qty) AS 'Quantity Of Sales' FROM
										OrderDetails
										JOIN
										Orders
ON OrderDetails.OrderID = ORDERS.OrderID
										RIGHT OUTER JOIN
										Employees
ON ORDERS.EmployeeID = Employees.EmployeeID
GROUP BY	Employees.EmployeeID, 
			Employees.FName, 
			Employees.LName
GO
-- Не элегантно...

-- Вот в принципе то же самое, только вместо количества - общая сумма продаж:
SELECT FName, LName, SUM (TotalPrice) AS 'Total Sales ($)' FROM
						Employees
						LEFT JOIN
						Orders
ON Employees.EmployeeID = Orders.EmployeeID
						LEFT JOIN
						OrderDetails
ON Orders.OrderID = OrderDetails.OrderID
GROUP BY FName, LName
GO

--							4. Показать даты покупок по каждому из покупателей

SELECT Customers.CustomerNo, Customers.FName, Customers.LName, Customers.Phone, OrderDate FROM
							Customers
							LEFT OUTER JOIN
							Orders
ON Customers.CustomerNo = orders.CustomerNo
GO
-- Всё нормально, но количество колонок можно сократить.

--							5. Вывести кто из продавцов каких покупателей обслуживает.

SELECT Employees.EmployeeID, Employees.FName, Employees.LName, Customers.FName AS 'Customer First Name', Customers.LName AS 'Customer Last Name' FROM
							Employees
							LEFT OUTER JOIN
							Orders
ON Employees.EmployeeID = Orders.EmployeeID
							FULL JOIN
							Customers
ON Orders.CustomerNo = Customers.CustomerNo
GO
