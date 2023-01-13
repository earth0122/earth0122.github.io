SELECT
	c.CustomerID,
	p.ProductID
FROM Customers c
CROSS JOIN Products p
