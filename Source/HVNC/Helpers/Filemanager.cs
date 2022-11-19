using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D6 RID: 214
	internal sealed class Filemanager
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x0005DAFC File Offset: 0x0005BCFC
		public static void RecursiveDelete(string path)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (directoryInfo.Exists)
			{
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					RecursiveDelete(directoryInfo2.FullName);
				}
				directoryInfo.Delete(true);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0005DB48 File Offset: 0x0005BD48
		public static void CopyDirectory(string sourceFolder, string destFolder)
		{
			if (!Directory.Exists(destFolder))
			{
				Directory.CreateDirectory(destFolder);
			}
			string[] files = Directory.GetFiles(sourceFolder);
			foreach (string text in files)
			{
				string fileName = Path.GetFileName(text);
				string text2 = Path.Combine(destFolder, fileName);
				File.Copy(text, text2);
			}
			string[] directories = Directory.GetDirectories(sourceFolder);
			foreach (string text3 in directories)
			{
				string fileName2 = Path.GetFileName(text3);
				string text4 = Path.Combine(destFolder, fileName2);
				CopyDirectory(text3, text4);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
		public static long DirectorySize(string path)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			return directoryInfo.GetFiles().Sum(fileInfo_0 => fileInfo_0.Length) + directoryInfo.GetDirectories().Sum(directoryInfo_0 => DirectorySize(directoryInfo_0.FullName));
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00006F52 File Offset: 0x00005152
		public Filemanager()
		{
		}

		// Token: 0x020000D7 RID: 215
		[CompilerGenerated]
		[Serializable]
		private sealed class cccc
		{
			// Token: 0x060008C8 RID: 2248 RVA: 0x0000AC33 File Offset: 0x00008E33
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x00006F52 File Offset: 0x00005152
			public cccc()
			{
			}

			// Token: 0x060008CA RID: 2250 RVA: 0x0000AC3F File Offset: 0x00008E3F
			internal long DirectorySize_2_0(FileInfo fileInfo_0)
			{
				return fileInfo_0.Length;
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x0000AC47 File Offset: 0x00008E47
			internal long DirectorySize_2_1(DirectoryInfo directoryInfo_0)
			{
				return DirectorySize(directoryInfo_0.FullName);
			}

			// Token: 0x04000715 RID: 1813
			public static readonly Filemanager.cccc ccc9 = new Filemanager.cccc();

			// Token: 0x04000716 RID: 1814
			public static Func<FileInfo, long> ccc9__2_0;

			// Token: 0x04000717 RID: 1815
			public static Func<DirectoryInfo, long> ccc9__2_1;
		}
	}
}
