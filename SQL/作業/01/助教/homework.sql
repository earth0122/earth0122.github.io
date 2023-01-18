-- 1 ��X�M�̶Q�����~�P���O���Ҧ����~
SELECT
	CategoryID
FROM Products
WHERE UnitPrice = (
	SELECT
		MAX(UnitPrice)
	FROM Products
)
--------------------------------------
SELECT
	*
FROM Products
WHERE CategoryID IN (
	SELECT
		CategoryID
	FROM Products
	WHERE UnitPrice = (
		SELECT
			MAX(UnitPrice)
		FROM Products
	)
)

-- 2 ��X�M�̶Q�����~�P���O�̫K�y�����~
SELECT
	CategoryID
FROM Products
WHERE UnitPrice = (
	SELECT
		MAX(UnitPrice)
	FROM Products
)
-------------------------
SELECT
	*
FROM Products
WHERE CategoryID IN (
	SELECT
		CategoryID
	FROM Products
	WHERE UnitPrice = (
		SELECT
			MAX(UnitPrice)
		FROM Products
	)
)
AND UnitPrice = (
	SELECT
		MIN(UnitPrice)
	FROM Products
	WHERE CategoryID IN (
		SELECT
			CategoryID
		FROM Products
		WHERE UnitPrice = (
			SELECT
				MAX(UnitPrice)
			FROM Products
		)
	)
)

-- 3 �p��X�W�����O�̶Q�M�̫K�y����Ӳ��~�����t
SELECT
	MAX(UnitPrice) - MIN(UnitPrice)
FROM Products
WHERE CategoryID IN (
	SELECT
		CategoryID
	FROM Products
	WHERE UnitPrice = (
		SELECT
			MAX(UnitPrice)
		FROM Products
	)
)


-- 4 ��X�S���q�L����ӫ~���Ȥ�Ҧb���������Ҧ��Ȥ�
SELECT DISTINCT
	CustomerID
FROM Orders
-------------------------------
SELECT
	City
FROM Customers
WHERE CustomerID NOT IN (
	SELECT DISTINCT
		CustomerID
	FROM Orders
)
-------------------------------
SELECT
	*
FROM Customers
WHERE City IN (
	SELECT
		City
	FROM Customers
	WHERE CustomerID NOT IN (
		SELECT DISTINCT
			CustomerID
		FROM Orders
	)
)

-- 5 ��X�� 5 �Q��� 8 �K�y�����~�����~���O
--SELECT
--	*
--FROM Products
--ORDER BY UnitPrice DESC

SELECT
	CategoryID
FROM (
	SELECT
		ROW_NUMBER() OVER (ORDER BY UnitPrice DESC) AS [Rank],
		*
	FROM Products
) t
WHERE [Rank] IN ( 5, (SELECT ((SELECT COUNT(*) FROM Products) - 7)) )

-- 6 ��X�ֶR�L�� 5 �Q��� 8 �K�y�����~
SELECT DISTINCT
	CustomerID
FROM Orders o
INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
WHERE ProductID IN (
	SELECT
		ProductID
	FROM (
		SELECT
			ROW_NUMBER() OVER (ORDER BY UnitPrice DESC) AS [Rank],
			*
		FROM Products
	) t
	WHERE [Rank] IN ( 5, (SELECT ((SELECT COUNT(*) FROM Products) - 7)) )
)
-------------------------------------------------------------
SELECT DISTINCT
	CustomerID
FROM Orders
WHERE OrderID IN (
	SELECT
		OrderID
	FROM [Order Details]
	WHERE ProductID IN (
		SELECT
			ProductID
		FROM (
			SELECT
				ROW_NUMBER() OVER (ORDER BY UnitPrice DESC) AS [Rank],
				*
			FROM Products
		) t
		WHERE [Rank] IN ( 5, (SELECT ((SELECT COUNT(*) FROM Products) - 7)) )
	)
)

-- 7 ��X�ֽ�L�� 5 �Q��� 8 �K�y�����~ ??????????
SELECT
	SupplierID
FROM (
	SELECT
		ROW_NUMBER() OVER (ORDER BY UnitPrice DESC) AS [Rank],
		*
	FROM Products
) t
WHERE [Rank] IN ( 5, (SELECT ((SELECT COUNT(*) FROM Products) - 7)) )

-- 8 ��X 13 ���P�������q�� (�c�]���q��)
SELECT
	*
FROM Orders
WHERE DATEPART(WEEKDAY, OrderDate) = 6
AND DAY(OrderDate) = 13

-- 9 ��X�֭q�F�c�]���q��
SELECT DISTINCT
	CustomerID
FROM Orders
WHERE DATEPART(WEEKDAY, OrderDate) = 6
AND DAY(OrderDate) = 13

-- 10 ��X�c�]���q��̦����򲣫~
SELECT DISTINCT
	ProductID
FROM [Order Details]
WHERE OrderID IN (
	SELECT
		OrderID
	FROM Orders
	WHERE DATEPART(WEEKDAY, OrderDate) = 6
	AND DAY(OrderDate) = 13
)

-- 11 �C�X�q�ӨS������ (Discount) �X�⪺���~
SELECT
	*
FROM Products
WHERE ProductID NOT IN (
	SELECT DISTINCT
		ProductID
	FROM [Order Details]
	WHERE Discount <> 0
)

-- 12 �C�X�ʶR�D���ꪺ���~���Ȥ�
SELECT DISTINCT
	CustomerID
FROM (
	SELECT
		*,
		(
			SELECT
				CustomerID
			FROM Orders
			WHERE OrderID = od.OrderID
		) AS CustomerID,
		(
			SELECT
				Country
			FROM Suppliers
			WHERE SupplierID = (
				SELECT
					SupplierID
				FROM Products
				WHERE ProductID = od.ProductID
			)
		) AS SupplierCountry,
		(
			SELECT
				Country
			FROM Customers
			WHERE CustomerID = (
				SELECT
					CustomerID
				FROM Orders
				WHERE OrderID = od.OrderID
			)
		) AS CustomerCountry
	FROM [Order Details] od
) t
WHERE SupplierCountry <> CustomerCountry

-- 13 �C�X�b�P�ӫ����������q���u�i�H�A�Ȫ��Ȥ�
SELECT 
    *
FROM Customers c
WHERE CustomerID IN
(SELECT  CustomerID FROM Orders WHERE  EmployeeID IN
(SELECT  EmployeeID FROM Employees  e WHERE  e.City = c.City ) )
------------------------------
SELECT DISTINCT
    c.CustomerID, c.CompanyName, c.city
FROM Customers c
INNER JOIN Employees e ON e.City = c.city
WHERE c.City = e.City


-- 14 �C�X���ǲ��~�S���H�R�L
SELECT
	*
FROM Products
WHERE ProductID NOT IN (
	SELECT DISTINCT
		ProductID
	FROM [Order Details]
)
