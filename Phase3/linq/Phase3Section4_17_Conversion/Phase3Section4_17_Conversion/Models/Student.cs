using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_17_Conversion.Models
{
    public class Student
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public string Class { get; set; }

        public int MarksPercent { get; set; }

    }
}
