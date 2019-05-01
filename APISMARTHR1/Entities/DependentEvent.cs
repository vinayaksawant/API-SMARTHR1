using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class DependentEvent
    {
        public int DependentEventID { get; set; }
        public Dependent Dependent { get; set; }
        public string DependentCode { get; set; }
        public string DependentFirstName { get; set; }
        public string DependentMiddleName { get; set; }
        public string DependentLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Relationship Relationship { get; set; }
        public IList<Address> DependentAddress { get; set; } = new List<Address>();
        public IList<Email> DependentEmail { get; set; } = new List<Email>();
        public IList<Phone> DependentPhone { get; set; } = new List<Phone>();
    }
}
