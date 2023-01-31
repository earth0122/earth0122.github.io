select
	c.CategoryName,
	SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) as total
from [Order Details] od
inner join Products p on od.ProductID = p.ProductID
inner join Categories c on p.CategoryID= c.CategoryID
group by c.CategoryName
order by total desc