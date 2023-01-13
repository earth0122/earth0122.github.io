SELECT
	c.CustomerID,
	o.OrderID
FROM Customers c
LEFT OUTER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE o.OrderID IS NULL
