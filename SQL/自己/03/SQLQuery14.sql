select
	ProductID,
	SUM(UnitPrice*Quantity*(1-Discount)) as total
from [Order Details]
group by ProductID
order by total desc