using Entitites.Models;
using System;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
namespace Business.Business
{
	public static class KutuphaneOlayları
	{
		public static KutuphaneIslem TeslimAl(string seciliKitapID, string ogrenciID)
		{
			//TEST İÇİN! int[] rastgele = { 2, 1, 14, -2, -1 };
			DateTime SuAn = DateTime.Now;
			//Yeni bir işlem yaratılır.
			//İadeTarihi null olarak verilir.
			//SonTeslimTarihi o an'dan 15 gün sonrası olarak verilir.
			//Veritabanı ilişkileri sayesinde bu işlem öğrenci üzerinde gözükür
			var x = new KutuphaneIslem()
			{
				AlimTarihi = SuAn,
				//TEST İÇİN! SonTeslimTarihi = SuAn.AddDays(rastgele[new Random().Next(0,4)]),
				SonTeslimTarihi = SuAn.AddDays(15),
				IadeTarihi = null,
				KitapBarkodNo = seciliKitapID,
				OgrenciID = ogrenciID,
				IslemUcret = 0,
			};
			//İşlem eklenir ve ilgili kitap stoktan düşer.
			Tables.Islem.Add(x);
			Tables.Kitap.StokToggleUpdate(seciliKitapID);
			return x;
		}
		//İşlemin borcunu hesaplar
		public static double BorcHesapla(this KutuphaneIslem item)
		{

			//KalanGun methodu ilgili işlemin SonİadeTarihi'ne kalan gün sayısını döner
			double gecenGUnSayisi = KalanGun(item);
			//Eğer geçen gün sayısı 0'dan küçük ise öğrenciye ceza uygulanır.
			if (gecenGUnSayisi < 0)
			{
				//Round methodu virgülden sonra kaç basamak alacağını söyler
				//Borç formülü geçen gün sayısı * 1TL'dir.
				return Math.Round(gecenGUnSayisi * -1, 1);
			} else
			{
				return 0;
			}
		}

		//İade için kalan günü hesaplar.
		public static double KalanGun(this KutuphaneIslem item)
		{
			//Eğer parametre olan işlemde iade tarihi var ise iade tarihi üzerindne borç hesaplar.
			double result = item.IadeTarihi != null
				? (item.SonTeslimTarihi - item.IadeTarihi.Value).TotalDays
				: (item.SonTeslimTarihi - DateTime.Now).TotalDays;

			//Round methodu virgülden sonra kaç basamak alacağını söyler
			return Math.Round(result, 1);
		}

		//Bir işlei kapatmayı, iade etmeyi sağlar.
		public static double IadeEt(this KutuphaneIslem islem)
		{
			//Eğer işlem iade edilmedi ise iade işlemi yapılır.
			if (islem.IadeTarihi == null)
			{
				//Önce işlemin borcu hesaplanır.
				double borc = islem.BorcHesapla();
				//İade tarihine o an girilir.
				islem.IadeTarihi = DateTime.Now;
				//Hesaplanan borç işleme işlenir
				islem.IslemUcret = borc;
				//İlgili işlem güncellenir.
				Tables.Islem.Update(islem);
				//İşleme ait kitap stoğu güncellenir.
				Tables.Kitap.StokToggleUpdate(islem.KitapBarkodNo);
				//İşlem ücreti geri döndürülür.
				return borc;
			} else
			{
				MessageBox.Show("Kitap zaten iade edildi.", "İade edili kitap", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

			return -1;
		}

		//Dogumtarihine göre yaş hesaplar
		public static double YasHesapla(this DateTime dogumTarihi) =>
			//Dogum tarihi üzerinden yaş hesaplama.
			Math.Round((DateTime.Now - dogumTarihi).TotalDays / 365, 0, MidpointRounding.ToZero);

		//Öğrencinin işlemleri için açıklama oluşturur
		public static string CreateAciklama(this KutuphaneIslem item)
		{
			//Bir işlemin iade tarihi yoksa ve son teslim tarihi geçmiş ise ceza uygulanır.
			if (item.IadeTarihi == null && item.SonTeslimTarihi < DateTime.Now)
				return $"Kitabın teslim süresi geçmiştir. Güncel ceza {item.BorcHesapla()}TL'dir.";
			else

				//Bir işlemin iade tarihi varsa, yani null deği ise, kitap teslim alınmıştır.
				return item.IadeTarihi != null ?
					"Kitap teslim alınmıştır." :
					$"Kitabın teslim tarihine son {item.KalanGun()} gün vardır";

		}
	}
}
