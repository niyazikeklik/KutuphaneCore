using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

namespace DTO
{
	//DatabaseContext nesnesni bir veritabanı örneğidir.
	public class DatabaseContext : DbContext
	{
		//Veritabanı bağlantı cümlesi.
		public string connectionString = @"Data Source=database.db;";
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//Burada sqllite veritabanı kullanacağımı söylüyorum.
			//Bu sayede EntityFramework benim için sorgu  oluşturduğunda sqllite'a göre sorgular oluşturacaktır.
			//Aynı zamanda ilgili konumda bir veritabanı bulamazsa bu method sayesinde veritabanı otomatik oluşturulur.
			optionsBuilder.UseSqlite(connectionString);
			optionsBuilder.EnableSensitiveDataLogging();
		}
		//İlgili modelleri DbSet<T> class'ı üzerinden veritabanı tablosu olarak simgeler. 
		//Aşağıdaki özelliklerin her biri veritabanında bir tabloyu simgeler.
		public DbSet<Ogrenci> Ogrencis { get; set; }
		public DbSet<Kitap> Kitaps { get; set; }
		public DbSet<KutuphaneIslem> KutuphaneIslems { get; set; }

	}


}
