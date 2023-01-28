select
 CategoryID,SupplierID,
 avg(UnitPrice),
 min(UnitPrice),
 max(UnitPrice),
 sum(UnitPrice),
 count(UnitPrice)
from Products
group by CategoryID,SupplierID