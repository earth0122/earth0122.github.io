select
ProductID,
UnitPrice,
case
when UnitPrice<10 then '«K©y'
when UnitPrice<30 then '´¶³q'
else '¶Q'
end
as level,
case
when UnitPrice<10 then 0
when UnitPrice<30 then 0.2
else 0.4
end
as Discount,
UnitPrice*(1-case
when UnitPrice<10 then 0
when UnitPrice<30 then 0.2
else 0.4
end)
as NewPrice,
case
when UnitPrice<10 then UnitPrice*(1-0)
when UnitPrice<30 then UnitPrice*(1-0.2)
else UnitPrice*(1-0.4)
end
as NewPrice2
from Products
order by unitprice