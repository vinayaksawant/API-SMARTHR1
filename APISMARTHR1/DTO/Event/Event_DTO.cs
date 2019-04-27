using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Event_DTO
    {
        public int EventID { get; set; }
        public int EmployerID { get; set; }
        public EventType EventType { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
    }
}
