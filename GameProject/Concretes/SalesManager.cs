using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
	public class SalesManager : ISalesService
	{
		public void Buy(Game game, Gamer gamer, Campaign campaign, Sales sales)
		{
			Console.WriteLine(
				game.Name
				+ " Adlı Oyun "
				+ gamer.FirstName
				+ " "
				+ gamer.LastName
				+ " Adlı Kullanıcıya "
				+ sales.SalesDate.Day
				+ "/"
				+ sales.SalesDate.Month
				+ "/"
				+ sales.SalesDate.Year
				+ " Tarihinde "
				+ campaign.CampaignTitle
				+ " Kampanyası Dahilinde Satılmıştır"
				);
		}

		public void Return(Game game, Gamer gamer, Campaign campaign, Sales sales)
		{
			Console.WriteLine(
				gamer.FirstName
				+ " "
				+ gamer.LastName
				+ " Adlı Kullanıcıya "
				+ sales.SalesDate.Day
				+ "/"
				+ sales.SalesDate.Month
				+ "/"
				+ sales.SalesDate.Year
				+ " Tarihinde "
				+ campaign.CampaignTitle
				+ " Kampanyası Dahilinde Satılmış olan "
				+ game.Name
				+ " Adlı Oyun İade Edilmiştir."
				);
		}
	}
}
