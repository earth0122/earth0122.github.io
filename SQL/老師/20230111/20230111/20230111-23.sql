SELECT
	*
FROM Customers
WHERE CompanyName LIKE '%\%%' ESCAPE '\'
