using DTO;
using DTO.Abstract;
using DTO.Concrete;

using Entitites.Models;

using KutuphaneCore;

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

using static Entitites.Models.Enums;
using static DTO.Concrete.Tablolar;
using Business;

namespace View.Kitap
{
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }
        void GridYenile()
        {
            //Kitap tablosunu olduğu gibi gridview'e basıyorum.
            data_TumKitap.DataSource = Tables.Kitap.GetList();
            //Sondaki işlemler sütununu gizliyorum.
            data_TumKitap.Columns[data_TumKitap.Columns.Count - 1].Visible = false;
        }
        private void KitapForm_Load(object sender, EventArgs e)
        {
            GridYenile();
        }
        private void btn_KtpEkle_Click(object sender, EventArgs e)
        {
            //Ekleme işlemi için popup form açılıyor.
            KitapIslem form = new KitapIslem();
            form.ktpBarkod.Enabled = true;
            form.ktpButon.Text = "Kitap Ekle";
            form.ShowDialog();
            //Ekleme işlemi bitince eklenen kayıt görüntülenebilmesi için gridview'i yeniliyorum.
            GridYenile();
        }

        private void btn_KtpSil_Click(object sender, EventArgs e)
        {
            //Eğer seçili satır var ise
            if (data_TumKitap.SelectedRows.Count == 1)
            {
                //Seçilen satırın 0. hücresindeki değerden silinecek kitabın BarkodNo'sunu alıyorum
                string secilenBarkod = (string)data_TumKitap.SelectedRows[0].Cells[0].Value;
                //  barkod no'ya göre ilgili kitabı siliyorum
                Tables.Kitap.Remove(secilenBarkod);
                //Deişikliklerin görünmesi için gridview yeniliyorum.
                GridYenile();
            }
            else MessageBox.Show("Lütfen bir kitap seçiniz!", "Kitap seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
            //Seçilen radiobutona göre gridview'de arama işlemi yapılıyor.
            if (rdBtn_ismeGore.Checked)
                data_TumKitap.Ara(1, txtAra.Text);
            else if (rdBtn_TC.Checked)
                data_TumKitap.Ara(0, txtAra.Text);
        }

        private void btn_KtpGuncelle_Click(object sender, EventArgs e)
        {
            //Seçilen satırdaki bilgiler güncellenmek için ilgili kitap kaydı üzerinden KitapIslem formundaki kontrollere işleniyor.
            var row = data_TumKitap.SelectedRows[0];
            string secilenBarkod = (string)row.Cells[0].Value;
            Entitites.Kitap secilenKitap = Tables.Kitap.GetById(secilenBarkod);
            KitapIslem form = new KitapIslem();
            form.ktpTur.DataSource = Enum.GetValues(typeof(KitapKategori));
            form.ktpBarkod.Enabled = false;
            form.ktpBarkod.Text = secilenKitap.BarkodNo;
            form.ktpYazar.Text = secilenKitap.KitapYazar;
            form.ktpAd.Text = secilenKitap.KitapAd;
            form.ktpSayfa.Text = secilenKitap.SayfaSayısı.ToString();
            form.ktpBasım.Value = secilenKitap.BasimTarihi;
            form.ktpTur.SelectedIndex = (int)secilenKitap.KitapTuru;

            form.ktpButon.Text = "Kitap Güncelle";
            form.ShowDialog();
            GridYenile();
        }

        private void Btn_KitapGit_Click(object sender, EventArgs e)
        {
            //Seçilen satır barkodno'ya göre ilgili kitabı kitapprofil formuna gönderiyorum.
            var id = (string)data_TumKitap.SelectedRows[0].Cells[0].Value;
            KitapProfil form = new KitapProfil(id);
            form.ShowDialog();

        }
    }
}
