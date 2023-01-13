SELECT
	ProductID, 
	UnitPrice, 
	CASE
		WHEN UnitPrice < 10 THEN '«K©y'
		WHEN UnitPrice < 30 THEN '´¶³q'
		ELSE '¶Q'
	END AS Level,
	CASE 
		WHEN UnitPrice < 10 THEN 0
		WHEN UnitPrice < 30 THEN 0.2
		ELSE 0.4
	END AS Discount,
	UnitPrice * (1 - CASE 
		WHEN UnitPrice < 10 THEN 0
		WHEN UnitPrice < 30 THEN 0.2
		ELSE 0.4
	END) AS NewPrice,
	CASE 
		WHEN UnitPrice < 10 THEN UnitPrice * (1 - 0)
		WHEN UnitPrice < 30 THEN  UnitPrice * (1 - 0.2)
		ELSE  UnitPrice * (1 - 0.4)
	END AS NewPrice2
FROM Products
ORDER BY UnitPrice
