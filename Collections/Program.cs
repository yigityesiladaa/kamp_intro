using System;
using System.Collections.Generic;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>();
			names.Add("Yiğit");
			names.Add("Sema");


			foreach (var name in names)
			{
				Console.WriteLine(name);
			}
		}
	}
}
