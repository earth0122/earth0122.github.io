select
Country,Fax,count(*)as Total,
grouping_id(Country),
grouping_id(Fax)
from Customers
group by cube(Country,Fax)

--0¬Otrue  1¬Ofalse