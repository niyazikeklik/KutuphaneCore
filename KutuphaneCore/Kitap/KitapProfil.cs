using Business;

using Entitites;
using Entitites.Models;

using KutuphaneCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DTO.Concrete.Tablolar;
namespace View.Kitap
{
    public partial class KitapProfil : Form
    {
        Entitites.Kitap ktp;
        Entitites.Models.Ogrenci zimmetliOgrenci;
        public KitapProfil(string id)
        {
            //Parametre olarak gelen id'ye göre ilgili kitabın işlemleriyle beraber çekilmesi.
            ktp = Tables.Kitap.GetKitapWithIslemlerById(id);
            InitializeComponent();
        }
        public void GridsYenile()
        {
            data_Kitap.Columns.Clear();
            List<KitapIslemBilgi> list = new List<KitapIslemBilgi>();
            foreach (var item in Tables.Kitap.GetKitapWithIslemlerById(ktp.BarkodNo).kutuphaneIslems) //İlgili kitabın tüm işlemlerinin dönülmesi.
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
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "İlgili Öğrenci";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Text = "Öğrenciye Git";
            btnColumn.Name = "GridBtn_ogrnciyeGit";
            data_Kitap.Columns.Add(btnColumn);
            //Datagrid'de default olarak seçili gelen satırlara unselect işlemi.
            data_Kitap.ClearSelection();

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

        private void KitapProfil_Load(object sender, EventArgs e)
        {
            GridsYenile();
            BilgiIsle();
        }

        private void btn_OgrGit_Click(object sender, EventArgs e)
        {
            //Kitabın zimmetli olduğu öğrencinin detaylarını gösterir.
            OgernciProfil form = new OgernciProfil(zimmetliOgrenci.OgrenciTC);
            form.ShowDialog();
        }

        private void data_Ogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eğer header satırına tıklandıysa işlem yapma.
            if(e.RowIndex != -1)
            {
                //Eğer son sütuna tıklandıysa(Buton olan sütun) ilgili işlem üzerinden öğrenciyi tespit et ve öğrencinin profil sayfasını aç.
                if (e.ColumnIndex == data_Kitap.Columns.Count - 1)
                {
                    var islemID = (int)data_Kitap.SelectedRows[0].Cells[0].Value;
                    var islem = Tables.Islem.GetById(islemID);
                    OgernciProfil form = new OgernciProfil(islem.OgrenciID);
                    form.ShowDialog();
                }
                    
            }
        }
    }
}
