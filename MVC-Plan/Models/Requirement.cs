﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementID { get; set; }

        public string  RequirementAbbrev { get; set; }
        
        public string RequirementName { get; set; }

        public int DegreeID { get; set; }

        public Degree Degree { get; set; }

        public int StudentTermId { get; set; }

        public StudentTerm StudentTerm { get; set; }

    }
}
