create synonym esc for [dbo].[Employee Sales by Country] --別名改成esc
go

EXEC [dbo].[Employee Sales by Country] '19970101', '19970201'

exec esc '19970101','19970201'