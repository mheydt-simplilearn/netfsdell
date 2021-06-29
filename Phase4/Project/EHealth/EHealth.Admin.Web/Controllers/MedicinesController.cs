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

namespace EHealth.Admin.Web.Controllers
{
    [Authorize(Roles = "User")]
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
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
