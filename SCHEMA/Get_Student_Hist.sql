SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_student_hist] (@studentID AS varchar(5))

AS
BEGIN
	SELECT V.course_id, V.year, C.title, C.dept_name, C.credits, V.grade 
	FROM dbo.View_Prereqs as V
	INNER JOIN dbo.course as C
	ON V.course_id = C.course_id 
	WHERE V.ID = @studentID AND V.year < 2021
	ORDER BY V.year;
END; 
