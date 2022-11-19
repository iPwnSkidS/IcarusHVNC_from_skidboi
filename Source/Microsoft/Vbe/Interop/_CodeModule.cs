using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.Microsoft.Vbe.Interop
{
	// Token: 0x02000105 RID: 261
	[DefaultMember("Name")]
	[CompilerGenerated]
	[ComImport]
	[Guid("0002E16E-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _CodeModule
	{
		// Token: 0x0600097E RID: 2430
		void _VtblGap1_2();

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600097F RID: 2431
		// (set) Token: 0x06000980 RID: 2432
		string Name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x06000981 RID: 2433
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743812)]
		void AddFromString([In] [MarshalAs(UnmanagedType.BStr)] string String);
	}
}
