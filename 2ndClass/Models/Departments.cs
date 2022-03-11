using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2ndClass.Models
{
    public class Departments
    {
        [Key]
        public int Did { get; set; }

        [Required]
        public string DName { get; set; }
        
    }
}
