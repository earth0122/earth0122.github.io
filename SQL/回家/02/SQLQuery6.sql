select
c.CustomerID,c.CompanyName,
p.ProductID,p.ProductName
from Customers c
inner join orders o on o.CustomerID =c.CustomerID
inner join [Order Details] od on od.OrderID = o.OrderID
inner join Products p on od.ProductID = p.ProductID