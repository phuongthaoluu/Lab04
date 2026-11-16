USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Lab2DB')
BEGIN
    ALTER DATABASE Lab2DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Lab2DB;
END
GO

CREATE DATABASE Lab2DB;
GO

USE Lab2DB;
GO

CREATE TABLE tblUsers (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
go
INSERT INTO tblUsers (Username, Password) VALUES ('user1', 'password1');
INSERT INTO tblUsers (Username, Password) VALUES ('user2', 'password2');
go
SELECT * FROM Lab2DB.dbo.tblUsers;
