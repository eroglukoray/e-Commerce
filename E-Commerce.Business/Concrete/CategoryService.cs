using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.DataAccess.Concrete.EntityFramework;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDAL = categoryDal;
        }

        public void createCategory(Categories category)
        {
            _categoryDAL.Add(category);
        }

        public Categories getCategoryById(int categoryId)
        {
            return _categoryDAL.Get(p=> p.Id == categoryId);
        }

        public List<Categories> getCategories()
        {
            return _categoryDAL.GetList();
        }
    }
}
