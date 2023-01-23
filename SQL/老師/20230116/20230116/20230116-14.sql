SELECT
	CustomerID, Region, Fax,
	COALESCE(Region, Fax, 'NoNo')
FROM Customers
