USE [NoWaste]
GO
/****** Object:  StoredProcedure [dbo].[spCreateUser]    Script Date: 06/08/2021 22:41:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spCreateUser]
	@FirstName varchar(MAX),
	@MiddleName varchar(MAX) = NULL,
    @LastName varchar(MAX),   
    @Address nvarchar(MAX),
	@Email nvarchar(MAX),
	@DOB date,
	@Sex bit = NULL,
	@PasswordHash BINARY(64)
AS   
    SET NOCOUNT ON;  
	INSERT INTO dbo.Users (	
					FirstName,
					MiddleName,
					LastName,
                    Address,
					Email,
					DOB,
					Sex,
					PasswordHash)
	VALUES (	@FirstName,	
				@MiddleName,
				@LastName,
				@Address,
				@Email,
				@DOB,
				@Sex,
				@PasswordHash);
