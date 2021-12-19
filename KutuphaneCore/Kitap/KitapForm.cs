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
            data_TumKitap.DataSource = Tables.Kitap.GetList();
            data_TumKitap.Columns[data_TumKitap.Columns.Count - 1].Visible = false;
        }
        private void KitapForm_Load(object sender, EventArgs e)
        {

            GridYenile();
        }
        private void btn_KtpEkle_Click(object sender, EventArgs e)
        {
            KitapIslem form = new KitapIslem();
            form.ktpBarkod.Enabled = true;
            form.ktpButon.Text = "Kitap Ekle";
            form.ShowDialog();
            GridYenile();
        }

        private void btn_KtpSil_Click(object sender, EventArgs e)
        {
            if (data_TumKitap.SelectedRows.Count == 1)
            {
                string secilenBarkod = (string)data_TumKitap.SelectedRows[0].Cells[0].Value;
                Tables.Kitap.Remove(secilenBarkod);
                GridYenile();
            }
            else MessageBox.Show("Lütfen bir kitap seçiniz!", "Kitap seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
            if (rdBtn_ismeGore.Checked)
                data_TumKitap.Ara(1, txtAra.Text);
            else if (rdBtn_TC.Checked)
                data_TumKitap.Ara(0, txtAra.Text);
        }

        private void btn_KtpGuncelle_Click(object sender, EventArgs e)
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
            GridYenile();
        }

        private void Btn_KitapGit_Click(object sender, EventArgs e)
        {
            var id = (string)data_TumKitap.SelectedRows[0].Cells[0].Value;
            KitapProfil form = new KitapProfil(id);
            form.ShowDialog();

        }
    }
}
