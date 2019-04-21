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
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddressCity { get; set; }
        public string PostalAddressState { get; set; }
        public int PostalAddressZip { get; set; }
        public string PostalAddressCountry { get; set; }
        public string EmployerEmail { get; set; }
        public int EmployerPhone { get; set; }
        public int EmployerFax { get; set; }
        public string OriginCountryFlagImageUrl { get; set; }
        public string EmployerImageUrl { get; set; }
        public int EmployerRating { get; set; }
    }
}
