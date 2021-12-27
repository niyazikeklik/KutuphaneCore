using System;

namespace Entitites.Models
{
	public class OgrenciIslemBilgi
	{
		//Veritabanında kullanılmaz kullanıcıya bilgi amaçlı oluşturulmuştur.
		public int IslemID { get; set; }
		public string KitapAdi { get; set; }
		public DateTime AlimTarihi { get; set; }
		public DateTime SonTeslimTarihi { get; set; }
		public DateTime? TeslimTarihi { get; set; }
		public double IsemUcreti { get; set; }
		public string Aciklama { get; set; }
	}
}
