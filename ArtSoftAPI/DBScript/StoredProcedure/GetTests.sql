USE [OSKITest]
GO
/****** Object:  StoredProcedure [dbo].[GetTests]    Script Date: 26.01.2023 11:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetTests]

AS
BEGIN

SET NOCOUNT ON;

select * from Test

END
