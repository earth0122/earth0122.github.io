select
	e.EmployeeID,e.FirstName,e.ReportsTo,
	boss.EmployeeID,boss.FirstName
from Employees e
left outer join Employees boss on e.ReportsTo =boss.EmployeeID