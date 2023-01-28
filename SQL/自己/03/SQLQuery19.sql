select
o.CustomerID,
sum(od.UnitPrice*od.Quantity*(1-Discount))as total
from [Order Details] od
inner join Orders o on od.OrderID = o.OrderID
group by o.CustomerID
having sum(od.UnitPrice*od.Quantity*(1-Discount))>=100000
order by total desc