SELECT
	c.CustomerID, c.CompanyName,
	o.OrderID, o.OrderDate
FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE OrderDate = (
	SELECT
		MAX(OrderDate)
	FROM Orders
	WHERE CustomerID = o.CustomerID
)
