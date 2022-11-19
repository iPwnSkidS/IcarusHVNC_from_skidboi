

// Token: 0x02000012 RID: 18

using System.Drawing;

namespace BirdBrainmofo
{
    internal class Bloom
    {
        // Token: 0x17000039 RID: 57
        // (get) Token: 0x06000112 RID: 274 RVA: 0x0000E378 File Offset: 0x0000C578
        // (set) Token: 0x06000113 RID: 275 RVA: 0x00006F40 File Offset: 0x00005140
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x06000114 RID: 276 RVA: 0x0000E390 File Offset: 0x0000C590
        // (set) Token: 0x06000115 RID: 277 RVA: 0x00006F49 File Offset: 0x00005149
        public Color Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }

        // Token: 0x06000116 RID: 278 RVA: 0x00006F52 File Offset: 0x00005152
        public Bloom()
        {
        }

        // Token: 0x06000117 RID: 279 RVA: 0x00006F5A File Offset: 0x0000515A
        public Bloom(string name, Color value)
        {
            _Name = name;
            _Value = value;
        }

        // Token: 0x040000AA RID: 170
        private string _Name;

        // Token: 0x040000AB RID: 171
        private Color _Value;
    }
}