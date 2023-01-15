select
	ProductName,UnitPrice,
	'['+ ProductName +']''s price is $'+ CAST(UnitPrice as varchar(10)),
	'['+ ProductName +']''s price is $'+ CONVERT(varchar(10),UnitPrice)
from Products