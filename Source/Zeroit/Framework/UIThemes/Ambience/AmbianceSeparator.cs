using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000067 RID: 103
	public class AmbianceSeparator : Control
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x0000937B File Offset: 0x0000757B
		public AmbianceSeparator()
		{
			SetStyle(ControlStyles.ResizeRedraw, true);
			Size = new Size(120, 10);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00024E9C File Offset: 0x0002309C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			pevent.Graphics.DrawLine(new Pen(Color.FromArgb(224, 222, 220)), 0, 5, Width, 5);
			pevent.Graphics.DrawLine(new Pen(Color.FromArgb(250, 249, 249)), 0, 6, Width, 6);
		}
	}
}
