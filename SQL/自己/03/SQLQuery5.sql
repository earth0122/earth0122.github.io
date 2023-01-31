select * from Shippers

delete from Shippers 
where ShipperID>3

update Shippers
set
CompanyName = 'Fedex',
phone = '09-12345678'
where ShipperID = 1
