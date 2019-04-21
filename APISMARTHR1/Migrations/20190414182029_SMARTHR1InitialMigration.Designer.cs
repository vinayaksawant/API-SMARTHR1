﻿// <auto-generated />
using APISMARTHR1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APISMARTHR1.Migrations
{
    [DbContext(typeof(EmployerContext))]
    [Migration("20190414182029_SMARTHR1InitialMigration")]
    partial class SMARTHR1InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APISMARTHR1.Entities.Benefit", b =>
                {
                    b.Property<int>("BenefitID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BenefitDescription");

                    b.Property<string>("BenefitName");

                    b.HasKey("BenefitID");

                    b.ToTable("Benefit");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Employer", b =>
                {
                    b.Property<int>("EmployerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployerCode");

                    b.Property<string>("EmployerName");

                    b.HasKey("EmployerID");

                    b.ToTable("Employer");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDescription");

                    b.Property<string>("EventName");

                    b.HasKey("EventID");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
