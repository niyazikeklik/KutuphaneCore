using System;
using System.Diagnostics;
using System.Drawing;
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
            //Form üzerindeki panel içerisine parametre olarak gelen formu gömme işlemi.
            panel1.Controls.Clear();
            form.BackColor = Color.White;
            form.TopLevel = false;
            form.WindowState = FormWindowState.Normal;
            //Form border'ları gizleme.
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
            //Parametre form'un boyutlarında sayfayı açma.
            this.Size = new Size(form.Width + 35, form.Height + 80);
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

        private void yapımcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Biglilerim = "İsmim: Niyazi Keklik\nNumaram: 182119010\nNormal Öğretim\n";
            MessageBox.Show(Biglilerim, "Yapımcı bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hocam, projenin github linki, bu kutucuğu kapattığınızda yönlendirileceksiniz. Normal şartlarda private bir repo. Projeyi son teslim tarihinden 3 gün sonra public olarak açacağım. Eğer erişemezseniz hala daha private'dır. Bana mailden ulaşırsanız hemen public olarak açabilirim: niyazikeklik@gmail.com \n\nProjedeki her satır kod kendime aittir. İlgili github reposundaki commitleri inceleyerek bunu görebilirsiniz, teşekkür ederim. Saygılarımla.", "Proje bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = @"https://github.com/niyazikeklik/KutuphaneCore/",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {


            }

        }
    }
}
