using learning.Northwind.Entities.Concrete;
using learning.core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning.Northwind.DataAccess.Abstract
{
   public interface ICategoryDal :IEntityRepository<Category>
    {

    }
}
