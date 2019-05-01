using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class EmployeeEvent
    {
        public int EmployeeEventID { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Relationship Relationship { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public DateTime RetirementDate { get; set; }
        public IList<Address> EmployeeAddress { get; set; } = new List<Address>();
        public IList<Email> EmployeeEmail { get; set; } = new List<Email>();
        public IList<Phone> EmployeePhone { get; set; } = new List<Phone>();
    }
}
