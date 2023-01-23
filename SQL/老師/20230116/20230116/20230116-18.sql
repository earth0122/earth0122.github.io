SELECT
	c.CategoryName,
	SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS Total
FROM [Order Details] od
INNER JOIN Products p ON od.ProductID = p.ProductID
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName
ORDER BY Total DESC
