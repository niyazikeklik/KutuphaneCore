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

using static DTO.Concrete.Tablolar;
namespace KutuphaneCore
{
    public partial class OgrenciProfil : Form
    {
        Ogrenci ogr;
        public OgrenciProfil(int ogrID)
        {
            this.ogr = Tables.Ogr.GetOgrenciWithIslemlerById(ogrID);
            InitializeComponent();
        }
        public void GridsYenile()
        {
            List<OgrenciIslemBilgi> list = new List<OgrenciIslemBilgi>();
            foreach (var item in Tables.Ogr.GetOgrenciWithIslemlerById(ogr.OgrenciID).kutuphaneIslems)
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
            data_Ogrenci.DataSource = list;
            GridBulunanKitaplar.DataSource = Tables.Kitap.GetAlinabilir();
            data_Ogrenci.ClearSelection();
            GridBulunanKitaplar.ClearSelection();
            data_Ogrenci.Boya();

        }
        public void OgrenciBilgileriIsle()
        {
            ogrIsim.Text = ogr.IsimSoyisim.ToString();
            ogrTc.Text = ogr.OgrenciID.ToString();
        }
        private void OgrenciProfil_Load(object sender, EventArgs e)
        {
            OgrenciBilgileriIsle();
            GridsYenile();
        }
        private void teslimAl_Click(object sender, EventArgs e)
        {
            var seciliKitapID = (int)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
            var result = Islemler.TeslimAl(seciliKitapID, ogr.OgrenciID);
            var kitap = Tables.Kitap.GetById(result.KitapBarkodNo);

            MessageBox.Show($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GridsYenile();
        }

        private void iadeEt_Click(object sender, EventArgs e)
        {

            var secilenrow = data_Ogrenci.SelectedRows[0];
            var secilenBarkodNo = (int)secilenrow.Cells[0].Value;

            var islem = Tables.Islem.GetById(secilenBarkodNo);
            double result = Islemler.IadeEt(islem);
            if (result != -1)
            {
                MessageBox.Show($"İade tamamlandı. Öğrencinin işlem borcu: {result} TL'dir.");

                OgrenciBilgileriIsle();
                GridsYenile();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void data_Ogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
