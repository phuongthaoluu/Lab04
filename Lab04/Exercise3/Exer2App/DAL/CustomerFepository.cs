using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepository
    {
        private readonly LoginDbContext _context = new LoginDbContext();

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
