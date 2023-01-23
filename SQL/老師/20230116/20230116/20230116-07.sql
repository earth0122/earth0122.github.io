INSERT INTO Table9(ProductID, ProductName, UnitPrice, CategoryName)
SELECT
	p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE p.UnitPrice < 0.1

SELECT * FROM Table9
