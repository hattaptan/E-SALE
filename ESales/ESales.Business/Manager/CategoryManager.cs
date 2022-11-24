using ESales.Business.Interfaces;
using ESales.DataAccess.Interfaces;
using ESales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESales.Business.Manager
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
                _categoryDal = categoryDal;
        }
        public void Delete(Category category)
        {
            _categoryDal.Delete(category);  
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            var category = _categoryDal.Get(x => x.categoryId == id);
            return category;
        }

        public Category Insert(Category category)
        {
            return _categoryDal.Add(category);
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
