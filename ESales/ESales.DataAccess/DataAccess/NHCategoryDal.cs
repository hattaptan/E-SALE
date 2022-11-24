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
    public class NHCategoryDal : NHEntityRepositoryManager<Category>, ICategoryDal
    {

        public NHCategoryDal(SQLDbHelper helper) : base(helper)
        {

        }
    }
}
