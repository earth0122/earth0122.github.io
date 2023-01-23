WITH t1 AS (
	SELECT
		CategoryID, AVG(UnitPrice) AS AvgPrice
	FROM Products
	GROUP BY CategoryID
)
SELECT * FROM t1
WHERE AvgPrice > 5