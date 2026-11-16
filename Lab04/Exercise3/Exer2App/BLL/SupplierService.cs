using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierService
    {
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAllSuppliers();
        }
    }
}
