using System;
using System.Collections.Generic;
using System.Text;
using learning.core.DataAccess.EntityFramework;
using learning.Northwind.Entities.Concrete;
using learning.Northwind.DataAccess.Abstract;

namespace learning.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        
    }
}
