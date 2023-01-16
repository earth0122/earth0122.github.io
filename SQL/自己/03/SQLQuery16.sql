-- CustomerID, Total
SELECT
    o.CustomerID,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS Total
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.CustomerID
having SUM(od.UnitPrice * od.Quantity * (1 - od.Discount))>=100000
ORDER BY Total DESC