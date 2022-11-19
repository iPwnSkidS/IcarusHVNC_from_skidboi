using System;
using System.Runtime.InteropServices;

namespace BirdBrainmofo.HVNC.StubUtils.Donut.Structs
{
	// Token: 0x020000C5 RID: 197
	public struct DSInstance
	{
		// Token: 0x040006B4 RID: 1716
		public uint len;

		// Token: 0x040006B5 RID: 1717
		public DSCrypt key;

		// Token: 0x040006B6 RID: 1718
		public ulong ulong_0;

		// Token: 0x040006B7 RID: 1719
		public API api;

		// Token: 0x040006B8 RID: 1720
		public int api_cnt;

		// Token: 0x040006B9 RID: 1721
		public int dll_cnt;

		// Token: 0x040006BA RID: 1722
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public DLL[] dll_0;

		// Token: 0x040006BB RID: 1723
		public AMSI amsi;

		// Token: 0x040006BC RID: 1724
		public int bypass;

		// Token: 0x040006BD RID: 1725
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public char[] clr;

		// Token: 0x040006BE RID: 1726
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] wldp;

		// Token: 0x040006BF RID: 1727
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] wldpQuery;

		// Token: 0x040006C0 RID: 1728
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] wldpIsApproved;

		// Token: 0x040006C1 RID: 1729
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] amsiInit;

		// Token: 0x040006C2 RID: 1730
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] amsiScanBuf;

		// Token: 0x040006C3 RID: 1731
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] amsiScanStr;

		// Token: 0x040006C4 RID: 1732
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] wscript;

		// Token: 0x040006C5 RID: 1733
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] wscript_exe;

		// Token: 0x040006C6 RID: 1734
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IUnknown;

		// Token: 0x040006C7 RID: 1735
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IDispatch;

		// Token: 0x040006C8 RID: 1736
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xCLSID_CLRMetaHost;

		// Token: 0x040006C9 RID: 1737
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_ICLRMetaHost;

		// Token: 0x040006CA RID: 1738
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_ICLRRuntimeInfo;

		// Token: 0x040006CB RID: 1739
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xCLSID_CorRuntimeHost;

		// Token: 0x040006CC RID: 1740
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_ICorRuntimeHost;

		// Token: 0x040006CD RID: 1741
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_AppDomain;

		// Token: 0x040006CE RID: 1742
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xCLSID_ScriptLanguage;

		// Token: 0x040006CF RID: 1743
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IHost;

		// Token: 0x040006D0 RID: 1744
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IActiveScript;

		// Token: 0x040006D1 RID: 1745
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IActiveScriptSite;

		// Token: 0x040006D2 RID: 1746
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IActiveScriptSiteWindow;

		// Token: 0x040006D3 RID: 1747
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IActiveScriptParse32;

		// Token: 0x040006D4 RID: 1748
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IActiveScriptParse64;

		// Token: 0x040006D5 RID: 1749
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xCLSID_DOMDocument30;

		// Token: 0x040006D6 RID: 1750
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IXMLDOMDocument;

		// Token: 0x040006D7 RID: 1751
		[MarshalAs(UnmanagedType.Struct)]
		public Guid xIID_IXMLDOMNode;

		// Token: 0x040006D8 RID: 1752
		public int type;

		// Token: 0x040006D9 RID: 1753
		public DSHttp http;

		// Token: 0x040006DA RID: 1754
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] sig;

		// Token: 0x040006DB RID: 1755
		public ulong mac;

		// Token: 0x040006DC RID: 1756
		public DSCrypt mod_key;

		// Token: 0x040006DD RID: 1757
		public ulong mod_len;

		// Token: 0x040006DE RID: 1758
		public MODULE module;
	}
}
