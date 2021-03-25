using GameProject.Concretes;
using GameProject.Entities;
using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Gamer gamer = new Gamer();
			gamer.Id = 1;
			gamer.FirstName = "YİĞİT";
			gamer.LastName = "YEŞİLADA";
			gamer.NationalityId = "12345678910";
			gamer.DateOfBirth = new DateTime(1999, 10, 22);

			GamerManager gamerManager = new GamerManager(new UserValidationManager());
			gamerManager.Add(gamer);

			Console.WriteLine("\n");

			Game game = new Game();
			game.Id = 1;
			game.Name = "FIFA 2021";

			GameManager gameManager = new GameManager();
			gameManager.Add(game);

			Console.WriteLine("\n");

			Campaign campaign1 = new Campaign();
			campaign1.Id = 1;
			campaign1.CampaignTitle = "Efsanevi Bahar İndirimleri";
			campaign1.DiscountAmount = 60;

			Campaign campaign2 = new Campaign();
			campaign2.Id = 1;
			campaign2.CampaignTitle = "Efsanevi Kasım İndirimleri";
			campaign2.DiscountAmount = 40;

			CampaignManager campaignManager = new CampaignManager();
			campaignManager.Add(game,campaign1);
			campaignManager.Update(game,campaign2);
			campaignManager.Delete(game,campaign2);


			Console.WriteLine("\n");

			Sales sales = new Sales();
			sales.Id = 1;
			sales.SalesDate = DateTime.Now;

			SalesManager salesManager = new SalesManager();
			salesManager.Buy(game,gamer,campaign2,sales);
			salesManager.Return(game,gamer,campaign2,sales);

		}
	}
}
