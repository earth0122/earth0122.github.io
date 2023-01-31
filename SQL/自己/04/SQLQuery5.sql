SELECT
    CategoryID, UnitPrice,
    LAG(UnitPrice) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS PrevPrice,
    LAG(UnitPrice) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) - UnitPrice AS DiffPrice
FROM Products
ORDER BY CategoryID, UnitPrice DESC