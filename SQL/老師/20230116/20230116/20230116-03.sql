SELECT * FROM Shippers

UPDATE Shippers
SET
	Phone = 'xyz'
WHERE CompanyName = 'ABC'

UPDATE Shippers
SET
	CompanyName = 'Hello ' + CompanyName,
	Phone = 'phone'
WHERE CompanyName LIKE 'OK%'
