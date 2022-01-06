using Business;
using Business.Business;

using Entitites.Models;

using KutuphaneCore;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
namespace View.Kitap
{
	public partial class KitapProfil : Form
	{
		private Entitites.Kitap ktp;
		private Entitites.Models.Ogrenci zimmetliOgrenci;
		private readonly string id;
		public KitapProfil(string id)
		{
			//Parametre olarak gelen id'ye göre ilgili kitabın işlemleriyle beraber çekilmesi.
			ktp = Tables.Kitap.GetKitapWithIslemlerById(id);
			this.id = id;
			InitializeComponent();
		}
		public void GridsYenile()
		{
			ktp = Tables.Kitap.GetKitapWithIslemlerById(id);
			data_Kitap.Columns.Clear();
			var list = new List<KitapIslemBilgi>();
			//İlgili kitabın tüm işlemlerinin dönülmesi.
			foreach (KutuphaneIslem? item in Tables.Kitap.GetKitapWithIslemlerById(ktp.BarkodNo).kutuphaneIslems) 
			{
				//Eğer geçerrli işlemin iade tarihi null ise öğrenci ıd üzerinden (Global)zimmetliOgrenci nesnesi doldurulur.
				if (item.IadeTarihi == null)
					zimmetliOgrenci = Tables.Ogr.GetById(item.OgrenciID);
				//Listeye öğrencinin tüm işlemleri KitapIslemBilgi modeli üzerinden yazılır.
				list.Add(new KitapIslemBilgi()
				{
					IslemID = item.IslemId,
					AlimTarihi = item.AlimTarihi,
					IadeTarihi = item.IadeTarihi,
					OgrenciAdi = Tables.Ogr.GetById(item.OgrenciID).IsimSoyisim,
				});
			}
			//Oluşturulan liste datagrid'e basılır.
			data_Kitap.DataSource = list;
			//Data gride bir buton sütunu eklenir
			var btnColumn = new DataGridViewButtonColumn
			{
				HeaderText = "İlgili Öğrenci",
				UseColumnTextForButtonValue = true,
				Text = "Öğrenciye Git",
				Name = "GridBtn_ogrnciyeGit"
			};
			data_Kitap.Columns.Add(btnColumn);
			//Datagrid'de default olarak seçili gelen satırlara unselect işlemi.
			data_Kitap.ClearSelection();
			BilgiIsle();
			data_Kitap.HeaderTextChange();

		}
		private void BilgiIsle()
		{

			//İlgili kitabın bilgilerinin formdaki kontrollere basılması.
			lblBasim.Text = ktp.BasimTarihi.ToShortDateString();
			lblIsım.Text = ktp.KitapAd;
			lblSayfa.Text = ktp.SayfaSayısı.ToString();
			lblTur.Text = ktp.KitapTuru.ToString();
			lblYazar.Text = ktp.KitapYazar;
			lblStok.Text = ktp.Stok ? "Stokta var" : zimmetliOgrenci.IsimSoyisim + " isimli öğrencide.";
			//Eğer kitap biri üzerine zimmetli ise o kişinin detaylarını gösterecek butonun görüntülenmesinin sağlanması.
			btn.Visible = !ktp.Stok;
		}
		private void KitapProfil_Load(object sender, EventArgs e) => GridsYenile();
		private void Btn_OgrGit_Click(object sender, EventArgs e)
		{
			//Kitabın zimmetli olduğu öğrencinin detaylarını gösterir.
			var form = new OgernciProfil(zimmetliOgrenci.OgrenciTC);
			form.ShowDialog();
			GridsYenile();
		}
		private void Data_Kitap_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Eğer header satırına tıklandıysa işlem yapma.
			if (e.RowIndex != -1)
			{
				//Eğer son sütuna tıklandıysa(Buton olan sütun) 
				if (e.ColumnIndex == data_Kitap.Columns.Count - 1)
				{
					//ilgili işlem üzerinden öğrenciyi tespit et
					int islemID = (int)data_Kitap.SelectedRows[0].Cells[0].Value;
					KutuphaneIslem? islem = Tables.Islem.GetById(islemID);
					//ve öğrencinin profil sayfasını aç.
					var form = new OgernciProfil(islem.OgrenciID);
					form.ShowDialog();
					GridsYenile();
				}

			}
		}
	}
}
