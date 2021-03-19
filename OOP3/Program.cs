using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
			ICreditManager transportCreditManager = new TransportCreditManager();
			ICreditManager mortgageCreditManager = new MortgageCreditManager();

			RecourseManager recourseManager = new RecourseManager();
			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };

			recourseManager.MakeRecourse(personalFinanceCreditManager, loggerServices);

			List<ICreditManager> credits = new List<ICreditManager>(){};
			credits.Add(personalFinanceCreditManager);
			credits.Add(transportCreditManager);
			
			//recourseManager.MakeCreditPreNotification(credits);
		}
	}
}
