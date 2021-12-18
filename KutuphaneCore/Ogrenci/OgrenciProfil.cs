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
            InitializeComponent();
        }
        public void GridsYenile()
        {
           
        }
        public void OgrenciBilgileriIsle()
        {
            ogrIsim.Text = ogr.IsimSoyisim.ToString();
            ogrTc.Text = ogr.OgrenciTC.ToString();
            ogrBorc.Text = ogr.ogrenciBorc.ToString();
        }
        private void OgrenciProfil_Load(object sender, EventArgs e)
        {
            OgrenciBilgileriIsle();
            GridsYenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var secilenrow = GridBulunanKitaplar.SelectedRows[0];
            var secilenBarkodNo = (int)secilenrow.Cells[0].Value;

            var islem = Tables.Islem.GetIslemsByOgrenciNoAndKitapNo(ogr.OgrenciTC, secilenBarkodNo);
            double result = Islemler.IadeEt(islem);

            if (MessageBox.Show($"İade tamamlandı.Öğrencinin işlem borcu: {result} TL'dir.\n\n Ödeme alındı mı?", "İşlem Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ogr.ogrenciBorc -= result;
                Tables.Ogr.Update(ogr);
                OgrenciBilgileriIsle();
            }
         
            GridsYenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var seciliKitapID = (int)GridAlinabilirKitaplar.SelectedRows[0].Cells[0].Value;
            var result = Islemler.TeslimAl(seciliKitapID, ogr.OgrenciTC);
            var kitap = Tables.Kitap.GetById(result.KitapBarkodNo);

            MessageBox.Show($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.","İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GridsYenile();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
