using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class Employee_UPDATE_DTO
    {
        //Update-Create DTO will not take this ID
        //It is database Identity
        //public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployerID { get; set; }
    }
}
