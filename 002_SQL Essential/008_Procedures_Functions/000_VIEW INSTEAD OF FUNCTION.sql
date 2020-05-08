USE AdventureWorks2012;
GO

	--CREATE FUNCTION fnContactList() -- создаем функцию
	--RETURNS TABLE -- возвращаемый тип TABLE указывает на то что возвращаться будет таблица
	--AS
	--RETURN (SELECT LastName, FirstName, ModifiedDate 
	--		FROM Person.Person); 
	--GO

	--SELECT * FROM dbo.fnContactList(); -- выводим всю информацию из таблицы сформированой при помощи функции fnContactList();
	--GO

-- ЗАДАНИЕ: повторите предыдущий пример с помощью представления

DROP VIEW fnContactListView
GO

CREATE VIEW fnContactListView
AS
SELECT LastName, FirstName, ModifiedDate 
		FROM Person.Person
GO

SELECT * FROM fnContactListView
GO