SELECT
	*,
	UnitPrice * Quantity * ( 1 - Discount ) AS Total
FROM [Order Details]
