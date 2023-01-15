select
	CustomerID,Country,Region,City
from Customers
where City = 'London'or City = 'Paris' or City = 'Barcelona'


select
	CustomerID,Country,Region,City
from Customers
where City in ('London', 'Paris','Barcelona')