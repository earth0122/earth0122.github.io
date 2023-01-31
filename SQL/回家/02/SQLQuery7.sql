select
	c.CustomerID,
	p.ProductID
from Customers c
cross join Products p