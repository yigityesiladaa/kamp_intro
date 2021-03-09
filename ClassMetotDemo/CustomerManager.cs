using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class CustomerManager
	{
		public void addCustomer(Customer customer)
		{
			Console.WriteLine("New Customer Added: " + customer.Name);
		}

		public void deleteCustomer(Customer customer)
		{
			Console.WriteLine(customer.Id + ". Customer Deleted...");

		}
		
		public void getCustomers(Customer[] customers)
		{
			foreach (Customer customer in customers)
			{
				Console.WriteLine("ID: " + customer.Id);
				Console.WriteLine("Name: " + customer.Name);
				Console.WriteLine("Description: " + customer.Surname);
				Console.WriteLine("UnitPrice: " + customer.Mail);
				Console.WriteLine("\n");
			}
		}
	}
}
