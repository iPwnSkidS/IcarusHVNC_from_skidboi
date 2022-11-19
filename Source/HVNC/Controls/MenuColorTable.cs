using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC.Controls
{
	// Token: 0x020000EC RID: 236
	public class MenuColorTable : ProfessionalColorTable
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x00062798 File Offset: 0x00060998
		public MenuColorTable(bool isMainMenu, Color primaryColor)
		{
			if (isMainMenu)
			{
				backColor = Color.FromArgb(37, 39, 60);
				leftColumnColor = Color.FromArgb(32, 33, 51);
				borderColor = Color.FromArgb(32, 33, 51);
				menuItemBorderColor = primaryColor;
				menuItemSelectedColor = primaryColor;
			}
			else
			{
				backColor = Color.White;
				leftColumnColor = Color.LightGray;
				borderColor = Color.LightGray;
				menuItemBorderColor = primaryColor;
				menuItemSelectedColor = primaryColor;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00062820 File Offset: 0x00060A20
		public override Color ToolStripDropDownBackground
		{
			get
			{
				return backColor;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00062838 File Offset: 0x00060A38
		public override Color MenuBorder
		{
			get
			{
				return borderColor;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00062850 File Offset: 0x00060A50
		public override Color MenuItemBorder
		{
			get
			{
				return menuItemBorderColor;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00062868 File Offset: 0x00060A68
		public override Color MenuItemSelected
		{
			get
			{
				return menuItemSelectedColor;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00062880 File Offset: 0x00060A80
		public override Color ImageMarginGradientBegin
		{
			get
			{
				return leftColumnColor;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00062880 File Offset: 0x00060A80
		public override Color ImageMarginGradientMiddle
		{
			get
			{
				return leftColumnColor;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00062880 File Offset: 0x00060A80
		public override Color ImageMarginGradientEnd
		{
			get
			{
				return leftColumnColor;
			}
		}

		// Token: 0x04000754 RID: 1876
		private Color backColor;

		// Token: 0x04000755 RID: 1877
		private Color leftColumnColor;

		// Token: 0x04000756 RID: 1878
		private Color borderColor;

		// Token: 0x04000757 RID: 1879
		private Color menuItemBorderColor;

		// Token: 0x04000758 RID: 1880
		private Color menuItemSelectedColor;
	}
}
