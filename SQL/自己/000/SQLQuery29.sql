with t1 as(
	select
		CategoryID,AVG(UnitPrice) as avgPrice
	from Products
	group by CategoryID
)
select * from t1
where avgPrice>5