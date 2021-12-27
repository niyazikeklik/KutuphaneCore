using DTO.Abstract;

using Entitites.Models;

using System.Collections.Generic;
using System.Linq;

namespace DTO.Concrete
{
	//Ogrenci türünde bir BaseRepo oluşturur.
	/*
        Sadece öğrenci tablosu için geçerli olan veritabanı sorgularını içerir.
     */
	public class OgrenciRepo : BaseRepo<Ogrenci>
	{
		public OgrenciRepo(DatabaseContext context) : base(context)
		{

		}
		// ID'ye göre İlgili öğrenciyi bağlı olduğu işlemler ile beraber döner
		public Ogrenci GetOgrenciWithIslemlerById(string id) => GetListWithIslems().FirstOrDefault(x => x.OgrenciTC == id);
		//ID'si verilen öğrencinin bağlı olduğu işlemler üzerinden üzerindeki kitaplar tespit edilir BarkodNo'lar döndürülür.
		public List<string> GetZimmetliKitapsNo(string ogrenciID)
		{
			//İade tarihi boş olan işlemlerin kitap barkod numaraları döndürülür.
			//Bir işlemin iade tarihi olmaması iade edilmediği anlamına gelir
			Ogrenci ogr = GetOgrenciWithIslemlerById(ogrenciID);
			return ogr.kutuphaneIslems.Where(x => x.IadeTarihi == null).Select(x => x.KitapBarkodNo).ToList();
		}
		//ID'si verilen öğrencinin bağlı olduğu işlemler üzerinden teslim ettiği kitaplar tespit edilir BarkodNo'lar döndürülür.
		public List<string> GetTeslimEttigiKitapsNo(string ogrenciID)
		{
			//İade tarihi dolu olan işlemlerin kitap barkod numaraları döndürülür.
			//Bir işlemin iade tarihi olması iade edildiği anlamına gelir
			Ogrenci ogr = GetById(ogrenciID);
			return ogr.kutuphaneIslems.Where(x => x.IadeTarihi != null).Select(x => x.KitapBarkodNo).ToList();
		}
		//Öğrencinin üzerinde zimmetli kitap var mı döndürülür varsa true, yoksa false döner.
		public bool ZimmetliKitapVarMi(string id)
		{
			Ogrenci ogr = GetOgrenciWithIslemlerById(id);
			//İade tarihi null olan bir işlem var ise öğrencinin üzerinde zimmetli kitap var demektir. Eğer iade tarihi null olan bir işlem bulamazsa öğrencinin tüm işlemleri kapalı veya işlemi yoktur.
			KutuphaneIslem x = ogr.kutuphaneIslems.FirstOrDefault(x => x.IadeTarihi == null);
			return x != null;
		}
		//Öğrencinin kapanmamış işlemlerini döner.
		public List<KutuphaneIslem> GetKapanmamisIslem(string ID) =>
			//İade tarihi null olan bir işlem heüz kapanmamış bir işlem olarak kabul edilir.
			GetOgrenciWithIslemlerById(ID).kutuphaneIslems.Where(x => x.IadeTarihi == null).ToList();

	}
}
