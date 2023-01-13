SELECT
	o.OrderDate,
	s.CompanyName AS ShipperName,
	c.CustomerID, c.CompanyName AS CustomerName
FROM Orders o
INNER JOIN Shippers s ON o.ShipVia = s.ShipperID
INNER JOIN Customers c ON o.CustomerID = c.CustomerID