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
        public Ogrenci GetOgrenciWithIslemlerById(string id)
        {
            return GetListWithIslemler().FirstOrDefault(x => x.OgrenciTC == id);
        }
        public IEnumerable<Ogrenci> GetListWithIslemler()
        {

            return _dbSet.Include(x => x.kutuphaneIslems).ToList();
        }
        public List<string> GetZimmetliKitapsNo(string ogrenciID)
        {
            Ogrenci ogr = GetOgrenciWithIslemlerById(ogrenciID);
            return ogr.kutuphaneIslems.Where(x => x.IadeTarihi == null).Select(x => x.KitapBarkodNo).ToList();
        }
        public List<string> GetTeslimEttigiKitapsNo(string ogrenciID)
        {
            Ogrenci ogr = GetById(ogrenciID);
            return ogr.kutuphaneIslems.Where(x => x.IadeTarihi != null).Select(x => x.KitapBarkodNo).ToList();
        }
        public List<string> GetTumAldigiKitapsNo(string ogrenciID)
        {
            Ogrenci ogr = GetById(ogrenciID);
            return ogr.kutuphaneIslems.Select(x => x.KitapBarkodNo).ToList();
        }

        public bool ZimmetliKitapVarMi(string id)
        {
            Ogrenci ogr = GetOgrenciWithIslemlerById(id);
            var x = ogr.kutuphaneIslems.FirstOrDefault(x => x.IadeTarihi == null);
            return x != null;
        }

        public List<KutuphaneIslem> GetKapanmamisIslem(string ID)
        {
            return GetOgrenciWithIslemlerById(ID).kutuphaneIslems.Where(x => x.IadeTarihi == null).ToList();
        }

    }
}
