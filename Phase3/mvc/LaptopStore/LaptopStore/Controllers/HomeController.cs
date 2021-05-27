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

        public HomeController(
            ILogger<HomeController> logger)
        {
            _logger = logger ?? throw new Exception("Logger not defined");
            _logger.LogInformation("In  the home controller constructor");
        }

        public ActionResult Index()
        {

            return RedirectToRoute("/products/index");
        }
    }
}
