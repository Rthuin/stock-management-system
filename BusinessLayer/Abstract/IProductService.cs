using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product product);
        void ProductRemove(Product product);
        void ProductUpdate(Product product);
        List<Product> GetAllProducts();
        Product GetProduct(int id);

    }
}
