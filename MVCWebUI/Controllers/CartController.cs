﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Helpers;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            //ürünü çek 
            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(cart,product);

            _cartSessionHelper.SetCart("cart",cart);

            return RedirectToAction("Index" ,"Product");
        }

        public IActionResult Index()
        {
            var model = new CardListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult RemoveFromCart(int productId)
        {
            //ürünü çek 
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFromCart(cart, productId);

            _cartSessionHelper.SetCart("cart", cart);
            return RedirectToAction("Index", "Product");
        }
    }
}
