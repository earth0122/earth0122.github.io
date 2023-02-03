-- 建立 PIVOT 表，統計銷售金額如下：
-- City, [Beverages], [Condiments], [Seafood]

-- 使用 NTILE window 函數，以銷售金額分成 5 等分，
-- 統計不同國家的客戶在這 5 個級距的平均銷售金額
-- Country, [1], [2], [3], [4], [5]
WITH t1 AS (
    SELECT
        c.Country, c.CustomerID,
        SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS SalesAmount,
        NTILE(5) OVER (
		PARTITION BY Country  --按照Country 做NTile
            ORDER BY SUM(od.UnitPrice * od.Quantity * (1 - od.Discount))
        ) AS [NTile]
    FROM Customers c
    INNER JOIN Orders o ON o.CustomerID = c.CustomerID
    INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
    GROUP BY c.Country, c.CustomerID
),
t2 AS (
    SELECT
        Country, [NTile], SUM(SalesAmount) AS SalesAmount
    FROM t1
    GROUP BY Country, [NTile]
)
SELECT
    Country, [1], [2], [3], [4], [5]
FROM t2
PIVOT (
    AVG(SalesAmount) FOR NTile IN ([1], [2], [3], [4], [5])
) AS pvt
-- 按照 UnitPrice 由大排到小，找出與前一筆產品價格相差 5 元以上的產品

-- 寫一個 TVF 可以帶入上一題所要過濾的價格差 @diff_price，
-- 傳回與前一筆價格相差 @diff_price 的產品

-- 列出年紀最大的員工最早的一筆訂單的日期

-- 列出每一個客戶所購買的同城市供應商所生產的產品
	SELECT
	  p.*,c.City,c.CustomerID,s.SupplierID
	FROM Customers c
	INNER JOIN Orders o ON o.CustomerID = c.CustomerID
	INNER JOIN [Order Details] od ON od.OrderID =o.OrderID
	INNER JOIN Products p ON od.ProductID = p.ProductID
	INNER JOIN Suppliers s ON p.SupplierID = S.SupplierID
	WHERE c.City=s.City
-- 列出每一個客戶所購買的同城市供應商所生產的產品的總銷售金額

-- 列出高於平均單價以上的產品在不同城市的銷售量

-- 列出業績最差的員工賣最好的產品

-- 列出職稱 (ContactTitle) 是 Sales 開頭的客戶最近一次訂單購買的產品清單

-- 列出公司最資深員工與最資淺員工之間的業績差距

-- 列出不同國家與不同產品類別的銷售量統計
SELECT
    c.Country, p.CategoryID,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS SalesAmount
FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
INNER JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.Country, p.CategoryID
-- 列出每個國家中賣得最好的產品與銷售金額

-- 列出銷售量最多的城市各類型產品的銷售明細
SELECT
    c.City, p.CategoryID,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS SalesAmount
FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
INNER JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.City, p.CategoryID
HAVING c.City = (
    SELECT TOP 1
        c.City
    FROM Customers c
    INNER JOIN Orders o ON o.CustomerID = c.CustomerID
    INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
    INNER JOIN Products p ON od.ProductID = p.ProductID
    GROUP BY c.City
    ORDER BY SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) DESC
-- 寫一支預存程序，用來新增一筆供應商 (Suppliers) 資料

-- 列出銷售數量最高的產品是那些客戶訂的，每年度分別訂多少

-- 列出每位員工的下屬的業績總金額
WITH sales AS (
    SELECT
        e.EmployeeID, e.ReportsTo,
        SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS SalesAmount
    FROM Employees e
    INNER JOIN Orders o ON o.EmployeeID = e.EmployeeID
    INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
    GROUP BY e.EmployeeID, e.ReportsTo
),
t AS (
    SELECT
        EmployeeID, ReportsTo, SalesAmount, CAST(EmployeeID AS varchar(1000)) AS Hierarchy
    FROM sales
    WHERE ReportsTo IS NULL
    UNION ALL
    SELECT
        sales.EmployeeID, sales.ReportsTo, sales.SalesAmount, CAST(t.Hierarchy + '/' + CAST(sales.EmployeeID AS varchar(50)) AS varchar(1000))
    FROM sales
    INNER JOIN t ON t.EmployeeID = sales.ReportsTo
)
SELECT
    me.*, (
        SELECT
            COALESCE(SUM(SalesAmount),0)
        FROM t
        WHERE Hierarchy LIKE CAST(me.Hierarchy AS varchar(1000)) + '/%'
    ) AS TotalSales
FROM t me