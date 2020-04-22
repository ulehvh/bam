using System;
using System.Windows.Forms;

namespace MetroLoader
{
	// Token: 0x02000036 RID: 54
	internal static class Program
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000614C File Offset: 0x0000434C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
