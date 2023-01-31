--Calegory , Qty ,Orderyear

select
  Calegory , Qty ,Orderyear
from MyPivot
unpivot
(
Qty for Orderyear in([1996],[1997],[1998]) 
)as unpvt
