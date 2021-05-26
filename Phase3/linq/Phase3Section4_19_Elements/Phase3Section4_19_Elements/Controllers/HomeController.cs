using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_19_Elements.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_19_Elements.Controllers
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

            Student first = students.FirstOrDefault();
            ViewData["first"] = first;

            Student last = students.LastOrDefault();
            ViewData["last"] = last;

            Student elementAt = students.ElementAtOrDefault(2);
            ViewData["elementAt"] = elementAt;

            Student single = students.SingleOrDefault(st => st.MarksPercent == 95);
            ViewData["single"] = single;

            List<Student> emptyList = new List<Student>();
            IEnumerable<Student> defaultIfEmpty = (IEnumerable<Student>)emptyList.DefaultIfEmpty();
            ViewData["defaultIfEmpty"] = defaultIfEmpty;

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
