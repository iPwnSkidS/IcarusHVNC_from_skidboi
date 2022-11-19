using System;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C1 RID: 193
	public struct DSConfig
	{
		// Token: 0x04000696 RID: 1686
		public int arch;

		// Token: 0x04000697 RID: 1687
		public int bypass;

		// Token: 0x04000698 RID: 1688
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] domain;

		// Token: 0x04000699 RID: 1689
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] cls;

		// Token: 0x0400069A RID: 1690
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] method;

		// Token: 0x0400069B RID: 1691
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2304)]
		public char[] param;

		// Token: 0x0400069C RID: 1692
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] file;

		// Token: 0x0400069D RID: 1693
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] url;

		// Token: 0x0400069E RID: 1694
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] runtime;

		// Token: 0x0400069F RID: 1695
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] modname;

		// Token: 0x040006A0 RID: 1696
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] outfile;

		// Token: 0x040006A1 RID: 1697
		public int mod_type;

		// Token: 0x040006A2 RID: 1698
		public ulong mod_len;

		// Token: 0x040006A3 RID: 1699
		public DSModule mod;

		// Token: 0x040006A4 RID: 1700
		public int inst_type;

		// Token: 0x040006A5 RID: 1701
		public ulong inst_len;

		// Token: 0x040006A6 RID: 1702
		public DSInstance inst;

		// Token: 0x040006A7 RID: 1703
		public int pic_cnt;

		// Token: 0x040006A8 RID: 1704
		public ulong pic_len;

		// Token: 0x040006A9 RID: 1705
		public IntPtr pic;
	}
}
