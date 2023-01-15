-- 1.找出和最貴的產品同類別的所有產品 CategoryID 1 UnitPrice 65.875
    /*
	CategoryID 1 
	UnitPrice 65.875
	*/
 select  top 1
ProductName,
UnitPrice,
CategoryID
from Products
order by UnitPrice desc
select 
ProductName,CategoryID
from Products
where CategoryID=1

-- 2.找出和最貴的產品同類別最便宜的產品  Guaraná Fantástica  0.0352
/*
UnitPrice 0.0352
*/
select top 1
ProductName,CategoryID,UnitPrice
from Products
where CategoryID=1
order by UnitPrice

-- 3.計算出上面類別最貴和最便宜的兩個產品的價差 65.8398
/*
65.875 0.0352 0.0352
*/
/*select 
UnitPrice as UnitPriceBig,
UnitPrice as UnitPriceSmall
(UnitPriceBig -UnitPriceSmall) as '價差'

from Products
where CategoryID=1
order by  UnitPriceBig desc ,UnitPriceSmall ASC */
select
max(UnitPrice) as '最貴',
min(UnitPrice) as '最便宜',
max(UnitPrice)-min(UnitPrice) as'價差'
from Products
where CategoryID=1
order by '最貴' desc ,'最便宜' ASC 
-- 4.找出沒有訂過任何商品的客戶所在的城市的所有客戶 /*FISSA PARIS  Madrid  Paris*/
select
c.CustomerID,o.CustomerID
from Customers c
left outer join Orders o on o.CustomerID = c.CustomerID
where o.CustomerID is null
select
City
from Customers
where CustomerID in ('FISSA','Paris') 
select
CustomerID
from Customers
where city in ('Madrid','Paris')
-- 5.找出第 5 貴跟第 8 便宜的產品的產品類別  13.75  4   0.0576  1
select
ProductName,CategoryID,UnitPrice
from Products
order by UnitPrice desc
offset 4 rows
fetch next 1 rows only

select
ProductName,CategoryID,UnitPrice

from Products
order by UnitPrice 
offset 7 rows
fetch next 1 rows only
-- 6.找出誰買過第 5 貴跟第 8 便宜的產品 178
select distinct
	c.CustomerID,p.ProductName,p.ProductID
from Customers c
inner join orders o on o.CustomerID = c.CustomerID
inner join [Order Details] od on od.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where p.ProductID in(1,59)
-- 7.找出誰賣過第 5 貴跟第 8 便宜的產品 18
select distinct
e.EmployeeID,e.FirstName,e.LastName,p.ProductName,p.ProductID
from Customers c
inner join orders o on o.CustomerID=c.CustomerID
inner join Employees e on o.EmployeeID=e.EmployeeID
inner join [Order Details] od on od.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where p.ProductID in(1,59)
order by e.EmployeeID
-- 8.找出 13 號星期五的訂單 (惡魔的訂單) 8
select 
datename(day,orderdate)as 日期,
datename(weekday,orderdate)as 星期,
OrderDate
from Orders
where datename(day,orderdate) =13 and datename(weekday,orderdate) = '星期五'
-- 9.找出誰訂了惡魔的訂單 8
select distinct 
o.OrderID,c.CustomerID
from orders o
inner join Customers c on o.CustomerID = c.CustomerID
where datename(day,orderdate) =13 and datename(weekday,orderdate) = '星期五'
order by CustomerID
-- 10.找出惡魔的訂單裡有什麼產品 21
select 
p.ProductName,o.OrderID,
datename(day,orderdate) as '日期',
datename(weekday,orderdate)as '星期'
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on od.OrderID = o.OrderID
where datename(day,orderdate) =13 and datename(weekday,orderdate) = '星期五'
order by ProductName

-- 11.列出從來沒有打折 (Discount) 出售的產品 77
select distinct
p.ProductName,p.ProductID,od.Discount
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
where Discount =0
order by ProductName
-- 12.列出購買非本國的產品的客戶 89
select distinct
c.CustomerID
from Customers c
inner join  orders o on o.CustomerID = c.CustomerID
inner join  [Order Details] od on od.OrderID=o.OrderID
inner join  Products p on od.ProductID = p.ProductID
inner join  Suppliers s on p.SupplierID =s.SupplierID
where c.Country<>s.Country
order by c.CustomerID
-- 13.列出在同個城市中有公司員工可以服務的客戶17
select 
c.City,e.EmployeeID,c.CustomerID
from Customers c
inner join Orders o on o.CustomerID = c.CustomerID
inner join Employees e on o.EmployeeID = e.EmployeeID
where c.City = e.City
-- 14.列出那些產品沒有人買過
	select
	p.ProductID,
	o.CustomerID,
	p.ProductName	
	from Products p
	left outer join [Order Details] od on od.ProductID=p.ProductID
	left outer join Orders o on od.OrderID = o.OrderID
	where o.CustomerID is null
