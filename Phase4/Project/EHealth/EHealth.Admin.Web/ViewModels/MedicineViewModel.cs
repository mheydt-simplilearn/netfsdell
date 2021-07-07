using EHealth.Shared.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.Admin.Web.ViewModels
{
    public class MedicineViewModel
    {
        public Medicine TheMedicine { get; set; }
        public Category RelatedCategory { get; set; }

        public string SelectedCategoryId { get; set; }
        public List<SelectListItem> CategoryItems { get; set; }

        public MedicineViewModel(Medicine theMedicine, Category relatedCategory)
        {
            TheMedicine = theMedicine;
            RelatedCategory = relatedCategory;
        }

        public MedicineViewModel(List<Category> categories)
        {
            CategoryItems = categories.Select(category => new SelectListItem(category.Name, category.Id.ToString())).ToList();
        }
    }
}
