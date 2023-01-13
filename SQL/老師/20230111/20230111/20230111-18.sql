SELECT
	ProductName, UnitPrice,
	'[' + ProductName + ']''s price is $' + CAST(UnitPrice AS varchar(10)),
	'[' + ProductName + ']''s price is $' + CONVERT(varchar(10), UnitPrice * 1000, 1)
FROM Products
