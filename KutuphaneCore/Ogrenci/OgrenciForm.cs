using DTO;
using DTO.Concrete;

using KutuphaneCore;

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

namespace View.Ogrenci
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {

            InitializeComponent();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tables.Ogr.GetList();
        }

        private void OgrEkle_Click(object sender, EventArgs e)
        {
            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = true;
            form.OgrButton.Text = "Öğrenciyi Ekle";
            form.ShowDialog();
            dataGridView1.DataSource = Tables.Ogr.GetList();
        }

        private void OgrGuncelle_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = false;
            form.ogrTC.Text = row.Cells[0].Value.ToString();
            form.ogrAd.Text = row.Cells[1].Value.ToString();
            form.OgrTelNo.Text = row.Cells[3].Value.ToString();
            form.OgrBirt.Value = (DateTime)row.Cells[4].Value;

            form.OgrButton.Text = "Öğrenciyi Güncelle";
            form.ShowDialog();
            dataGridView1.DataSource = Tables.Ogr.GetList();
        }

        private void OgrSil_Click(object sender, EventArgs e)
        {

            var y = Tables.Ogr.GetList();
            var x = Tables.Ogr.GetListWithIslems();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int secilenOgrenciID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Tables.Ogr.Remove(secilenOgrenciID);
                dataGridView1.DataSource = Tables.Ogr.GetList();
            }
            else MessageBox.Show("Lütfen bir öğrenci seçiniz!");
        }

        private void OgrGit_Click(object sender, EventArgs e)
        {
            var ogrenciNo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            OgrenciProfil form = new OgrenciProfil(ogrenciNo);
            form.ShowDialog();
        }
    }
}
