using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISMARTHR1.Entities;

namespace APISMARTHR1.Services
{
    public interface IEmployer_Repo
    {
        IEnumerable<Employer> GetEmployers();
    }
}
