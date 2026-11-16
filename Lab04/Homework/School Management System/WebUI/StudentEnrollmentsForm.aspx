<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEnrollmentsForm.aspx.cs" Inherits="WebUI.StudentEnrollmentsForm" %>

<!DOCTYPE html>

<html>
<head runat="server"><title>Student Enrollments</title></head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Enrollments Sub-Form</h2>
            <a href="MainForm.aspx">Back to Main</a><br /><br />
            <asp:Label Text="Select Course: " runat="server" />
            <asp:DropDownList ID="ddlCourses" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCourses_SelectedIndexChanged" DataTextField="CourseName" DataValueField="CourseID"></asp:DropDownList>
            <br /><br />
            <asp:GridView ID="gvEnrollments" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>