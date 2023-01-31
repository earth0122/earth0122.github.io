select
OrderID,OrderDate
from Orders
where OrderDate >='1997-03-01'and OrderDate<'1997-04-01'

select
OrderID,OrderDate
from Orders
where year(OrderDate) =1997 and month(OrderDate)=3