﻿using LaptopStore.Helpers;
using LaptopStore.Models;
using LaptopStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly IProductsRepository _productsRepository;

        public CartController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            return View(cart);
        }

        [HttpGet("AddToCart")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            if (SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart") == null)
            {
                var cart = new Cart();
                cart.Add(new CartItem { Product = await _productsRepository.FindAsync(productId), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
                var item = cart.FindItemByProductId(productId);
                if (item != null)
                {
                    item.Quantity++;
                }
                else
                {
                    cart.Add(new CartItem { Product = await _productsRepository.FindAsync(productId), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Remove")]
        public IActionResult Remove(int productId)
        {
            var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            var item = cart.FindItemByProductId(productId);
            if (item != null)
            {
                cart.Remove(item);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
    }
}
