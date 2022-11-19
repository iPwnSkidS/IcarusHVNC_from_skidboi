using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C6 RID: 198
	[StructLayout(LayoutKind.Explicit)]
	public struct API
	{
		// Token: 0x040006DF RID: 1759
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public ulong[] hash;

		// Token: 0x040006E0 RID: 1760
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public unsafe void*[] addr;
	}
}
