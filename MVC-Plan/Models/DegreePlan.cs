using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanID { get; set; }

        public int DegreeID { get; set; }

        public int StudentID { get; set; }

        public String DegreePlanAbbrev { get; set; }

        public String DegreePlanName { get; set; }


        public Degree Degree { get; set; }
        public Student Student { get; set; }

        // each plan has many terms... 
        public ICollection<StudentTerm> StudentTerms { get; set; }
    }
}
