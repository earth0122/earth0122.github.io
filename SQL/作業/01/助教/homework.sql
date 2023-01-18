-- 1 找出和最貴的產品同類別的所有產品
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

-- 2 找出和最貴的產品同類別最便宜的產品
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

-- 3 計算出上面類別最貴和最便宜的兩個產品的價差
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


-- 4 找出沒有訂過任何商品的客戶所在的城市的所有客戶
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

-- 5 找出第 5 貴跟第 8 便宜的產品的產品類別
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

-- 6 找出誰買過第 5 貴跟第 8 便宜的產品
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

-- 7 找出誰賣過第 5 貴跟第 8 便宜的產品 ??????????
SELECT
	SupplierID
FROM (
	SELECT
		ROW_NUMBER() OVER (ORDER BY UnitPrice DESC) AS [Rank],
		*
	FROM Products
) t
WHERE [Rank] IN ( 5, (SELECT ((SELECT COUNT(*) FROM Products) - 7)) )

-- 8 找出 13 號星期五的訂單 (惡魔的訂單)
SELECT
	*
FROM Orders
WHERE DATEPART(WEEKDAY, OrderDate) = 6
AND DAY(OrderDate) = 13

-- 9 找出誰訂了惡魔的訂單
SELECT DISTINCT
	CustomerID
FROM Orders
WHERE DATEPART(WEEKDAY, OrderDate) = 6
AND DAY(OrderDate) = 13

-- 10 找出惡魔的訂單裡有什麼產品
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

-- 11 列出從來沒有打折 (Discount) 出售的產品
SELECT
	*
FROM Products
WHERE ProductID NOT IN (
	SELECT DISTINCT
		ProductID
	FROM [Order Details]
	WHERE Discount <> 0
)

-- 12 列出購買非本國的產品的客戶
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

-- 13 列出在同個城市中有公司員工可以服務的客戶
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


-- 14 列出那些產品沒有人買過
SELECT
	*
FROM Products
WHERE ProductID NOT IN (
	SELECT DISTINCT
		ProductID
	FROM [Order Details]
)
