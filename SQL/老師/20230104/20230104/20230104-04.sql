SELECT
	OrderID, 
	ProductID, 
	UnitPrice, 
	Quantity, 
	Discount, 	
	UnitPrice * Quantity * ( 1 - Discount ) AS Total
FROM [Order Details]
ORDER BY Total DESC		-- DESC: descending, ASC: ascending
