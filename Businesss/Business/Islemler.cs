using Entitites.Models;

using System;
using System.Drawing;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
namespace Business
{
    public static class Islemler
    {
        //Öğrencinin işlemleri için açıklama oluştururç
        public static string CreateAciklama(this KutuphaneIslem item)
        {
            //Bir işlemin iade tarihi yoksa ve son teslim tarihi geçmiş ise ceza uygulanır.
            if (item.IadeTarihi == null && item.SonTeslimTarihi < DateTime.Now)
            {
                return "Kitabın teslim süresi geçmiştir. Güncel ceza " + item.BorcHesapla() + "TL'dir.";
            }
            //Bir işlemin iade tarihi varsa, kitap teslim alınmıştır.
            else if (item.IadeTarihi != null)
            {
                return "Kitap teslim alınmıştır.";
            }
            //Yukarıdaki şartar gerçekleşmezse kitabın iade tarihine daha vardır.
            else
            {
                return "Kitabın teslim tarihine son " + item.KalanGun() + " gün vardır";
            }
        }
        //Parametre olarak gelen datagridview nesnesinde ilgili sütunda ilgili veriyi arar.
        public static void Ara(this DataGridView grid, int sutunIndis, string aranacak)
        {
            //Datagrid'in tüm satırlarını döner.
            foreach (DataGridViewRow row in grid.Rows)
            {
                //İlgili hücre, aranan veriyi içeriyor ise satır görünür.
                if (row.Cells[sutunIndis].Value.ToString().ToLower().Contains(aranacak.ToLower()))
                {
                    row.Visible = true;
                }
                //İlgili hücre, aranan veriyi içermiyor ise satır saklanır.
                else
                {
                    grid.CurrentCell = null;
                    row.Visible = false;
                }
            }
        }
        //Dogumtarihine göre yaş hesaplar
        public static double YasHesapla(this DateTime dogumTarihi)
        {
            //Dogum tarihi üzerinden yaş hesaplama.
            return Math.Round((DateTime.Now - dogumTarihi).TotalDays / 365, 0, MidpointRounding.ToZero);
        }
        //Parametre olarak gelen gridin satırlarını döner ve duruma göre rengini değiştirir.
        public static void Boya(this DataGridView grid)
        {
            //Datagrid satırlarını dönüyorum.
            foreach (DataGridViewRow row in grid.Rows)
            {
                //Datagridin 1.0. hücresindeki veriden ilgili işlemi tespit ediyorum.
                var islem = Tables.Islem.GetById((int)row.Cells[0].Value);
                //İlgili işlemin kapanmasına kalan gün sayısını tespit ediyorum.
                double kalanGun = islem.KalanGun();
                //Eğer iade tarihi var ise satır rengi yeşil olur.
                if (islem.IadeTarihi != null)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                //Kalan gün 0'dan küçükse yani SonİadeTarihi geçti ise ilgili satır kırmızı olur.
                else if (kalanGun < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                //Kalan gün 2'den küçükse yani SonİadeTarihi'ne 0-2 gün var ise satır sarı olur.
                else if (kalanGun <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        //İşlemin borcunu hesaplar
        public static double BorcHesapla(this KutuphaneIslem item)
        {

            //KalanGun methodu ilgili işlemin SonİadeTarihi'ne kalan gün sayısını döner
            var gecenGUnSayisi = KalanGun(item);
            //Eğer geçen gün sayısı 0'dan küçük ise öğrenciye ceza uygulanır.
            if (gecenGUnSayisi < 0)
            {
                //Round methodu virgülden sonra kaç basamak alacağını söyler
                //Borç formülü geçen gün sayısı * 1TL'dir.
                return Math.Round(gecenGUnSayisi * -1, 2);
            }
            else
            {
                return 0;
            }
        }

        //İade için kalan günü hesaplar.
        public static double KalanGun(this KutuphaneIslem item)
        {
            var result = 0.0;
            //Eğer parametre olan işlemde iade tarihi var ise iade tarihi üzerindne borç hesaplar.
            if (item.IadeTarihi != null)
            {
                result = (item.SonTeslimTarihi - item.IadeTarihi.Value).TotalDays;
            }
            //İade tarihi yoksa o anki tarihten itibaren borç hesaplaması yapar.
            else
            {
                result = (item.SonTeslimTarihi - DateTime.Now).TotalDays;
            }
            //Round methodu virgülden sonra kaç basamak alacağını söyler
            return Math.Round(result, 2);
        }

        //Bir işlei kapatmayı, iade etmeyi sağlar.
        public static double IadeEt(KutuphaneIslem islem)
        {
            //Eğer işlem iade edilmedi ise iade işlemi yapılır.
            if (islem.IadeTarihi == null)
            {
                //Önce işlemin borcu hesaplanır.
                double borc = islem.BorcHesapla();
                //İade tarihine o an girilir.
                islem.IadeTarihi = DateTime.Now;
                //Hesaplanan borç işleme işlenir
                islem.IslemUcret = borc;
                //İlgili işlem güncellenir.
                Tables.Islem.Update(islem);
                //İşleme ait kitap stoğu güncellenir.
                Tables.Kitap.StokUpdate(islem.KitapBarkodNo);
                //İşlem ücreti geri döndürülür.
                return borc;
            }
            else
            {
                MessageBox.Show("Kitap zaten iade edildi.", "İade edili kitap", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return -1;
        }

        //Bir kitabı ilgili öğrenciye zimmetler.
        public static KutuphaneIslem TeslimAl(string seciliKitapID, string ogrenciID)
        {
            //TEST İÇİN!!! int[] rastgele = { 2, 1, 14, -2, -1 };
            var SuAn = DateTime.Now;
            //Yeni bir işlem yaratılır.
            //İadeTarihi null olarak verilir.
            //SonTeslimTarihi o an'dan 15 gün sonrası olarak verilir.
            //Veritabanı ilişkileri sayesinde bu işlem öğrenci üzerinde gözükür
            var x = new KutuphaneIslem()
            {
                AlimTarihi = SuAn,
                //TEST İÇİN!!! SonTeslimTarihi = suAn.AddDays(rastgele[new Random().Next(0,4)]),
                SonTeslimTarihi = SuAn.AddDays(15),
                IadeTarihi = null,
                KitapBarkodNo = seciliKitapID,
                OgrenciID = ogrenciID,
                IslemUcret = 0,
            };
            //İşlem eklenir ve ilgili kitap stoktan düşer.
            Tables.Islem.Add(x);
            Tables.Kitap.StokUpdate(seciliKitapID);
            return x;
        }
    }
}
