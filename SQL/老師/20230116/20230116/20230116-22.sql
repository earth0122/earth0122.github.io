SELECT c.* FROM Customers c
WHERE c.CustomerID = (
	SELECT
		o.CustomerID
	FROM Orders o
	WHERE o.OrderDate = (
		SELECT
			MAX(OrderDate)
		FROM Orders
		WHERE CustomerID = o.CustomerID
	)
	GROUP BY o.CustomerID, o.OrderDate
	HAVING COUNT(*) > 1
)


