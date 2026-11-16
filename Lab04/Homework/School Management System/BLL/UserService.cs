using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        private readonly UserRepository _repo = new UserRepository();
        public bool ValidateUser(string username, string password) => _repo.ValidateUser(username, password);
    }
}
