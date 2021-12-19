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

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            data_Ogrenci.DataSource = Tables.Ogr.GetList();
        }
        private void OgrEkle_Click_1(object sender, EventArgs e)
        {
            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = true;
            form.OgrButton.Text = "Öğrenciyi Ekle";
            form.ShowDialog();
            data_Ogrenci.DataSource = Tables.Ogr.GetList();
        }

        private void btn_OgrGuncelle_Click(object sender, EventArgs e)
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
            data_Ogrenci.DataSource = Tables.Ogr.GetList();
        }

        private void OgrSil_Click_1(object sender, EventArgs e)
        {
            if (data_Ogrenci.SelectedRows.Count == 1)
            {
                int secilenOgrenciID = (int)data_Ogrenci.SelectedRows[0].Cells[0].Value;
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
                data_Ogrenci.DataSource = Tables.Ogr.GetList();
            }
            else MessageBox.Show("Lütfen bir öğrenci seçiniz!");
        }

        private void btn_OgrenciyeGit_Click(object sender, EventArgs e)
        {
            var ogrenciNo = (int)data_Ogrenci.SelectedRows[0].Cells[0].Value;
            OgrenciProfil form = new OgrenciProfil(ogrenciNo);
            form.ShowDialog();
        }

        private void ogrTC_TextChanged(object sender, EventArgs e)
        {
            if (rdBtn_ismeGore.Checked)
                data_Ogrenci.Ara(1, txtAra.Text);
            else if (rdBtn_TC.Checked)
                data_Ogrenci.Ara(0, txtAra.Text);
        }
    }
}
