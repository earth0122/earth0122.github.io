select
	p.ProductID,p.ProductName,p.CategoryID,
	c.CategoryID,c.CategoryName,s.CompanyName
from Products p
inner join Categories c on p.CategoryID = c.CategoryID
inner join Suppliers s on p.SupplierID = s.SupplierID