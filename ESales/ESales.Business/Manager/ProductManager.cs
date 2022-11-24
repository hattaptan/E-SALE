using ESales.Business.Interfaces;
using ESales.DataAccess.Interfaces;
using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Business.Manager
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;


        public ProductManager(IProductDal productDal)
        {
            _productDal= productDal;
        }
        public void Delete(Product product)
        {
           _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
           return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            var product= _productDal.Get(x =>x.productId==id);
            return product;
        }

        public Product Insert(Product product)
        {
            return _productDal.Add(product);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
