using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using APISMARTHR1.DTO.Employer;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace APISMARTHR1.Services
{
    public class Employer_Repo : IEmployer_Repo
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        public Employer_Repo(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        public IEnumerable<Employer_DTO> GetEmployers()
        {
            return ReadJasonAndTransformToEmployer();
        }


        public IEnumerable<Employer_DTO> ReadJasonAndTransformToEmployer()
        {
            List<Employer_DTO> employerList = new List<Employer_DTO>();
            #region 
            Employer_DTO employer2 = new Employer_DTO
            {
                EmployerID = 2,
                EmployerName = "Gargi world wide",
                EmployerCode = "SMART-HR-2",
                StartDate = Convert.ToDateTime("01/01/2013"),
                EmployeeCount = 2013,
                EmployerRevenue = 201300,
                BillingRate = 20.13,
                PostalAddress1 = "",
                PostalAddress2 = "",
                PostalAddressCity = "",
                PostalAddressState = "",
                PostalAddressZip = null,
                PostalAddressCountry = "",
                EmployerEmail = "",
                EmployerPhone = 0,
                EmployerFax = 0,
                OriginCountryFlagImageUrl = "",
                EmployerImageUrl = "https://openclipart.org/download/194073/yellow-banana-cluster.svg",
                EmployerRating = 5
            };
            employerList.Add(employer2);

            Employer_DTO employer4 = new Employer_DTO
            {
                  EmployerID= 4,
                  EmployerName= "Sharvil Import Exports",
                  EmployerCode= "SMART-HR-4",
                  StartDate= Convert.ToDateTime("01/01/2012"),
                  EmployeeCount= 2012,
                  EmployerRevenue= 201200,
                  BillingRate= 20.12,
                  PostalAddress1= "",
                  PostalAddress2= "",
                  PostalAddressCity= "",
                  PostalAddressState= "",
                  PostalAddressZip= null,
                  PostalAddressCountry= "",
                  EmployerEmail= "",
                  EmployerPhone= 0,
                  EmployerFax= 0,
                  OriginCountryFlagImageUrl= "",
                  EmployerImageUrl= "https://openclipart.org/download/22871/chovynz-Pineapple-Icon.svg",
                  EmployerRating= 4
            };
            employerList.Add(employer4);

            Employer_DTO employer5 = new Employer_DTO
            {
                EmployerID= 5,
                EmployerName=  "Shurya Business Intelligence",
                EmployerCode =  "SMART-HR-5",
                StartDate= Convert.ToDateTime("01/01/2016"),
                EmployeeCount = 2016,
                EmployerRevenue= 201600,
                BillingRate = 20.16,
                PostalAddress1= "",
                PostalAddress2= "",
                PostalAddressCity = "",
                PostalAddressState = "",
                PostalAddressZip = null,
                PostalAddressCountry= "",
                EmployerEmail= "",
                EmployerPhone= 0,
                EmployerFax= 0,
                OriginCountryFlagImageUrl= "",
                EmployerImageUrl= "https://openclipart.org/download/209684/food-strawberry.svg",
                EmployerRating= 4,
            };
            employerList.Add(employer5);
            #endregion 
            return employerList;
        }


    }
}
