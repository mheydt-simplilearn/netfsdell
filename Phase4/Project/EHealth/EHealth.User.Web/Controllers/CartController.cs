using EHealth.Shared.Models;
using EHealth.Shared.Repositories;
using EHealth.User.Web.Helpers;
using EHealth.User.Web.Models;
using EHealth.User.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.User.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IRepository<Medicine> _medicineRepository;
        private readonly IRepository<Category> _categoryRepository;

        public CartController(
            IRepository<Medicine> medicineRepository,
            IRepository<Category> categoryRepository)
        {
            _medicineRepository = medicineRepository ?? throw new ArgumentNullException(nameof(medicineRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            return View(cart);
        }

        [HttpGet("AddToCart")]
        public IActionResult AddToCart(int medicineId)
        {
            if (SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart") == null)
            {
                var cart = new Cart();
                cart.Add(new CartItem { Medicine = _medicineRepository.Get(medicineId), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                HttpContext.Session.SetInt32("CartItemCount", cart.Items.Sum(i => i.Quantity));
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
                var item = cart.FindItemByProductId(medicineId);
                if (item != null)
                {
                    item.Quantity++;
                }
                else
                {
                    cart.Add(new CartItem { Medicine = _medicineRepository.Get(medicineId), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                HttpContext.Session.SetInt32("CartItemCount", cart.Items.Sum(i => i.Quantity));
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Remove")]
        public IActionResult Remove(int medicineId)
        {
            var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            var item = cart.FindItemByProductId(medicineId);
            if (item != null)
            {
                cart.Remove(item);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                HttpContext.Session.SetInt32("CartItemCount", cart.Items.Sum(i => i.Quantity));
            }
            return RedirectToAction("Index");
        }

        [HttpGet("CompletePurchase")]
        public IActionResult CompletePurchase()
        {
            var cart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");


            ViewData["CartItemCount"] = 0;

            HttpContext.Session.Remove("cart");

            return View(new OrderSummaryViewModel() { OrderTotal = cart.Items.Sum(item => item.Quantity * (double)item.Medicine.Price) });


        }
    }
}
