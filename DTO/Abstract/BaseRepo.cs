using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
namespace DTO.Abstract
{
	/*
     * Kalıtım olarak alınması için her tablo için kullanılacak veritabanı işlem methodlarını tek bir class'da yazıyoruz.
     * bu class new'lenmemeli ve abstract olmalıdır.
     * Generic olduğu için kalıtım alındığı class'a göre ilgili tabloyu temsil edebilir.
     * 
    */
	public abstract class BaseRepo<T> where T : class
	{

		//context nesneni veritabanı örneğini tutar.
		protected DatabaseContext _context;
		//DBSet kalıtım alınan class'a göre ilgili tabloyu tutar.
		protected DbSet<T> _dbSet;
		public BaseRepo(DatabaseContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}
		//Eğer veritabanında ilgili ID'ye ait bir kayıt var ise true yoksa false döner.
		public bool IsExistRecord(string ID) => GetById(ID) != null;
		
		//Parametre olarak gelen nesneyi ilgili tabloya ekler.
		public void Add(T entity)
		{
			_dbSet.Add(entity);
			_context.SaveChanges();
		}
		//ID'ye göre veritabanında ilgili kaydı getirir.
		public T GetById(string ID) => _dbSet.Find(ID);
		//Overload edilmiş GetByID
		public T GetById(int ID) => _dbSet.Find(ID);
		//İlgili tabloyu olduğu gibi döner.
		public List<T> GetList() => _dbSet.ToList();
		//İlgili tabloyu Include, Join ederek çeker
		//Tablodaki kayıtların ilişkili olduğu işlemlerle beraber döner.
		public List<T> GetListWithIslems() => _dbSet.Include("kutuphaneIslems").ToList();
		//İlgili kaydı ID üzerinden siler.
		public void Remove(string ID)
		{
			_dbSet.Remove(GetById(ID));
			_context.SaveChanges();
		}

		//İlgili kaydı günceller.
		public void Update(T obje)
		{
			_dbSet.Update(obje);
			_context.SaveChanges();
		}

		//Eğer ilgili ıd ilgili tabloda var ise günceller, yok ise ekler.

	}
}
