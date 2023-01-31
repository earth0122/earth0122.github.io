CREATE OR ALTER FUNCTION PeopleInCity
(
    @city nvarchar(50)
)
RETURNS 
@table1 TABLE 
(
    ID            varchar(50),
    Name    nvarchar(100),
    City        nvarchar(50)
)
AS
BEGIN
    INSERT INTO @table1(ID, Name, City)
    SELECT
        CustomerID, CompanyName, City
    FROM Customers
    WHERE City = @city

 

    INSERT INTO @table1(ID, Name, City)
    SELECT
        EmployeeID, FirstName + ' ' + LastName, City
    FROM Employees
    WHERE City = @city

 

    RETURN 
END
GO

SELECT * FROM PeopleInCity('London')