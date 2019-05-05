using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Beneficiary_DTO
    {
        public int BeneficiaryEventID { get; set; }
        public int BeneficiaryID { get; set; }
        public string BeneficiaryCode { get; set; }
        public string BeneficiaryFirstName { get; set; }
        public string BeneficiaryMiddleName { get; set; }
        public string BeneficiaryLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public IList<Address_DTO> BeneficiaryAddress { get; set; } = new List<Address_DTO>();
        public IList<Email_DTO> BeneficiaryEmail { get; set; } = new List<Email_DTO>();
        public IList<Phone_DTO> BeneficiaryPhone { get; set; } = new List<Phone_DTO>();
    }
}
