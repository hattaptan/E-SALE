using ESales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Core.Interfaces
{
    public interface IQueryableRepositoryService<T> where T : class, IEntity, new()
    {
        IQueryable<T> Tables { get; }
    }
}
