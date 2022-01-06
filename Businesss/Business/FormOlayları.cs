using Entitites.Models;

using System;
using System.Drawing;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;

namespace Business.Business
{
	public static class FormOlayları
	{
		//Parametre olarak gelen datagridview nesnesinde ilgili sütunda ilgili veriyi arar.
		public static void Ara(this DataGridView grid, int sutunIndis, string aranacak)
		{
			//Datagrid'in tüm satırlarını döner.
			foreach (DataGridViewRow row in grid.Rows)
			{
				//İlgili hücre, aranan veriyi içeriyor ise satır görünür.
				if (row.Cells[sutunIndis].Value.ToString().ToLower().Contains(aranacak.ToLower()))
				{
					row.Visible = true;
				}
				//İlgili hücre, aranan veriyi içermiyor ise satır saklanır.
				else
				{
					grid.CurrentCell = null;
					row.Visible = false;
				}
			}
		}

		//Parametre olarak gelen gridin satırlarını döner ve duruma göre rengini değiştirir.
		public static void Boya(this DataGridView grid)
		{
			//Datagrid satırlarını dönüyorum.
			foreach (DataGridViewRow row in grid.Rows)
			{
				//Datagridin 1.0. hücresindeki veriden ilgili işlemi tespit ediyorum.
				KutuphaneIslem islem = Tables.Islem.GetById((int)row.Cells[0].Value);
				//İlgili işlemin kapanmasına kalan gün sayısını tespit ediyorum.
				double kalanGun = islem.KalanGun();
				//Eğer iade tarihi var ise satır rengi yeşil olur.
				if (islem.IadeTarihi != null)
				{
					row.DefaultCellStyle.BackColor = Color.Green;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
				//Kalan gün 0'dan küçükse yani SonİadeTarihi geçti ise ilgili satır kırmızı olur.
				else if (kalanGun < 0)
				{
					row.DefaultCellStyle.BackColor = Color.Red;
					row.DefaultCellStyle.ForeColor = Color.White;
				}

				//Kalan gün 2'den küçükse yani SonİadeTarihi'ne 0-2 gün var ise satır sarı olur.
				else if (kalanGun <= 2)
				{
					row.DefaultCellStyle.BackColor = Color.Yellow;
					row.DefaultCellStyle.ForeColor = Color.Black;
				}
			}
		}

		//Parametre olarak verilen grid'in sütun isimlerini değiştirir.
		public static void HeaderTextChange(this DataGridView grid)
		{
			//Yerel bir fonksiyon tanımlıyorum.
			//Bu Fonksiyon, eğer parametre oalrak verilen column name'e ait bir sütun bulursa
			//Header Text'ini yine parametre olarak verilen headertext ile değiştirecek.
			//Geriye göstermelik olarak varsa true, yoksa false dönecektir.
			Func<string, string, bool> HeaderChange = (name, headertext) =>
			{
				if (grid.Columns.Contains(name))
					grid.Columns[name].HeaderText = headertext;
				return grid.Columns.Contains(name);
			};

			//Yukarıdaki fonksiyonun kullanımı aşağıdaki gibidir.
			HeaderChange("BarkodNo", "Barkod No");
			HeaderChange("KitapAd", "Kitap Adı");
			HeaderChange("KitapYazar", "Yazar");
			HeaderChange("SayfaSayısı", "Sayfa Sayısı");
			HeaderChange("BasimTarihi", "Basım Tarihi");
			HeaderChange("KitapTuru", "Kategori");

			HeaderChange("OgrenciTC", "TC Numarası");
			HeaderChange("IsimSoyisim", "İsim Soyisim");
			HeaderChange("TelefonNo", "Telefon No");
			HeaderChange("DogumTarihi", "Doğum Tarihi");

			HeaderChange("IslemID", "İşlem No");
			HeaderChange("OgrenciAdi", "Öğrenci İsim");
			HeaderChange("AlimTarihi", "Alım Tarihi");
			HeaderChange("IadeTarihi", "İade Tarihi");

			HeaderChange("KitapAdi", "Kitap Adı");
			HeaderChange("AlimTarihi", "Alım Tarihi");
			HeaderChange("SonTeslimTarihi", "Son Teslim Tarihi");
			HeaderChange("TeslimTarihi", "Teslim Tarihi");
			HeaderChange("IsemUcreti", "Ücret");
			HeaderChange("Aciklama", "Açıklama");

			//İlgili grid'de kutuphaneIslems sütunu varsa gizler.
			if (grid.Columns.Contains("kutuphaneIslems"))
				grid.Columns["kutuphaneIslems"].Visible = false;

		}


	}
}
