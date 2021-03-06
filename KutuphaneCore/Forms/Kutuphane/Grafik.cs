using System;
using System.Drawing;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;


namespace View.Kutuphane
{
	public partial class Grafik : Form
	{
		public Grafik() => InitializeComponent();

		private void Grafik_Load(object sender, EventArgs e)
		{
			double[] x = { 1, 2, 3 };
			int countAlinabilir = Tables.Kitap.GetAlinabilir().Count;
			int countTum = Tables.Kitap.GetList().Count;
			int countZimmetli = Tables.Kitap.GetZimmetli().Count;
			//Bar değerlerini (Y ekseni) double türünde dizelere yazıyorum.
			double[] y = { countAlinabilir };
			double[] y1 = { countZimmetli };
			double[] y2 = { countTum };
			// Eski veriler temizlenir.
			zedGraphControl1.GraphPane.CurveList.Clear();

			// Grafiğe yeni bar ekleme işlemleri
			zedGraphControl1.GraphPane.AddBar("Alınabilir", x, y, Color.Green);
			zedGraphControl1.GraphPane.AddBar("Zimmetli", x, y1, Color.Red);
			zedGraphControl1.GraphPane.AddBar("Hepsi", x, y2, Color.Yellow);

			//Grafiğin başlıklarını ayarlama kısmı
			zedGraphControl1.GraphPane.Title.Text = "Başlık Buraya";
			zedGraphControl1.GraphPane.XAxis.Title.Text = "Durum";
			zedGraphControl1.GraphPane.YAxis.Title.Text = "Kitap Sayısı";
			zedGraphControl1.GraphPane.Border.IsVisible = false;
			//Oluşturulan ayaların grafik üzeinde güncellenmesi.
			zedGraphControl1.GraphPane.XAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
			zedGraphControl1.GraphPane.YAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
			zedGraphControl1.Refresh();

		}

		private void OgrButton_Click(object sender, EventArgs e)
		{
			//Girilen değerin grafik başlığına işlenmesi
			zedGraphControl1.GraphPane.Title.Text = TxtTitles.Text;
			zedGraphControl1.Refresh();
		}

		private void MetroButton1_Click(object sender, EventArgs e)
		{
			//Girilen değerin Y Ekseni başlığına işlenmesi
			zedGraphControl1.GraphPane.YAxis.Title.Text = TxtTitles.Text;
			zedGraphControl1.Refresh();
		}

		private void MetroButton2_Click(object sender, EventArgs e)
		{
			//Girilen değerin X Ekseni başlığına işlenmesi
			zedGraphControl1.GraphPane.XAxis.Title.Text = TxtTitles.Text;
			zedGraphControl1.Refresh();
		}
	}
}
