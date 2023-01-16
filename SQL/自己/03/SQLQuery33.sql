select top 5
*
into #table7
from Products
order by UnitPrice desc

select * from #table7

select top 5
*
into ##table6
from Products
order by UnitPrice desc

select * from ##table6