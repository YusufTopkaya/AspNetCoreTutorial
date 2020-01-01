using learning.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning.Northwind.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
