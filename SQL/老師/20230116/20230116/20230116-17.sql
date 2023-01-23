SELECT
	ProductID,
	SUM(UnitPrice * Quantity * (1 - Discount)) AS Total
FROM [Order Details]
GROUP BY ProductID
ORDER BY Total DESC
