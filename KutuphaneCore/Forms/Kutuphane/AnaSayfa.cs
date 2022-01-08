using Business.Business;

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

		private void githubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string mesaj = "Hocam vize notuma bakarak projeyi ben yapmadım sanmayın lütfen :) Her satır kod kendime ait, dilerseniz tamam butonuna basınca yönlendirileceğiniz github reposunun commmitlerini inceleyerek görebilirsiniz.\n\nNot: Repo normalde private size teslim ettikten 1 gün sonra public olarak açacağım eğer o arada projeyi incelerseniz ulaşamazsınız. Bana ulaşırsanız anında açabilirim.\nniyazikeklik@gmail.com\n\nTeşekkür ederim, saygılarımla..";
			var r = Msj.ShowInfo(mesaj);
			if (r == DialogResult.OK)
				System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					FileName = "https://github.com/niyazikeklik/KutuphaneCore",
					UseShellExecute = true
				});
		}
	}
}
