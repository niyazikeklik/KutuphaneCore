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
using View.Kitap;
using View.Ogrenci;

namespace KutuphaneCore
{
    public partial class KutuphaneIslemForm : Form
    {
        public KutuphaneIslemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciForm form = new OgrenciForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapForm form = new KitapForm();
            form.ShowDialog();
        }
    }
}
