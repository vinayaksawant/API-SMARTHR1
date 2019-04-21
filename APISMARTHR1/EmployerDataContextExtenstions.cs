using APISMARTHR1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISMARTHR1
{
	public static class EmployerDataContextExtenstions
	{

		public static void EnsureSeedDataForContext(this EmployerContext context)
		{
			if (context.Employer.Any())
			{
				return;
			}
			#region
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
			#endregion

			context.Employer.AddRange(employerList);
			context.SaveChanges();



		}
	}
}
