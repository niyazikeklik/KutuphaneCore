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
            dataGridView1.DataSource = Tables.Kitap.GetList();
        }

        private void OgrEkle_Click_1(object sender, EventArgs e)
        {
            KitapIslem form = new KitapIslem();
            form.ktpBarkod.Enabled = true;
            form.ktpButon.Text = "Kitap Ekle";
            form.ShowDialog();
            dataGridView1.DataSource = Tables.Kitap.GetList();
        }

        private void OgrGuncelle_Click_1(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
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
            dataGridView1.DataSource = Tables.Kitap.GetList();
        }

        private void OgrSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int secilenBarkod = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Tables.Kitap.Remove(secilenBarkod);
                MessageBox.Show("Seçilen Kitap Silindi!");
                dataGridView1.DataSource = Tables.Kitap.GetList();
            }
            else MessageBox.Show("Lütfen bir kitap seçiniz!");
        }
    }
}
