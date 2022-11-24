using ESales.Core.Entities;
using ESales.Core.Helpers;
using ESales.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Core.NHibernateManager
{
    public class QueryableRepositoryManager<T> : IQueryableRepositoryService<T> where T : class, IEntity, new()
    {
 
        NHibernateHelper _helper;
        IQueryable<T> _entities;
        public QueryableRepositoryManager(NHibernateHelper helper)
        {
            _helper = helper;
        }
        public IQueryable<T> Tables => this.Entities;

        public virtual IQueryable<T> Entities
        {

            get { return _entities ?? (_entities = _helper.OpenSession().Query<T>()); }

        }
    }
}
