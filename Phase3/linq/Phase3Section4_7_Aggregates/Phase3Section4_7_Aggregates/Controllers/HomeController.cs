using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_7_Aggregates.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_7_Aggregates.Controllers
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
            return View();
        }
        public IActionResult StudentListView()
        {
            StudentDAL dal = new StudentDAL();
            List<Student> students = (List<Student>)dal.GetAllStudents();
            ViewData["students"] = students;

            var marksMin = students.Select(student => student.MarksPercent).Min();
            ViewData["minMarks"] = marksMin;

            var marksMax = (from st in students
                            select st.MarksPercent).Max();
            ViewData["maxMarks"] = marksMax;

            var marksTotal = (from st in students
                              select st.MarksPercent).Sum();
            ViewData["sumMarks"] = marksTotal;


            var marksCount = (from st in students
                              select st.MarksPercent).Count();
            ViewData["countMarks"] = marksCount;


            var marksAverage = (from st in students
                                select st.MarksPercent).Average();
            ViewData["averageMarks"] = marksAverage;


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
