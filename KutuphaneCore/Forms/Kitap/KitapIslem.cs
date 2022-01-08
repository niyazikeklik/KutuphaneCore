using Business.Business;

using Entitites;

using System;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
using static Entitites.Models.Enums;
namespace KutuphaneCore
{
	public partial class KitapIslem : Form
	{
		public KitapIslem() => InitializeComponent();

		private void KitapIslem_Load(object sender, EventArgs e)
		{
			//Kitap kategorisi için comboxlara ilgili enum elemanlarını yazıyorum.
			if (ktpTur.Items.Count <= 0)
			{
				ktpTur.DataSource = Enum.GetValues(typeof(KitapKategori));
			}
		}


		private void KtpButon_Click(object sender, EventArgs e)
		{

			Kitap kitap = new()
			{
				BarkodNo = ktpBarkod.Text,
				KitapAd = ktpAd.Text,
				KitapTuru = (KitapKategori)ktpTur.SelectedIndex,
				BasimTarihi = ktpBasım.Value,
				SayfaSayısı = Convert.ToInt32(ktpSayfa.Value),
				KitapYazar = ktpYazar.Text
			};
			//ktpBarkod enabled ise ekleme işlemi yapılacak demektir.
			if (ktpBarkod.Enabled)
				// Girilen barkod numarası zaten veritabanında var ise ekleme yapılmaz.
				if (Tables.Kitap.IsExistRecord(kitap.BarkodNo))
					Msj.ShowStop("Aynı BarkodNo ile kayıtlı başka bir kayıt bulunmakta.");
				else
				{
					//Girilen bilgiler ile oluşturulan kitap nesnesinin veritabanına eklenme işlemi.
					Tables.Kitap.Add(kitap);
					Msj.ShowInfo("Kitap başarılı bir şekilde kaydedildi.");
				}
			else
			{
				//Girilen barkod numarası üzerinden ilgili kitabın güncellenme işlemi.
				Tables.Kitap.Update(kitap);
				Msj.ShowInfo("Kitap başarılı bir şekilde güncellendi.");
			}

		}
	}
}
