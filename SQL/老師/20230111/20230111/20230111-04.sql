SELECT
	p.ProductID, p.ProductName, p.CategoryID,
	c.CategoryID, c.CategoryName,
	s.CompanyName
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID