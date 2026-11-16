using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class StudentEnrollmentsForm : System.Web.UI.Page
    {
        private readonly CourseService _courseService = new CourseService();
        private readonly StudentCourseService _studentCourseService = new StudentCourseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCourses();
                LoadData();
            }
        }

        private void LoadCourses()
        {
            ddlCourses.DataSource = _courseService.GetAllCourses();
            ddlCourses.DataBind();
        }

        private void LoadData()
        {
            if (ddlCourses.SelectedValue != null)
            {
                int courseId = Convert.ToInt32(ddlCourses.SelectedValue);
                gvEnrollments.DataSource = _studentCourseService.GetEnrollmentsByCourse(courseId);
                gvEnrollments.DataBind();
            }
        }

        protected void ddlCourses_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
    }
}