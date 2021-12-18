using Entitites;
using Entitites.Models;

using System.Collections.Generic;
using System.Linq;

using static DTO.Concrete.Tablolar;
namespace KutuphaneCore
{
    public static class ExtendMethod
    {
        public static List<Kitap> GetKitaps(this IEnumerable<int> kitapsIds)
        {
            List<Kitap> result = new List<Kitap>();

            if (kitapsIds == null) return result;

            foreach (var item in kitapsIds)
                result.Add(Tables.Kitap.GetById(item));
            return result;
        }
        public static List<int> GetTeslimEttigiKitaplarBarkodNo(this IEnumerable<KutuphaneIslem> islem)
        {
            return islem.Where(x => x.IadeTarihi != null).Select(x => x.KitapBarkodNo).ToList();
        }

        public static List<int> GetZimmetliKitapBarkodNo(this IEnumerable<KutuphaneIslem> islem)
        {
            return islem.Where(x => x.IadeTarihi == null).Select(x => x.KitapBarkodNo).ToList();
        }

    
    }
}