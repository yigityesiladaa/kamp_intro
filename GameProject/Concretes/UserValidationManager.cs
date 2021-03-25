using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstracts;

namespace GameProject.Concretes
{
	public class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{

			if(gamer.DateOfBirth.Year == 1999 && gamer.DateOfBirth.Month == 10 && gamer.DateOfBirth.Day == 22 && gamer.FirstName == "Yiğit".ToUpper() && gamer.LastName == "Yeşilada".ToUpper() && gamer.NationalityId == "12345678910")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
