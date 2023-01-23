-- 13.列出在同個城市中有公司員工可以服務的客戶(有6位??8位)
SELECT 
    *
FROM Customers c
WHERE CustomerID IN
(SELECT  CustomerID FROM Orders WHERE  EmployeeID IN
(SELECT  EmployeeID FROM Employees  e WHERE  e.City = c.City ) )
 
SELECT DISTINCT
    c.CustomerID, c.CompanyName, c.city
FROM Customers c
INNER JOIN Employees e ON e.City = c.city
WHERE c.City = e.City