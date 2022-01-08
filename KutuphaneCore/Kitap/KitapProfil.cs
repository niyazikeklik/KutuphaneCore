using Business.Business;

using Entitites.Models;

using KutuphaneCore;

using System;
using System.Linq;
using System.Windows.Forms;

using View.CustomElement;

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
		public void FormYenile()
		{

			data_Kitap.Columns.Clear();
			ktp = Tables.Kitap.GetKitapWithIslemlerById(id);

			string? ogrID = ktp.kutuphaneIslems.FirstOrDefault(x => x.IadeTarihi == null)?.OgrenciID;
			if (ogrID != null)
				zimmetliOgrenci = Tables.Ogr.GetById(ogrID);

			//Kullanıcı bilgilendirmesi için yeni bir entites üzerinden liste oluşturma.
			data_Kitap.DataSource = ktp.CreateKitapIslemBilgi();
			//Data gride bir buton sütunu eklenir
			data_Kitap.Columns.Add(new CustomGridButton
			{
				HeaderText = "İlgili Öğrenci",
				UseColumnTextForButtonValue = true,
				Text = "Öğrenciye Git"
			});
			//Datagrid'de default olarak seçili gelen satırlara unselect işlemi.
			data_Kitap.ClearSelection();
			//Grid sütun iismleri değiştirme.
			data_Kitap.HeaderTextChange();
			BilgiIsle();
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
		private void KitapProfil_Load(object sender, EventArgs e) => FormYenile();
		private void Btn_OgrGit_Click(object sender, EventArgs e)
		{
			//Kitabın zimmetli olduğu öğrencinin detaylarını gösterir.
			var form = new OgernciProfil(zimmetliOgrenci.OgrenciTC);
			form.ShowDialog();
			FormYenile();
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
					FormYenile();
				}

			}
		}
	}
}
