using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class LoginForm : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (_userService.ValidateUser(username, password))
            {
                Session["Username"] = username;

                Response.Redirect("MainForm.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login failed!');</script>");
            }
        }
    }
}