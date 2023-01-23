WITH t1 AS (
	SELECT
		SUM(od.UnitPrice * od.Quantity * ( 1 - od.Discount )) AS Total	
	FROM Orders o
	INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
	GROUP BY o.CustomerID
)
SELECT 
	MAX(Total) - MIN(Total)
FROM t1
