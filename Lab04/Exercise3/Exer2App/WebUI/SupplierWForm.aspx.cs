using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class SupplierWForm : System.Web.UI.Page
    {
        private readonly SupplierService _supplierService = new SupplierService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvSuppliers.DataSource = _supplierService.GetAllSuppliers();
                gvSuppliers.DataBind();
            }
        }
    }
}