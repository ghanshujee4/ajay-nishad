using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Angularmvc.Models
{
     public class AngmvcModel
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
