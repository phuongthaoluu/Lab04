using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class LoginWForm : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

     
            bool isValid = _userService.ValidateUser(username, password);

            if (isValid)
            {
                Response.Redirect("MainWForm.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login failed. Please check your username and password.');</script>");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

    }
}