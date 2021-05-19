using Microsoft.AspNetCore.Mvc;
using Phase3_Scaffolding.Data;
using Phase3_Scaffolding.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3_Scaffolding.Controllers
{
    public class SubjectsController : Controller
    {
        private IGenericRepository<Subject> repository = null;
        public SubjectsController(IGenericRepository<Subject> repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var subjects = this.repository.SelectAll();

            return View();
        }
    }
}
