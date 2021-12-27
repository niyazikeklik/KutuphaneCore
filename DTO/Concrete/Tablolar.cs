namespace DTO.Concrete
{
	public class Tablolar
	{
		/*
         * Bu class yapısı SINGLETON tasarım deseninden esinlenerek yapılmıştır.
         * SINGLETON yapısında normalde class örneği yeniden oluşturulmadan her zaman aynı nesne döndürülür.
         * Yalnız bu durum bizim işimizi göremeyecektir.
         * Çünkü;
         * DatabaseContext nesnesi sürekli yenilenmeli ve veritabanındaki değişiklikleri içine almalıdır.
         * Bundan dolayı SINGLETON tasarım deseni değiştirilerek kullanılmıştır.
         */
		public static Tablolar Tables => new();
		public OgrenciRepo Ogr { get; set; }
		public KitapRepo Kitap { get; set; }
		public KutuphaneIslemRepo Islem { get; set; }

		private Tablolar()
		{
			//Bu yapıcı methodunda, ilgili yerel değişkenler Tablolar class'ı için bir nesne oluşturulduğunda doldurulur.
			/*
             * Private olarak işaretlenmesi, bu class'ın başka bir yerde new'lenmesinin önüne geçmek için
               SINGLETON tasarım deseninin bir kuralıdır. 
            */
			var context = new DatabaseContext();
			Ogr = new OgrenciRepo(context);
			Kitap = new KitapRepo(context);
			Islem = new KutuphaneIslemRepo(context);
		}


	}
}
