SELECT
    CategoryID, SupplierID, AVG(UnitPrice) AS AvgPrice
FROM Products
GROUP BY CUBE(CategoryID, SupplierID)
ORDER BY CategoryID,SupplierID

 

SELECT
    CategoryID, SupplierID, AVG(UnitPrice) AS AvgPrice
FROM Products
GROUP BY ROLLUP(CategoryID, SupplierID)
ORDER BY CategoryID,SupplierID