using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class LifeEvent
    {
        public int LifeEventID { get; set; }

        public  int EmployeeID { get; set; }

        public Event Event  { get; set; }

        public string EventComment { get; set; }

        public DateTime LifeEventDate { get; set; }

    }
}
