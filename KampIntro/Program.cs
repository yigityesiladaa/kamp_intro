using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type-safety
            bool isLoggedInToSystem = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;


			if (isLoggedInToSystem)
			{
                Console.WriteLine("User Settings Button");

                if (dollarYesterday > dollarToday)
                {
                    Console.WriteLine("Dollar Down");
                }
                else if (dollarYesterday < dollarToday)
                {
                    Console.WriteLine("Dollar Up");
    
            }
                else
                {
                    Console.WriteLine("Do Not Changed");
                }
            }
			else
			{
                Console.WriteLine("Login Button");
			}

        } 
    }
}



