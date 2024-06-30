using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productDal.GetById(id);
        }

        public void ProductAdd(Product product)
        {
            _productDal.Insert(product);
        }

        public void ProductRemove(Product product)
        {
            _productDal.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productDal.Update(product);
        }
    }
}
