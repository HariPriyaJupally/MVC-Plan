using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Plan.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int StudentTermId { get; set; }
        [Required]
        public int StudentID { get; set; }
        [Required]
        public int TermID { get; set; }
        [Required]
        [MaxLength(20)]
        public String TermName { get; set; }
        [Required]
        public int DegreePlanID { get; set; }

        public Student Student { get; set; }


        public DegreePlan DegreePlan { get; set; }

        public ICollection<DegreeRequirement> DegreeRequirements { get; set; }

    }
}