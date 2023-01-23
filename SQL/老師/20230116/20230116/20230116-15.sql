SELECT
	CategoryID, SupplierID,
	AVG(UnitPrice),
	MIN(UnitPrice),
	MAX(UnitPrice),
	SUM(UnitPrice),
	COUNT(UnitPrice)
FROM Products
GROUP BY CategoryID, SupplierID
