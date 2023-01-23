SELECT
	CustomerID, Fax,
	ISNULL(Fax, '¨S¶Ç¯u')
FROM Customers
