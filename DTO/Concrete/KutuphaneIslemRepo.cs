using DTO.Abstract;

using Entitites.Models;

namespace DTO.Concrete
{
	//KutuphaneIslem türünde bir BaseRepo oluşturur.
	/*
      Sadece KutuphaneIslem tablosu için geçerli olan veritabanı sorgularını içerir.
   */
	public class KutuphaneIslemRepo : BaseRepo<KutuphaneIslem>
	{
		public KutuphaneIslemRepo(DatabaseContext context) : base(context)
		{

		}
	}
}
