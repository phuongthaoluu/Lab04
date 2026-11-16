using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class DepartmentsForm : System.Web.UI.Page
    {
        private readonly DepartmentService _departmentService = new DepartmentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            gvDepartments.DataSource = _departmentService.GetAllDepartments();
            gvDepartments.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var department = new Department
            {
                DepartmentName = "New Department"
            };
            _departmentService.AddDepartment(department);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvDepartments.SelectedDataKey != null)
            {
                int departmentId = Convert.ToInt32(gvDepartments.SelectedDataKey.Value);
                _departmentService.DeleteDepartment(departmentId);
                LoadData();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}