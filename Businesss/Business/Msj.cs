using System.Windows.Forms;

namespace Business.Business
{
	public static class Msj
	{
		//ÇEŞİTLİ HAZIR MESSAGEBOX Gösterme Methodları
		//Pratik olması için hazırlandı.
		public static void ShowStop(string mesaj) => MessageBox.Show(mesaj, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		public static void ShowInfo(string mesaj) => MessageBox.Show(mesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		public static DialogResult ShowQuest(string mesaj) => MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	}
}
