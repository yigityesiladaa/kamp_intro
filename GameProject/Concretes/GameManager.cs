using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
	public class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine(game.Name + " Adlı Oyun Sisteme Eklenmiştir");
		}

		public void Delete(Game game)
		{
			Console.WriteLine(game.Name + " Adlı Oyun Sistemden Siinmiştir");
		}

		public void Update(Game game)
		{
			Console.WriteLine(game.Name + " Adlı Oyun Bilgileri Günccellenmiştir");
		}
	}
}
