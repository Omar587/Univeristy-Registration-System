SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_available]
AS
BEGIN
    SELECT s.capacity, c.course_id, c.title, s.sec_id, c.dept_name, s.building, s.room_number, s.time_slot_id, c.credits
    FROM dbo.section AS s
	INNER JOIN dbo.course AS c
	ON s.course_id = c.course_id
	WHERE year = 2021 and semester like 'Fall' and capacity <= 100;
END;
