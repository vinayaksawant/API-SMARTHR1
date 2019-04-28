using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class CoverageEvent
    {
        public int CoverageEventID { get; set; }
        public EmployerPlan Plan { get; set; }
        public string PlanOptions { get; set; }
    }
}
