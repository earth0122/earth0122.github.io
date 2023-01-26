select*

from Shippers

set identity_insert shippers on
insert into Shippers(CompanyName,Phone,ShipperID)
values('ABC','0999-999999',134)

set identity_insert shippers off


insert into Shippers(CompanyName,Phone)
values('ABC','0999-999999')

insert into Shippers(CompanyName)
values('ABC')