using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learning.Northwind.Entities.Concrete;
using learning.Northwind.MvcUI.ExtensionMethods;
using Microsoft.AspNetCore.Http;

namespace learning.Northwind.MvcUI.Services
{
    public class CartSessionService : ICartSessionService
    {

        private IHttpContextAccessor _httpContextAccesor;
        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccesor = httpContextAccessor;
        }
        public Cart GetCart()
        {
          Cart cartToCheck=  _httpContextAccesor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck==null)
            {
                _httpContextAccesor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccesor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccesor.HttpContext.Session.SetObject("cart", new Cart());
        }
    }
}
