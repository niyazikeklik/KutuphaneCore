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
        private void KitapForm_Load(object sender, EventArgs e)
        {
            data_TumKitap.DataSource = Tables.Kitap.GetList();
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            KitapIslem form = new KitapIslem();
            form.ktpBarkod.Enabled = true;
            form.ktpButon.Text = "Kitap Ekle";
            form.ShowDialog();
            data_TumKitap.DataSource = Tables.Kitap.GetList();
        }

        private void btn_KitapGuncelle_Click(object sender, EventArgs e)
        {
            var row = data_TumKitap.SelectedRows[0];
            KitapIslem form = new KitapIslem();
            form.ktpTur.DataSource = Enum.GetValues(typeof(KitapKategori));
            form.ktpBarkod.Enabled = false;
            form.ktpBarkod.Text = row.Cells[0].Value.ToString();
            form.ktpYazar.Text = row.Cells[2].Value.ToString();
            form.ktpAd.Text = row.Cells[1].Value.ToString();
            form.ktpSayfa.Text = row.Cells[3].Value.ToString();
            form.ktpBasım.Value = (DateTime)row.Cells[4].Value;
            Enum.TryParse(row.Cells[5].Value.ToString(), out Enums.KitapKategori kategori);
            form.ktpTur.SelectedIndex = (int)kategori;
            form.ktpButon.Text = "Kitap Güncelle";
            form.ShowDialog();
            data_TumKitap.DataSource = Tables.Kitap.GetList();
        }

        private void btn_KitapSil_Click(object sender, EventArgs e)
        {
            if (data_TumKitap.SelectedRows.Count == 1)
            {
                int secilenBarkod = (int)data_TumKitap.SelectedRows[0].Cells[0].Value;
                Tables.Kitap.Remove(secilenBarkod);
                MessageBox.Show("Seçilen Kitap Silindi!");
                data_TumKitap.DataSource = Tables.Kitap.GetList();
            }
            else MessageBox.Show("Lütfen bir kitap seçiniz!");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (rdBtn_ismeGore.Checked)
                data_TumKitap.Ara(1, txtAra.Text);
            else if (rdBtn_TC.Checked)
                data_TumKitap.Ara(0, txtAra.Text);
        }
    }
}
