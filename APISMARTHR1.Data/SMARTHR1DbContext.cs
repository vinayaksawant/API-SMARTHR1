using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace APISMARTHR1.Data
{
    public class SMARTHR1DbContext :DbContext
    {
        public DbSet <Employer> Employers { get; set; }

    }
}
