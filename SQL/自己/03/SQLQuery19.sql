select
	c.CustomerID,c.CompanyName,
	o.OrderID,o.OrderDate
from Customers c
inner join Orders o on o.CustomerID = c.CustomerID
where OrderDate = (
select
	max(OrderDate)
from Orders
where CustomerID = o.CustomerID
)

