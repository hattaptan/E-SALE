using ESales.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.DataAccess.Mapping
{
    public class CategoryMapping : ClassMap<Category>
    {
        public CategoryMapping()
        {
            Table(@"Category");
            Id(x => x.categoryId).Column("categoryId");
            Map(p => p.categoryName).Column("categoryName");
           
        }
    }
}
