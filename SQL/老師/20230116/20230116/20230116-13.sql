SELECT
	CustomerID, Fax,
	ISNULL(Fax, '�S�ǯu')
FROM Customers
