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
  
    public class Kitap
    {
        [Key]
        public int BarkodNo { get; set; }

        public string KitapAd { get; set; }

        public string KitapYazar { get; set; }

        public int SayfaSayısı { get; set; }

        public DateTime BasimTarihi { get; set; }

        public KitapKategori KitapTuru { get; set; }

        public bool Stok { get; set; } = true;

        public ICollection<KutuphaneIslem> kutuphaneIslems { get; set; }

    }
}
