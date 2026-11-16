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

CREATE TABLE tblProducts (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);
GO

CREATE TABLE tblSuppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200) NULL
);
GO
CREATE TABLE tblCustomers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NULL,
    Address NVARCHAR(200) NULL
);
GO

INSERT INTO tblCustomers (CustomerName, Phone, Address) 
VALUES 
(N'Nguyễn Văn A', '0901234567', N'TP. Hồ Chí Minh'),
(N'Trần Thị B', '0987654321', N'Hà Nội');
GO

INSERT INTO tblProducts (ProductName, Price) VALUES (N'Laptop Dell', 15000000), (N'Chuột Logitech', 350000);
INSERT INTO tblSuppliers (SupplierName, Address) VALUES (N'Công ty A', N'TP.HCM'), (N'Công ty B', N'Hà Nội');
GO
