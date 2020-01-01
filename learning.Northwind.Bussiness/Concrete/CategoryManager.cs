using learning.Northwind.Bussiness.Abstract;
using learning.Northwind.DataAccess.Abstract;
using learning.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning.Northwind.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
