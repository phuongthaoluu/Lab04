using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        private readonly StudentRepository _repo = new StudentRepository();

        public List<Student> GetAllStudents() => _repo.GetAll();
        public void AddStudent(Student student) => _repo.Add(student);
        public void UpdateStudent(Student student) => _repo.Update(student);
        public void DeleteStudent(int id) => _repo.Delete(id);
    }
}
