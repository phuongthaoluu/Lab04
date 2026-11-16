using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class ProductWForm : System.Web.UI.Page
    {
        private readonly ProductService _productService = new ProductService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvProducts.DataSource = _productService.GetAllProducts();
                gvProducts.DataBind();
            }
        }
    }
}