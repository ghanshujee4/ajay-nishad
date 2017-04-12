using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Globalization;
using System.Data;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angularmvc.Models
{
    
    public class Employee
    {
        //[Key]
        //[Column(TypeName = "Filedata")]
        //public byte[] Filedata { get; set; }

        //
        [Key]
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
    }

}