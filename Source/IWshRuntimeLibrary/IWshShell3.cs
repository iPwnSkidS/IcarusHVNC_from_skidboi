using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.IWshRuntimeLibrary
{
	// Token: 0x020000FA RID: 250
	[CompilerGenerated]
	[ComImport]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[TypeIdentifier]
	public interface IWshShell3
	{
		// Token: 0x0600094E RID: 2382
		void _VtblGap1_4();

		// Token: 0x0600094F RID: 2383
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([In] [MarshalAs(UnmanagedType.BStr)] string PathLink);
	}
}
