SELECT * FROM Shippers

DELETE FROM Shippers WHERE ShipperID > 3

UPDATE Shippers
SET
	CompanyName = 'Fedex',
	Phone = '02-33334444'
WHERE ShipperID = 1
