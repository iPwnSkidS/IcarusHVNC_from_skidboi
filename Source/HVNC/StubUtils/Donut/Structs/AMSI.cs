using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C9 RID: 201
	[StructLayout(LayoutKind.Explicit)]
	public struct AMSI
	{
		// Token: 0x040006E4 RID: 1764
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public char[] char_0;

		// Token: 0x040006E5 RID: 1765
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public uint[] uint_0;
	}
}
