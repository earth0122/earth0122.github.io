insert into Table9(ProductID,ProductName,UnitPrice,CategoryName)
select 
  p.ProductID,p.ProductName,p.UnitPrice,c.CategoryName

from Products p
inner join Categories c on p.CategoryID = c.CategoryID
where p.UnitPrice<0.1

select * from Table9