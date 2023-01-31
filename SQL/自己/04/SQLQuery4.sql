SELECT
    CategoryID, UnitPrice,
    LAG(UnitPrice, 2) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS PrevPrice,
    LEAD(UnitPrice, 3) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS NextPrice,
    FIRST_VALUE(UnitPrice) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS FirstPrice,
    LAST_VALUE(UnitPrice) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS LastPrice
FROM Products
ORDER BY CategoryID, UnitPrice DESC