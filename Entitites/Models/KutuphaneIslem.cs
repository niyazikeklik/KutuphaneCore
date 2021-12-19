using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entitites.Models.Enums;

namespace Entitites.Models
{

    public class KutuphaneIslem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IslemId { get; set; }
        [Required]
        [ForeignKey(name: "Ogrenci")]
        public int OgrenciID { get; set; }
        [Required]
        [ForeignKey(name: "Kitap")]
        public int KitapBarkodNo { get; set; }

        public double IslemUcret { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime SonTeslimTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Kitap Kitap { get; set; }
    }
}
