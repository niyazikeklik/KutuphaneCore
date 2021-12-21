using DTO.Abstract;

using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    //Kitap türünde bir BaseRepo oluşturur.
    /*
      Sadece kitap tablosu için geçerli olan veritabanı sorgularını içerir.
   */
    public class KitapRepo : BaseRepo<Kitap>
    {
        public KitapRepo(DatabaseContext context) : base(context)
        {

        }
        //Alınabilir kitapları döner. Eğer bir kitabın stoğu true ise 
        //zimmetli değildir.
        public List<Kitap> GetAlinabilir()
        {
            return _dbSet.Where(x => x.Stok).ToList();
        }
        //Alınamaz kitapları döner. Eğer bir kitabın stoğu false ise 
        //zimmetlidir.
        public List<Kitap> GetZimmetli()
        {
            return _dbSet.Where(x => !x.Stok).ToList();
        }
        //İlgili kitabın stoğu true ise false, false ise true olur.
        public void StokUpdate(string ID)
        {
            var kitap = GetById(ID);
            kitap.Stok = !kitap.Stok;
            Update(kitap);
        }
        //Tek bir kitabı bağlı olduğu işlemler ile beraber döner.
        public Kitap GetKitapWithIslemlerById(string id)
        {
            return GetListWithIslems().FirstOrDefault(x => x.BarkodNo == id);
        }
    }
}
