using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_13_Sorting.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_13_Sorting.Controllers
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

            var orderby = (from st in students
                           orderby st.Name
                           select st
                           );

            List<Student> orderAsc = orderby.ToList<Student>();
            ViewData["ascorder"] = orderAsc;

            orderby = (from st in students
                       orderby st.Name descending
                       select st
                       );

            List<Student> orderDesc = orderby.ToList<Student>();
            ViewData["descorder"] = orderDesc;

            var thenBy = students.OrderBy(st => st.MarksPercent).ThenBy(st => st.Name);
            List<Student> thenByList = thenBy.ToList();
            ViewData["thenbyList"] = thenByList;

            var thenByDesc = students.OrderByDescending(st => st.MarksPercent).ThenByDescending(st => st.Name);
            List<Student> thenByDescList = thenByDesc.ToList<Student>();
            ViewData["thenbydescList"] = thenByDescList;


            var reverse = (from st in students
                           orderby st.Name
                           select st
                       ).Reverse();

            List<Student> reverseList = reverse.ToList<Student>();
            ViewData["reverse"] = reverseList;
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
