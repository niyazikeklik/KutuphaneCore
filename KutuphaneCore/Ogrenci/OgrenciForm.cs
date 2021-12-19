using Business;

using KutuphaneCore;

using System;
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
        void GridYenile()
        {
            data_Ogrenci.DataSource = Tables.Ogr.GetList();
            data_Ogrenci.Columns[data_Ogrenci.Columns.Count - 1].Visible = false;
        }
        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            GridYenile();
        }
        private void OgrEkle_Click_1(object sender, EventArgs e)
        {
            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = true;
            form.OgrButton.Text = "Öğrenciyi Ekle";
            form.ShowDialog();
            GridYenile();
        }
        private void btn_OgrGuncelle_Click_1(object sender, EventArgs e)
        {
            var row = data_Ogrenci.SelectedRows[0];

            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = false;
            form.ogrTC.Text = row.Cells[0].Value.ToString();
            form.ogrAd.Text = row.Cells[1].Value.ToString();
            form.OgrTeNo.Text = row.Cells[2].Value.ToString();
            form.OgrBirt.Value = (DateTime)row.Cells[3].Value;

            form.OgrButton.Text = "Öğrenciyi Güncelle";
            form.ShowDialog();
            GridYenile();
         
        }

        private void btn_OgrGit_Click(object sender, EventArgs e)
        {
            var ogrenciNo = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
            OgernciProfil form = new OgernciProfil(ogrenciNo);
            form.ShowDialog();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (rdBtn_ismeGore.Checked)
                data_Ogrenci.Ara(1, txtAra.Text);
            else if (rdBtn_TC.Checked)
                data_Ogrenci.Ara(0, txtAra.Text);
        }

        private void btn_OgrSil_Click_1(object sender, EventArgs e)
        {
            if (data_Ogrenci.SelectedRows.Count == 1)
            {
                string secilenOgrenciID = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
                var zimmetliKitaplar = Tables.Ogr.GetZimmetliKitapsNo(secilenOgrenciID);
                if (zimmetliKitaplar.Count != 0)
                {
                    if (MessageBox.Show("Silinmek istenen öğrencinin üzerinde kitap bulunmaktadır yine de silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var item in zimmetliKitaplar)
                            Tables.Kitap.StokUpdate(item);
                        Tables.Ogr.Remove(secilenOgrenciID);
                    }
                }
                else Tables.Ogr.Remove(secilenOgrenciID);
                GridYenile();
            }
            else MessageBox.Show("Lütfen bir öğrenci seçiniz!");
        }
    }
}
