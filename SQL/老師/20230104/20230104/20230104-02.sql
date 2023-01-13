SELECT 
	EmployeeID AS ID,
	FirstName,
	LastName,
	FirstName + N' ' + LastName AS FullName,
	Title AS [Job Title]
FROM dbo.Employees

