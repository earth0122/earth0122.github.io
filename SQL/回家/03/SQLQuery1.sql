select * from Shippers

set identity_insert Shippers on
insert into Shippers(CompanyName,Phone,ShipperID)
values('ABC','0999-999999',100)
set identity_insert Shippers off
insert into Shippers(CompanyName,Phone)
values('ABC','0999-999999')

insert into Shippers(CompanyName)
values('ABC')