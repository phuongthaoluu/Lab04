using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
