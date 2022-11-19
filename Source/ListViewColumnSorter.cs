

// Token: 0x02000003 RID: 3

using System.Collections;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    public class ListViewColumnSorter : IComparer
    {
        // Token: 0x06000007 RID: 7 RVA: 0x00006231 File Offset: 0x00004431
        public ListViewColumnSorter()
        {
            _columnToSort = 0;
            _orderOfSort = SortOrder.None;
            _objectCompare = new CaseInsensitiveComparer();
        }

        // Token: 0x06000008 RID: 8 RVA: 0x0000B5F0 File Offset: 0x000097F0
        public int Compare(object object_0, object object_1)
        {
            ListViewItem listViewItem = (ListViewItem)object_0;
            ListViewItem listViewItem2 = (ListViewItem)object_1;
            int num2;
            if (!(listViewItem.SubItems[0].Text == "..") && !(listViewItem2.SubItems[0].Text == ".."))
            {
                int num = _objectCompare.Compare(listViewItem.SubItems[_columnToSort].Text, listViewItem2.SubItems[_columnToSort].Text);
                if (_orderOfSort == SortOrder.Ascending)
                {
                    num2 = num;
                }
                else if (_orderOfSort == SortOrder.Descending)
                {
                    num2 = -num;
                }
                else
                {
                    num2 = 0;
                }
            }
            else
            {
                num2 = 0;
            }
            return num2;
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600000A RID: 10 RVA: 0x0000B6A4 File Offset: 0x000098A4
        // (set) Token: 0x06000009 RID: 9 RVA: 0x00006252 File Offset: 0x00004452
        public int SortColumn
        {
            get
            {
                return _columnToSort;
            }
            set
            {
                _columnToSort = value;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x0600000C RID: 12 RVA: 0x0000B6BC File Offset: 0x000098BC
        // (set) Token: 0x0600000B RID: 11 RVA: 0x0000625B File Offset: 0x0000445B
        public SortOrder Order
        {
            get
            {
                return _orderOfSort;
            }
            set
            {
                _orderOfSort = value;
            }
        }

        // Token: 0x04000006 RID: 6
        private int _columnToSort;

        // Token: 0x04000007 RID: 7
        private SortOrder _orderOfSort;

        // Token: 0x04000008 RID: 8
        private readonly CaseInsensitiveComparer _objectCompare;
    }
}
