USE [OSKITest]
GO
/****** Object:  StoredProcedure [dbo].[GetTestById]    Script Date: 26.01.2023 11:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetTestById]
		@TestId int

AS
BEGIN

SET NOCOUNT ON;

select * from Test t
where t.Id = @TestId

END
