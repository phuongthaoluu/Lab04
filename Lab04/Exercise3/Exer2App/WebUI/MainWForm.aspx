<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWForm.aspx.cs" Inherits="WebUI.MainWForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Form</title>
    <style>
        .navbar { background-color: #333; overflow: hidden; }
        .navbar a { float: left; display: block; color: white; text-align: center; padding: 14px 20px; text-decoration: none; }
        .navbar a:hover { background-color: #ddd; color: black; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <a href="CustomerWForm.aspx">Customer Management</a>
            <a href="ProductWForm.aspx">Product Management</a>
            <a href="SupplierWForm.aspx">Supplier Management</a>
            <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click" Style="float:right;">Logout</asp:LinkButton>
        </div>
        <div style="padding: 20px;">
            <h2>Welcome to Main System</h2>
            <p>Chọn chức năng từ thanh Menu trên để quản lý dữ liệu.</p>
        </div>
    </form>
</body>
</html>
