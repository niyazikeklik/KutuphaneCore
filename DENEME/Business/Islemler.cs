using DTO.Concrete;

using Entitites;
using Entitites.Models;

using KutuphaneCore;

using System;

using static DTO.Concrete.Tablolar; 
namespace Business
{
    public static class Islemler
    {
        public static double IadeEt(KutuphaneIslem islem)
        {
            islem.IadeTarihi = DateTime.Now;
            Tables.Islem.Update(islem);

            var kitap = Tables.Kitap.GetById(islem.KitapBarkodNo);
            kitap.Stok = true;
            Tables.Kitap.Update(kitap);

            double borc = IslemBorcHesapla(islem);
            return borc;
        }
        public static KutuphaneIslem TeslimAl(int seciliKitapID, int ogrenciID)
        {
            var seciliKitap = Tables.Kitap.GetById(seciliKitapID);
            seciliKitap.Stok = !seciliKitap.Stok;
            Tables.Kitap.Update(seciliKitap);
            var x = new KutuphaneIslem()
            {
                AlimTarihi = DateTime.Now.AddDays(-20),
                IadeTarihi = null,
                KitapBarkodNo = seciliKitapID,
                OgrenciNo = ogrenciID
            };
            Tables.Islem.Add(x);
            return x;
        }
        public static double IslemBorcHesapla(KutuphaneIslem islem)
        {
            double gunSayisi = (islem.AlimTarihi - islem.IadeTarihi).Value.TotalDays * -1;
            if (gunSayisi > 15)
                return (gunSayisi - 15) * 1;
            else
                return 0;

        }
    }
}
