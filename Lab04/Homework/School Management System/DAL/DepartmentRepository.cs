using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Department> GetAll() => _context.Departments.ToList();

        public Department GetById(int id) => _context.Departments.Find(id);

        public void Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void Update(Department department)
        {
            var existing = _context.Departments.Find(department.DepartmentID);
            if (existing != null)
            {
                existing.DepartmentName = department.DepartmentName;
                _context.SaveChanges();
            }
        }

        public void Delete(int departmentId)
        {
            var existing = _context.Departments.Find(departmentId);
            if (existing != null)
            {
                _context.Departments.Remove(existing);
                _context.SaveChanges();
            }
        }
    }
}
