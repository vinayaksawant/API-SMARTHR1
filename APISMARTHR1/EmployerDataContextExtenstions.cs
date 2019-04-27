using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APISMARTHR1
{
    public static class EmployerDataContextExtenstions
    {

        public static void EnsureSeedDataForContext(this EmployerContext context)
        {
            PopulateEmployerData(context);
            PopulateBenefitData(context);
            PopulateEventTypeData(context);

            PopulateEventData(context);

            PopulateEmployerPlanData(context);

            PopulateEmployeeData(context);

        }

        public static void PopulateEmployerData(this EmployerContext context)
        {
            if (context.Employer.Any())
            {
                return;
            }
            List<Employer> employerList = new List<Employer>()
            {
                new Employer()
                {
                    EmployerName = "Gargi world wide",
                    EmployerCode = "SMART-HR-2",
                    StartDate = Convert.ToDateTime("01/01/2013"),
                    EmployeeCount = 2013,
                    EmployerRevenue = 201300,
                    BillingRate = 20.13m,
                    PostalAddress1 = "",
                    PostalAddress2 = "",
                    PostalAddressCity = "",
                    PostalAddressState = "",
                    PostalAddressZip = 0,
                    PostalAddressCountry = "",
                    EmployerEmail = "",
                    EmployerPhone = 0,
                    EmployerFax = 0,
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/194073/yellow-banana-cluster.svg",
                    EmployerRating = 5
                },
                new Employer
                {
                    EmployerName = "Sharvil Import Exports",
                    EmployerCode = "SMART-HR-4",
                    StartDate = Convert.ToDateTime("01/01/2012"),
                    EmployeeCount = 2012,
                    EmployerRevenue = 201200,
                    BillingRate = 20.12m,
                    PostalAddress1 = "",
                    PostalAddress2 = "",
                    PostalAddressCity = "",
                    PostalAddressState = "",
                    PostalAddressZip = 0,
                    PostalAddressCountry = "",
                    EmployerEmail = "",
                    EmployerPhone = 0,
                    EmployerFax = 0,
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/22871/chovynz-Pineapple-Icon.svg",
                    EmployerRating = 4
                },
                new Employer()
                {
                    EmployerName = "Shurya Business Intelligence",
                    EmployerCode = "SMART-HR-5",
                    StartDate = Convert.ToDateTime("01/01/2016"),
                    EmployeeCount = 2016,
                    EmployerRevenue = 201600,
                    BillingRate = 20.16m,
                    PostalAddress1 = "",
                    PostalAddress2 = "",
                    PostalAddressCity = "",
                    PostalAddressState = "",
                    PostalAddressZip = 0 ,
                    PostalAddressCountry = "",
                    EmployerEmail = "",
                    EmployerPhone = 0,
                    EmployerFax = 0,
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/209684/food-strawberry.svg",
                    EmployerRating = 4,
                }
            };
            context.Employer.AddRange(employerList);
            context.SaveChanges();
        }

        public static void PopulateBenefitData(this EmployerContext context)
        {
            if (context.Benefit.Any())
            {
                return;
            }
            List<Benefit> benefitList = new List<Benefit>()
            {
                new Benefit()
                {
                    BenefitName = "Health",
                    BenefitDescription = "Health Benefit"
                },
                new Benefit()
                {
                    BenefitName = "Life",
                    BenefitDescription = "Life Benefit"
                },
                new Benefit()
                {
                    BenefitName = "Disability",
                    BenefitDescription = "Disability Benefit"
                },
                new Benefit()
                {
                    BenefitName = "SpendingAccount",
                    BenefitDescription = "Spending Account Or Cafeteria Plan"
                },
                new Benefit()
                {
                    BenefitName = "Retirement",
                    BenefitDescription = "Retirement Benefits"
                },
                new Benefit()
                {
                    BenefitName = "Other",
                    BenefitDescription = "Other misc benefit"
                }
            };
            context.Benefit.AddRange(benefitList);
            context.SaveChanges();
        }

        public static void PopulateEventTypeData(this EmployerContext context)
        {
            if (context.Event.Any())
            {
                return;
            }
            List<EventType> eventTypeList = new List<EventType>()
            {
                new EventType()
                {
                    EventName = "Import",
                    EventDescription = "Import Event"
                },
                new EventType()
                {
                    EventName = "NewHire",
                    EventDescription = "NewHire Event"
                },
                new EventType()
                {
                    EventName = "OpenEnrollment",
                    EventDescription = "OpenEnrollment Event"
                },
                new EventType()
                {
                    EventName = "Birth",
                    EventDescription = "Birth Event"
                },
                new EventType()
                {
                    EventName = "Marriage",
                    EventDescription = "Marriage Event"
                },
                new EventType()
                {
                    EventName = "Retirement",
                    EventDescription = "Retirement Event"
                }
            };
            context.EventType.AddRange(eventTypeList);
            context.SaveChanges();
        }

        public static void PopulateEventData(this EmployerContext context)
        {
            if (context.Event.Any())
            {
                return;
            }
            List<Event> eventList = new List<Event>()
            {
                new Event()
                {
                    EventName = "EE1-EV1",
                    EventDescription = "EE1 Import",
                    EmployerID = 1,
                    EventType = context.EventType.Where(e => e.EventTypeID == 1).FirstOrDefault(),
                },
                new Event()
                {
                    EventName = "EE1-EV2",
                    EventDescription = "EE1 NewHire",
                    EmployerID = 1,
                    EventType = context.EventType.Where(e => e.EventTypeID == 2).FirstOrDefault(),
                },
                new Event()
                {
                    EventName = "EE1-EV3",
                    EventDescription = "EE1 OpenEnrollment",
                    EmployerID = 1,
                    EventType = context.EventType.Where(e => e.EventTypeID == 3).FirstOrDefault(),
                },
            };
            context.Event.AddRange(eventList);
            context.SaveChanges();
        }

        public static void PopulateEmployerPlanData(this EmployerContext context)
        {
            if (context.EmployerPlan.Any())
            {
                return;
            }
            List<EmployerPlan> employerPlanList = new List<EmployerPlan>()
            {
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 1).FirstOrDefault(),
                    PlanCode = "MedicalHealth",
                    PlanName = "MedicalHealth",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 1).FirstOrDefault(),
                    PlanCode = "DentalHealth",
                    PlanName = "DentalHealth",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 1).FirstOrDefault(),
                    PlanCode = "VisionHealth",
                    PlanName = "VisionHealth",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "BasicLife",
                    PlanName = "BasicLife",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "SpouseLife",
                    PlanName = "SpouseLife",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "ChildLife",
                    PlanName = "ChildLife",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 3).FirstOrDefault(),
                    PlanCode = "LTD",
                    PlanName = "LTD",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 3).FirstOrDefault(),
                    PlanCode = "STD",
                    PlanName = "STD",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Medical",
                    PlanName = "FSA-Medical",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Dependent",
                    PlanName = "FSA-Dependent",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Parking",
                    PlanName = "FSA-Parking",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Transit",
                    PlanName = "FSA-Transit",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 5).FirstOrDefault(),
                    PlanCode = "Retirement-401K",
                    PlanName = "Retirement-401K",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 5).FirstOrDefault(),
                    PlanCode = "Retirement-IRA",
                    PlanName = "Retirement-IRA",
                    EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 6).FirstOrDefault(),
                    PlanCode = "Other-Legal",
                    PlanName = "Other-Legal",
                    EmployerID= 1,
                }
            };
            context.EmployerPlan.AddRange(employerPlanList);
            context.SaveChanges();
        }

        public static void PopulateEmployeeData(this EmployerContext context)
        {
            if (context.Employee.Any())
            {
                return;
            }
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeName = "john keep",
                    EmployerID= 1,
                },
                new Employee()
                {
                    EmployeeName = "maggie mars",
                    EmployerID= 1,
                },
                new Employee()
                {
                    EmployeeName = "churio frito",
                    EmployerID= 2,
                },
                new Employee()
                {
                    EmployeeName = "yummy tummy",
                    EmployerID= 2,
                },
            };
            context.Employee.AddRange(employeeList);
            context.SaveChanges();
        }


    }
}
