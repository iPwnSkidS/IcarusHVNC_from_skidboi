using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace BirdBrainmofo
{
	// Token: 0x02000036 RID: 54
	[StandardModule]
	internal sealed class Helper
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		public static byte[] smethod_0(string string_0)
		{
			return Encoding.Default.GetBytes(string_0);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00010ACC File Offset: 0x0000ECCC
		public static string smethod_1(byte[] byte_0)
		{
			return Encoding.Default.GetString(byte_0);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		public static string BytesToString(long byteCount)
		{
			string[] array = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
			if (byteCount == 0L)
			{
				string text = "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			double num2 = 1.0;
			return (Math.Sign(byteCount) * num2) + array[6];
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
