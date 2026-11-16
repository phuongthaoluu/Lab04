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
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _userRepository.GetUser(username, password);
            return user != null;
        }
    }
}
