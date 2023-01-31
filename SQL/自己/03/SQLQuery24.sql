select
c.*
from Customers c
where not exists(
select*from Orders
where CustomerID = c.CustomerID
)