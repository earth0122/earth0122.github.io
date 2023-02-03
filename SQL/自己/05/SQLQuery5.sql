SELECT*FROM Products WHERE ProductID = 38 --65.875->79.05

UPDATE Products
SET
	UnitPrice = UnitPrice*1.2
	WHERE ProductID =(
SELECT TOP 1
	ProductID	
FROM [Order Details]
GROUP BY ProductID
ORDER BY SUM(UnitPrice*Quantity*(1-Discount))DESC
)