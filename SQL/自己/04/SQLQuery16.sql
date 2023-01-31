CREATE OR ALTER PROC DeleteShipper (
    @id int
)
AS
BEGIN
    DECLARE @name nvarchar(40)
    SELECT
        @name = CompanyName
    FROM Shippers
    WHERE ShipperID = @id

 

    DELETE FROM Shippers 
    WHERE ShipperID = @id

 

    SELECT @name
END
GO

 

EXEC DeleteShipper 104

 

SELECT * FROM Shippers