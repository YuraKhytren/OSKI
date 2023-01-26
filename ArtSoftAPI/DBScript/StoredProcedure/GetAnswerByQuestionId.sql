USE [OSKITest]
GO
/****** Object:  StoredProcedure [dbo].[GetAnswerByQuestionId]    Script Date: 26.01.2023 11:51:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetAnswerByQuestionId]
		@QuestionId int

AS
BEGIN

SET NOCOUNT ON;

select
       a.Id Id,
	   a.Text AnswerText,
	   a.IsTrue IsTrue
	  
from Answer a
where a.QuestionId = @QuestionId

END
