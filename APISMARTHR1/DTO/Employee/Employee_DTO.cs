using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Employee_DTO
    {
        public int EmployeeEventID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public DateTime RetirementDate { get; set; }
        public IList<Address_DTO> EmployeeAddress { get; set; } = new List<Address_DTO>();
        public IList<Email_DTO> EmployeeEmail { get; set; } = new List<Email_DTO>();
        public IList<Phone_DTO> EmployeePhone { get; set; } = new List<Phone_DTO>();
    }
}
