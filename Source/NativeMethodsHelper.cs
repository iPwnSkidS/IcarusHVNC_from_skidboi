

// Token: 0x02000004 RID: 4

using System;

namespace BirdBrainmofo
{
    public static class NativeMethodsHelper
    {
        // Token: 0x0600000D RID: 13 RVA: 0x0000B6D4 File Offset: 0x000098D4
        public static int MakeWin32Long(short wLow, short wHigh)
        {
            return (wLow << 16) | wHigh;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000B6EC File Offset: 0x000098EC
        public static void SetItemState(IntPtr handle, int itemIndex, int mask, int value)
        {
            NativeMethods.LVITEM lvitem = new NativeMethods.LVITEM
            {
                stateMask = mask,
                state = value
            };
            NativeMethods.SendMessage_1(handle, 4139U, new IntPtr(itemIndex), ref lvitem);
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00006264 File Offset: 0x00004464
        public static void ScrollToBottom(IntPtr handle)
        {
            NativeMethods.SendMessage(handle, 277U, SB_PAGEBOTTOM, IntPtr.Zero);
        }

        // Token: 0x06000010 RID: 16 RVA: 0x0000627C File Offset: 0x0000447C
        // Note: this type is marked as 'beforefieldinit'.
        static NativeMethodsHelper()
        {
        }

        // Token: 0x04000009 RID: 9
        private const int LVM_FIRST = 4096;

        // Token: 0x0400000A RID: 10
        private const int LVM_SETITEMSTATE = 4139;

        // Token: 0x0400000B RID: 11
        private const int WM_VSCROLL = 277;

        // Token: 0x0400000C RID: 12
        private static readonly IntPtr SB_PAGEBOTTOM = new IntPtr(7);
    }
}
