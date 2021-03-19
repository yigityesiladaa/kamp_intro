using System;

namespace OOP2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Yiğit Yeşilada
			IndividualCustomer individualCustomer = new IndividualCustomer();
			individualCustomer.Id = 1;
			individualCustomer.CustomerNumber = "12345";
			individualCustomer.Name = "Yiğit";
			individualCustomer.Surname = "Yeşilada";
			individualCustomer.TCNo = "49105686818";


			//Kodlama.io
			CorporateCustomer corporateCustomer = new CorporateCustomer();
			corporateCustomer.Id = 2;
			corporateCustomer.CompanyName = "Kodlama.io";
			corporateCustomer.CustomerNumber = "6789";
			corporateCustomer.TaxNumber = "46874543843512579";



			Customer individualCustomer2 = new IndividualCustomer();
			Customer corporateCustomer2 = new CorporateCustomer();

			CustomerManager customerManager = new CustomerManager();

			customerManager.Add(individualCustomer);
			customerManager.Add(corporateCustomer);
			customerManager.Add(corporateCustomer2);
			customerManager.Add(corporateCustomer2);

		}
	}
}
