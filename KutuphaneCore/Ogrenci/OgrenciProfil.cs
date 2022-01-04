using Business;

using Entitites.Models;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using View.Kitap;

using static DTO.Concrete.Tablolar;
namespace KutuphaneCore
{
	public partial class OgernciProfil : Form
	{
		private Ogrenci ogr;
		private readonly string id;
		public OgernciProfil(string ogrID)
		{
			//parametre olarak gelen öğrenci ıd üzerinden ilgili öğrenci tespiti yapılır.
			ogr = Tables.Ogr.GetOgrenciWithIslemlerById(ogrID);
			id = ogrID;
			InitializeComponent();
		}
		public void GridsYenile()
		{
			ogr = Tables.Ogr.GetOgrenciWithIslemlerById(id);
			GridBulunanKitaplar.Columns.Clear();
			var list = new List<OgrenciIslemBilgi>();
			//Öğrenciye ait işlemler döndürülür ve kullanıcıya bilgi amaçlı OgrenciIslemBilgi modeli üzerinden yeni bir listeye çevrilir.
			foreach (KutuphaneIslem? item in Tables.Ogr.GetOgrenciWithIslemlerById(ogr.OgrenciTC).kutuphaneIslems)
				list.Add(new OgrenciIslemBilgi()
				{
					IslemID = item.IslemId,
					KitapAdi = Tables.Kitap.GetById(item.KitapBarkodNo).KitapAd,
					AlimTarihi = item.AlimTarihi,
					SonTeslimTarihi = item.SonTeslimTarihi,
					TeslimTarihi = item.IadeTarihi,
					IsemUcreti = item.BorcHesapla(),
					Aciklama = item.CreateAciklama()
				});

			//Oluşturulan liste ekrana basılır.
			data_Ogrenci.DataSource = list;

			//Alınabilir kitaplar listesi gridviewde gösterilir.
			GridBulunanKitaplar.DataSource = Tables.Kitap.GetAlinabilir();
			// Son sutun olan kutuphaneıslemler gizlenir.
			GridBulunanKitaplar.Columns[GridBulunanKitaplar.ColumnCount - 1].Visible = false;

			//Son sütuna bir buton sütunu eklenir.
			var btnColumn = new DataGridViewButtonColumn
			{
				UseColumnTextForButtonValue = true,
				Text = "Kitaba git",
				HeaderText = "İlgili Kitap"
			};
			GridBulunanKitaplar.Columns.Add(btnColumn);

			//Default seçili satırlar temizlenir.
			data_Ogrenci.ClearSelection();
			GridBulunanKitaplar.ClearSelection();

			//İşlem durumuna göre grid renklendirilir
			data_Ogrenci.Boya();

			//Öğrenci bilgilerini ekrana dolduracak fonksiyon.
			OgrenciBilgileriIsle();

		}
		public void OgrenciBilgileriIsle()
		{
			//Öğrencinin kapanmamış işlemleri üzerinden güncel borcu hesaplanır.
			double ToplamBorc = 0;
			foreach (KutuphaneIslem? item in Tables.Ogr.GetKapanmamisIslem(ogr.OgrenciTC))
				ToplamBorc += item.BorcHesapla();

			//İlgili öğrenci bilgileri ekrandaki kontrollere basılır.
			lblTC.Text = ogr.OgrenciTC;
			lblIsim.Text = ogr.IsimSoyisim;
			lblBorc.Text = Math.Round(ToplamBorc, 1).ToString();
			lblTel.Text = ogr.TelefonNo.ToString();
			//Öğrencinin yaşı hesaplanır.
			lblYas.Text = ogr.DogumTarihi.YasHesapla().ToString();
		}
		private void OgrenciProfil_Load(object sender, EventArgs e) => GridsYenile();
		private void İadeEt_Click_1(object sender, EventArgs e)
		{
			//Seçilen row'daki ıd'ye göre ilgili işlemin iade edilmesi.
			if (data_Ogrenci.SelectedRows.Count >= 0)
			{
				DataGridViewRow? secilenrow = data_Ogrenci.SelectedRows[0];
				int secilenBarkodNo = (int)secilenrow.Cells[0].Value;
				//İlgili işlem tespiti.
				KutuphaneIslem? islem = Tables.Islem.GetById(secilenBarkodNo);
				//İşlemin kapatılması, iade edilmesi.
				double result = Islemler.IadeEt(islem);
				if (result != -1)
				{
					MessageBox.Show($"İade tamamlandı. Öğrencinin işlem borcu: {result} TL'dir.");
					GridsYenile();
				}
			} else MessageBox.Show("İade etmek istediğniz işlemi seçiniz.", "İşlem seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}
		private void TeslimAl_Click_1(object sender, EventArgs e)
		{
			//Seçili bir satır var ise
			if (GridBulunanKitaplar.SelectedRows.Count >= 0)
			{
				//Seçilen satır üzerindeki ıd üzerinden ilgili kitabın tespiti ve zimmetlenmesi.
				string? seciliKitapID = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
				//Kitap, öğrenciye zimmetlenir.
				KutuphaneIslem? result = Islemler.TeslimAl(seciliKitapID, ogr.OgrenciTC);
				//Kullancııyı bilgilendirme amaçlı kitap detayları çekilir.
				Entitites.Kitap? kitap = Tables.Kitap.GetById(result.KitapBarkodNo);
				MessageBox.Show($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//Değişikliklerin gözükmesi için grid yenilenir.
				GridsYenile();
			} else MessageBox.Show("Teslim almak istediğniz kitabı seçiniz.", "Kitap seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}
		private void GridBulunanKitaplar_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			//Eğer header satırı dışında bir satıra tıklandı ve
			//Tıklanılan hücre sondaki buton hücresi ise?
			if (e.RowIndex != -1 && e.ColumnIndex == GridBulunanKitaplar.Columns.Count - 1)
			{
				//Tıklanılan satırdaki barkod no üzerinden ilgili kitabın profilinin açılması.
				string? barkrodNo = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
				var form = new KitapProfil(barkrodNo);
				form.ShowDialog();
				GridsYenile();
			}
		}
	}
}
