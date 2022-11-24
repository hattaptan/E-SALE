using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Business.Interfaces
{
    public interface IProductService
    {

        Product Insert(Product product);
        Product Update(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        void Delete(Product product);

    }
}
