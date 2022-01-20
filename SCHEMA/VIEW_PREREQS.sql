SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW View_Prereqs
	WITH SCHEMABINDING
AS

SELECT t.ID, course_id, sec_id, semester, year, grade, name, dept_name, tot_cred 
FROM dbo.takes AS t 
INNER JOIN dbo.student AS s 
ON t.ID = s.ID
--ADD WHERE FILTER HERE

GO
CREATE UNIQUE CLUSTERED INDEX IDX_2
ON View_Prereqs(ID);
