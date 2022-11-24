using ESales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Entity
{
    public class Category : IEntity
    {
        public virtual int categoryId { get; set; }
        public virtual string categoryName { get; set; } 
        
    }
}
