using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Business.Interfaces
{
    public interface ICategoryService
    {
        Category Insert(Category category);
        Category Update(Category category);
        Category GetById(int id);
        List<Category> GetAll();
        void Delete(Category category);
    }
}
