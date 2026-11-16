using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _departmentRepo = new DepartmentRepository();

        public List<Department> GetAllDepartments()
        {
            return _departmentRepo.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepo.GetById(id);
        }

        public void AddDepartment(Department department)
        {
            _departmentRepo.Add(department);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepo.Update(department);
        }

        public void DeleteDepartment(int departmentId)
        {
            _departmentRepo.Delete(departmentId);
        }
    }
}
