using Entitites.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.WebRequestMethods;
using static DTO.Concrete.Tablolar;
using Entitites;

namespace Business.Business
{
	public static class Islemler
	{
		public static List<KitapIslemBilgi> CreateKitapIslemBilgi(this Kitap kitap)
		{
			var list = new List<KitapIslemBilgi>();
			//İlgili kitabın tüm işlemlerinin dönülmesi.
			foreach (KutuphaneIslem item in kitap.kutuphaneIslems)
			{
				//Eğer geçerrli işlemin iade tarihi null ise öğrenci ıd üzerinden (Global)zimmetliOgrenci nesnesi doldurulur.
				//Listeye öğrencinin tüm işlemleri KitapIslemBilgi modeli üzerinden yazılır.
				list.Add(new KitapIslemBilgi()
				{
					IslemID = item.IslemId,
					AlimTarihi = item.AlimTarihi,
					IadeTarihi = item.IadeTarihi,
					OgrenciAdi = Tables.Ogr.GetById(item.OgrenciID).IsimSoyisim,
				});
			}
			return list;
		}
		public static List<OgrenciIslemBilgi> CreateOgrenciIslemBilgi(this Ogrenci ogrenci)
		{
			var list = new List<OgrenciIslemBilgi>();
			//Öğrenciye ait işlemler döndürülür ve kullanıcıya bilgi amaçlı OgrenciIslemBilgi modeli üzerinden yeni bir listeye çevrilir.
			foreach (KutuphaneIslem? item in ogrenci.kutuphaneIslems)
				list.Add(new OgrenciIslemBilgi()
				{
					IslemID = item.IslemId,
					KitapAdi = Tables.Kitap.GetById(item.KitapBarkodNo).KitapAd,
					AlimTarihi = item.AlimTarihi,
					SonTeslimTarihi = item.SonTeslimTarihi,
					TeslimTarihi = item.IadeTarihi,
					IsemUcreti = item.BorcHesapla(),
					Aciklama = item.CreateAciklama()
				});
			return list;

		}
	}
}


//if (item.IadeTarihi == null)
//	zimmetliOgrenci = Tables.Ogr.GetById(item.OgrenciID);