using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class Email
    {
        public int EmailID { get; set; }
        public EmailType EmailType { get; set; }
        public string EmailAddress { get; set; }
    }
}
