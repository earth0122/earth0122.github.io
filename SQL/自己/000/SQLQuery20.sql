select
	o.CustomerID,o.OrderDate,
	count(*)
from orders o
where OrderDate = (
--�C�ӫȤ�̤j�q����
select
	max(OrderDate)
from Orders
where CustomerID = o.CustomerID
)
group by o.CustomerID,o.OrderDate
having count(*)>1

