SELECT
	e.EmployeeID, e.FirstName, e.ReportsTo,
	boss.EmployeeID, boss.FirstName
FROM Employees e
LEFT OUTER JOIN Employees boss ON e.ReportsTo = boss.EmployeeID

