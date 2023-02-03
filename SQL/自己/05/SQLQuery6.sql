SELECT * FROM Customers

SELECT
c.*
FROM Customers c
LEFT OUTER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE o.OrderID IS NULL

update c
set 
  Fax = 'Hello'
  FROM Customers c
  LEFT OUTER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE o.OrderID IS NULL

update Customers
SET
  Fax = 'World'
WHERE CustomerID NOT IN(
SELECT CustomerID FROM Orders
)

UPDATE c
SET 
  FAX = 'world2'
  FROM Customers c
  WHERE NOT EXISTS(
  SELECT*FROM Orders WHERE CustomerID = C.CustomerID
  )

