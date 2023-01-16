select
c.*
from Customers c
where CustomerID in(
SELECT
    o.CustomerID
  
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.CustomerID
HAVING SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) >= 100000
)

