using Entitites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entitites.Models.Enums;

namespace Entitites
{
  //Kitap class'ı
    public class Kitap
    {
        [Key] //Key anahtar kelimesi, EntityFramework'e bu sütunun primary key olacağını söylemk için gereklidir.
        public string BarkodNo { get; set; }
        public string KitapAd { get; set; }

        public string KitapYazar { get; set; }

        public int SayfaSayısı { get; set; }

        public DateTime BasimTarihi { get; set; }

        public KitapKategori KitapTuru { get; set; }

        public bool Stok { get; set; } = true;
        //ICollection sınıfı üzerinden Kitap nesnesinin birden fazla işlemi olabilececeğini söylüyorum. Bu aslında veritabanı ilişkimin kod karşılığıdır. KutuphaneIslem tablosu ile Kitap tablosu arasında bire çok ilişki olduğunu söyler.
        public ICollection<KutuphaneIslem> kutuphaneIslems { get; set; }

    }
}
