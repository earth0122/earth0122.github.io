SELECT
	CAST('2023-01-10' AS datetime),
	TRY_CAST('2023-01-99' AS datetime),
	CONVERT(datetime, '2023-01-10'),
	TRY_CONVERT(datetime, '2023-01-99')
