SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insert_takes] 
	(@studentID AS varchar(5),
	 @courseID AS varchar(8),
	 @secID AS varchar(8),
	 @semester AS varchar(6),
	 @year AS int,
	 @grade AS varchar(2),
	 @result AS int OUTPUT)

AS
BEGIN
	INSERT INTO dbo.takes
	VALUES (@studentID, @courseID, @secID, @semester, @year, @grade);

	SELECT @result = @@ROWCOUNT;
END; 
