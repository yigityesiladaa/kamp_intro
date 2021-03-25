using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
	public interface ICampaignService
	{
		void Add(Game game, Campaign campaign);
		void Update(Game game, Campaign campaign);
		void Delete(Game game, Campaign campaign);
	}
}
