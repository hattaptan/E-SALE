using ESales.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Entity
{
    public class Product : IEntity
    {
        public virtual int productId { get; set; }
        public virtual string productName { get; set; }
        public virtual string productDesc { get; set; }
        public virtual string productCondition { get; set; }
        public virtual Category categoryID { get; set; }
    }
}
