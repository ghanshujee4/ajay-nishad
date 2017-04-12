using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Angularmvc.Models
{
    public class tblA
    {
       [Key]
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string imageUrl { get; set; }
        //public DateTime CreatedUtc { get; set; }

        public DateTime Datetime { get; set; }
    }
    public abstract class EntityBase
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedUtc { get; set; }
    }
}