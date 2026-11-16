<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoursesForm.aspx.cs" Inherits="WebUI.CoursesForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Courses Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Courses Management</h2>
            <a href="MainForm.aspx">Back to Main</a><br /><br />
            
            <asp:GridView ID="gvCourses" runat="server" AutoGenerateSelectButton="True" DataKeyNames="CourseID"></asp:GridView>
            <br />
            
            <asp:Button ID="btnAdd" Text="Add Sample Course" runat="server" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" Text="Delete Selected" runat="server" OnClick="btnDelete_Click" />
            <asp:Button ID="btnRefresh" Text="Refresh" runat="server" OnClick="btnRefresh_Click" />
        </div>
    </form>
</body>
</html>
