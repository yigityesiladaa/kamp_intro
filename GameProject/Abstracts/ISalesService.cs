using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
	public interface ISalesService
	{
		void Buy(Game game, Gamer gamer, Campaign campaign, Sales sales);
		void Return(Game game, Gamer gamer, Campaign campaign, Sales sales);
	}
}
