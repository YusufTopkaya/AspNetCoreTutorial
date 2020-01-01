﻿using learning.Northwind.Bussiness.Abstract;
using learning.Northwind.MvcUI.Models; 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning.Northwind.MvcUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(int page=1, int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategoryId(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1)*pageSize).Take(pageSize).ToList()
            };
            return View(model);
        }
    }
}
