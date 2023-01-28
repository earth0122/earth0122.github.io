USE [Northwind]

--1 列出各產品的供應商名稱 77
select
	p.ProductName,s.CompanyName
from Products p
inner join Suppliers s  on p.SupplierID = s.SupplierID
--2 列出各產品的種類名稱 77
select
p.ProductName,c.CategoryID
from Products p
inner join Categories c on p.CategoryID = c.CategoryID
--3 列出各訂單的顧客名字 835
select
o.OrderID, c.CustomerID
from Customers c
inner join Orders o on o.CustomerID = c.CustomerID
--4 列出各訂單的所負責的物流商名字以及員工名字 830
select
o.OrderID,s.CompanyName,s.ShipperID
from Orders o
inner join Shippers s on o.ShipVia = s.ShipperID
--5 列出1998年的訂單 270
select
OrderDate
from Orders 
where OrderDate >='19980101' and OrderDate<'19990101'
--6 各產品，UnitsInStock(庫存) < UnitsOnOrder(訂單) 顯示'供不應求'，否則顯示'正常' 77
select
ProductID,ProductName,UnitsInStock,UnitsOnOrder,
case
when UnitsInStock < UnitsOnOrder then '供不應求'
else '正常'
end as 庫存
from Products 
--7 取得訂單日期最新的9筆訂單 9
select top 9 with ties 
OrderID,OrderDate
from Orders
order by OrderDate desc
--8 產品單價最便宜的第4~8名 5
select
ProductID,ProductName,UnitPrice
from Products
order by UnitPrice
offset 3 rows
fetch next 5 rows only
--9 列出每種類別中最高單價的商品
select
CategoryID,
max(UnitPrice)
from Products
group by CategoryID
order by CategoryID

--10 列出每個訂單的總金額  835
select
o.OrderID,
sum(od.UnitPrice*od.Quantity*(1-Discount))as total
from Orders o
left join [Order Details] od on od.OrderID = o.OrderID
group by o.OrderID
--11 列出每個物流商送過的訂單筆數
select
s.CompanyName,
count(o.OrderID)as'訂單筆數'
from Shippers s
left join orders o on o.ShipVia = s.ShipperID
group by s.CompanyName
--12 列出被下訂次數小於9次的產品
select
od.OrderID,
count(od.ProductID)
from [Order Details] od
group by od.OrderID
having count(od.ProductID)<9
-- (13、14、15請一起寫)
--13 新增物流商(Shippers)：
-- 公司名稱: 青杉人才，電話: (02)66057606
-- 公司名稱: 青群科技，電話: (02)14055374
select * from Shippers
insert into Shippers(CompanyName,Phone)
values
('青杉人才','(02)66057606'),
('青群科技','(02)14055374')

update Shippers
set
CompanyName = CompanyName+'有限公司',
Phone ='(02)66057606'
where CompanyName = '青杉人才' 
update Shippers
set
CompanyName = CompanyName+'有限公司',
Phone ='(02)66057606'
where CompanyName = '青群科技' 

delete from Shippers 
where CompanyName = '青杉人才有限公司'
delete from Shippers 
where CompanyName = '青群科技有限公司'
--14 方才新增的兩筆資料，電話都改成(02)66057606，公司名稱結尾加'有限公司'

--15 刪除剛才兩筆資料

