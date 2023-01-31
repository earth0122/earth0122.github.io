create or alter proc SalesAmountByCustomer(
  @cid char(5),@amount money output
)
as
begin
  select
    @amount = sum(od.UnitPrice*od.Quantity*(1-Discount))
  from [Order Details] od
  inner join Orders o on od.OrderID = o.OrderID
  where o.CustomerID=@cid
end
go

declare @sales money
exec SalesAmountByCustomer'ALFKI',@sales output
select @sales