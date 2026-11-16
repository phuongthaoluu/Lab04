using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
    }
}
