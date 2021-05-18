using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section2_18.Models
{
    public class StudentModel
    {
        
        public string Name { get; set; }
        public string WhichClass { get; set; }
        [Required]
        public string Address { get; set; }
        [Display(Name="Final Grade for the Course")]
        [Range(60, 100)]
        public int TotalMarks { get; set; }


    }

}
