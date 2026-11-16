USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'SchoolDB')
BEGIN
    ALTER DATABASE SchoolDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SchoolDB;
END
GO

CREATE DATABASE SchoolDB;
GO

USE SchoolDB;
GO

CREATE TABLE tblUsers (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
INSERT INTO tblUsers (Username, Password) VALUES ('user1', 'password1'), ('user2', 'password2');

CREATE TABLE tblDepartments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);
INSERT INTO tblDepartments (DepartmentName) VALUES (N'Computer Science'), (N'Mathematics'), (N'Physics'), (N'Chemistry');

CREATE TABLE tblInstructors (
    InstructorID INT PRIMARY KEY IDENTITY(1,1),
    InstructorName NVARCHAR(100) NOT NULL,
    DepartmentID INT NOT NULL,
    CONSTRAINT FK_Instructors_Departments FOREIGN KEY (DepartmentID) REFERENCES tblDepartments(DepartmentID)
);
INSERT INTO tblInstructors (InstructorName, DepartmentID) VALUES (N'Dr. John Smith', 1), (N'Dr. Jane Doe', 2), (N'Dr. Alice Brown', 3), (N'Dr. Bob White', 4);

CREATE TABLE tblCourses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    Credits INT NOT NULL,
    DepartmentID INT NOT NULL,
    InstructorID INT NOT NULL,
    CONSTRAINT FK_Courses_Departments FOREIGN KEY (DepartmentID) REFERENCES tblDepartments(DepartmentID),
    CONSTRAINT FK_Courses_Instructors FOREIGN KEY (InstructorID) REFERENCES tblInstructors(InstructorID)
);
INSERT INTO tblCourses (CourseName, Credits, DepartmentID, InstructorID) VALUES 
(N'Introduction to Computer Science', 3, 1, 1),
(N'Calculus I', 4, 2, 2),
(N'Physics I', 4, 3, 3),
(N'Organic Chemistry', 4, 4, 4);
go 

CREATE TABLE tblStudents (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Age INT NOT NULL,
    YearOfEnroll INT NOT NULL,
    Major NVARCHAR(50),
    GPA DECIMAL(3, 2)
);
go

INSERT INTO tblStudents (StudentName, DateOfBirth, City, Age, YearOfEnroll, Major, GPA) VALUES
(N'Trung Pham', '2000-01-15', 'HCMC', 24, 2018, 'Computer Science', 3.5),
(N'Luu Phuong Thao','2006-03-03','HCMC', 20, 2026,'Computer Science',4.0);

CREATE TABLE tblStudentCourses (
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    PRIMARY KEY (StudentID, CourseID),
    CONSTRAINT FK_StudentCourses_Students FOREIGN KEY (StudentID) REFERENCES tblStudents(StudentID),
    CONSTRAINT FK_StudentCourses_Courses FOREIGN KEY (CourseID) REFERENCES tblCourses(CourseID)
);
INSERT INTO tblStudentCourses (StudentID, CourseID) VALUES (1, 1), (1, 2), (2, 1);
GO

CREATE PROCEDURE GetCourses
AS
BEGIN
    SELECT CourseID, CourseName FROM tblCourses;
END
GO