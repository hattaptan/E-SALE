using ESales.Core.Interfaces;
using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.DataAccess.Interfaces
{
    public interface IProductDal : IEntityRepositoryService<Product>
    {
    }
}
