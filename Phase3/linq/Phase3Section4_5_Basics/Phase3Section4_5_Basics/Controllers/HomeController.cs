using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_5_Basics.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_5_Basics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Student[] arr = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();
                student.ID = i + 1;
                student.Name = "Name " + i.ToString();
                student.Address = "Address " + i.ToString();
                student.Email = "Email " + i.ToString();
                student.Class = "Class 4";
                arr[i] = student;
            }

            ViewData["students"] = arr;

            Student[] arr2 = arr.Where(s => s.ID == 2).ToArray();
            ViewData["idfilter"] = arr2;

            Student[] arr3 = arr.Where(s => s.Email == "Email 3").ToArray();

            ViewData["emailfilter"] = arr3;

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
