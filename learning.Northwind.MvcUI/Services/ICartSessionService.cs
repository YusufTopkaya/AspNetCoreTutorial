using learning.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning.Northwind.MvcUI.Services
{
   public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
