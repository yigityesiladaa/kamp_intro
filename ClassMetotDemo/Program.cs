using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer();
			customer1.Id = 1;
			customer1.Name = "Yiğit";
			customer1.Surname = "Yeşilada";
			customer1.Mail = "yy.yesilada@gmail.com";

			Customer customer2 = new Customer();
			customer2.Id = 2;
			customer2.Name = "Sema";
			customer2.Surname = "Cevher";
			customer2.Mail = "semacevher20@gmail.com";

			Customer[] customers = new Customer[] { customer1,customer2 };

			CustomerManager customerManager = new CustomerManager();

			customerManager.addCustomer(customer1);
			customerManager.addCustomer(customer2);

			customerManager.deleteCustomer(customer1);
			customerManager.deleteCustomer(customer2);
			Console.WriteLine("\n");
			customerManager.getCustomers(customers);
		}
	}
}
