SELECT
    CategoryID, SupplierID, AVG(UnitPrice) AS AvgPrice
FROM Products
GROUP BY CategoryID, SupplierID

 

SELECT
    CategoryID, SupplierID, AVG(UnitPrice) AS AvgPrice
FROM Products
GROUP BY GROUPING SETS(CategoryID, SupplierID, ())