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
    public partial class InstructorsForm : System.Web.UI.Page
    {
        private readonly InstructorService _instructorService = new InstructorService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            gvInstructors.DataSource = _instructorService.GetAllInstructors();
            gvInstructors.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor
            {
                InstructorName = "Dr. New Instructor",
                DepartmentID = 1
            };
            _instructorService.AddInstructor(instructor);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvInstructors.SelectedDataKey != null)
            {
                int instructorId = Convert.ToInt32(gvInstructors.SelectedDataKey.Value);
                _instructorService.DeleteInstructor(instructorId);
                LoadData();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}