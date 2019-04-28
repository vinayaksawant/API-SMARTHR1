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

        public DbSet<EmployerPlan> EmployerPlan { get; set; }
        public DbSet<Event> Event { get; set; }
        /*Handle uniqueness Criteria in code by checking 
         *before insert or update. that way it will be easier
         */
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Event>()
        //        .HasIndex(e => new { e.EmployerID, e.EventType.EventTypeID })
        //        .IsUnique(true);
        //}

        public DbSet<LifeEvent> LifeEvent { get; set; }
        public DbSet<CoverageEvent> CoverageEvent { get; set; }

        public DbSet<Employee> Employee { get; set; }

    }
}
