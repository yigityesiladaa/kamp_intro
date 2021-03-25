using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
	public class CampaignManager : ICampaignService
	{
		public void Add(Game game, Campaign campaign)
		{
			Console.WriteLine(game.Name + " Adlı Oyuna " + campaign.CampaignTitle + " Kampanyası Dahilinde " + campaign.DiscountAmount + " TL İndirim Yapılmıştır");

		}

		public void Delete(Game game, Campaign campaign)
		{
			Console.WriteLine(game.Name + " Adlı Oyuna " + campaign.CampaignTitle + " Kampanyası Dahilinde Uygulanan " + campaign.DiscountAmount + " TL İndirim İptal Edilmiştir");
		}

		public void Update(Game game, Campaign campaign)
		{

			Console.WriteLine(game.Name + " Adlı Oyuna " + campaign.CampaignTitle + " Kampanyası Dahilinde Uygulanan İndirim " + campaign.DiscountAmount + " TL Olarak Güncellenmiştir");
		}
	}
}
