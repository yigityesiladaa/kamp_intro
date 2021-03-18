using System;
using System.Collections.Generic;

namespace GenericsIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> names = new MyList<string>();
			names.Add("Yiğit");
			names.Add("Sema");

			Console.WriteLine(names.Length);

			Dictionary<string, string> dic = new Dictionary<string,string>();

		}
	}
}
