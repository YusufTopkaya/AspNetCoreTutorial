using learning.Northwind.Bussiness.Abstract;
using learning.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning.Northwind.MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}
