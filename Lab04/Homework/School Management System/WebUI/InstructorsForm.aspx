<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorsForm.aspx.cs" Inherits="WebUI.InstructorsForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Instructors Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Instructors Management</h2>
            <a href="MainForm.aspx">Back to Main</a><br /><br />
            
            <asp:GridView ID="gvInstructors" runat="server" AutoGenerateSelectButton="True" DataKeyNames="InstructorID"></asp:GridView>
            <br />
            
            <asp:Button ID="btnAdd" Text="Add Sample Instructor" runat="server" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" Text="Delete Selected" runat="server" OnClick="btnDelete_Click" />
            <asp:Button ID="btnRefresh" Text="Refresh" runat="server" OnClick="btnRefresh_Click" />
        </div>
    </form>
</body>
</html>