using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_15_Partitioning.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_15_Partitioning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentListView()
        {
            StudentDAL dal = new StudentDAL();
            List<Student> students = (List<Student>)dal.GetAllStudents();
            ViewData["students"] = students;

            var take = students.Take(2);
            List<Student> takeList = take.ToList();
            ViewData["take"] = takeList;

            var takewhile = students.OrderBy(st => st.MarksPercent).TakeWhile(st => st.MarksPercent <= 75);
            List<Student> takewhileList = takewhile.ToList();
            ViewData["takewhile"] = takewhileList;

            var skip = students.Skip(1);
            List<Student> skipList = skip.ToList();
            ViewData["skip"] = skipList;

            var skipwhile = students.OrderBy(st => st.MarksPercent).SkipWhile(st => st.MarksPercent <= 90);
            List<Student> skipwhileList = skipwhile.Reverse().ToList();
            ViewData["skipwhile"] = skipwhileList;


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
