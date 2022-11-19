using System;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000CA RID: 202
	public struct DSModule
	{
		// Token: 0x040006E6 RID: 1766
		public int type;

		// Token: 0x040006E7 RID: 1767
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] runtime;

		// Token: 0x040006E8 RID: 1768
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] domain;

		// Token: 0x040006E9 RID: 1769
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] cls;

		// Token: 0x040006EA RID: 1770
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] method;

		// Token: 0x040006EB RID: 1771
		public int param_cnt;

		// Token: 0x040006EC RID: 1772
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public GStruct2[] gstruct2_0;

		// Token: 0x040006ED RID: 1773
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] sig;

		// Token: 0x040006EE RID: 1774
		public ulong mac;

		// Token: 0x040006EF RID: 1775
		public ulong len;

		// Token: 0x040006F0 RID: 1776
		public IntPtr data;
	}
}
