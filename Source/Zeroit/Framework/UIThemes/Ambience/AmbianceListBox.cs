using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200005C RID: 92
	public class AmbianceListBox : ListBox
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00008E7B File Offset: 0x0000707B
		public AmbianceListBox()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
			DrawMode = DrawMode.OwnerDrawFixed;
			IntegralHeight = false;
			ItemHeight = 18;
			Font = new Font("Seoge UI", 11f, FontStyle.Regular);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00023664 File Offset: 0x00021864
		protected override void OnDrawItem(DrawItemEventArgs drawItemEventArgs_0)
		{
			base.OnDrawItem(drawItemEventArgs_0);
			drawItemEventArgs_0.DrawBackground();
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(drawItemEventArgs_0.Bounds, Color.FromArgb(246, 132, 85), Color.FromArgb(231, 108, 57), 90f);
			if (Convert.ToInt32(drawItemEventArgs_0.State & DrawItemState.Selected) == 1)
			{
				drawItemEventArgs_0.Graphics.FillRectangle(linearGradientBrush, drawItemEventArgs_0.Bounds);
			}
			using (SolidBrush solidBrush = new SolidBrush(drawItemEventArgs_0.ForeColor))
			{
				if (Items.Count == 0)
				{
					return;
				}
				drawItemEventArgs_0.Graphics.DrawString(GetItemText(Items[drawItemEventArgs_0.Index]), drawItemEventArgs_0.Font, solidBrush, drawItemEventArgs_0.Bounds);
			}
			linearGradientBrush.Dispose();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002374C File Offset: 0x0002194C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Region region = new Region(pevent.ClipRectangle);
			pevent.Graphics.FillRegion(new SolidBrush(BackColor), region);
			if (Items.Count > 0)
			{
				for (int i = 0; i <= Items.Count - 1; i++)
				{
					Rectangle itemRectangle = GetItemRectangle(i);
					if (pevent.ClipRectangle.IntersectsWith(itemRectangle))
					{
						if ((SelectionMode == SelectionMode.One && SelectedIndex == i) || (SelectionMode == SelectionMode.MultiSimple && SelectedIndices.Contains(i)) || (SelectionMode == SelectionMode.MultiExtended && SelectedIndices.Contains(i)))
						{
							OnDrawItem(new DrawItemEventArgs(pevent.Graphics, Font, itemRectangle, i, DrawItemState.Selected, ForeColor, BackColor));
						}
						else
						{
							OnDrawItem(new DrawItemEventArgs(pevent.Graphics, Font, itemRectangle, i, DrawItemState.Default, Color.FromArgb(60, 60, 60), BackColor));
						}
						region.Complement(itemRectangle);
					}
				}
			}
		}
	}
}
