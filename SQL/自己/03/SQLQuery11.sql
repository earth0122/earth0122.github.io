select
	CustomerID,Fax,
	ISNULL(Fax,'�S�ǯu')
from Customers

select
	CustomerID,Region,Fax,
	coalesce(Region,Fax,'NoNo')
from Customers