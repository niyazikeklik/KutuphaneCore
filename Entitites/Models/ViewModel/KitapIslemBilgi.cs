using System;

namespace Entitites.Models
{
    public class KitapIslemBilgi
    {
        //Veritabanında kullanılmaz kullanıcıya bilgi amaçlı oluşturulmuştur.
        public int IslemID { get; set; }
        public string OgrenciAdi { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }

    }
}
