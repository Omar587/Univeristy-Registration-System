SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[check_prereq] 
	(@studentID AS varchar(5),
	 @courseID AS varchar(8),
	 @result AS int OUTPUT)

AS
BEGIN
	SELECT @result = count(course_id)
	FROM dbo.View_Prereqs
	WHERE course_id = @courseID AND ID = @studentID;
END; 
