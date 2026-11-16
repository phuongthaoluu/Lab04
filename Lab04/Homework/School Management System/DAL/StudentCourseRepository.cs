using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentCourseRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<StudentCourse> GetAll() => _context.StudentCourses.ToList();

        public List<StudentCourse> GetByCourseId(int courseId)
        {
            return _context.StudentCourses.Where(sc => sc.CourseID == courseId).ToList();
        }

        public List<StudentCourse> GetByStudentId(int studentId)
        {
            return _context.StudentCourses.Where(sc => sc.StudentID == studentId).ToList();
        }

        public void Add(StudentCourse studentCourse)
        {
            _context.StudentCourses.Add(studentCourse);
            _context.SaveChanges();
        }

        public void Delete(int studentId, int courseId)
        {
            var existing = _context.StudentCourses.FirstOrDefault(sc => sc.StudentID == studentId && sc.CourseID == courseId);
            if (existing != null)
            {
                _context.StudentCourses.Remove(existing);
                _context.SaveChanges();
            }
        }
    }
}
