using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learning.Northwind.Bussiness.Abstract;
using learning.Northwind.MvcUI.Models;
using learning.Northwind.MvcUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace learning.Northwind.MvcUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
