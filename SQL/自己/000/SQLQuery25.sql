create or alter view ProductsFrom10To50
as
select
ProductID,ProductName,UnitPrice,CategoryID
from Products
where UnitPrice between 10 and 50
go

select*from ProductsFrom10To50