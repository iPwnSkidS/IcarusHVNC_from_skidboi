using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC.Controls
{
	// Token: 0x020000ED RID: 237
	public class MenuRenderer : ToolStripProfessionalRenderer
	{
		// Token: 0x06000920 RID: 2336 RVA: 0x00062898 File Offset: 0x00060A98
		public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
			: base(new MenuColorTable(isMainMenu, primaryColor))
		{
			this.primaryColor = primaryColor;
			if (isMainMenu)
			{
				arrowThickness = 3;
				if (textColor == Color.Empty)
				{
					this.textColor = Color.Gainsboro;
				}
				else
				{
					this.textColor = textColor;
				}
			}
			else
			{
				arrowThickness = 2;
				if (textColor == Color.Empty)
				{
					this.textColor = Color.DimGray;
				}
				else
				{
					this.textColor = textColor;
				}
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0000AD58 File Offset: 0x00008F58
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs_0)
		{
			base.OnRenderItemText(toolStripItemTextRenderEventArgs_0);
			toolStripItemTextRenderEventArgs_0.Item.ForeColor = (toolStripItemTextRenderEventArgs_0.Item.Selected ? Color.White : textColor);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00062910 File Offset: 0x00060B10
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs toolStripArrowRenderEventArgs_0)
		{
			Graphics graphics = toolStripArrowRenderEventArgs_0.Graphics;
			Size size = new Size(5, 12);
			Color color = (toolStripArrowRenderEventArgs_0.Item.Selected ? Color.White : primaryColor);
			Rectangle rectangle = new Rectangle(toolStripArrowRenderEventArgs_0.ArrowRectangle.Location.X, (toolStripArrowRenderEventArgs_0.ArrowRectangle.Height - size.Height) / 2, size.Width, size.Height);
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				using (Pen pen = new Pen(color, arrowThickness))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphicsPath.AddLine(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Top + rectangle.Height / 2);
					graphicsPath.AddLine(rectangle.Right, rectangle.Top + rectangle.Height / 2, rectangle.Left, rectangle.Top + rectangle.Height);
					graphics.DrawPath(pen, graphicsPath);
				}
			}
		}

		// Token: 0x04000759 RID: 1881
		private Color primaryColor;

		// Token: 0x0400075A RID: 1882
		private Color textColor;

		// Token: 0x0400075B RID: 1883
		private int arrowThickness;
	}
}
