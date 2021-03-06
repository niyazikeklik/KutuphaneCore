
using Business.Business;

using Entitites.Models;

using System;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;

namespace KutuphaneCore
{
	public partial class OgrenciIslem : Form
	{
		public OgrenciIslem() => InitializeComponent();

		private void OgrEkle_Click(object sender, EventArgs e)
		{
			Ogrenci ogrenci = new()
			{
				OgrenciTC = ogrTC.Text,
				IsimSoyisim = ogrAd.Text,
				TelefonNo = OgrTeNo.Text,
				DogumTarihi = OgrBirt.Value
			};
			//OgrTc textbox'ı etkin ise form ekle işlemini gerçekleştirecek form olarak açılmıştır.
			if (ogrTC.Enabled)
			{
				//Eğer girilen öğrencitc ile başka bir kayıt bulunuyorsa uyarı verir.
				if (Tables.Ogr.IsExistRecord(ogrenci.OgrenciTC))
					Msj.ShowStop("Aynı öğrenci numarası ile kayıtlı başka bir kayıt bulunmakta.");
				else
				{
					//Yeni öğrenci ekleme işlemi
					Tables.Ogr.Add(ogrenci);
					Msj.ShowInfo("İşlem başarılı!");
				}
			}
			// Eğer ogrtc textboxı etkin değil ise ve girilen öğernciye ait bir kayıt var ise güncelleme işlemi yapılır.
			else if (Tables.Ogr.IsExistRecord(ogrenci.OgrenciTC))
			{
				Tables.Ogr.Update(ogrenci);
				Msj.ShowInfo("İşlem başarılı!");
			} else Msj.ShowStop("Güncellenecek Öğrenci bulunamadı!");
		}

		private void OgrenciIslem_Load(object sender, EventArgs e) => ogrTC.Focus();

		private void OgrTC_TextChanged(object sender, EventArgs e)
		{
			int sonKarakterIndis = ogrTC.Text.Length - 1;
			//Son karakter rakam mı diye kontrol ettirilir.
			if (sonKarakterIndis >= 0 && !char.IsNumber(ogrTC.Text[sonKarakterIndis]))
			{

				Msj.ShowStop("TC Numarası rakamlardan oluşmalıdır!");
				//Son karakter rakam değilse ekrana uyarı mesajı veriyorum ve son karakteri siliyorum.
				ogrTC.Text = ogrTC.Text.Remove(sonKarakterIndis);
			}
		}
	}
}
