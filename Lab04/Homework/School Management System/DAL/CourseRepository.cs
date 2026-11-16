using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Course> GetAll() => _context.Courses.ToList();

        public Course GetById(int id) => _context.Courses.Find(id);

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            var existing = _context.Courses.Find(course.CourseID);
            if (existing != null)
            {
                existing.CourseName = course.CourseName;
                existing.Credits = course.Credits;
                existing.DepartmentID = course.DepartmentID;
                existing.InstructorID = course.InstructorID;
                _context.SaveChanges();
            }
        }

        public void Delete(int courseId)
        {
            var existing = _context.Courses.Find(courseId);
            if (existing != null)
            {
                _context.Courses.Remove(existing);
                _context.SaveChanges();
            }
        }
    }
}
