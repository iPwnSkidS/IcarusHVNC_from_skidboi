

// Token: 0x02000005 RID: 5

using System;
using System.Runtime.InteropServices;

namespace BirdBrainmofo
{
    public static class NativeMethods
    {
        // Token: 0x06000011 RID: 17
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        // Token: 0x06000012 RID: 18
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        internal static extern IntPtr SendMessage_1(IntPtr hWnd, uint msg, IntPtr wParam, ref LVITEM lParam);

        // Token: 0x06000013 RID: 19
        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int int_0, uint fsModifiers, int int_1);

        // Token: 0x06000014 RID: 20
        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int int_0);

        // Token: 0x06000015 RID: 21
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        internal static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        // Token: 0x02000006 RID: 6
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct LVITEM
        {
            // Token: 0x0400000D RID: 13
            public uint mask;

            // Token: 0x0400000E RID: 14
            public int iItem;

            // Token: 0x0400000F RID: 15
            public int iSubItem;

            // Token: 0x04000010 RID: 16
            public int state;

            // Token: 0x04000011 RID: 17
            public int stateMask;

            // Token: 0x04000012 RID: 18
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszText;

            // Token: 0x04000013 RID: 19
            public int cchTextMax;

            // Token: 0x04000014 RID: 20
            public int iImage;

            // Token: 0x04000015 RID: 21
            public IntPtr lParam;

            // Token: 0x04000016 RID: 22
            public int iIndent;

            // Token: 0x04000017 RID: 23
            public int iGroupId;

            // Token: 0x04000018 RID: 24
            public uint cColumns;

            // Token: 0x04000019 RID: 25
            public IntPtr puColumns;

            // Token: 0x0400001A RID: 26
            public IntPtr piColFmt;

            // Token: 0x0400001B RID: 27
            public int iGroup;
        }
    }
}
