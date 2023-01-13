SELECT
	c.CustomerID, c.CompanyName,
	p.ProductID, p.ProductName
FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
INNER JOIN Products p ON od.ProductID = p.ProductID		
