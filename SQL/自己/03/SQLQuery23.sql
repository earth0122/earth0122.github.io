SELECT
    *
FROM Customers
WHERE City IN (
    SELECT
        City
    FROM Customers
    WHERE CustomerID IN (
        SELECT
            o.CustomerID
        FROM [Order Details] od
        INNER JOIN Orders o ON od.OrderID = o.OrderID
        GROUP BY o.CustomerID
        HAVING SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) >= 100000
    )
)