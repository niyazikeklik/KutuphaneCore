using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Business
{
	public static class Msj
	{
		public static void ShowStop(string mesaj)
		{
			MessageBox.Show(mesaj, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}
		public static void ShowInfo(string mesaj)
		{
			MessageBox.Show(mesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public static DialogResult ShowQuest(string mesaj)
		{
			return MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}
