SELECT
	p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName
INTO Table9
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE p.UnitPrice > 20

SELECT * FROM Table9
