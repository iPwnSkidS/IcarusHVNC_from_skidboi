using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000DF RID: 223
	internal sealed class Report
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x000607C8 File Offset: 0x0005E9C8
		public static bool CreateReport(string sSavePath)
		{
			List<Thread> list = new List<Thread>();
			bool flag;
			try
			{
				Directory.CreateDirectory(sSavePath + "\\System");
				foreach (Thread thread in list)
				{
					thread.Start();
				}
				foreach (Thread thread2 in list)
				{
					thread2.Join();
				}
				flag = Logging.Log();
			}
			catch (Exception)
			{
				flag = Logging.Log(false);
			}
			return flag;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
