using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeRequirementID { get; set; }
        
        public int StudentTermID { get; set; }

        public int RequirementID { get; set; }

        public StudentTerm StudentTerm { get; set; }

        public Requirement Requirement { get; set; }
    }
}
