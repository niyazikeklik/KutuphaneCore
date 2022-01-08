using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.CustomElement
{
	internal class CustomGridButton : DataGridViewButtonColumn
	{
		public CustomGridButton()
		{
			DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
			this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			cellStyle.BackColor = Color.FromArgb(40, 0, 40);
			cellStyle.ForeColor = Color.White;
			cellStyle.SelectionBackColor = Color.FromArgb(60, 0, 60);
			cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DefaultCellStyle = cellStyle;
		}
	}
}
