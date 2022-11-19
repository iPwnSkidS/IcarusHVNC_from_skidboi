using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.Microsoft.Vbe.Interop
{
	// Token: 0x02000108 RID: 264
	[DefaultMember("Item")]
	[CompilerGenerated]
	[ComImport]
	[Guid("0002E162-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _VBComponents_Old : IEnumerable
	{
		// Token: 0x06000982 RID: 2434
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		 void Item([In] [MarshalAs(UnmanagedType.Struct)] object index);
	}
}
