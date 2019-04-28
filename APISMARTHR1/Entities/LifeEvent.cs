using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class LifeEvent
    {
        public int LifeEventID { get; set; }
        public Event Event  { get; set; }
        public string LifeEventComment { get; set; }
        public DateTime LifeEventDate { get; set; }
        public IList<EmployeeEvent> EmployeeEvent { get; set; } = new List<EmployeeEvent>();
        public IList<DependentEvent> DependentEvent { get; set; } = new List<DependentEvent>();
        public IList<BeneficiaryEvent> BeneficiaryEvent { get; set; } = new List<BeneficiaryEvent>();
        public IList<CoverageEvent> CoverageEvent { get; set; } = new List<CoverageEvent>();
    }
}
