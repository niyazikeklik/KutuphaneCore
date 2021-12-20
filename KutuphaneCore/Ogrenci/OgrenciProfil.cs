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
            this.ogr = Tables.Ogr.GetOgrenciWithIslemlerById(ogrID);
            InitializeComponent();
        }
        public void GridsYenile()
        {
            GridBulunanKitaplar.Columns.Clear();
            List<OgrenciIslemBilgi> list = new List<OgrenciIslemBilgi>();
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
            data_Ogrenci.DataSource = list;
            GridBulunanKitaplar.DataSource = Tables.Kitap.GetAlinabilir();
            GridBulunanKitaplar.Columns[GridBulunanKitaplar.ColumnCount - 1].Visible = false;
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Text = "Kitaba git";
            btnColumn.HeaderText = "İlgili Kitap";
            GridBulunanKitaplar.Columns.Add(btnColumn);
            data_Ogrenci.ClearSelection();
            GridBulunanKitaplar.ClearSelection();
            data_Ogrenci.Boya();
            OgrenciBilgileriIsle();

        }
        public void OgrenciBilgileriIsle()
        {
            double ToplamBorc = 0;
            foreach (var item in Tables.Ogr.GetKapanmamisIslem(ogr.OgrenciTC))
                ToplamBorc += item.BorcHesapla();

            lblTC.Text = ogr.OgrenciTC;
            lblIsim.Text = ogr.IsimSoyisim;
            lblBorc.Text = ToplamBorc.ToString();
            lblTel.Text = ogr.TelefonNo.ToString();
            lblYas.Text = Math.Round((DateTime.Now - ogr.DogumTarihi).TotalDays / 365, 0, MidpointRounding.ToZero).ToString();
        }
        private void OgrenciProfil_Load(object sender, EventArgs e)
        {

            GridsYenile();

        }

        private void iadeEt_Click_1(object sender, EventArgs e)
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

        private void teslimAl_Click_1(object sender, EventArgs e)
        {
            if (GridBulunanKitaplar.SelectedRows.Count >= 0)
            {
                var seciliKitapID = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
                var result = Islemler.TeslimAl(seciliKitapID, ogr.OgrenciTC);
                var kitap = Tables.Kitap.GetById(result.KitapBarkodNo);

                MessageBox.Show($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GridsYenile();
            }
            else MessageBox.Show("Bir kitap seçiniz.");

        }

        private void GridBulunanKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridBulunanKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == GridBulunanKitaplar.Columns.Count - 1)
                {
                    var barkrodNo = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
                    KitapProfil form = new KitapProfil(barkrodNo);
                    form.ShowDialog();
                }

            }
        }
    }
}
