select
CategoryID,SupplierID,UnitPrice,
avg(UnitPrice) over(partition by CategoryID) as AverageByCalegory,
avg(UnitPrice) over(partition by CategoryID) as AverageBySupplier
from Products 
order by CategoryID ,SupplierID, UnitPrice desc