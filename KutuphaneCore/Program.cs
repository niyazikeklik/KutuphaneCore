using DTO;

using Microsoft.EntityFrameworkCore;

using System;
using System.Windows.Forms;

namespace KutuphaneCore
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			using (DatabaseContext client = new())
			{
				client.Database.Migrate();
			}
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AnaSayfa());
		}
	}
}
