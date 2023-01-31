create or alter proc AddShipper(
@name nvarchar(40),@phone nvarchar(24)=null
)
as
begin
  insert into Shippers(CompanyName,Phone)
  values(@name,@phone)

  return @@identity
end
go
declare @id int
exec @id = AddShipper 'Black Cat','0999-333444'
select @id
select*from Shippers