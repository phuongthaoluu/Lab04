<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebUI.LoginForm" %>
<html>
<head runat="server"><title>Login</title></head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login Form</h2>
            <asp:Label Text="Username:" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" /><br /><br />
            <asp:Label Text="Password:" runat="server" />
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" /><br /><br />
            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
            <asp:Label ID="lblCopyright" Text="<br/><br/>Developed by Luu Phuong Thao" runat="server" />
        </div>
    </form>
</body>
</html>