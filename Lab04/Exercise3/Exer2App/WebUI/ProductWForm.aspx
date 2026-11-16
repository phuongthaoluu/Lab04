<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductWForm.aspx.cs" Inherits="WebUI.ProductWForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product List</h2>
            <a href="MainWForm.aspx">Back to Main</a><br /><br />
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
