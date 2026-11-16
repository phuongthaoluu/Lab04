using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepository
    {
        private readonly LoginDbContext _context = new LoginDbContext();

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
