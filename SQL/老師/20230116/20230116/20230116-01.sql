SELECT * FROM Shippers


SET IDENTITY_INSERT Shippers ON

INSERT INTO Shippers(CompanyName, Phone, ShipperID)
VALUES ('ABC', '0999-999999', 100)

SET IDENTITY_INSERT Shippers OFF

INSERT INTO Shippers(CompanyName, Phone)
VALUES ('ABC', '0999-999999')

INSERT INTO Shippers(CompanyName)
VALUES ('ABC')