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
    [Migration("20190504011210_RemovedEmployerID_FromEventAndEmployerPlan")]
    partial class RemovedEmployerID_FromEventAndEmployerPlan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APISMARTHR1.Entities.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressTypeID");

                    b.Property<int?>("BeneficiaryEventID");

                    b.Property<int?>("DependentEventID");

                    b.Property<int?>("EmployeeEventID");

                    b.Property<int?>("EmployerID");

                    b.Property<string>("PostalAddress1");

                    b.Property<string>("PostalAddress2");

                    b.Property<string>("PostalAddressCity");

                    b.Property<string>("PostalAddressCountry");

                    b.Property<string>("PostalAddressState");

                    b.Property<int>("PostalAddressZip");

                    b.HasKey("AddressID");

                    b.HasIndex("AddressTypeID");

                    b.HasIndex("BeneficiaryEventID");

                    b.HasIndex("DependentEventID");

                    b.HasIndex("EmployeeEventID");

                    b.HasIndex("EmployerID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.AddressType", b =>
                {
                    b.Property<int>("AddressTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressTypeCode");

                    b.Property<string>("AddressTypeDescription");

                    b.HasKey("AddressTypeID");

                    b.ToTable("AddressType");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Beneficiary", b =>
                {
                    b.Property<int>("BeneficiaryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BeneficiaryCode");

                    b.Property<int?>("EmployeeID");

                    b.HasKey("BeneficiaryID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Beneficiary");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.BeneficiaryEvent", b =>
                {
                    b.Property<int>("BeneficiaryEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BeneficiaryCode");

                    b.Property<string>("BeneficiaryFirstName");

                    b.Property<int?>("BeneficiaryID");

                    b.Property<string>("BeneficiaryLastName");

                    b.Property<string>("BeneficiaryMiddleName");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int?>("LifeEventID");

                    b.Property<int?>("RelationshipID");

                    b.HasKey("BeneficiaryEventID");

                    b.HasIndex("BeneficiaryID");

                    b.HasIndex("LifeEventID");

                    b.HasIndex("RelationshipID");

                    b.ToTable("BeneficiaryEvent");
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

            modelBuilder.Entity("APISMARTHR1.Entities.DependentEvent", b =>
                {
                    b.Property<int>("DependentEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("DependentCode");

                    b.Property<string>("DependentFirstName");

                    b.Property<int?>("DependentID");

                    b.Property<string>("DependentLastName");

                    b.Property<string>("DependentMiddleName");

                    b.Property<int?>("LifeEventID");

                    b.Property<int?>("RelationshipID");

                    b.HasKey("DependentEventID");

                    b.HasIndex("DependentID");

                    b.HasIndex("LifeEventID");

                    b.HasIndex("RelationshipID");

                    b.ToTable("DependentEvent");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Email", b =>
                {
                    b.Property<int>("EmailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeneficiaryEventID");

                    b.Property<int?>("DependentEventID");

                    b.Property<string>("EmailAddress");

                    b.Property<int?>("EmailTypeID");

                    b.Property<int?>("EmployeeEventID");

                    b.Property<int?>("EmployerID");

                    b.HasKey("EmailID");

                    b.HasIndex("BeneficiaryEventID");

                    b.HasIndex("DependentEventID");

                    b.HasIndex("EmailTypeID");

                    b.HasIndex("EmployeeEventID");

                    b.HasIndex("EmployerID");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmailType", b =>
                {
                    b.Property<int>("EmailTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailTypeCode");

                    b.Property<string>("EmailTypeDescription");

                    b.HasKey("EmailTypeID");

                    b.ToTable("EmailType");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeCode");

                    b.Property<int?>("EmployerID");

                    b.HasKey("EmployeeID");

                    b.HasIndex("EmployerID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployeeEvent", b =>
                {
                    b.Property<int>("EmployeeEventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmployeeCode");

                    b.Property<string>("EmployeeDepartment");

                    b.Property<string>("EmployeeFirstName");

                    b.Property<int?>("EmployeeID");

                    b.Property<string>("EmployeeLastName");

                    b.Property<string>("EmployeeMiddleName");

                    b.Property<DateTime>("HireDate");

                    b.Property<int?>("LifeEventID");

                    b.Property<int?>("RelationshipID");

                    b.Property<DateTime>("RetirementDate");

                    b.Property<DateTime>("TerminationDate");

                    b.HasKey("EmployeeEventID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("LifeEventID");

                    b.HasIndex("RelationshipID");

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

                    b.Property<string>("EmployerImageUrl");

                    b.Property<string>("EmployerName");

                    b.Property<int>("EmployerRating");

                    b.Property<int>("EmployerRevenue");

                    b.Property<string>("EmployerWebsite");

                    b.Property<string>("OriginCountryFlagImageUrl");

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

                    b.Property<int?>("EmployerID");

                    b.Property<string>("PlanCode");

                    b.Property<string>("PlanName");

                    b.HasKey("EmployerPlanID");

                    b.HasIndex("BenefitID");

                    b.HasIndex("EmployerID");

                    b.ToTable("EmployerPlan");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployerID");

                    b.Property<string>("EventDescription");

                    b.Property<string>("EventName");

                    b.Property<int?>("EventTypeID");

                    b.HasKey("EventID");

                    b.HasIndex("EmployerID");

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

            modelBuilder.Entity("APISMARTHR1.Entities.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeneficiaryEventID");

                    b.Property<int?>("DependentEventID");

                    b.Property<int?>("EmployeeEventID");

                    b.Property<int?>("EmployerID");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("PhoneTypeID");

                    b.HasKey("PhoneID");

                    b.HasIndex("BeneficiaryEventID");

                    b.HasIndex("DependentEventID");

                    b.HasIndex("EmployeeEventID");

                    b.HasIndex("EmployerID");

                    b.HasIndex("PhoneTypeID");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.PhoneType", b =>
                {
                    b.Property<int>("PhoneTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhoneTypeCode");

                    b.Property<string>("PhoneTypeDescription");

                    b.HasKey("PhoneTypeID");

                    b.ToTable("PhoneType");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Relationship", b =>
                {
                    b.Property<int>("RelationshipID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RelationshipCode");

                    b.Property<string>("RelationshipCodeDescription");

                    b.HasKey("RelationshipID");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Address", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.AddressType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeID");

                    b.HasOne("APISMARTHR1.Entities.BeneficiaryEvent")
                        .WithMany("BeneficiaryAddress")
                        .HasForeignKey("BeneficiaryEventID");

                    b.HasOne("APISMARTHR1.Entities.DependentEvent")
                        .WithMany("DependentAddress")
                        .HasForeignKey("DependentEventID");

                    b.HasOne("APISMARTHR1.Entities.EmployeeEvent")
                        .WithMany("EmployeeAddress")
                        .HasForeignKey("EmployeeEventID");

                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("EmployerAddress")
                        .HasForeignKey("EmployerID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Beneficiary", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee")
                        .WithMany("Beneficiary")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.BeneficiaryEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Beneficiary", "Beneficiary")
                        .WithMany()
                        .HasForeignKey("BeneficiaryID");

                    b.HasOne("APISMARTHR1.Entities.LifeEvent")
                        .WithMany("BeneficiaryEvent")
                        .HasForeignKey("LifeEventID");

                    b.HasOne("APISMARTHR1.Entities.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipID");
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

            modelBuilder.Entity("APISMARTHR1.Entities.DependentEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Dependent", "Dependent")
                        .WithMany()
                        .HasForeignKey("DependentID");

                    b.HasOne("APISMARTHR1.Entities.LifeEvent")
                        .WithMany("DependentEvent")
                        .HasForeignKey("LifeEventID");

                    b.HasOne("APISMARTHR1.Entities.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Email", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.BeneficiaryEvent")
                        .WithMany("BeneficiaryEmail")
                        .HasForeignKey("BeneficiaryEventID");

                    b.HasOne("APISMARTHR1.Entities.DependentEvent")
                        .WithMany("DependentEmail")
                        .HasForeignKey("DependentEventID");

                    b.HasOne("APISMARTHR1.Entities.EmailType", "EmailType")
                        .WithMany()
                        .HasForeignKey("EmailTypeID");

                    b.HasOne("APISMARTHR1.Entities.EmployeeEvent")
                        .WithMany("EmployeeEmail")
                        .HasForeignKey("EmployeeEventID");

                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("EmployerEmail")
                        .HasForeignKey("EmployerID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Employee", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("Employee")
                        .HasForeignKey("EmployerID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployeeEvent", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("APISMARTHR1.Entities.LifeEvent")
                        .WithMany("EmployeeEvent")
                        .HasForeignKey("LifeEventID");

                    b.HasOne("APISMARTHR1.Entities.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.EmployerPlan", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Benefit", "Benefit")
                        .WithMany()
                        .HasForeignKey("BenefitID");

                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("EmployerPlan")
                        .HasForeignKey("EmployerID");
                });

            modelBuilder.Entity("APISMARTHR1.Entities.Event", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("Event")
                        .HasForeignKey("EmployerID");

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

            modelBuilder.Entity("APISMARTHR1.Entities.Phone", b =>
                {
                    b.HasOne("APISMARTHR1.Entities.BeneficiaryEvent")
                        .WithMany("BeneficiaryPhone")
                        .HasForeignKey("BeneficiaryEventID");

                    b.HasOne("APISMARTHR1.Entities.DependentEvent")
                        .WithMany("DependentPhone")
                        .HasForeignKey("DependentEventID");

                    b.HasOne("APISMARTHR1.Entities.EmployeeEvent")
                        .WithMany("EmployeePhone")
                        .HasForeignKey("EmployeeEventID");

                    b.HasOne("APISMARTHR1.Entities.Employer")
                        .WithMany("EmployerPhone")
                        .HasForeignKey("EmployerID");

                    b.HasOne("APISMARTHR1.Entities.PhoneType", "PhoneType")
                        .WithMany()
                        .HasForeignKey("PhoneTypeID");
                });
#pragma warning restore 612, 618
        }
    }
}
