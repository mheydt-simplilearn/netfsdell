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
            ViewData["students"] = students;

            SubjectDAL dal2 = new SubjectDAL();
            List<Subject> subjects = (List<Subject>)dal2.GetAllSubjects();

            var innerjoin = (from st in students
                             join sub in subjects on st.ID equals sub.StudentId
                             select new
                             {
                                 st.ID,
                                 st.Name,
                                 st.Email,
                                 st.Address,
                                 st.Class,
                                 Subject = sub.Name
                             }).ToList();

            ViewData["innerjoin"] = innerjoin;

            var leftjoin = (from st in students
                            join sub in subjects on st.ID equals sub.StudentId
                            into a
                            from b in a.DefaultIfEmpty(new Subject())
                            select new
                            {
                                st.ID,
                                st.Name,
                                st.Email,
                                st.Address,
                                st.Class,
                                Subject = b.Name
                            }).ToList();

            ViewData["leftjoin"] = leftjoin;

            var crossjoin = (from st in students
                             from sub in subjects
                             select new
                             {
                                 st.ID,
                                 st.Name,
                                 st.Email,
                                 st.Address,
                                 st.Class,
                                 Subject = sub.Name
                             }).ToList();

            ViewData["crossjoin"] = crossjoin;

            var groupjoin = students.GroupJoin(subjects, st => st.ID, sub => sub.StudentId,
                                (st, sub) => new { Key = st.ID, Name = st.Name, subjects = sub });

            ViewData["groupjoin"] = groupjoin;


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
