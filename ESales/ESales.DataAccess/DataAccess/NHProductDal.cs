using ESales.Core.NHibernateManager;
using ESales.DataAccess.Helpers;
using ESales.DataAccess.Interfaces;
using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.DataAccess.DataAccess
{
    public class NHProductDal : NHEntityRepositoryManager<Product>, IProductDal
    {
 
        public NHProductDal(SQLDbHelper helper) : base(helper)
        {

        }
    }
}
