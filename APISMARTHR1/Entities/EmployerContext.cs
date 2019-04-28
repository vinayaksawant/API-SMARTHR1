using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1.Entities
{
    public class EmployerContext : DbContext
    {
        public EmployerContext(DbContextOptions<EmployerContext> options) 
            : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<EventType> EventType { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<AddressType> AddressType { get; set; }



        public DbSet<EmployerPlan> EmployerPlan { get; set; }
        public DbSet<Event> Event { get; set; }

        public DbSet<LifeEvent> LifeEvent { get; set; }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Dependent> Dependent { get; set; }
        public DbSet<Beneficiary> Beneficiary { get; set; }

        public DbSet<Address> Address { get; set; }
        public DbSet<EmployeeEvent> EmployeeEvent { get; set; }
        public DbSet<DependentEvent> DependentEvent { get; set; }
        public DbSet<BeneficiaryEvent> BeneficiaryEvent { get; set; }
        public DbSet<CoverageEvent> CoverageEvent { get; set; }
    }
}
