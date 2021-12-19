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
using View.Kutuphane;
using View.Ogrenci;

namespace KutuphaneCore
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGom(Form form)
        {
            panel1.Controls.Clear();
            form.BackColor = Color.White;
            form.TopLevel = false;
            form.WindowState = FormWindowState.Normal;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
            this.Size = new Size(form.Width, form.Height + 75);
            this.CenterToParent();
        }


        private void KutuphaneIslemForm_Load(object sender, EventArgs e)
        {
            FormGom(new OgrenciForm());
        }

        private void öğrenciİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGom(new OgrenciForm());
        }

        private void kitapİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGom(new KitapForm());
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGom(new Grafik());
        }
    }
}
