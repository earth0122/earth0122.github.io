SELECT
    ProductID,
	(select
	ProductName
	from Products
	where ProductID = od.productID
	) AS ProductName,
    SUM(UnitPrice * Quantity * (1 - Discount)) AS Total
FROM [Order Details] od
GROUP BY ProductID
ORDER BY Total DESC