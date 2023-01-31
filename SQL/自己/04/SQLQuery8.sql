--Orderyear , Seafood , Condiments , Confections,Beverages
select
Orderyear , [Seafood] , [Condiments] , [Confections],[Beverages]
from salesData
pivot(
sum(Qty)for Calegory in([Seafood] , [Condiments] , [Confections],[Beverages])
)as pvt