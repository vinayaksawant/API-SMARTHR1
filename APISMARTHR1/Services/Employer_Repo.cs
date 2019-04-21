using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using APISMARTHR1.Entities;

namespace APISMARTHR1.Services
{
    public class Employer_Repo : IEmployer_Repo
    {
        private EmployerContext _context;
        public Employer_Repo(EmployerContext context)
        {
            _context = context;
        }


        public IEnumerable<Employer> GetEmployers()
        {
            return _context.Employer.OrderBy(e => e.EmployerName).ToList();

            //return ReadJasonAndTransformToEmployer();
        }
    }
}
