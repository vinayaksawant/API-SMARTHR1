﻿// <auto-generated />
using System;
using APISMARTHR1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APISMARTHR1.Migrations
{
    [DbContext(typeof(EmployerContext))]
    [Migration("20190428223018_AddedDepenentBeneficiary_UpdatedLifeEventDependencies")]
    partial class AddedDepenentBeneficiary_UpdatedLifeEventDependencies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APISMARTHR1.Entities.Beneficiary", b =>
                {
                    b.Property<int>("BeneficiaryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeID");

                    b.Property<string>("beneficiaryCode");

                    b.HasKey("BeneficiaryID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Beneficiary");
                });

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

            modelBuilder.Entity("APISMARTHR1.Entities.CoverageEvent", b =>
                {
                    b.Property<int>("CoverageEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LifeEventID");

                    b.Property<int?>("PlanEmployerPlanID");

                    b.Property<string>("PlanOptions");

                    b.HasKey("CoverageEventID");

                    b.HasIndex("LifeEventID");

                    b.HasIndex("PlanEmployerPlanID");

                    b.ToTable("CoverageEvent");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Dependent", b =>
                {
                    b.Property<int>("DependentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DependentCode");

                    b.Property<int?>("EmployeeID");

                    b.HasKey("DependentID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Dependent");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeName");

                    b.Property<int>("EmployerID");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployeeEvent", b =>
                {
                    b.Property<int>("EmployeeEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeDepartment");

                    b.Property<string>("EmployeeEmail");

                    b.Property<string>("EmployeeFirstName");

                    b.Property<int?>("EmployeeID");

                    b.Property<string>("EmployeeLastName");

                    b.Property<string>("EmployeeMiddleName");

                    b.Property<string>("EmployeeName");

                    b.Property<int>("EmployeePhone");

                    b.Property<DateTime>("HireDate");

                    b.Property<int?>("LifeEventID");

                    b.Property<string>("PostalAddress1");

                    b.Property<string>("PostalAddress2");

                    b.Property<string>("PostalAddressCity");

                    b.Property<string>("PostalAddressCountry");

                    b.Property<string>("PostalAddressState");

                    b.Property<int>("PostalAddressZip");

                    b.Property<DateTime>("RetirementDate");

                    b.Property<DateTime>("TerminationDate");

                    b.HasKey("EmployeeEventID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("LifeEventID");

                    b.ToTable("EmployeeEvent");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Employer", b =>
                {
                    b.Property<int>("EmployerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BillingRate");

                    b.Property<int>("EmployeeCount");

                    b.Property<string>("EmployerCode");

                    b.Property<string>("EmployerEmail");

                    b.Property<int>("EmployerFax");

                    b.Property<string>("EmployerImageUrl");

                    b.Property<string>("EmployerName");

                    b.Property<int>("EmployerPhone");

                    b.Property<int>("EmployerRating");

                    b.Property<int>("EmployerRevenue");

                    b.Property<string>("OriginCountryFlagImageUrl");

                    b.Property<string>("PostalAddress1");

                    b.Property<string>("PostalAddress2");

                    b.Property<string>("PostalAddressCity");

                    b.Property<string>("PostalAddressCountry");

                    b.Property<string>("PostalAddressState");

                    b.Property<int>("PostalAddressZip");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("EmployerID");

                    b.ToTable("Employer");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployerPlan", b =>
                {
                    b.Property<int>("EmployerPlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BenefitID");

                    b.Property<int>("EmployerID");

                    b.Property<string>("PlanCode");

                    b.Property<string>("PlanName");

                    b.HasKey("EmployerPlanID");

                    b.HasIndex("BenefitID");

                    b.ToTable("EmployerPlan");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployerID");

                    b.Property<string>("EventDescription");

                    b.Property<string>("EventName");

                    b.Property<int?>("EventTypeID");

                    b.HasKey("EventID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EventType", b =>
                {
                    b.Property<int>("EventTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDescription");

                    b.Property<string>("EventName");

                    b.HasKey("EventTypeID");

                    b.ToTable("EventType");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.LifeEvent", b =>
                {
                    b.Property<int>("LifeEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeID");

                    b.Property<int?>("EventID");

                    b.Property<string>("LifeEventComment");

                    b.Property<DateTime>("LifeEventDate");

                    b.HasKey("LifeEventID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("EventID");

                    b.ToTable("LifeEvent");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Beneficiary", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee")
                        .WithMany("Beneficiary")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.CoverageEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.LifeEvent")
                        .WithMany("CoverageEvent")
                        .HasForeignKey("LifeEventID");

                    b.HasOne("APISMARTHR1.Entities.EmployerPlan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanEmployerPlanID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Dependent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee")
                        .WithMany("Dependent")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployeeEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("APISMARTHR1.Entities.LifeEvent")
                        .WithMany("EmployeeEvent")
                        .HasForeignKey("LifeEventID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployerPlan", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Benefit", "Benefit")
                        .WithMany()
                        .HasForeignKey("BenefitID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Event", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.LifeEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee")
                        .WithMany("LifeEvent")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("APISMARTHR1.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventID");
                });
#pragma warning restore 612, 618
        }
    }
}
