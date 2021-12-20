﻿using DTO;
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

        private void OgrEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new()
            {
                OgrenciTC = ogrTC.Text,
                IsimSoyisim = ogrAd.Text,
                TelefonNo = OgrTeNo.Text,
                DogumTarihi = OgrBirt.Value
            };
            if (ogrTC.Enabled)
            {
                if (Tables.Ogr.IsExistRecord(ogrenci.OgrenciTC))
                    MessageBox.Show("Aynı öğrenci numarası ile kayıtlı başka bir kayıt bulunmakta.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    Tables.Ogr.Add(ogrenci);
                    MessageBox.Show("İşlem başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (Tables.Ogr.IsExistRecord(ogrenci.OgrenciTC))
            {
                Tables.Ogr.Update(ogrenci);
                MessageBox.Show("İşlem başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Güncellenek öğrenci bulunamadı.", "İşlem başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OgrenciIslem_Load(object sender, EventArgs e)
        {

            ogrTC.Focus();
        }

        private void ogrTC_TextChanged(object sender, EventArgs e)
        {
            int sonKarakterIndis = ogrTC.Text.Count() - 1;
            //Son karakter rakam mı diye kontrol ettirilir.
            if (sonKarakterIndis >= 0 && !char.IsNumber(ogrTC.Text[sonKarakterIndis]))
            {

                MessageBox.Show("TC No rakam olmalıdır!", "Yanlış girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Son karakter rakam değilse ekrana uyarı mesajı veriyorum ve son karakteri siliyorum.
                ogrTC.Text = ogrTC.Text.Remove(sonKarakterIndis);
            }
        }
    }
}
