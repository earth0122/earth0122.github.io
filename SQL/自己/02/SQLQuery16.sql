select 
	ProductID,ProductName,UnitPrice
from Products
order by UnitPrice
offset 3 rows
fetch next 6 rows only