select
	p.CategoryID,
	sum(od.UnitPrice*od.Quantity*(1-od.Discount))as total
from [Order Details] od
inner join Products p on od.ProductID = p.ProductID
group by p.CategoryID
order by total desc