WITH  t1 AS (
    SELECT
        EmployeeID, FirstName, ReportsTo, 1 AS Level,
        CAST(FirstName AS nvarchar(100)) AS Hierarchy
    FROM Employees
    WHERE ReportsTo IS NULL
    UNION ALL
    SELECT
        e.EmployeeID, e.FirstName, e.ReportsTo, t1.Level + 1 AS Level,
        CAST(t1.Hierarchy + ' / ' + e.FirstName AS nvarchar(100)) AS Hierarchy
    FROM Employees e
    INNER JOIN t1 ON e.ReportsTo = t1.EmployeeID
)
SELECT * FROM t1