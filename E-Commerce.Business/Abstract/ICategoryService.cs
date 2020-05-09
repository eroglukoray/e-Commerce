using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Categories> getCategories();
        Categories getCategoryById(int categoryId);
        void createCategory(Categories category);
       
    }
}
