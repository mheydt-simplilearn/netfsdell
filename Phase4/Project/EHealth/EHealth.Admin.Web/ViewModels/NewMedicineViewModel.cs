using EHealth.Shared.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.Admin.Web.ViewModels
{
    public class NewMedicineViewModel 
    {
        public Medicine TheMedicine { get; set; }

        [DisplayName("Category")]
        public string SelectedCategoryId { get; set; }
        public List<SelectListItem> CategoryItems { get; set; }

        public NewMedicineViewModel()
        {

        }

        public NewMedicineViewModel(List<Category> categories)
        {
            CategoryItems = categories.Select(category => new SelectListItem(category.Name, category.Id.ToString())).ToList();
        }

        public Medicine ToMedicine()
        {
            var medicine = this.TheMedicine;
            medicine.CategoryId = int.Parse(this.SelectedCategoryId);
            return medicine;
        }
    }
}
