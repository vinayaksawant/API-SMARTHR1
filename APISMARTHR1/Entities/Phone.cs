using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
