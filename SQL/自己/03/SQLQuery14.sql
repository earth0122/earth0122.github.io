select 
	CustomerID,Region,Fax,
	coalesce(Region,Fax,'NoNo')
from Customers