using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	class RecourseManager
	{
		//Method Injection
		public void MakeRecourse(ICreditManager creditManager,List<ILoggerService> loggerServices)
		{
			//Evaluation to Recourseer Informations
			creditManager.Calculate();
			foreach (ILoggerService loggerService in loggerServices)
			{
				loggerService.Log();
			}
			
		}

		public void MakeCreditPreNotification(List<ICreditManager> credits)
		{
			foreach (ICreditManager credit in credits)
			{
				credit.Calculate();
			}
		}
	}
}
