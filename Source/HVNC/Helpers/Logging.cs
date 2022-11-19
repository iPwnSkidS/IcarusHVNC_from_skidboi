using System.IO;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000DA RID: 218
	internal sealed class Logging
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0000AC54 File Offset: 0x00008E54
		public static bool Log(bool ret = true)
		{
			return ret;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000606A4 File Offset: 0x0005E8A4
		public static void Save(string sSavePath)
		{
			if (!(Config.DebugMode != "1") && File.Exists(Logfile))
			{
				try
				{
					File.Copy(Logfile, sSavePath);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x060008D4 RID: 2260 RVA: 0x0000AC57 File Offset: 0x00008E57
		// Note: this type is marked as 'beforefieldinit'.
		static Logging()
		{
		}

		// Token: 0x0400072A RID: 1834
		private static readonly string Logfile = Path.Combine(Path.GetTempPath(), "Icarus-Latest.log");
	}
}
