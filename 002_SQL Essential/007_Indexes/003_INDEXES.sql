USE MyJoinsDB
GO

SELECT * FROM Employees			-- кластеризованна€ таблица.
SELECT * FROM PersonalInfo		-- кластеризованна€ таблица.
SELECT * FROM SalaryPosition	-- кластеризованна€ таблица.
GO

CREATE UNIQUE NONCLUSTERED INDEX PK_IND1	-- ќбоснование: быстрый поиск по телефону. “елефон должен быть уникальным при внесении нового сотрудника.
ON Employees(Phone)
GO

-- проверка планов выполнени€ запросов из таблицы с таким индексом:
SELECT * FROM Employees WHERE Phone LIKE '%78745%'	-- 'Clustered Index Scan (Clustered)' - при использовании IN, LIKE или т.п., а также, если знак '=' вернЄт более одного значени€ - будет такой план.
SELECT * FROM Employees WHERE Phone = '(093)9874545'	-- только при использовании '=', которое вернЄт только ≈ƒ»Ќ»„Ќќ≈ значение будет поиск по некластеризованному индексу (а потом и по кластеризованному).

CREATE UNIQUE NONCLUSTERED INDEX PK_IND2	-- ќбоснование: быстрый поиск по адресу. ” всех сотрудников должен быть уникальный адрес ;).
ON PersonalInfo([Address])
GO

-- проверка плана выполнени€:
SELECT * FROM PersonalInfo WHERE [Address] = 'сидорова, 23'	

CREATE NONCLUSTERED INDEX PK_IND3			-- ќбоснование почти безосновательное :) - быстрый поиск по семейному положению (а их всего-то - 4!). ≈стественно - не уникален.
ON PersonalInfo(MarriageStatus)
GO

-- проверка плана выполнени€ запроса:
SELECT * FROM PersonalInfo WHERE MarriageStatus = 'не женат'	--'Clustered Index Scan (Clustered)'... т.е., когда значени€ на колонке, на которой задан некластеризованный индекс, не уникальны, производитс€ сканирование кластеризованного индекса. Ѕезосновательного ничего не бывает. ќснование, казалось бы, не заслуживающее внимани€, а помогло увидеть этот момент (€ думал, что при знаке = всегда будет поочерЄдный поиск по 2-м индексам)

CREATE NONCLUSTERED INDEX PK_IND4			-- ќбоснование - незначительное - быстрый поиск по должности. Ќе уникален.
ON SalaryPosition(Position)
GO

-- проверка плана выполнени€ запроса:
SELECT * FROM SalaryPosition WHERE Position = 'менеджер'	--'Clustered Index Scan (Clustered)'.