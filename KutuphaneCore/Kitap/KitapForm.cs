
using Business;

using KutuphaneCore;

using System;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
using static Entitites.Models.Enums;

namespace View.Kitap
{
	public partial class KitapForm : Form
	{
		public KitapForm() => InitializeComponent();
		private void GridYenile()
		{
			//Kitap tablosunu olduğu gibi gridview'e basıyorum.
			data_TumKitap.DataSource = Tables.Kitap.GetList();
			//Sondaki işlemler sütununu gizliyorum.
			data_TumKitap.Columns[data_TumKitap.Columns.Count - 1].Visible = false;
		}
		private void KitapForm_Load(object sender, EventArgs e) => GridYenile();
		private void Btn_KtpEkle_Click(object sender, EventArgs e)
		{
			//Ekleme işlemi için popup form açılıyor.
			var form = new KitapIslem();
			form.ktpBarkod.Enabled = true;
			form.ktpButon.Text = "Kitap Ekle";
			form.ShowDialog();
			//Ekleme işlemi bitince eklenen kayıt görüntülenebilmesi için gridview'i yeniliyorum.
			GridYenile();
		}
		private void Btn_KtpSil_Click(object sender, EventArgs e)
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
			} else MessageBox.Show("Lütfen bir kitap seçiniz!", "Kitap seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}
		private void Btn_KtpGuncelle_Click(object sender, EventArgs e)
		{    //Eğer seçili satır var ise
			if (data_TumKitap.SelectedRows.Count == 1)
			{
				//Seçilen satırdaki bilgiler güncellenmek için ilgili kitap kaydı üzerinden kitap bilgileri KitapIslem formundaki kontrollere işleniyor.
				DataGridViewRow? row = data_TumKitap.SelectedRows[0];
				string secilenBarkod = (string)row.Cells[0].Value;
				Entitites.Kitap secilenKitap = Tables.Kitap.GetById(secilenBarkod);

				var form = new KitapIslem();
				form.ktpTur.DataSource = Enum.GetValues(typeof(KitapKategori));
				form.ktpBarkod.Enabled = false;
				form.ktpAd.Text = secilenKitap.KitapAd;
				form.ktpYazar.Text = secilenKitap.KitapYazar;
				form.ktpSayfa.Text = secilenKitap.SayfaSayısı.ToString();
				form.ktpBarkod.Text = secilenKitap.BarkodNo;
				form.ktpBasım.Value = secilenKitap.BasimTarihi;
				form.ktpTur.SelectedIndex = (int)secilenKitap.KitapTuru;
				form.ktpButon.Text = "Kitap Güncelle";
				form.ShowDialog();

				GridYenile();
			} else MessageBox.Show("Lütfen bir kitap seçiniz!", "Kitap seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}
		private void Btn_KitapGit_Click(object sender, EventArgs e)
		{//Eğer seçili satır var ise
			if (data_TumKitap.SelectedRows.Count == 1)
			{
				//Seçilen satır barkodno'ya göre ilgili kitabı kitapprofil formuna gönderiyorum.
				string? id = (string)data_TumKitap.SelectedRows[0].Cells[0].Value;
				var form = new KitapProfil(id);
				form.ShowDialog();

			} else MessageBox.Show("Lütfen bir kitap seçiniz!", "Kitap seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}
		private void TxtAra_TextChanged(object sender, EventArgs e)
		{
			//Seçilen radiobutona göre gridview'de arama işlemi yapılıyor.
			if (rdBtn_ismeGore.Checked) data_TumKitap.Ara(1, txtAra.Text);
			else if (rdBtn_TC.Checked) data_TumKitap.Ara(0, txtAra.Text);
		}
	}
}
