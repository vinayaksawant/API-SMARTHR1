using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Event_CREATE_DTO
    {
        //Update-Create DTO will not take this ID
        //It is database Identity
        //public int EventID { get; set; }
        public int EmployerID { get; set; }
        public EventType EventType { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
    }
}
