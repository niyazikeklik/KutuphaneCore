using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DTO.Concrete.Tablolar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace View.Kutuphane
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            double[] x = { 1, 2, 3};
            var countAlinabilir = Tables.Kitap.GetAlinabilir().Count;
            var countTum = Tables.Kitap.GetList().Count();
            var countZimmetli = Tables.Kitap.GetZimmetli().Count;
            double[] y =  {countAlinabilir };
            double[] y1 = {countZimmetli };
            double[] y2 = {countTum};
            // clear old curves
            zedGraphControl1.GraphPane.CurveList.Clear();

            // plot the data as bars
            zedGraphControl1.GraphPane.AddBar("Alınabilir", x, y, Color.Green);
            zedGraphControl1.GraphPane.AddBar("Zimmetli", x, y1, Color.Red);
            zedGraphControl1.GraphPane.AddBar("Hepsi", x, y2, Color.Yellow);

            // style the plot
            zedGraphControl1.GraphPane.Title.Text = "Başlık Buraya";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Durum";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Kitap Sayısı";

            // auto-axis and update the display
            zedGraphControl1.GraphPane.XAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            zedGraphControl1.GraphPane.YAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            zedGraphControl1.Refresh();

        }

        private void OgrButton_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.Title.Text = TxtTitles.Text;
            zedGraphControl1.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.YAxis.Title.Text = TxtTitles.Text;
            zedGraphControl1.Refresh();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.XAxis.Title.Text = TxtTitles.Text;
            zedGraphControl1.Refresh();
        }
    }
}
