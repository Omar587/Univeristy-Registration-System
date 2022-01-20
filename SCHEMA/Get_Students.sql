SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE get_students
AS
BEGIN
    SELECT DISTINCT ID, name, dept_name, tot_cred
    FROM dbo.View_Prereqs
	WHERE year > 2015;
END;
