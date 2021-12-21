using Business;

using DTO;
using DTO.Concrete;

using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using View.Kitap;

using static DTO.Concrete.Tablolar;
namespace KutuphaneCore
{
    public partial class OgernciProfil : Form
    {
        Ogrenci ogr;
        public OgernciProfil(string ogrID)
        {
            //parametre olarak gelen öğrenci ıd üzerinden ilgili öğrenci tespiti yapılır.
            this.ogr = Tables.Ogr.GetOgrenciWithIslemlerById(ogrID);
            InitializeComponent();
        }
        public void GridsYenile()
        {
            GridBulunanKitaplar.Columns.Clear();
            List<OgrenciIslemBilgi> list = new List<OgrenciIslemBilgi>();
            //Öğrenciye ait işlemler döndürülür ve kullanıcıya bilgi amaçlı OgrenciIslemBilgi modeli üzerinden yeni bir listeye çevrilir.
            foreach (var item in Tables.Ogr.GetOgrenciWithIslemlerById(ogr.OgrenciTC).kutuphaneIslems)
            {
                list.Add(new OgrenciIslemBilgi()
                {
                    IslemID = item.IslemId,
                    KitapAdi = Tables.Kitap.GetById(item.KitapBarkodNo).KitapAd,
                    AlimTarihi = item.AlimTarihi,
                    SonTeslimTarihi = item.SonTeslimTarihi,
                    TeslimTarihi = item.IadeTarihi,
                    IsemUcreti = item.BorcHesapla(),
                    Aciklama = item.CreateAciklama()
                });
            }
            //Oluşturulan liste ekrana basılır.
            data_Ogrenci.DataSource = list;

            GridBulunanKitaplar.DataSource = Tables.Kitap.GetAlinabilir();
            GridBulunanKitaplar.Columns[GridBulunanKitaplar.ColumnCount - 1].Visible = false;

            //Son sütuna bir buton sütunu eklenir.
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Text = "Kitaba git";
            btnColumn.HeaderText = "İlgili Kitap";
            GridBulunanKitaplar.Columns.Add(btnColumn);

            data_Ogrenci.ClearSelection();
            GridBulunanKitaplar.ClearSelection();

            //İşlem durumuna göre grid renklendirilir
            data_Ogrenci.Boya();

            OgrenciBilgileriIsle();

        }
        public void OgrenciBilgileriIsle()
        {
     
            //Öğrencinin kapanmamış işlemleri üzerinden güncel borcu hesaplanır.
            double ToplamBorc = 0;
            foreach (var item in Tables.Ogr.GetKapanmamisIslem(ogr.OgrenciTC))
                ToplamBorc += item.BorcHesapla();

            //İlgili öğrenci bilgileri ekrandaki kontrollere basılır.
            lblTC.Text = ogr.OgrenciTC;
            lblIsim.Text = ogr.IsimSoyisim;
            lblBorc.Text = ToplamBorc.ToString();
            lblTel.Text = ogr.TelefonNo.ToString();
            //Öğrencinin yaşı hesaplanır.
            lblYas.Text = ogr.DogumTarihi.YasHesapla().ToString(); 
        }
        private void OgrenciProfil_Load(object sender, EventArgs e)
        {

            GridsYenile();

        }

        private void iadeEt_Click_1(object sender, EventArgs e)
        {
            //Seçilen row'daki ıd'ye göre ilgili işlemin iade edilmesi.
            if (data_Ogrenci.SelectedRows.Count >= 0)
            {
                var secilenrow = data_Ogrenci.SelectedRows[0];
                var secilenBarkodNo = (int)secilenrow.Cells[0].Value;

                var islem = Tables.Islem.GetById(secilenBarkodNo);
                double result = Islemler.IadeEt(islem);
                if (result != -1)
                {
                    MessageBox.Show($"İade tamamlandı. Öğrencinin işlem borcu: {result} TL'dir.");

                    GridsYenile();
                }
            }
            else MessageBox.Show("İade etmek istediğniz işlemi seçiniz.", "İşlem seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void teslimAl_Click_1(object sender, EventArgs e)
        {
            //Seçili bir satır var ise
            if (GridBulunanKitaplar.SelectedRows.Count >= 0)
            {
                //Seçilen satır üzerindeki ıd üzerinden ilgili kitabın tespiti ve zimmetlenmesi.
                var seciliKitapID = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
                var result = Islemler.TeslimAl(seciliKitapID, ogr.OgrenciTC);
                var kitap = Tables.Kitap.GetById(result.KitapBarkodNo);

                MessageBox.Show($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GridsYenile();
            }
            else MessageBox.Show("Teslim almak istediğniz kitabı seçiniz.", "Kitap seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void GridBulunanKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eğer header satırı dışında bir satıra tıklandı ise
            if (e.RowIndex != -1)
            {
                //Tıklanılan hücre sondaki buton hücresi mi?
                if (e.ColumnIndex == GridBulunanKitaplar.Columns.Count - 1)
                {
                    //Tıklanılan satırdaki barkod no üzerinden ilgili kitabın profilinin açılması.
                    var barkrodNo = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
                    KitapProfil form = new KitapProfil(barkrodNo);
                    form.ShowDialog();
                }

            }
        }
    }
}
