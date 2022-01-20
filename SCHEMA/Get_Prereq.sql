SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_prereq] 
	(@courseID AS varchar(8),
	 @prereqID AS varchar(8) OUTPUT)

AS
BEGIN
	SELECT @prereqID = prereq_id
	FROM dbo.prereq 
	WHERE course_id = @courseID;
END; 
