create or alter proc OthersByDateRange(
	@begin_date datetime,
	@end_date datetime
)
as
begin
  select
    o.OrderID,c.CustomerID,c.CompanyName,o.OrderDate,p.ProductName,
	sum(od.Unitprice*od.Quantity*(1-od.Discount))as total
  from Orders o
  inner join Customers c on o.CustomerID=c.CustomerID
  inner join [Order Details] od on od.OrderID = o.OrderID
  inner join Products p on od.ProductID = p.ProductID
  where o.OrderDate>=@begin_date and o.OrderDate<@end_date
  group by o.OrderID,c.CustomerID,c.CompanyName,o.OrderDate,p.ProductName
  end
  go

  exec OthersByDateRange '19970101','19970801'