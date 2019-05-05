using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Dependent_DTO
    {
        public int DependentEventID { get; set; }
        public int DependentID { get; set; }
        public string DependentCode { get; set; }
        public string DependentFirstName { get; set; }
        public string DependentMiddleName { get; set; }
        public string DependentLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public IList<Address_DTO> DependentAddress { get; set; } = new List<Address_DTO>();
        public IList<Email_DTO> DependentEmail { get; set; } = new List<Email_DTO>();
        public IList<Phone_DTO> DependentPhone { get; set; } = new List<Phone_DTO>();
    }
}
