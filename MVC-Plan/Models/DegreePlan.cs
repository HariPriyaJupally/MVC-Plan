using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class DegreePlan
    {

        public int DegreePlanID { get; set; }

        public int DegreeID { get; set; }

        public int StudentID { get; set; }

        public String DegreePlanAbbrev { get; set; }

        public String DegreePlanName { get; set; }
    }
}
