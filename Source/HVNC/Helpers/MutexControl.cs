using System;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000DB RID: 219
	internal sealed class MutexControl
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x000606F4 File Offset: 0x0005E8F4
		public static void Check()
		{
			bool flag;
			_mutex = new Mutex(true, Config.Mutex, out flag);
			if (!flag)
			{
				Environment.Exit(0);
			}
			else
			{
				_mutex.ReleaseMutex();
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x0400072B RID: 1835
		private static Mutex _mutex;
	}
}
