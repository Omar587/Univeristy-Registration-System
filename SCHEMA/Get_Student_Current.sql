SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_student_current] (@studentID AS varchar(5))

AS
BEGIN
	SELECT t.course_id, t.sec_id, c.title, c.dept_name, c.credits, t.grade
	FROM dbo.takes AS t
	INNER JOIN dbo.student AS s
	ON t.ID = s.ID
	INNER JOIN dbo.course as c
	ON t.course_id = c.course_id 
	WHERE s.ID = @studentID AND t.year = 2021;
END; 
