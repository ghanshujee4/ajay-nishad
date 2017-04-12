using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Angularmvc.Models
{
    public class img
    {
        [ScaffoldColumn(false)]
    public int EmployeeID { get; set; }

    //[Required(ErrorMessage = "Please Enter BirthDay")]
    //public System.DateTime BirthDay { get; set; }

    [Required(ErrorMessage = "Please Enter Avatar Url")]
    public string AvatarUrl { get; set; }

    public string OriginalFilename { get; set; }

    public string ImageId { get; set; }
    }
}
