using System;
using System.Drawing;
using System.Windows.Forms;

using View.Kitap;
using View.Kutuphane;
using View.Ogrenci;

namespace KutuphaneCore
{
	public partial class AnaSayfa : Form
	{
		public AnaSayfa() => InitializeComponent();
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
			Size = new Size(form.Width + 35, form.Height + 80);
			CenterToParent();
		}
		private void KutuphaneIslemForm_Load(object sender, EventArgs e) => FormGom(new OgrenciForm());
		private void ÖğrenciİşlemlerToolStripMenuItem_Click(object sender, EventArgs e) => FormGom(new OgrenciForm());
		private void KitapİşlemlerToolStripMenuItem_Click(object sender, EventArgs e) => FormGom(new KitapForm());
		private void GrafikToolStripMenuItem_Click(object sender, EventArgs e) => FormGom(new Grafik());
		private void YapımcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("İsmim: Niyazi Keklik\nNumaram: 182119010\nNormal Öğretim\n", "Yapımcı bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
