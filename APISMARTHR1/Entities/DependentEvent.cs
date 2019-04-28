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
        public IList<Address> Address { get; set; }
        public string DependentEmail { get; set; }
        public int DependentPhone { get; set; }
    }
}
