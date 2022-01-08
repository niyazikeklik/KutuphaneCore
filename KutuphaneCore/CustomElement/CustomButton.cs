using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.CustomElement
{
	//Kendi görünüm tercihlerime göre kişiselleştirdiğim bir buton sınıfı.
	public class CustomButton : Button
	{
		public CustomButton()
		{
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ForeColor = System.Drawing.Color.White;
			this.UseVisualStyleBackColor = false;
			this.BackColor = Color.FromArgb(40, 0, 40);

		}
		//Mouse üstüne gelince renk değiştir.
		protected override void OnMouseEnter(EventArgs e)
		{
			this.BackColor = Color.FromArgb(60, 0, 60);
		}
		//Mouse üstünden çekilince renk değiştir.

		protected override void OnMouseLeave(EventArgs e)
		{
			this.BackColor = Color.FromArgb(40, 0, 40);
		}

	}
}
