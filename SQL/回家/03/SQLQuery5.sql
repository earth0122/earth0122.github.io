select*from Shippers

delete from Shippers
where ShipperID>3

update Shippers
set
CompanyName ='Fedex',
Phone = '0912345678'
where ShipperID =1