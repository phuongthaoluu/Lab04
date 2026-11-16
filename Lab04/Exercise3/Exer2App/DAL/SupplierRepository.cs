using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierRepository
    {
        private readonly LoginDbContext _context = new LoginDbContext();

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}
