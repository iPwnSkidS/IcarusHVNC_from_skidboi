using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200005F RID: 95
	public class AmbiancePanel : ContainerControl
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x00008FC4 File Offset: 0x000071C4
		public AmbiancePanel()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.Opaque, false);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00024004 File Offset: 0x00022204
		protected override void OnPaint(PaintEventArgs pevent)
		{
			Graphics graphics = pevent.Graphics;
			Font = new Font("Tahoma", 9f);
			BackColor = Color.White;
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, Width, Height));
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, Width - 1, Height - 1));
			graphics.DrawRectangle(new Pen(Color.FromArgb(211, 208, 205)), 0, 0, Width - 1, Height - 1);
		}
	}
}
