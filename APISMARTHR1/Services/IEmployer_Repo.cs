using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISMARTHR1.DTO.Employer;

namespace APISMARTHR1.Services
{
    interface IEmployer_Repo
    {
        IEnumerable<Employer_DTO> GetEmployers();
    }
}
