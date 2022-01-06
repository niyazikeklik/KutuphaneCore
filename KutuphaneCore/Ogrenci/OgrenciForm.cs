using Business.Business;

using KutuphaneCore;

using System;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;

namespace View.Ogrenci
{
	public partial class OgrenciForm : Form
	{
		public OgrenciForm() => InitializeComponent();
		private void GridYenile()
		{
			//Öğrenciler tablosunun datagrid üzerine basılması.
			data_Ogrenci.DataSource = Tables.Ogr.GetList();
			data_Ogrenci.HeaderTextChange();
		}
		private void OgrenciForm_Load(object sender, EventArgs e) => GridYenile();
		private void OgrEkle_Click_1(object sender, EventArgs e)
		{
			//Öğrenci ekleme formunun ayarlanması ve gösterilmesi.
			var form = new OgrenciIslem();
			form.ogrTC.Enabled = true;
			form.OgrButton.Text = "Öğrenciyi Ekle";
			form.ShowDialog();
			//İşlem sonrası değişiklikelrin görünmesi için grid yenileme.
			GridYenile();
		}
		private void Btn_OgrGuncelle_Click_1(object sender, EventArgs e)
		{
			//Seçili öğrenci var ise 
			if (data_Ogrenci.SelectedRows.Count == 1)
			{
				//Öğrenci güncelleme formunun seçilen satırdaki bilgilere göre ayarlanması ve gösterilmesi.
				DataGridViewRow? row = data_Ogrenci.SelectedRows[0];
				string? secilenOgrID = (string)row.Cells[0].Value;
				Entitites.Models.Ogrenci SecilenOgrenci = Tables.Ogr.GetById(secilenOgrID);

				//İlgili bilgileri  OgrenciIslem formundaki kontrollere basılması.
				var form = new OgrenciIslem();
				form.ogrTC.Enabled = false;
				form.ogrTC.Text = SecilenOgrenci.OgrenciTC;
				form.ogrAd.Text = SecilenOgrenci.IsimSoyisim;
				form.OgrTeNo.Text = SecilenOgrenci.TelefonNo;
				form.OgrBirt.Value = SecilenOgrenci.DogumTarihi;
				form.OgrButton.Text = "Öğrenciyi Güncelle";
				form.ShowDialog();
				//İşlem sonrası değişikliklerin gözükmesi için grid yenileme.
				GridYenile();
			} else Msj.ShowStop("Lütfen bir öğrenci seçiniz!");

		}
		private void Btn_OgrGit_Click(object sender, EventArgs e)
		{
			//Seçili öğrenci var ise 
			if (data_Ogrenci.SelectedRows.Count == 1)
			{
				//Seçilen öğrenci ıd üzerinden OgrenciProfil formunun açılması.
				string? ogrenciNo = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
				var form = new OgernciProfil(ogrenciNo);
				form.ShowDialog();

			} else Msj.ShowStop("Lütfen bir öğrenci seçiniz!");

		}
		private void Btn_OgrSil_Click_1(object sender, EventArgs e)
		{
			//Seçili öğrenci var ise 
			if (data_Ogrenci.SelectedRows.Count == 1)
			{
				string secilenOgrenciID = (string)data_Ogrenci.SelectedRows[0].Cells[0].Value;
				//Seçeili öğrencinin üzerinde zimmetli kitap var ise
				if (Tables.Ogr.ZimmetliKitapVarMi(secilenOgrenciID))
				{
					DialogResult result = Msj.ShowQuest("Silinmek istenen öğrencinin üzerinde kitap bulunmaktadır yine de silmek istiyor musunuz?");
					//Yukarıdaki soruya kullanıcı evet cevabını verdii ise
					if (result == DialogResult.Yes)
					{
						//öğrenciye zimmetli olduğu kitapların stok bilgis güncellenir ve ardından öğrenci silinir
						System.Collections.Generic.List<string>? list = Tables.Ogr.GetZimmetliKitapsNo(secilenOgrenciID);
						foreach (string? item in list) Tables.Kitap.StokToggleUpdate(item);
						Tables.Ogr.Remove(secilenOgrenciID);
					}
				}
				//Zimmetli kitap yoksa direkt öğrenci silinir.
				else Tables.Ogr.Remove(secilenOgrenciID);
				//İşlem sonrası değişikliklerin gözükmesi için grid yenileme.
				GridYenile();
			} else Msj.ShowStop("Lütfen bir öğrenci seçiniz!");
		}
		private void TxtAra_TextChanged_1(object sender, EventArgs e)
		{
			//txtAra textbox'ına data girildikçe seçili radiobutona göre arama işlemi.
			if (rdBtn_ismeGore.Checked) data_Ogrenci.Ara(1, txtAra.Text);
			else if (rdBtn_TC.Checked) data_Ogrenci.Ara(0, txtAra.Text);
		}
	}
}
