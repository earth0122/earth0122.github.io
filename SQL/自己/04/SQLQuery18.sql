create or alter proc SP1
as
begin
  select*from Shippers
  select*from Categories
end
go

exec SP1