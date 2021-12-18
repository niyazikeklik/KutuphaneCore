using DTO;
using DTO.Abstract;
using DTO.Concrete;
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
using static DTO.Concrete.Tablolar;

namespace KutuphaneCore
{
    public partial class OgrenciIslem : Form
    {
        public OgrenciIslem()
        {
            InitializeComponent();
        }

        private void OgrButton_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new(){
                OgrenciTC = int.Parse(ogrTC.Text),
                IsimSoyisim = ogrAd.Text,
                TelefonNo = OgrTelNo.Text,
                DogumTarihi = OgrBirt.Value
            };
            if (ogrTC.Enabled) {
                if (Tables.Ogr.GetList().Any(x => x.OgrenciTC == ogrenci.OgrenciTC))
                    MessageBox.Show("Aynı öğrenci numarası ile kayıtlı başka bir kayıt bulunmakta.");
                else
                    Tables.Ogr.Add(ogrenci);
            }
            else
            {
                var guncellenecekOGR = Tables.Ogr.GetList().FirstOrDefault(x => x.OgrenciTC == ogrenci.OgrenciTC);
                if (guncellenecekOGR != null)
                    Tables.Ogr.Update(guncellenecekOGR);
            }
            MessageBox.Show("İşlem başarılı.");
        }

        private void OgrenciIslem_Load(object sender, EventArgs e)
        {

        }
    }
}
