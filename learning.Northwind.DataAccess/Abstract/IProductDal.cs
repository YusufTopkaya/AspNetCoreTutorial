using System;
using System.Collections.Generic;
using System.Text;
using learning.core.DataAccess;
using learning.Northwind.Entities.Concrete;

namespace learning.Northwind.DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {

    }
}
