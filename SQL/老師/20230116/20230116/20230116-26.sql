CREATE OR ALTER FUNCTION ProductsPriceBetween 
(	
	@min money,
	@max money
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT
		ProductID, ProductName, UnitPrice, CategoryID
	FROM Products
	WHERE UnitPrice BETWEEN @min AND @max
)
GO

SELECT * FROM ProductsPriceBetween(10, 20)
