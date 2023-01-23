-- 13.�C�X�b�P�ӫ����������q���u�i�H�A�Ȫ��Ȥ�(��6��??8��)
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