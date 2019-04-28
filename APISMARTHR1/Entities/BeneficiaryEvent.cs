using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class BeneficiaryEvent
    {

        public int BeneficiaryEventID { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public string BeneficiaryCode { get; set; }
        public string BeneficiaryFirstName { get; set; }
        public string BeneficiaryMiddleName { get; set; }
        public string BeneficiaryLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Relationship Relationship { get; set; }
        public IList<Address> Address { get; set; }
        public string BeneficiaryEmail { get; set; }
        public int BeneficiaryPhone { get; set; }

    }
}
