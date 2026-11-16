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
    public partial class StudentsForm : System.Web.UI.Page
    {
        private readonly StudentService _studentService = new StudentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadData();
        }

        private void LoadData()
        {
            gvStudents.DataSource = _studentService.GetAllStudents();
            gvStudents.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = "New Student",
                DateOfBirth = DateTime.Now,
                City = "HCMC",
                Age = 20,
                YearOfEnroll = 2024,
                Major = "Software Engineering",
                GPA = 3.5m
            };
            _studentService.AddStudent(student);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvStudents.SelectedDataKey != null)
            {
                int studentId = Convert.ToInt32(gvStudents.SelectedDataKey.Value);
                _studentService.DeleteStudent(studentId);
                LoadData();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}