using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Address_DTO
    {
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddressCity { get; set; }
        public string PostalAddressState { get; set; }
        public int PostalAddressZip { get; set; }
        public string PostalAddressCountry { get; set; }
    }
}
