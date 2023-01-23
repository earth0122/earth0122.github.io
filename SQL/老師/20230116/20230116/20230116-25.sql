CREATE OR ALTER VIEW ProductsFrom10To50
AS
	SELECT
		ProductID, ProductName, UnitPrice, CategoryID
	FROM Products
	WHERE UnitPrice BETWEEN 10 AND 50
GO

SELECT * FROM ProductsFrom10To50