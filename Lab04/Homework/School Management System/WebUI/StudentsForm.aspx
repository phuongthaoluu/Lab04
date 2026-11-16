<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsForm.aspx.cs" Inherits="WebUI.StudentsForm" %>

<!DOCTYPE html>

<html>
<head runat="server"><title>Students Management</title></head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Students Management</h2>
            <a href="MainForm.aspx">Back to Main</a><br /><br />
            <asp:GridView ID="gvStudents" runat="server" AutoGenerateSelectButton="True" DataKeyNames="StudentID"></asp:GridView><br />
            <asp:Button ID="btnAdd" Text="Add Sample Student" runat="server" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" Text="Delete Selected" runat="server" OnClick="btnDelete_Click" />
            <asp:Button ID="btnRefresh" Text="Refresh" runat="server" OnClick="btnRefresh_Click" />
        </div>
    </form>
</body>
</html>