using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }

        public int EmployerID { get; set; }

        public IList<LifeEvent> LifeEvent { get; set; } = new List<LifeEvent>();
        public IList<Dependent> Dependent { get; set; } = new List<Dependent>();
        public IList<Beneficiary> Beneficiary { get; set; } = new List<Beneficiary>();

    }
}
