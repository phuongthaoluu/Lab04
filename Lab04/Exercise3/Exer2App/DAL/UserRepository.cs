using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository
    {
        private readonly LoginDbContext _context;

        public UserRepository()
        {
            _context = new LoginDbContext();
        }
        public User GetUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
