using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Student> GetAll() => _context.Students.ToList();

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            var existing = _context.Students.Find(student.StudentID);
            if (existing != null)
            {
                existing.StudentName = student.StudentName;
                existing.DateOfBirth = student.DateOfBirth;
                existing.City = student.City;
                existing.Age = student.Age;
                existing.YearOfEnroll = student.YearOfEnroll;
                existing.Major = student.Major;
                existing.GPA = student.GPA;
                _context.SaveChanges();
            }
        }

        public void Delete(int studentId)
        {
            var existing = _context.Students.Find(studentId);
            if (existing != null)
            {
                _context.Students.Remove(existing);
                _context.SaveChanges();
            }
        }
    }
}
