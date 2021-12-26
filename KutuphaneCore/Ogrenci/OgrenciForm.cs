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
            //Öğrenciler tablosunun datagrid üzerine basılması.
            data_Ogrenci.DataSource = Tables.Ogr.GetList();
            //Son sütun olan işlemler sütununun gizlenmesi.
            data_Ogrenci.Columns[data_Ogrenci.Columns.Count - 1].Visible = false;
        }
        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            GridYenile();
        }
        private void OgrEkle_Click_1(object sender, EventArgs e)
        {
            //Öğrenci ekleme formunun ayarlanması ve gösterilmesi.
            OgrenciIslem form = new OgrenciIslem();
            form.ogrTC.Enabled = true;
            form.OgrButton.Text = "Öğrenciyi Ekle";
            form.ShowDialog();
            GridYenile();
        }
        private void btn_OgrGuncelle_Click_1(object sender, EventArgs e)
        {     //Seçili öğrenci var ise 
            if (data_Ogrenci.SelectedRows.Count == 1)
            {
                //Öğrenci güncelleme formunun seçilen satırdaki bilgilere göre ayarlanması ve gösterilmesi.
                var row = data_Ogrenci.SelectedRows[0];
                var secilenOgrID = (string)row.Cells[0].Value;
                Entitites.Models.Ogrenci SecilenOgrenci = Tables.Ogr.GetById(secilenOgrID);
                OgrenciIslem form = new OgrenciIslem();
                form.ogrTC.Enabled = false;
                form.ogrTC.Text = SecilenOgrenci.OgrenciTC;
                form.ogrAd.Text = SecilenOgrenci.IsimSoyisim;
                form.OgrTeNo.Text = SecilenOgrenci.TelefonNo;
                form.OgrBirt.Value = SecilenOgrenci.DogumTarihi;
                form.OgrButton.Text = "Öğrenciyi Güncelle";
                form.ShowDialog();
                GridYenile();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz!", "Öğrenci seçmediniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_OgrGit_Click(object sender, EventArgs e)
        {
            if (data_Ogrenci.SelectedRows.Count == 1)
            {
                //Seçilen öğrenci ıd üzerinden OgrenciProfil formunun açılması.
                var ogrenciNo = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
                OgernciProfil form = new OgernciProfil(ogrenciNo);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz!", "Öğrenci seçmediniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OgrSil_Click_1(object sender, EventArgs e)
        {
            //Seçili öğrenci var ise 
            if (data_Ogrenci.SelectedRows.Count == 1)
            {

                string secilenOgrenciID = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
                //Seçeili öğrencinin üzerinde zimmetli kitap var ise
                if (Tables.Ogr.ZimmetliKitapVarMi(secilenOgrenciID))
                {
                    if (MessageBox.Show("Silinmek istenen öğrencinin üzerinde kitap bulunmaktadır yine de silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //öğrenciye zimmetli olduğu kitapların stok bilgis güncellenir ve ardından öğrenci silinir
                        var list = Tables.Ogr.GetZimmetliKitapsNo(secilenOgrenciID);
                        foreach (var item in list)
                        {
                            Tables.Kitap.StokUpdate(item);
                        }

                        Tables.Ogr.Remove(secilenOgrenciID);
                    }
                }
                //Zimmetli kitap yoksa direkt öğrenci silinir.
                else
                {
                    Tables.Ogr.Remove(secilenOgrenciID);
                }

                GridYenile();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz!", "Öğrenci seçmediniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
            //txtAra textbox'ına data girildikçe seçili radiobutona göre arama işlemi.
            if (rdBtn_ismeGore.Checked)
            {
                data_Ogrenci.Ara(1, txtAra.Text);
            }
            else if (rdBtn_TC.Checked)
            {
                data_Ogrenci.Ara(0, txtAra.Text);
            }
        }
    }
}
