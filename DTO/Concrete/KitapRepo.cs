using DTO.Abstract;

using Entitites;

using System.Collections.Generic;
using System.Linq;

namespace DTO.Concrete
{
	//Kitap türünde bir BaseRepo oluşturur.
	/*
      Sadece kitap tablosu için geçerli olan veritabanı sorgularını içerir.
   */
	public class KitapRepo : BaseRepo<Kitap>
	{
		public KitapRepo(DatabaseContext context) : base(context)
		{

		}
		//Alınabilir kitapları döner. Eğer bir kitabın stoğu true ise 
		//zimmetli değildir.
		public List<Kitap> GetAlinabilir() => _dbSet.Where(x => x.Stok).ToList();
		//Alınamaz kitapları döner. Eğer bir kitabın stoğu false ise 
		//zimmetlidir.
		public List<Kitap> GetZimmetli() => _dbSet.Where(x => !x.Stok).ToList();
		//İlgili kitabın stoğu true ise false, false ise true olur.
		public void StokToggleUpdate(string ID)
		{
			Kitap kitap = GetById(ID);
			kitap.Stok = !kitap.Stok;
			Update(kitap);
		}
		//Tek bir kitabı bağlı olduğu işlemler ile beraber döner.
		public Kitap GetKitapWithIslemlerById(string id) => GetListWithIslems().FirstOrDefault(x => x.BarkodNo == id);
	}
}
