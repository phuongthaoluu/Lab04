<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerWForm.aspx.cs" Inherits="WebUI.CustomerWForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Customer List</h2>
            <a href="MainWForm.aspx">Back to Main</a><br /><br />
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>