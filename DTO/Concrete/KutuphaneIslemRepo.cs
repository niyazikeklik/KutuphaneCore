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
    public class KutuphaneIslemRepo : BaseRepo<KutuphaneIslem>
    {
        public KutuphaneIslemRepo(DatabaseContext context) : base(context)
        {

        }
        public IEnumerable<KutuphaneIslem> GetAktifIslems()
        {
            return _dbSet.Where(x => x.IadeTarihi == null);
        }

        public IEnumerable<KutuphaneIslem> GetKapaliIslems()
        {
            return _dbSet.Where(x => x.IadeTarihi != null);
        }

        public KutuphaneIslem GetIslemsByOgrenciNoAndKitapNo(int ogrID, int kitapID)
        {
            return _dbSet.Where(x => (kitapID == x.KitapBarkodNo) && (x.OgrenciNo == ogrID)).First();
        }
    }
}
