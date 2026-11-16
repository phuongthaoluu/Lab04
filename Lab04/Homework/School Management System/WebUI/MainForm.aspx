<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebUI.MainForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Main Form</title>
    <style>
        .navbar { background-color: #333; overflow: hidden; }
        .navbar a { float: left; color: white; padding: 14px 20px; text-decoration: none; }
        .navbar a:hover { background-color: #ddd; color: black; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <a href="StudentsForm.aspx">Students</a>
            <a href="CoursesForm.aspx">Courses</a>
            <a href="InstructorsForm.aspx">Instructors</a>
            <a href="DepartmentsForm.aspx">Departments</a>
            <a href="StudentEnrollmentsForm.aspx">Student Enrollments</a>
            <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click" Style="float:right; color:white; padding:14px 20px;">Logout</asp:LinkButton>
        </div>
        <div style="padding:20px;">
            <h2>Student Management System</h2>
            <p>Chọn chức năng từ thanh menu để bắt đầu quản lý.</p>
        </div>
    </form>
</body>
</html>
