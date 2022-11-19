using System;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal class AeroListView : ListView
    {
        private readonly IntPtr _removeDots = new IntPtr(NativeMethodsHelper.MakeWin32Long(1, 1));

        private ListViewColumnSorter LvwColumnSorter { get; set; }

        public AeroListView()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            LvwColumnSorter = new ListViewColumnSorter();
            ListViewItemSorter = LvwColumnSorter;
            View = View.Details;
            FullRowSelect = true;
        }

        protected override void OnHandleCreated(EventArgs eventArgs_0)
        {
            base.OnHandleCreated(eventArgs_0);
            if (!PlatformHelper.RunningOnMono)
            {
                if (PlatformHelper.VistaOrHigher)
                {
                    NativeMethods.SetWindowTheme(Handle, "explorer", null);
                }
                if (PlatformHelper.XpOrHigher)
                {
                    NativeMethods.SendMessage(Handle, 295u, _removeDots, IntPtr.Zero);
                }
            }
        }

        protected override void OnColumnClick(ColumnClickEventArgs columnClickEventArgs_0)
        {
            base.OnColumnClick(columnClickEventArgs_0);
            if (columnClickEventArgs_0.Column == LvwColumnSorter.SortColumn)
            {
                LvwColumnSorter.Order = ((LvwColumnSorter.Order != SortOrder.Ascending) ? SortOrder.Ascending : SortOrder.Descending);
            }
            else
            {
                LvwColumnSorter.SortColumn = columnClickEventArgs_0.Column;
                LvwColumnSorter.Order = SortOrder.Ascending;
            }
            if (!VirtualMode)
            {
                Sort();
            }
        }
    }
}