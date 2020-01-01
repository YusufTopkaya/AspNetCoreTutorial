using System;
using System.Collections.Generic;
using learning.Northwind;
using System.Text;
using learning.Northwind.Entities.Concrete;

namespace learning.Northwind.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
