<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierWForm.aspx.cs" Inherits="WebUI.SupplierWForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Supplier List</h2>
            <a href="MainWForm.aspx">Back to Main</a><br /><br />
            <asp:GridView ID="gvSuppliers" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>