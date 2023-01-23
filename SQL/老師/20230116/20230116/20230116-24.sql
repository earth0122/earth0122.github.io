SELECT
	c.*
FROM Customers c
WHERE NOT EXISTS (
	SELECT * FROM Orders
	WHERE CustomerID = c.CustomerID
)
