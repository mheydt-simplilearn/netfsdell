using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_23_Joins.Models
{
    public class Subject
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int StudentId { get; set; }

    }

}
