using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepo = new CourseRepository();

        public List<Course> GetAllCourses()
        {
            return _courseRepo.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepo.GetById(id);
        }

        public void AddCourse(Course course)
        {
            _courseRepo.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepo.Update(course);
        }

        public void DeleteCourse(int courseId)
        {
            _courseRepo.Delete(courseId);
        }
    }
}
