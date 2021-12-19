using DTO.Abstract;

using Entitites;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    public class KitapRepo : BaseRepo<Kitap>
    {
        public KitapRepo(DatabaseContext context) : base(context)
        {

        }

        public List<Kitap> GetAlinabilir()
        {
            return _dbSet.Where(x => x.Stok).ToList();
        }

        public List<Kitap> GetZimmetli()
        {
            return _dbSet.Where(x => !x.Stok).ToList();
        }
        public void StokUpdate(int ID)
        {
            var kitap = GetById(ID);
            kitap.Stok = !kitap.Stok;
            Update(kitap);
        }
    }
}
