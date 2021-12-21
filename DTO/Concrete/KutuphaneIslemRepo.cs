using DTO.Abstract;

using Entitites;
using Entitites.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    //KutuphaneIslem türünde bir BaseRepo oluşturur.
    /*
      Sadece KutuphaneIslem tablosu için geçerli olan veritabanı sorgularını içerir.
   */
    public class KutuphaneIslemRepo : BaseRepo<KutuphaneIslem>
    {
        public KutuphaneIslemRepo(DatabaseContext context) : base(context)
        {

        }
    }
}
