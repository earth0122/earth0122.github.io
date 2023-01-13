SELECT
	OrderID, OrderDate
FROM Orders
WHERE OrderDate >= '19970301' AND OrderDate < '19970401'

SELECT
	OrderID, OrderDate
FROM Orders
WHERE YEAR(OrderDate) = 1997 AND MONTH(OrderDate) = 3