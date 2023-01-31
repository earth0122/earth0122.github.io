select
c.CustomerID,c.CompanyName as CustomerName,
o.OrderDate,s.CompanyName as ShipperName
from Customers c
inner join Orders o on c.CustomerID =o.CustomerID 
inner join Shippers s on o.ShipVia =s.ShipperID