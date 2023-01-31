-- SQL Injection
EXEC GetCustomers 'CustomerID, CompanyName, City', '1=1 INSERT INTO Shippers(CompanyName) VALUES(''Hacker'') --'

 

SELECT * FROM Shippers

