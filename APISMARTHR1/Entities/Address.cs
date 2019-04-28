using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public AddressType AddressType { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddressCity { get; set; }
        public string PostalAddressState { get; set; }
        public int PostalAddressZip { get; set; }
        public string PostalAddressCountry { get; set; }
    }
}
