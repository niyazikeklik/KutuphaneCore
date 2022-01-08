using Business.Business;

using Entitites.Models;

using System;
using System.Windows.Forms;

using View.CustomElement;
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
		public void FormYenile()
		{
			ogr = Tables.Ogr.GetOgrenciWithIslemlerById(id);
			GridBulunanKitaplar.Columns.Clear();

			//Kullanıcı bilgilendirmesi için oluşturulan liste ekrana basılır.
			data_Ogrenci.DataSource = ogr.CreateOgrenciIslemBilgi();

			//Alınabilir kitaplar listesi gridviewde gösterilir.
			GridBulunanKitaplar.DataSource = Tables.Kitap.GetAlinabilir();
			// Son sutun olan kutuphaneıslemler gizlenir.
			GridBulunanKitaplar.Columns[GridBulunanKitaplar.ColumnCount - 1].Visible = false;

			//Son sütuna bir buton sütunu eklenir.
			var btnColumn = new CustomGridButton
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
			//Sütun isimleri değiştirilir.
			data_Ogrenci.HeaderTextChange();
			GridBulunanKitaplar.HeaderTextChange();
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
		private void OgrenciProfil_Load(object sender, EventArgs e) => FormYenile();
		private void İadeEt_Click_1(object sender, EventArgs e)
		{
			//Seçilen row'daki ıd'ye göre ilgili işlemin iade edilmesi.
			if (data_Ogrenci.SelectedRows.Count > 0)
			{
				DataGridViewRow? secilenrow = data_Ogrenci.SelectedRows[0];
				int secilenBarkodNo = (int)secilenrow.Cells[0].Value;
				//İlgili işlem tespiti.
				KutuphaneIslem? islem = Tables.Islem.GetById(secilenBarkodNo);
				//İşlemin kapatılması, iade edilmesi.
				double result = islem.IadeEt();
				if (result != -1)
				{
					Msj.ShowInfo($"İade tamamlandı. Öğrencinin işlem borcu: {result} TL'dir.");
					FormYenile();
				}
			} else Msj.ShowStop("İade etmek istediğniz işlemi seçiniz.");

		}
		private void TeslimAl_Click_1(object sender, EventArgs e)
		{
			//Seçili bir satır var ise
			if (GridBulunanKitaplar.SelectedRows.Count > 0)
			{
				//Seçilen satır üzerindeki ıd üzerinden ilgili kitabın tespiti ve zimmetlenmesi.
				string? seciliKitapID = (string)GridBulunanKitaplar.SelectedRows[0].Cells[0].Value;
				//Kitap, öğrenciye zimmetlenir.
				KutuphaneIslem? result = KutuphaneOlayları.TeslimAl(seciliKitapID, ogr.OgrenciTC);
				//Kullancııyı bilgilendirme amaçlı kitap detayları çekilir.
				Entitites.Kitap? kitap = Tables.Kitap.GetById(result.KitapBarkodNo);

				Msj.ShowInfo($"{kitap.KitapAd} - {kitap.KitapYazar} İsimli kitap {ogr.IsimSoyisim} isimli kişiye zimmetlenmiştir. Son teslim tarihi: {result.AlimTarihi.AddDays(15)}'dir. Bu tarihten sonraki teslimler için her gün başına 1 TL ceza uygulanacaktır.");

				//Değişikliklerin gözükmesi için grid yenilenir.
				FormYenile();
			} else Msj.ShowStop("Teslim etmek istediğniz kitabı seçiniz.");

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
				FormYenile();
			}
		}
	}
}
