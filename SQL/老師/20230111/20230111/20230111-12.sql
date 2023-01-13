SELECT
	CustomerID, Country, Region, City
FROM Customers
WHERE City = 'London' OR City = 'Paris' OR City = 'Barcelona'

SELECT
	CustomerID, Country, Region, City
FROM Customers
WHERE City IN ('London', 'Paris', 'Barcelona')