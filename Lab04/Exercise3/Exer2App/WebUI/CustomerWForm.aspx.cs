using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class CustomerWForm : System.Web.UI.Page
    {
        private readonly CustomerService _customerService = new CustomerService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvCustomers.DataSource = _customerService.GetAllCustomers();
                gvCustomers.DataBind();
            }
        }
    }
}