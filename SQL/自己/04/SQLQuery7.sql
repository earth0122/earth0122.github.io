select
  Calegory,[1996],[1997],[1998]
from SalesData
pivot(
sum(Qty)for Orderyear in([1996],[1997],[1998])
)as pvt

