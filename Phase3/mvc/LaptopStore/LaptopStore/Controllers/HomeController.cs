using LaptopStore.Models;
using LaptopStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILaptopStoreRepository _repository;

        public HomeController(
            ILogger<HomeController> logger,
            ILaptopStoreRepository repository)
        {
            _logger = logger ?? throw new Exception("Logger not defined");
            _repository = repository ?? throw new Exception("Exception not defined");
        }

        public ActionResult Index()
        {

            var products = _repository.GetProducts();// _ctx.Products.ToList<Product>();
            return View(products);
        }

        public ActionResult Category(string catName)
        {
            /*
            List<Product> products;
            if (catName == "")
            {
                products = _ctx.Products.ToList<Product>();
            }
            else
            {
                products = _ctx.Products.Where(p => p.Category == catName).ToList<Product>();
            }
            ViewBag.Products = products;
            return View("Index");
            */
            return Ok();
        }

        /*
        public ActionResult Suppliers()
        {
            List<Supplier> suppliers = _ctx.Suppliers.ToList<Supplier>();
            ViewBag.Suppliers = suppliers;
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            addToCart(id);
            return RedirectToAction("Index");
        }

        private void addToCart(int pId)
        {
            // check if product is valid
            Product product = _ctx.Products.FirstOrDefault(p => p.PID == pId);
            if (product != null && product.UnitsInStock > 0)
            {
                // check if product already existed
                ShoppingCartData cart = _ctx.ShoppingCartDatas.FirstOrDefault(c => c.PID == pId);
                if (cart != null)
                {
                    cart.Quantity++;
                }
                else
                {

                    cart = new ShoppingCartData
                    {
                        PName = product.PName,
                        PID = product.PID,
                        UnitPrice = product.UnitPrice,
                        Quantity = 1
                    };

                    _ctx.ShoppingCartDatas.Add(cart);
                }
                product.UnitsInStock--;
                _ctx.SaveChanges();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        */
    }
}
