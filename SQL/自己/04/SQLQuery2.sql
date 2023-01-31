SELECT
    CategoryID, UnitPrice,
    SUM(UnitPrice) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
        ROWS BETWEEN 2 PRECEDING    -- UNBOUNDED PRECEDING, CURRENT ROW
        AND 3 FOLLOWING             -- UNBOUNDED FOLLOWING, CURRENT ROW
    ) AS AverageByCategory
FROM Products
ORDER BY CategoryID, UnitPrice DESC