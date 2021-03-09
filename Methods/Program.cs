using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Product product1 = new Product();

			product1.Name = "Apple";
			product1.Id = 1;
			product1.Description = "This is an Apple";
			product1.UnitPrice = 14;
			product1.InStockAmount = 125;

			Product product2 = new Product();

			product2.Name = "Banana";
			product2.Id = 2;
			product2.Description = "This is a Banana";
			product2.UnitPrice = 26;
			product2.InStockAmount = 452;

			Product[] products = new Product[] { product1,product2 };

			foreach (Product product in products)
			{
				Console.WriteLine("ID: " + product.Id);
				Console.WriteLine("Name: " + product.Name);
				Console.WriteLine("Description: " + product.Description);
				Console.WriteLine("UnitPrice: " + product.UnitPrice);
				Console.WriteLine("\n");
			}

			Console.WriteLine("-----------------------Methods---------------------\n");


			CartManager cartManager = new CartManager();

			cartManager.AddToCart(product1);
			cartManager.AddToCart(product2);
			



		}


	}
}


// Do Not Repeat Yourself! - D.R.Y.
// Clean Code