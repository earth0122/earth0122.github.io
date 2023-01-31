select
c.CategoryName as Calegory,
od.Quantity as Qty,
year(o.OrderDate)as Orderyear
into SalesData
from Categories c
inner join Products p on p.CategoryID=c.CategoryID
inner join [Order Details] od on od.ProductID = p.ProductID
inner join Orders o on od.OrderID = o.OrderID