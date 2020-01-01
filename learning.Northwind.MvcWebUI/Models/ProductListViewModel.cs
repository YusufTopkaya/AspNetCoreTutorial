using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learning.Northwind.Entities.Concrete;

namespace learning.Northwind.MvcUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
