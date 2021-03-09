using System;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{

			string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
			string course2 = "Programlamaya Başlangıç İçin Temel Kurs";
			string course3 = "Java Geliştirme Kursu";

			string[] courses = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
											  "Programlamaya Başlangıç İçin Temel Kurs",
											  "Java Geliştirme Kursu", };

			Console.WriteLine("   Kurslar\n");
			for (int i = 0; i < courses.Length; i++)
			{
				Console.WriteLine((i+1) + ". " + courses[i]);
			}

			Console.WriteLine("\n\n");

			foreach (string course in courses)
			{ 
				Console.WriteLine(course);
			}

			Console.WriteLine("\nFooter");
		}
	}
}
