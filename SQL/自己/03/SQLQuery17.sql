SELECT
    o.CustomerID,
    (
        SELECT
            CompanyName
        FROM Customers
        WHERE CustomerID = o.CustomerID
    ) AS CompanyName,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS Total
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.CustomerID
HAVING SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) >= 100000
ORDER BY Total DESC