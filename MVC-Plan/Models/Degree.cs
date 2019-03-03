using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Plan.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeID { get; set; }
        [Required]
        [MaxLength(20)]
        public string DegreeAbbreviation { get; set; }
        [Required]
        [MaxLength(40)]
        public string DegreeName { get; set; } 

    }
}