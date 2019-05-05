using APISMARTHR1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APISMARTHR1
{
    public static class EmployerDataContextExtenstions
    {

        public static void EnsureSeedDataForContext(this EmployerContext context)
        {
            #region reseeddata
            string SQLRESEEDTables = "" +
                                            //"DBCC CheckIDENT ('Employer',RESEED,0);" +
                                            //"DBCC CheckIDENT ('Benefit',RESEED,0);" +
                                            //"DBCC CheckIDENT ('EventType',RESEED,0);" +
                                            //"DBCC CheckIDENT ('Relationship',RESEED,0);" +
                                            //"DBCC CheckIDENT ('AddressType',RESEED,0);" +
                                            //"DBCC CheckIDENT ('EmailType',RESEED,0);" +
                                            //"DBCC CheckIDENT ('PhoneType',RESEED,0);" +
                                          //"DBCC CheckIDENT ('Address',RESEED,0);" +
                                          //"DBCC CheckIDENT ('Email',RESEED,0);" +
                                          //"DBCC CheckIDENT ('Phone',RESEED,0);" +
                                          ////"DBCC CheckIDENT ('EmployerPlan',RESEED,0);" +
                                          ////"DBCC CheckIDENT ('Event',RESEED,0);" +
                                          ////"DBCC CheckIDENT ('Employee',RESEED,0);" +
                                          ////"DBCC CheckIDENT ('Dependent',RESEED,0);" +
                                          ////"DBCC CheckIDENT ('Beneficiary',RESEED,0);" +
                                          //"DBCC CheckIDENT ('LifeEvent',RESEED,0);" +
                                          //"DBCC CheckIDENT ('EmployeeEvent',RESEED,0);" +
                                          //"DBCC CheckIDENT ('DependentEvent',RESEED,0);" +
                                          //"DBCC CheckIDENT ('BeneficiaryEvent',RESEED,0);" +
                                          //"DBCC CheckIDENT ('CoverageEvent',RESEED,0);" +
                                          "";
            #endregion reseeddata

            //context.Database.ExecuteSqlCommand(SQLRESEEDTables);
            //context.SaveChanges();

            PopulateEmployerData(context);
            //AddAddressForEmployerData(context);
            PopulateBenefitData(context);
            PopulateEventTypeData(context);
            PopulateAddressTypeData(context);
            PopulateEmailTypeData(context);
            PopulatePhoneTypeData(context);
            PopulateRelationshipData(context);
            PopulateEventData(context);
            PopulateEmployerPlanData(context);
            PopulateEmployeeData(context);
            PopulateLifeEventData(context);
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
                    EmployerCode = "SMART-HR-1",
                    StartDate = Convert.ToDateTime("01/01/2013"),
                    EmployeeCount = 2013,
                    EmployerRevenue = 201300,
                    BillingRate = 20.13m,
                    EmployerAddress = GenerateAddress(context,"Home","Employer"),
                    EmployerPhone = GeneratePhone(context,"Home","Employer"),
                    EmployerEmail = GenerateEmail(context,"Home","Employer"),
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/194073/yellow-banana-cluster.svg",
                    EmployerRating = 5
                },
                new Employer
                {
                    EmployerName = "Sharvil Import Exports",
                    EmployerCode = "SMART-HR-2",
                    StartDate = Convert.ToDateTime("01/01/2012"),
                    EmployeeCount = 2012,
                    EmployerRevenue = 201200,
                    BillingRate = 20.12m,
                    EmployerAddress = GenerateAddress(context,"Home","Employer"),
                    EmployerPhone = GeneratePhone(context,"Home","Employer"),
                    EmployerEmail = GenerateEmail(context,"Home","Employer"),
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/22871/chovynz-Pineapple-Icon.svg",
                    EmployerRating = 4
                },
                new Employer()
                {
                    EmployerName = "Shurya Business Intelligence",
                    EmployerCode = "SMART-HR-3",
                    StartDate = Convert.ToDateTime("01/01/2016"),
                    EmployeeCount = 2016,
                    EmployerRevenue = 201600,
                    BillingRate = 20.16m,
                    EmployerAddress = GenerateAddress(context,"Home","Employer"),
                    EmployerPhone = GeneratePhone(context,"Home","Employer"),
                    EmployerEmail = GenerateEmail(context,"Home","Employer"),
                    OriginCountryFlagImageUrl = "",
                    EmployerImageUrl = "https://openclipart.org/download/209684/food-strawberry.svg",
                    EmployerRating = 4,
                }
            };
            context.Employer.AddRange(employerList);
            context.SaveChanges();
        }

        public static void AddAddressForEmployerData(this EmployerContext context)
        {
            if (context.Employer.Any())
            {
                var employer1 = context.Employer.Where(e => e.EmployerCode == "SMART-HR-1").FirstOrDefault();
                employer1.EmployerAddress = GenerateAddress(context, "Home", "Employer");
                employer1.EmployerPhone = GeneratePhone(context, "Home", "Employer");
                employer1.EmployerEmail = GenerateEmail(context, "Home", "Employer");

                var employer2 = context.Employer.Where(e => e.EmployerCode == "SMART-HR-2").FirstOrDefault();
                employer2.EmployerAddress = GenerateAddress(context, "Home", "Employer");
                employer2.EmployerPhone = GeneratePhone(context, "Home", "Employer");
                employer2.EmployerEmail = GenerateEmail(context, "Home", "Employer");

                var employer3 = context.Employer.Where(e => e.EmployerCode == "SMART-HR-3").FirstOrDefault();
                employer3.EmployerAddress = GenerateAddress(context, "Home", "Employer");
                employer3.EmployerPhone = GeneratePhone(context, "Home", "Employer");
                employer3.EmployerEmail = GenerateEmail(context, "Home", "Employer");
            }
            context.SaveChanges();
        }

        static IList<Address> GenerateAddress(this EmployerContext context,string AddressType , string AddressFor)
        {
            AddressType adrType = context.AddressType
                                    .Where( i => i.AddressTypeCode.ToUpper() == AddressType.ToUpper())
                                    .FirstOrDefault();

            return new List<Address>()
            {
                new Address()
                {
                    AddressType= adrType,
                    PostalAddress1 = AddressFor + " " + "123 Prairie Center Drive",
                    PostalAddress2 = AddressFor + " " + "Apt # 3120",
                    PostalAddressCity = AddressFor + " " + "Edina",
                    PostalAddressState = "MN",
                    PostalAddressZip = 55436 ,
                    PostalAddressCountry = "USA",
                }
            };
        }
        static IList<Phone> GeneratePhone(this EmployerContext context, string PhoneType, string AddressFor)
        {
            PhoneType phoneType = context.PhoneType
                                    .Where(i => i.PhoneTypeCode.ToUpper() == PhoneType.ToUpper())
                                    .FirstOrDefault();

            string phone = "000-000-0000";
            switch (AddressFor)
            {
                case "Employer":
                    phone = "111-111-1111";
                    break;
                case "Employee":
                    phone = "222-222-2222";
                    break;
                case "Dependent":
                    phone = "333-333-3333";
                    break;
                case "Beneficiary":
                    phone = "444-444-4444";
                    break;
            };

            return new List<Phone>()
            {
                new Phone()
                {
                    PhoneType= phoneType,
                    PhoneNumber= phone
                }
            };
        }
        static IList<Email> GenerateEmail(this EmployerContext context, string EmailType, string AddressFor)
        {
            EmailType emailType = context.EmailType
                                    .Where(i => i.EmailTypeCode.ToUpper() == EmailType.ToUpper())
                                    .FirstOrDefault();

            string email = "generic@generic.com";
            switch (AddressFor)
            {
                case "Employer":
                    email = "employer@employer.com";
                    break;
                case "Employee":
                    email = "employee@employee.com";
                    break;
                case "Dependent":
                    email = "dependent@dependent.com";
                    break;
                case "Beneficiary":
                    email = "beneficiary@beneficiary.com";
                    break;
            };

            return new List<Email>()
            {
                new Email()
                {
                    EmailType= emailType,
                    EmailAddress = email
                }
            };
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
            if (context.EventType.Any())
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
        public static void PopulateAddressTypeData(this EmployerContext context)
        {
            if (context.AddressType.Any())
            {
                return;
            }
            List<AddressType> addressTypeList = new List<AddressType>()
            {
                new AddressType()
                {
                    AddressTypeCode = "Home",
                    AddressTypeDescription = "HomeAddress",
                }
            };
            context.AddressType.AddRange(addressTypeList);
            context.SaveChanges();
        }
        public static void PopulateEmailTypeData(this EmployerContext context)
        {
            if (context.EmailType.Any())
            {
                return;
            }
            List<EmailType> emailTypeList = new List<EmailType>()
            {
                new EmailType()
                {
                    EmailTypeCode = "Home",
                    EmailTypeDescription = "Home"
                }
            };
            context.EmailType.AddRange(emailTypeList);
            context.SaveChanges();
        }
        public static void PopulatePhoneTypeData(this EmployerContext context)
        {
            if (context.PhoneType.Any())
            {
                return;
            }
            List<PhoneType> phoneTypeList = new List<PhoneType>()
            {
                new PhoneType()
                {
                    PhoneTypeCode = "Home",
                    PhoneTypeDescription = "Home"
                }
            };
            context.PhoneType.AddRange(phoneTypeList);
            context.SaveChanges();
        }
        public static void PopulateRelationshipData(this EmployerContext context)
        {
            if (context.Relationship.Any())
            {
                return;
            }
            List<Relationship> relationshipList = new List<Relationship>()
            {
                new Relationship()
                {
                    RelationshipCode = "Self",
                    RelationshipCodeDescription = "Self"
                },
                new Relationship()
                {
                    RelationshipCode = "Spouse",
                    RelationshipCodeDescription = "Spouse"
                },
                new Relationship()
                {
                    RelationshipCode = "Child",
                    RelationshipCodeDescription = "Child"
                },
                new Relationship()
                {
                    RelationshipCode = "Other",
                    RelationshipCodeDescription = "Other"
                }
            };
            context.Relationship.AddRange(relationshipList);
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
                    EventCode = "EE1-EV1",
                    EventName = "Import",
                    EventDescription = "EE1 Import",
                    EventType = context.EventType.Where(e => e.EventTypeID == 1).FirstOrDefault(),
                },
                new Event()
                {
                    EventCode = "EE1-EV2",
                    EventName = "NewHire",
                    EventDescription = "EE1 NewHire",
                    EventType = context.EventType.Where(e => e.EventTypeID == 2).FirstOrDefault(),
                },
                new Event()
                {
                    EventCode = "EE1-EV3",
                    EventName = "OpenEnrollment",
                    EventDescription = "EE1 OpenEnrollment",
                    EventType = context.EventType.Where(e => e.EventTypeID == 3).FirstOrDefault(),
                },
            };

            Employer employer1 = context.Employer.Where(i => i.EmployerID == 1).FirstOrDefault();
            if (employer1 != null)
            {
                employer1.Event = eventList;
            }
            //context.Event.AddRange(eventList);
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
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 1).FirstOrDefault(),
                    PlanCode = "DentalHealth",
                    PlanName = "DentalHealth",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 1).FirstOrDefault(),
                    PlanCode = "VisionHealth",
                    PlanName = "VisionHealth",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "BasicLife",
                    PlanName = "BasicLife",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "SpouseLife",
                    PlanName = "SpouseLife",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 2).FirstOrDefault(),
                    PlanCode = "ChildLife",
                    PlanName = "ChildLife",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 3).FirstOrDefault(),
                    PlanCode = "LTD",
                    PlanName = "LTD",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 3).FirstOrDefault(),
                    PlanCode = "STD",
                    PlanName = "STD",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Medical",
                    PlanName = "FSA-Medical",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Dependent",
                    PlanName = "FSA-Dependent",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Parking",
                    PlanName = "FSA-Parking",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 4).FirstOrDefault(),
                    PlanCode = "FSA-Transit",
                    PlanName = "FSA-Transit",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 5).FirstOrDefault(),
                    PlanCode = "Retirement-401K",
                    PlanName = "Retirement-401K",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 5).FirstOrDefault(),
                    PlanCode = "Retirement-IRA",
                    PlanName = "Retirement-IRA",
                    //EmployerID= 1,
                },
                new EmployerPlan()
                {
                    Benefit = context.Benefit.Where(b => b.BenefitID == 6).FirstOrDefault(),
                    PlanCode = "Other-Legal",
                    PlanName = "Other-Legal",
                    //EmployerID= 1,
                }
            };

            Employer employer1 = context.Employer.Where(i => i.EmployerID == 1).FirstOrDefault();
            if (employer1 != null)
            {
                employer1.EmployerPlan = employerPlanList;
            }
            //context.EmployerPlan.AddRange(employerPlanList);
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
                    EmployeeCode = "john_keep",
                    Dependent = new List<Dependent>()
                        {
                            new Dependent()
                            {
                                DependentCode = "john_keep_dep1"
                            }
                        },
                    Beneficiary = new List<Beneficiary>()
                        {
                            new Beneficiary()
                            {
                                BeneficiaryCode = "john_keep_benef1"
                            }
                        }
                },

                new Employee()
                {
                    EmployeeCode = "maggie_mars",
                    Dependent = new List<Dependent>()
                        {
                            new Dependent()
                            {
                                DependentCode = "maggie_mars_dep1"
                            }
                        },
                    Beneficiary = new List<Beneficiary>()
                        {
                            new Beneficiary()
                            {
                                BeneficiaryCode = "maggie_mars_benef1"
                            }
                        }
                },
            };

            Employer employer1 = context.Employer.Where(i => i.EmployerID == 1).FirstOrDefault();
            if (employer1 != null)
            {
                employer1.Employee = employeeList;

            }
             context.SaveChanges();
        }

        public static void PopulateLifeEventData(this EmployerContext context)
        {
            if (context.LifeEvent.Any())
            {
                return;
            }
            var er_event = context.Event.Where(e => e.EventCode.ToUpper() == "EE1-EV1").FirstOrDefault();

            var employee1 = context.Employee.Where(e => e.EmployeeCode.ToUpper() == "JOHN_KEEP").FirstOrDefault();
            var relationshipSelf = context.Relationship.Where(r => r.RelationshipCode.ToUpper() == "SELF").FirstOrDefault();
            var employeeEvent1 =
                new List<EmployeeEvent>() {
                        new EmployeeEvent(){
                            Employee = employee1,
                            EmployeeCode = employee1.EmployeeCode,
                            EmployeeFirstName = "John",
                            EmployeeMiddleName ="s",
                            EmployeeLastName = "Keep",
                            EmployeeDepartment = "Finance",
                            DateOfBirth = new DateTime(1991,01,01),
                            Relationship = relationshipSelf,
                            HireDate = new DateTime(2001,01,01),
                            TerminationDate = DateTime.MaxValue,
                            RetirementDate = DateTime.MaxValue,
                            EmployeeAddress = GenerateAddress(context,"Home","Employee"),
                            EmployeePhone = GeneratePhone(context,"Home","Employee"),
                            EmployeeEmail = GenerateEmail(context,"Home","Employee"),
                        }
                };

            var dependent1 = context.Dependent.Where(d => d.DependentCode.ToUpper() == "JOHN_KEEP_DEP1").FirstOrDefault();
            var relationshipChild = context.Relationship.Where(r => r.RelationshipCode.ToUpper() == "CHILD").FirstOrDefault();
            var dependentEvent1 = new List<DependentEvent>() {
                    new DependentEvent(){
                        Dependent = dependent1,
                        DependentCode = dependent1.DependentCode,
                        DependentFirstName = "John_dep1",
                        DependentMiddleName = "J",
                        DependentLastName = "Keep",
                        DateOfBirth = new DateTime(2011, 01, 01),
                        Relationship = relationshipChild,
                        DependentAddress = GenerateAddress(context, "Home", "Dependent"),
                        DependentEmail = GenerateEmail(context,"Home","Dependent"),
                        DependentPhone = GeneratePhone(context, "Home", "Dependent"),
                    }
            };

            var beneficiary1 = context.Beneficiary.Where(e => e.BeneficiaryCode.ToUpper() == "JOHN_KEEP_BENEF1").FirstOrDefault();
            var beneficiaryEvent1 = new List<BeneficiaryEvent>() {
                    new BeneficiaryEvent(){
                        Beneficiary = beneficiary1,
                        BeneficiaryCode = beneficiary1.BeneficiaryCode,
                        BeneficiaryFirstName = "John_bene1",
                        BeneficiaryMiddleName ="J",
                        BeneficiaryLastName = "Keep",
                        DateOfBirth = new DateTime(2011, 01, 01),
                        Relationship = relationshipChild,
                        BeneficiaryAddress = GenerateAddress(context, "Home", "Beneficiary"),
                        BeneficiaryEmail = GenerateEmail(context, "Home", "Beneficiary"),
                        BeneficiaryPhone = GeneratePhone(context, "Home", "Beneficiary"),
                    }
            };

            var lifeevent1 = new LifeEvent()
            {
                Event = er_event,
                LifeEventDate = System.DateTime.Today,
                LifeEventComment = "This is new LifeEvent",
            };

            lifeevent1.EmployeeEvent = employeeEvent1;
            lifeevent1.DependentEvent = dependentEvent1;
            lifeevent1.BeneficiaryEvent = beneficiaryEvent1;

            employee1.LifeEvent.Add(lifeevent1);

            context.SaveChanges();
        }
    }
}
