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
        public int OgrenciID { get; set; }
        public string IsimSoyisim { get; set; }
        public string OgrenciTC { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public ICollection<KutuphaneIslem> kutuphaneIslems { get; set; }

    }
}
