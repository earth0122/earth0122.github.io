create or alter procedure MathAdd(
	@no1 int,@no2 int = 0 ,@max int output
)
as
begin
  
	set @max = iif(@no1>@no2,@no1,@no2)
 
	return @no1+@no2
end
go  --go �H�W������ �b����H�U

declare @result int,@max int
exec @result = MathAdd 10,20,@max output
select @result