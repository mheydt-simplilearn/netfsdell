using EHealth.Shared.Models;
using EHealth.Shared.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.User.Web.Controllers
{
    [Authorize]
    public class MedicinesController : Controller
    {
        private IRepository<Medicine> _medicineRepository;
        private IRepository<Category> _categoryRepository;

        public MedicinesController(
            IRepository<Medicine> medicineRepository,
            IRepository<Category> categoryRepository)
        {
            _medicineRepository = medicineRepository ?? throw new ArgumentNullException(nameof(medicineRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IActionResult Index()
        {
            return View(_medicineRepository.GetAll());
        }

        public IActionResult Search(string searchString)
        {
            if (searchString == null) searchString = "";
            var filtered = _medicineRepository.GetAll().Where(medicine => medicine.Name.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return View("Index", filtered);
        }
    }
}
