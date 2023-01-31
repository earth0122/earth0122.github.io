select * from Shippers

update Shippers
set
	Phone = 'xyz'
where CompanyName = 'ABC'

update Shippers
set
	CompanyName = 'hello' + CompanyName,
	phone = 'phone'
where CompanyName like 'OK%'