using DTO.Concrete;
using DTO;
using Entitites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entitites;
using static Entitites.Models.Enums;
using static DTO.Concrete.Tablolar;
namespace KutuphaneCore
{
    public partial class KitapIslem : Form
    {
        public KitapIslem()
        {
            InitializeComponent();
        }

        private void KitapIslem_Load(object sender, EventArgs e)
        {
            if (ktpTur.Items.Count <= 0)
                ktpTur.DataSource = Enum.GetValues(typeof(KitapKategori));
        }

        private void ktpButon_Click(object sender, EventArgs e)
        {
            Kitap kitap = new()
            {
                BarkodNo = this.ktpBarkod.Text,
                KitapAd = ktpAd.Text,
                KitapTuru = (KitapKategori)ktpTur.SelectedIndex,
                BasimTarihi = (DateTime)ktpBasım.Value,
                SayfaSayısı = Convert.ToInt32(ktpSayfa.Value),
                KitapYazar = ktpYazar.Text
            };
            //ktpBarkod enabled ise ekleme işlemi yapılacak demektir.
            if (ktpBarkod.Enabled) 
            {
                if (Tables.Kitap.IsExistRecord(kitap.BarkodNo)) 
                    // Girilen barkod numarası zaten veritabanında var ise ekleme yapılmaz.
                    MessageBox.Show("Aynı BarkodNo ile kayıtlı başka bir kayıt bulunmakta.", "Benzer kayıt", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                else
                {
                    //Girilen bilgiler ile oluşturulan kitap nesnesinin veritabanına eklenme işlemi.
                    Tables.Kitap.Add(kitap);

                    MessageBox.Show("Kitap başarılı bir şekilde kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Girilen barkod numarası üzerinden ilgili kitabın güncellenme işlemi.
                Tables.Kitap.Update(kitap);

                MessageBox.Show("Kitap başarılı bir şekilde güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
