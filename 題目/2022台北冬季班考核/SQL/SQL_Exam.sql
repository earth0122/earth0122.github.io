USE [Northwind]

--1 列出各產品的供應商名稱 77
SELECT
	p.ProductName,s.CompanyName
FROM Products p
INNER JOIN Suppliers s  ON p.SupplierID = s.SupplierID
--2 列出各產品的種類名稱 77
SELECT
p.ProductName,c.CategoryID
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
--3 列出各訂單的顧客名字 835
SELECT
o.OrderID, c.CustomerID
FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
ORDER BY o.OrderID
--4 列出各訂單的所負責的物流商名字以及員工名字 830
SELECT
o.OrderID,s.CompanyName,s.ShipperID
FROM Orders o
INNER JOIN Shippers s ON o.ShipVia = s.ShipperID
--5 列出1998年的訂單 270
SELECT
OrderDate
FROM Orders 
--WHERE OrderDate >='19980101' and OrderDate<'19990101'
WHERE YEAR(OrderDate)=1998

--6 各產品，UnitsInStock(庫存) < UnitsOnOrder(訂單) 顯示'供不應求'，否則顯示'正常' 77
SELECT
ProductID,ProductName,UnitsInStock,UnitsOnOrder,
CASE
WHEN UnitsInStock < UnitsOnOrder THEN '供不應求'
ELSE '正常'
END AS 庫存
FROM Products 
--7 取得訂單日期最新的9筆訂單 9
SELECT TOP 9 WITH ties --避免和第9筆一樣
OrderID,OrderDate
FROM Orders
ORDER BY OrderDate DESC
--8 產品單價最便宜的第4~8名 5
SELECT
ProductID,ProductName,UnitPrice
FROM Products
ORDER BY UnitPrice
offset 3 ROWS
FETCH NEXT 5 ROWS only
--9 列出每種類別中最高單價的商品*
SELECT
CategoryID,
MAX(UnitPrice) AS 最高單價商品價格
FROM Products

GROUP BY CategoryID
ORDER BY CategoryID

--10 列出每個訂單的總金額  835 ?
SELECT
o.OrderID,
SUM(od.UnitPrice*od.Quantity*(1-Discount))AS total
FROM Orders o
LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY o.OrderID
--11 列出每個物流商送過的訂單筆數
SELECT
s.CompanyName,
COUNT(o.OrderID)AS'訂單筆數'
FROM Shippers s
LEFT JOIN orders o ON o.ShipVia = s.ShipperID
GROUP BY s.CompanyName
--12 列出被下訂次數小於9次的產品
SELECT
od.OrderID,
COUNT(od.ProductID)
FROM [Order Details] od
GROUP BY od.OrderID
HAVING COUNT(od.ProductID)<9
-- (13、14、15請一起寫)
--13 新增物流商(Shippers)：
-- 公司名稱: 青杉人才，電話: (02)66057606
-- 公司名稱: 青群科技，電話: (02)14055374
SELECT * FROM Shippers
INSERT INTO Shippers(CompanyName,Phone)
VALUES
('青杉人才','(02)66057606'),
('青群科技','(02)14055374')

UPDATE Shippers
SET
CompanyName = CompanyName+'有限公司',
Phone ='(02)66057606'
WHERE CompanyName = '青杉人才' 
UPDATE Shippers
SET
CompanyName = CompanyName+'有限公司',
Phone ='(02)66057606'
WHERE CompanyName = '青群科技' 

DELETE FROM Shippers 
WHERE CompanyName = '青杉人才有限公司'
DELETE FROM Shippers 
WHERE CompanyName = '青群科技有限公司'
--14 方才新增的兩筆資料，電話都改成(02)66057606，公司名稱結尾加'有限公司'

--15 刪除剛才兩筆資料

