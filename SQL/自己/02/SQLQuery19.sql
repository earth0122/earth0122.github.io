select
cast('2023-01-10' as datetime),
try_cast('2023-01-99' as datetime),
convert(datetime,'2023-01-10'),
try_convert(datetime,'2023-01-99')
