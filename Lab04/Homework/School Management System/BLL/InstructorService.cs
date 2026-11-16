using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepo = new InstructorRepository();

        public List<Instructor> GetAllInstructors()
        {
            return _instructorRepo.GetAll();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorRepo.GetById(id);
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorRepo.Add(instructor);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructorRepo.Update(instructor);
        }

        public void DeleteInstructor(int instructorId)
        {
            _instructorRepo.Delete(instructorId);
        }
    }
}
