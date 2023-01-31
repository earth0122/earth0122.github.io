SELECT
    CategoryID, UnitPrice,
    RANK() OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS Rank1,
    DENSE_RANK() OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS Rank2,
    ROW_NUMBER() OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS No,
    NTILE(5) OVER (
        PARTITION BY CategoryID
        ORDER BY UnitPrice DESC
    ) AS Tile1
FROM Products
ORDER BY CategoryID, UnitPrice DESC