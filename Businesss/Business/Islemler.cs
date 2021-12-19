using Entitites.Models;

using System;
using System.Drawing;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
namespace Business
{
    public static class Islemler
    {
        public static string CreateAciklama(this KutuphaneIslem item)
        {
            if (item.IadeTarihi == null && item.SonTeslimTarihi < DateTime.Now)
                return "Kitabın teslim süresi geçmiştir. Güncel ceza " + item.BorcHesapla();
            else if (item.IadeTarihi != null)
                return "Kitap teslim alınmıştır.";
            else
                return "Kitabın teslim tarihine son " + item.KalanGun() + " gün vardır";

        }
        public static void Ara(this DataGridView grid, int sutunIndis, string aranacak)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[sutunIndis].Value.ToString().ToLower().Contains(aranacak.ToLower()))
                    row.Visible = true;
                else
                {
                    grid.CurrentCell = null;
                    row.Visible = false;
                }
            }
        }
        public static void Boya(this DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                var islem = Tables.Islem.GetById((int)row.Cells[0].Value);
                double kalanGun = islem.KalanGun();
                if (islem.IadeTarihi != null)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (kalanGun < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                else if (kalanGun <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        public static double BorcHesapla(this KutuphaneIslem item)
        {
            var gecenGUnSayisi = KalanGun(item);
            if (gecenGUnSayisi < 0)
                return Math.Round(gecenGUnSayisi * -1, 2);
            else return 0;
        }
        public static double KalanGun(this KutuphaneIslem item)
        {
            var result = 0.0;
            if (item.IadeTarihi != null)
                result = (item.SonTeslimTarihi - item.IadeTarihi.Value).TotalDays;
            else
                result = (item.SonTeslimTarihi - DateTime.Now).TotalDays;
            return Math.Round(result, 2);
        }
        public static double IadeEt(KutuphaneIslem islem)
        {
            if (islem.IadeTarihi == null)
            {
                double borc = islem.BorcHesapla();
                islem.IadeTarihi = DateTime.Now;
                islem.IslemUcret = borc;
                Tables.Islem.Update(islem);

                Tables.Kitap.StokUpdate(islem.KitapBarkodNo);

                return borc;
            }
            else MessageBox.Show("Kitap zaten iade edildi.");
            return -1;
        }
        public static KutuphaneIslem TeslimAl(int seciliKitapID, int ogrenciID)
        {

            var suAn = DateTime.Now;
            var x = new KutuphaneIslem()
            {
                AlimTarihi = suAn,
                SonTeslimTarihi = suAn.AddDays(2),
                IadeTarihi = null,
                KitapBarkodNo = seciliKitapID,
                OgrenciID = ogrenciID,
                IslemUcret = 0,
            };

            Tables.Islem.Add(x);
            Tables.Kitap.StokUpdate(seciliKitapID);
            return x;
        }
    }
}
