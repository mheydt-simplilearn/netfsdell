using EHealth.Shared.Models;
using EHealth.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicinesController : ControllerBase
    {
        private readonly ILogger<MedicinesController> _logger;
        private readonly IRepository<Medicine> _medicineRepository;

        public MedicinesController(
            ILogger<MedicinesController> logger,
            IRepository<Medicine> medicineRepository)
        {
            _logger = logger;
            _medicineRepository = medicineRepository;
        }

        [HttpGet]
        public IEnumerable<Medicine> Get()
        {
            return _medicineRepository.GetAll();
        }
    }
}
