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
        [Key] //IslemId'nin primarykey olacağını söylüyorum.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //İslemId'nin ıdentity olarak artacağını söylüyorum
        public int IslemId { get; set; }
        [Required]// Bu bilginin gerekli olduğunu eğer boş geçilir ise hata vermesi gerektiğini söylüyorum
        [ForeignKey(name: "Ogrenci")]
        //ÖğrenciID sütunun Öğrenci tablosunun PrimaryKey'i olduğunu yani bu tabloda ForeignKey olması gerektiğini söylüyorum
        public string OgrenciID { get; set; }
        [Required]
        [ForeignKey(name: "Kitap")]
        public string KitapBarkodNo { get; set; }
        public double IslemUcret { get; set; }
        public DateTime AlimTarihi { get; set; }
      
        public DateTime SonTeslimTarihi { get; set; }  
        public DateTime? IadeTarihi { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Kitap Kitap { get; set; }
    }
}
