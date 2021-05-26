using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase3Section4_17_Conversion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_17_Conversion.Controllers
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

            List<Student> toList = students.ToList<Student>();
            ViewData["toList"] = toList;

            Student[] toArray = students.ToArray<Student>();
            ViewData["toArray"] = toArray;

            var marksLookup = students.ToLookup(st => st.MarksPercent);
            List<Student> listLookup = new List<Student>();
            foreach (Student s in marksLookup[80])
            {
                listLookup.Add(s);
            }
            ViewData["listLookup"] = listLookup;

            IEnumerable<Student> cast = students.Cast<Student>();
            ViewData["cast"] = cast;

            ArrayList arrMixed = new ArrayList();
            arrMixed.Add("String value");
            arrMixed.Add(12);
            arrMixed.Add(DateTime.Today);
            arrMixed.Add(students[0]);
            IEnumerable<Student> arrOfType = arrMixed.OfType<Student>();
            List<Student> ofTypeList = arrOfType.ToList<Student>();
            ViewData["oftypeList"] = ofTypeList;

            IEnumerable<Student> ienum = students.AsEnumerable<Student>();
            ViewData["ienum"] = ienum;

            IQueryable<Student> query = students.AsQueryable().Where(st => st.MarksPercent < 90);
            ViewData["query"] = query;

            var dict = students.ToDictionary(st => st.Name, st => st.Address);
            ViewData["dict"] = dict;
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
