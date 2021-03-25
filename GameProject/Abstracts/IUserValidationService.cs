using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
	public interface IUserValidationService
	{
		bool Validate(Gamer gamer);
	}
}
