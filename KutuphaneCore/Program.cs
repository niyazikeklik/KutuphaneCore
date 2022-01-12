using DTO;

using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Windows.Forms;

using static Entitites.Models.Enums;

namespace KutuphaneCore
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			//using (DatabaseContext client = new())
			//{
			//	client.Database.Migrate();
			//}
			//var context = new DatabaseContext();
			////ÖRNEK DATA GÝRÝÞLERÝ.
			//if (!context.Kitaps.AnyAsync().Result)
			//{
			//	string[] BarkodNos = { "A055123", "B055124", "C055123", "D055123", "E055123", "F055123", "G055123", "H055123", "I055123", "J055123", };
			//	string[] Ýsims = { "Tutunamayanlar", "Uçamayanlar", "Koþamayanlar", "Konamayanlar", "Sevemeyenler", "Konuþamayanlar", "Býrakamayanlar", "Duramayanlar", "Devam Edemeyenler", "Býkamayanlar" };
			//	for (int i = 0; i < BarkodNos.Length; i++)
			//	{
			//		var kitap = new Kitap()
			//		{
			//			BarkodNo = BarkodNos[i],
			//			BasimTarihi = new DateTime(2000 + i, ((5 + i) % 12) + 1, ((5 + i) % 25) + 1),
			//			KitapAd = Ýsims[i],
			//			KitapTuru = (KitapKategori)(i % Enum.GetNames<KitapKategori>().Length),
			//			KitapYazar = "Oðuz Atay",
			//			SayfaSayýsý = 100 * (i / 2 + 1),
			//			Stok = true
			//		};
			//		context.Kitaps.Add(kitap);
			//	}
			//}
			//if (!context.Ogrencis.AnyAsync().Result)
			//{
			//	var ogr1 = new Ogrenci
			//	{
			//		DogumTarihi = new DateTime(1999, 05, 06),
			//		IsimSoyisim = "Niyazi Keklik",
			//		OgrenciTC = "37822286862",
			//		TelefonNo = "5346861675",
			//	};
			//	//var ogr2 = new Ogrenci
			//	//{
			//	//	DogumTarihi = new DateTime(1999, 05, 06),
			//	//	IsimSoyisim = "Merve Keklik",
			//	//	OgrenciTC = "37811111111",
			//	//	TelefonNo = "5346861675",
			//	//};
			//	var ogr3 = new Ogrenci
			//	{
			//		DogumTarihi = new DateTime(1999, 05, 06),
			//		IsimSoyisim = "Furkan Keklik",
			//		OgrenciTC = "37822222222",
			//		TelefonNo = "5346861675",
			//	};
			//	context.Ogrencis.Add(ogr1);
			//	context.Ogrencis.Add(ogr3);

			//}
			//context.SaveChanges();

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AnaSayfa());
		}
	}
}
