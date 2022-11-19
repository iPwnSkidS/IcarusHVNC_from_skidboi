using System;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E6 RID: 230
	internal sealed class StartDelay
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x000618F0 File Offset: 0x0005FAF0
		public static void Run()
		{
			int num = new Random().Next(0, 10000);
			Logging.Log();
			Thread.Sleep(num);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x0400073D RID: 1853
		private const int SleepMin = 0;

		// Token: 0x0400073E RID: 1854
		private const int SleepMax = 10;
	}
}
