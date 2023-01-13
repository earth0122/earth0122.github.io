SELECT
	e1.EmployeeID, e1.FirstName,
	e2.EmployeeID, e2.FirstName
FROM Employees e1
CROSS JOIN Employees e2
