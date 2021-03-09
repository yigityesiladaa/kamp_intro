using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{

			Course course1 = new Course();

			course1.Name = "Flutter & Dart Course";
			course1.Instructor = "Yiğit Yeşilada";
			course1.ViewRate = 4.8;

			Course course2 = new Course();

			course2.Name = "React Native Course";
			course2.Instructor = "Yiğit Yeşilada";
			course2.ViewRate = 4.5;
			Course[] courses = new Course[] { course1, course2 };


			foreach (Course course in courses)
			{
				Console.WriteLine("Name: " + course.Name);
				Console.WriteLine("Instructor: " + course.Instructor);
				Console.WriteLine("ViewRate: " + course.ViewRate);
				Console.WriteLine("\n");
			}
		}
	}

	class Course
	{
		public string Name { get; set; }
		public string Instructor { get; set; }
		public double ViewRate { get; set; }
	}
}
