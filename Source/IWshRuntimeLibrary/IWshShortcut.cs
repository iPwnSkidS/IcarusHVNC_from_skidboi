using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.IWshRuntimeLibrary
{
	// Token: 0x020000FB RID: 251
	[DefaultMember("FullName")]
	[CompilerGenerated]
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	public interface IWshShortcut
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000950 RID: 2384
		string FullName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000951 RID: 2385
		// (set) Token: 0x06000952 RID: 2386
		[DispId(1000)]
		string Arguments
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000953 RID: 2387
		// (set) Token: 0x06000954 RID: 2388
		[DispId(1001)]
		string Description
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000955 RID: 2389
		// (set) Token: 0x06000956 RID: 2390
		[DispId(1002)]
		string Hotkey
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1002)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1002)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000957 RID: 2391
		// (set) Token: 0x06000958 RID: 2392
		[DispId(1003)]
		string IconLocation
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x06000959 RID: 2393
		void _VtblGap1_1();

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600095A RID: 2394
		// (set) Token: 0x0600095B RID: 2395
		[DispId(1005)]
		string TargetPath
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600095C RID: 2396
		// (set) Token: 0x0600095D RID: 2397
		[DispId(1006)]
		int WindowStyle
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1006)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1006)]
			[param: In]
			set;
		}

		// Token: 0x0600095E RID: 2398
		void _VtblGap2_3();

		// Token: 0x0600095F RID: 2399
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2001)]
		void Save();
	}
}
