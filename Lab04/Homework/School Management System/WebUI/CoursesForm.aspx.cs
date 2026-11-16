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
    public partial class CoursesForm : System.Web.UI.Page
    {
        private readonly CourseService _courseService = new CourseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            gvCourses.DataSource = _courseService.GetAllCourses();
            gvCourses.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                CourseName = "New Course",
                Credits = 3,
                DepartmentID = 1,
                InstructorID = 1
            };
            _courseService.AddCourse(course);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvCourses.SelectedDataKey != null)
            {
                int courseId = Convert.ToInt32(gvCourses.SelectedDataKey.Value);
                _courseService.DeleteCourse(courseId);
                LoadData();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}