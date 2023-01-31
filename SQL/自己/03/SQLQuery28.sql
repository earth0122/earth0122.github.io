SELECT
    CategoryID, AvgPrice
FROM (
    SELECT
        CategoryID, AVG(UnitPrice) AS AvgPrice
    FROM Products
    GROUP BY CategoryID
) AS t
WHERE AvgPrice > 5