using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class Ogrenci
    {
       
        [Key]
        public string OgrenciTC { get; set; }
        public string IsimSoyisim { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        //ICollection sınıfı üzerinden Ogrenci nesnesinin birden fazla işlemi olabilececeğini söylüyorum. Bu aslında veritabanı ilişkimin kod karşılığıdır. KutuphaneIslem tablosu ile Ogrenci tablosu arasında bire çok ilişki olduğunu söyler.
        public ICollection<KutuphaneIslem> kutuphaneIslems { get; set; }

    }
}
