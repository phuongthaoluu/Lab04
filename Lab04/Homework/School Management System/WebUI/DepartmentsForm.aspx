<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentsForm.aspx.cs" Inherits="WebUI.DepartmentsForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Departments Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Departments Management</h2>
            <a href="MainForm.aspx">Back to Main</a><br /><br />
            
            <asp:GridView ID="gvDepartments" runat="server" AutoGenerateSelectButton="True" DataKeyNames="DepartmentID"></asp:GridView>
            <br />
            
            <asp:Button ID="btnAdd" Text="Add Sample Department" runat="server" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" Text="Delete Selected" runat="server" OnClick="btnDelete_Click" />
            <asp:Button ID="btnRefresh" Text="Refresh" runat="server" OnClick="btnRefresh_Click" />
        </div>
    </form>
</body>
</html>