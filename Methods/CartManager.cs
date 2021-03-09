using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
	class CartManager
	{
		//Naming Convention
		public void AddToCart(Product product)
		{
			Console.WriteLine("Added To Cart: " + product.Name);
		}
	}
}
