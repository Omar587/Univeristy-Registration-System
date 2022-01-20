SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[check_section] 
	(@courseID AS varchar(8),
	 @secID AS varchar(8),
	 @semester AS varchar(6),
	 @year AS int,
	 @result AS int OUTPUT)

AS
BEGIN
	UPDATE dbo.section
	SET capacity = capacity + 1
	WHERE course_id = @courseID AND sec_id = @secID AND semester = @semester AND year = @year;

	SELECT @result = @@ROWCOUNT;
END; 
