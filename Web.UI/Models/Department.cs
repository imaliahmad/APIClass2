using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class Department
    {
        public int Did { get; set; }

        [Required]
        public string DName { get; set; }
    }
}
