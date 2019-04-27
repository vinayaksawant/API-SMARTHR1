using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.DTO
{
    public class EmployerPlan_DTO
    {
        public int EmployerPlanID { get; set; }
        public int EmployerID { get; set; }
        public Benefit Benefit { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
    }
}
