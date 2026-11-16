using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructorRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Instructor> GetAll() => _context.Instructors.ToList();

        public Instructor GetById(int id) => _context.Instructors.Find(id);

        public void Add(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public void Update(Instructor instructor)
        {
            var existing = _context.Instructors.Find(instructor.InstructorID);
            if (existing != null)
            {
                existing.InstructorName = instructor.InstructorName;
                existing.DepartmentID = instructor.DepartmentID;
                _context.SaveChanges();
            }
        }

        public void Delete(int instructorId)
        {
            var existing = _context.Instructors.Find(instructorId);
            if (existing != null)
            {
                _context.Instructors.Remove(existing);
                _context.SaveChanges();
            }
        }
    }
}
