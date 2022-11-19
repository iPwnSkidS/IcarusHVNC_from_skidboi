using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC.Controls
{
	// Token: 0x020000EF RID: 239
	public class RJDropdownMenu : ContextMenuStrip
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x0000AE00 File Offset: 0x00009000
		public RJDropdownMenu(IContainer container)
			: base(container)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0000AE27 File Offset: 0x00009027
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0000AE2F File Offset: 0x0000902F
		[Category("RJ Code Advance")]
		public bool IsMainMenu
		{
			get
			{
				return isMainMenu;
			}
			set
			{
				isMainMenu = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00062C98 File Offset: 0x00060E98
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0000AE38 File Offset: 0x00009038
		[Category("RJ Code Advance")]
		public int MenuItemHeight
		{
			get
			{
				return menuItemHeight;
			}
			set
			{
				menuItemHeight = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00062CB0 File Offset: 0x00060EB0
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0000AE41 File Offset: 0x00009041
		[Category("RJ Code Advance")]
		public Color MenuItemTextColor
		{
			get
			{
				return menuItemTextColor;
			}
			set
			{
				menuItemTextColor = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00062CC8 File Offset: 0x00060EC8
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0000AE4A File Offset: 0x0000904A
		[Category("RJ Code Advance")]
		public Color PrimaryColor
		{
			get
			{
				return primaryColor;
			}
			set
			{
				primaryColor = value;
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00062CE0 File Offset: 0x00060EE0
		private void LoadMenuItemHeight()
		{
			if (isMainMenu)
			{
				menuItemHeaderSize = new Bitmap(25, 45);
			}
			else
			{
				menuItemHeaderSize = new Bitmap(20, menuItemHeight);
			}
			foreach (object obj in Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				toolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
				if (toolStripMenuItem.Image == null)
				{
					toolStripMenuItem.Image = menuItemHeaderSize;
				}
				foreach (object obj2 in toolStripMenuItem.DropDownItems)
				{
					ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)obj2;
					toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
					if (toolStripMenuItem2.Image == null)
					{
						toolStripMenuItem2.Image = menuItemHeaderSize;
					}
					foreach (object obj3 in toolStripMenuItem2.DropDownItems)
					{
						ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)obj3;
						toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
						if (toolStripMenuItem3.Image == null)
						{
							toolStripMenuItem3.Image = menuItemHeaderSize;
						}
						foreach (object obj4 in toolStripMenuItem3.DropDownItems)
						{
							ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)obj4;
							toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
							if (toolStripMenuItem4.Image == null)
							{
								toolStripMenuItem4.Image = menuItemHeaderSize;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000AE53 File Offset: 0x00009053
		protected override void OnHandleCreated(EventArgs eventArgs_0)
		{
			base.OnHandleCreated(eventArgs_0);
			if (!DesignMode)
			{
				Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
				LoadMenuItemHeight();
			}
		}

		// Token: 0x04000762 RID: 1890
		private bool isMainMenu;

		// Token: 0x04000763 RID: 1891
		private int menuItemHeight = 25;

		// Token: 0x04000764 RID: 1892
		private Color menuItemTextColor = Color.Empty;

		// Token: 0x04000765 RID: 1893
		private Color primaryColor = Color.Empty;

		// Token: 0x04000766 RID: 1894
		private Bitmap menuItemHeaderSize;
	}
}
