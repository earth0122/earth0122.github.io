select 
	c.CustomerID,
	o.CustomerID
from Customers c
left outer join Orders o on o.CustomerID = c.CustomerID