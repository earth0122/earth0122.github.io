select
	CustomerID,Fax,
	ISNULL(Fax,'¨S¶Ç¯u')
from Customers

select
	CustomerID,Region,Fax,
	coalesce(Region,Fax,'NoNo')
from Customers