using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public string EmployerCode { get; set; }
        public string EmployerName { get; set; }
        public DateTime StartDate { get; set; }
        public int EmployeeCount { get; set; }
        public int EmployerRevenue { get; set; }
        public Decimal BillingRate { get; set; }
        public IList<Address> EmployerAddress { get; set; } = new List<Address>();
        public IList<Email> EmployerEmail { get; set; } = new List<Email>();
        public IList<Phone> EmployerPhone { get; set; } = new List<Phone>();
        public string EmployerWebsite { get; set; }
        public string EmployerImageUrl { get; set; }
        public int EmployerRating { get; set; }
        public string OriginCountryFlagImageUrl { get; set; }
        public IList<Employee> Employee { get; set; } = new List<Employee>();
        public IList<EmployerPlan> EmployerPlan { get; set; } = new List<EmployerPlan>();
        public IList<Event> Event { get; set; } = new List<Event>();

    }
}
