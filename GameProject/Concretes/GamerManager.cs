using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstracts;

namespace GameProject.Concretes
{
	public class GamerManager : IGamerService
	{

		IUserValidationService _userValidationService;

		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Add(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer))
			{
				Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı Oyuncu Sisteme Kaydedildi.");
			}
			else
			{
				Console.WriteLine("Doğrulama Başarısız, Kayıt Geçersiz!");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı Oyuncu Sistemden Silindi.");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı Oyuncu Bilgileri Güncellendi.");
		}
	}
}
