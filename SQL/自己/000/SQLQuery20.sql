select
	o.CustomerID,o.OrderDate,
	count(*)
from orders o
where OrderDate = (
--每個客戶最大訂單日期
select
	max(OrderDate)
from Orders
where CustomerID = o.CustomerID
)
group by o.CustomerID,o.OrderDate
having count(*)>1

