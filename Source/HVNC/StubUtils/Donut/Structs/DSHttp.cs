using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C4 RID: 196
	public struct DSHttp
	{
		// Token: 0x040006B2 RID: 1714
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] url;

		// Token: 0x040006B3 RID: 1715
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public char[] req;
	}
}
