using ESales.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.DataAccess.Mapping
{
    public class ProductMapping : ClassMap<Product>
    {
        public ProductMapping()
        {
            Table(@"Products");
            Id(x => x.productId).Column("productId");
            Map(p => p.productName).Column("productName");
            Map(p => p.productDesc).Column("productDesc");
            Map(p => p.productCondition).Column("productCondition");
            References(p => p.categoryID).Column("categoryID").Not.LazyLoad();
        }
    }
}
