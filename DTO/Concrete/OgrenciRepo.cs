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
    public class OgrenciRepo : BaseRepo<Ogrenci>
    {
        public OgrenciRepo(DatabaseContext context) : base(context)
        {

        }
        public Ogrenci GetOgrenciWithIslemlerById(int id)
        {
            return GetListWithIslemler().FirstOrDefault(x => x.OgrenciID == id);
        }
        public IEnumerable<Ogrenci> GetListWithIslemler()
        {

            return _dbSet.Include(x => x.kutuphaneIslems).ToList();
        }
        public List<int> GetZimmetliKitapsNo(int ogrenciID)
        {
            Ogrenci ogr = GetOgrenciWithIslemlerById(ogrenciID);
            return ogr.kutuphaneIslems.Where(x => x.IadeTarihi == null).Select(x => x.KitapBarkodNo).ToList();
        }
        public List<int> GetTeslimEttigiKitapsNo(int ogrenciID)
        {
            Ogrenci ogr = GetById(ogrenciID);
            return ogr.kutuphaneIslems.Where(x => x.IadeTarihi != null).Select(x => x.KitapBarkodNo).ToList();
        }
        public List<int> GetTumAldigiKitapsNo(int ogrenciID)
        {
            Ogrenci ogr = GetById(ogrenciID);
            return ogr.kutuphaneIslems.Select(x => x.KitapBarkodNo).ToList();
        }

        public bool ZimmetliKitapVarMi(int id)
        {
            Ogrenci ogr = GetOgrenciWithIslemlerById(id);
            var x = ogr.kutuphaneIslems.FirstOrDefault(x => x.IadeTarihi == null);
            return x != null;
        }

    }
}
