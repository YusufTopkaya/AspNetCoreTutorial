using learning.Northwind.Bussiness.Abstract;
using learning.Northwind.DataAccess.Abstract;
using learning.Northwind.DataAccess.Concrete.EntityFramework;
using learning.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning.Northwind.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
