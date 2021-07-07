using EHealth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.Admin.Web.ViewModels
{
    public class MedicinesListViewModel
    {
        public List<Medicine> Medicines { get; private set; }
        public List<Category> Categories { get; private set; }
        public List<MedicineViewModel> MedicineViewModels { get; private set; }

        public MedicinesListViewModel(List<Medicine> medicines, List<Category> categories)
        {
            Medicines = medicines;
            Categories = categories;

            MedicineViewModels =
                medicines.Select(medicine => new MedicineViewModel(medicine, categories.FirstOrDefault(category => category.Id == medicine.CategoryId))).ToList();
        }
    }
}
