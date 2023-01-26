USE OSKITest
GO
/****** Object:  StoredProcedure [dbo].[CreateEmployer]    Script Date: 21.12.2022 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SetLog]
	@Operation varchar(200),
	@ErrorMessage varchar(2000),
	@StackTrace varchar(2000)

AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Logs(OperationId,ErrorMessage,StackTrace,Created)
    VALUES (@Operation,@ErrorMessage,@StackTrace, cast(getdate() as datetime))

END
