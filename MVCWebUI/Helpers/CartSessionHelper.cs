using Entities.DomainModels;
using Microsoft.AspNetCore.Http;
using MVCWebUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Helpers
{
    public class CartSessionHelper : ICartSessionHelper
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }

        public Cart GetCart(string key)
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key); //sessionı oku
            if (cartToCheck == null)
            {
                SetCart(key,new Cart()); //set et
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key); //artık session var 
            }
            return cartToCheck;
        }

        public void SetCart(string key,Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, cart); ///anlamadım mantığını 
        }
    }
}
