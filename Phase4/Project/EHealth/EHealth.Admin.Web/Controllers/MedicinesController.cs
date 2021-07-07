using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EHealth.Shared;
using EHealth.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using EHealth.Shared.Repositories;
using EHealth.Admin.Web.ViewModels;

namespace EHealth.Admin.Web.Controllers
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

        // GET: Medicines
        public IActionResult Index()
        {
            var medicinesIndexViewModel = new MedicinesListViewModel(
                _medicineRepository.GetAll().ToList(),
                _categoryRepository.GetAll().ToList());

            return View(medicinesIndexViewModel);
        }

        public IActionResult Create()
        {
            return View(new NewMedicineViewModel(_categoryRepository.GetAll().ToList()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewMedicineViewModel newMedicineViewModel)
        {
            _medicineRepository.Insert(newMedicineViewModel.ToMedicine());
            return RedirectToAction("Index");
        }
    }
}
