CREATE OR ALTER PROC GetCustomers (
    @columns nvarchar(1000), @conditions nvarchar(1000)
)
AS
BEGIN
    DECLARE @sql nvarchar(4000)
    SET @sql = 'SELECT ' + @columns + ' FROM Customers WHERE ' + @conditions
    EXEC sp_executesql @sql
END
GO

 

EXEC GetCustomers 'CustomerID, CompanyName, City', 'City = ''London'''