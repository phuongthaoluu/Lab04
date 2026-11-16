using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentCourseService
    {
        private readonly StudentCourseRepository _studentCourseRepo = new StudentCourseRepository();

        public List<StudentCourse> GetAllEnrollments()
        {
            return _studentCourseRepo.GetAll();
        }

        public List<StudentCourse> GetEnrollmentsByCourse(int courseId)
        {
            return _studentCourseRepo.GetByCourseId(courseId);
        }

        public List<StudentCourse> GetEnrollmentsByStudent(int studentId)
        {
            return _studentCourseRepo.GetByStudentId(studentId);
        }

        public void EnrollStudent(StudentCourse studentCourse)
        {
            _studentCourseRepo.Add(studentCourse);
        }

        public void RemoveEnrollment(int studentId, int courseId)
        {
            _studentCourseRepo.Delete(studentId, courseId);
        }
    }
}
