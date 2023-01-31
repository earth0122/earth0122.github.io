select * from Shippers

update Shippers
set
Phone='xyz'
where CompanyName = 'ABC'

update Shippers
set
CompanyName = 'Hello '+CompanyName,
Phone = 'phone'
where CompanyName like 'OK%'