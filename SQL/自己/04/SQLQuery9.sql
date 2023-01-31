SELECT
    Calegory, [1996], [1997], [1998]
INTO MyPivot
FROM SalesData
PIVOT (
    SUM(Qty) FOR Orderyear IN ([1996], [1997], [1998])
) AS pvt