CREATE PROCEDURE [dbo].[Occupied_Rooms]
	@query_start_date date,
	@query_end_date date,
	@count  INT OUTPUT

AS
Begin

   While @query_start_date <=@query_end_date
    BEGIN
	Select Count(*)From Reservation Where @query_start_date between Start_date AND End_date
	set @query_start_date = DATEADD(day, 1, @query_start_date)


	Select @count += @@dayCount;
    END
END
