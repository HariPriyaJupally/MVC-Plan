using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC_Plan.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        [StringLength(20)]
        public string bearcatNum { get; set; }
        public bool Done { get; set; }

    }
}
