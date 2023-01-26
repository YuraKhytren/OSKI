USE [OSKITest]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionByTestId]    Script Date: 26.01.2023 11:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetQuestionByTestId]
		@TestId int

AS
BEGIN

SET NOCOUNT ON;

select
       q.Id Id,
	   q.Text Text
	  
from Question q
where q.TestId = @TestId

END
