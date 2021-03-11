using System;

namespace OOP1
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.Id = 1;
			product1.CategoryId = 6;
			product1.ProductName = "Ütü";
			product1.UnitPrice = 1275;
			product1.UnitsInStock = 9;

			Product product2 = new Product { Id = 2, CategoryId = 2 ,ProductName = "Masa", UnitPrice = 785,UnitsInStock = 55 };

			ProductManager productManager = new ProductManager();
		}
	}
}
