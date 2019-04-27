using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class LifeEvent_UPDATE_DTO
    {
        //Update-Create DTO will not take this ID
        //It is database Identity
        //public int LifeEventID { get; set; }
        public int EmployeeID { get; set; }
        public Event Event { get; set; }
        public string LifeEventComment { get; set; }
        public DateTime LifeEventDate { get; set; }
    }
}
