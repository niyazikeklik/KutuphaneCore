using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class KitapIslemBilgi
    {
        public int IslemID { get; set; }
        public string OgrenciAdi { get;set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }

    }
}
