using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.CustomElement
{
	public class CustomButton : Button
	{
		public CustomButton()
		{
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ForeColor = System.Drawing.Color.White;
			this.UseVisualStyleBackColor = false;

		}
		protected override void OnMouseEnter(EventArgs e)
		{
			this.BackColor = Color.FromArgb(60, 0, 60);
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			this.BackColor = Color.FromArgb(30, 0, 30);
		}

	}
}
