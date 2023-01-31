select
	p.ProductID,p.ProductName,p.UnitPrice,c.CategoryName
into table9
from Products p
inner join Categories c on p.CategoryID = c.CategoryID
where p.UnitPrice>20
select*from table9