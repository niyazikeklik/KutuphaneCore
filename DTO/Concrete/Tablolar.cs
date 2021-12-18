using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    public class Tablolar
    {
        /*
         * Bu class yapısı SINGLETON tasarım deseni kullanılarak yapılmıştır.
         * Amaç program çalışma süresi boyunca sürekli oluşturulan nesnelerin,
         * tek bir sefer oluşturulması ve ortak bir nesne üzerinden erişilebilmesidir.
         * Bu sayede başka bir form'da veya katmanda yapılan veritabanı değişiklikleri
         * her yerden görülebilir olacaktır. Çünkü değişiklikler her zaman aynı nesne 
         * üzerinden yapılacaktır.
         */
        private static Tablolar tables;
        public static Tablolar Tables
        {
            //    Bu prop, eğer nesneleri bir kere oluşturduysa her başvuruda aynı nesneyi dönme görevini get methodu üzerinde gerçekleştirir.
            get
            {
                if (tables == null)
                    tables = new Tablolar();
                return tables;
            }
        }
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
            DatabaseContext context = new DatabaseContext();
            this.Ogr = new OgrenciRepo(context);
            this.Kitap = new KitapRepo(context);
            this.Islem = new KutuphaneIslemRepo(context);
        }


    }
}
