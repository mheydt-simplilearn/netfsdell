using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_9_Projection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_9_Projection.Controllers
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

            var filter = (from st in students
                          where st.MarksPercent > 80
                          select st);
            List<Student> filterStudent = filter.ToList<Student>();

            ViewData["filter"] = filterStudent;

            students.ForEach(student =>
                student.subjects = Enumerable.Range(0, 4)
                    .Select((item, i) => $"Subject {item*4+i}").ToList());


            var many = students.SelectMany(st => st.subjects);
            List<String> manyList = many.ToList<String>();
            ViewData["many"] = manyList;

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
