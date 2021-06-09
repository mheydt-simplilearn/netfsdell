using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_23_Joins.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_23_Joins.Controllers
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
            students.Add(students[0]);
            ViewData["students"] = students;

            
            var students1 = students.Where(st => st.MarksPercent > 90);
            var students2 = students.Where(st => st.MarksPercent <= 90);
            var union = students1.Union(students2);
            List<Student> unionList = union.ToList();
            ViewData["union"] = unionList;

            students1 = students.Where(st => st.MarksPercent >= 80);
            students2 = students.Where(st => st.MarksPercent <= 80);
            var intersect = students1.Intersect(students2);
            List<Student> intersectList = intersect.ToList();
            ViewData["intersect"] = intersectList;

            var distinct = (from st in students
                            select new
                            {
                                st.MarksPercent
                            }).Distinct();
            var distinctList = distinct.ToList();
            ViewData["distinct"] = distinctList;


            students1 = students.Where(st => st.MarksPercent >= 80);
            students2 = students.Where(st => st.MarksPercent <= 80);
            var except = students1.Except(students2);
            List<Student> exceptList = except.ToList();
            ViewData["except"] = exceptList;
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
