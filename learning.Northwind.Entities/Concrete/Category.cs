using learning.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
