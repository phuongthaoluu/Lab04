using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public SchoolDbContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolDbContext>(null);
        }
    }
}
