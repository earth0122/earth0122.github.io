select
*
from Customers
where CompanyName like '%#%%' escape '#'
