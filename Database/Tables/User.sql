IF EXISTS (	
			SELECT *
			FROM sys.objects
			WHERE name like '%Users%'
			)
DROP TABLE dbo.Users 
BEGIN
CREATE TABLE dbo.Users ( UserID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
					FirstName nvarchar(MAX) NOT NULL,
					LastName nvarchar(MAX) NOT NULL,
                    MiddleName nvarchar(MAX) NULL, 
                    Address nvarchar(MAX) NOT NULL,
					Email nvarchar(MAX) NOT NULL,
					Sex bit NULL,
					DOB date NOT NULL,
					PasswordHash BINARY(64) NOT NULL,
					)
END