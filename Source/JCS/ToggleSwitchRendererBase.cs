using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.JCS
{
	// Token: 0x0200004B RID: 75
	public abstract class ToggleSwitchRendererBase
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x06000456 RID: 1110 RVA: 0x000085FF File Offset: 0x000067FF
		internal void SetToggleSwitch(ToggleSwitch toggleSwitch)
		{
			_toggleSwitch = toggleSwitch;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		internal ToggleSwitch ToggleSwitch
		{
			get
			{
				return _toggleSwitch;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00020BEC File Offset: 0x0001EDEC
		public void RenderBackground(PaintEventArgs paintEventArgs_0)
		{
			if (_toggleSwitch != null)
			{
				paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rectangle = new Rectangle(0, 0, _toggleSwitch.Width, _toggleSwitch.Height);
				FillBackground(paintEventArgs_0.Graphics, rectangle);
				RenderBorder(paintEventArgs_0.Graphics, rectangle);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00020C4C File Offset: 0x0001EE4C
		public void RenderControl(PaintEventArgs paintEventArgs_0)
		{
			if (_toggleSwitch != null)
			{
				paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle buttonRectangle = GetButtonRectangle();
				int num = ToggleSwitch.Width - buttonRectangle.Width;
				if (buttonRectangle.X > 0)
				{
					Rectangle rectangle = new Rectangle(0, 0, buttonRectangle.X, ToggleSwitch.Height);
					if (rectangle.Width > 0)
					{
						RenderLeftToggleField(paintEventArgs_0.Graphics, rectangle, num);
					}
				}
				if (buttonRectangle.X + buttonRectangle.Width < paintEventArgs_0.ClipRectangle.Width)
				{
					Rectangle rectangle2 = new Rectangle(buttonRectangle.X + buttonRectangle.Width, 0, ToggleSwitch.Width - buttonRectangle.X - buttonRectangle.Width, ToggleSwitch.Height);
					if (rectangle2.Width > 0)
					{
						RenderRightToggleField(paintEventArgs_0.Graphics, rectangle2, num);
					}
				}
				RenderButton(paintEventArgs_0.Graphics, buttonRectangle);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00020D58 File Offset: 0x0001EF58
		public void FillBackground(Graphics graphics_0, Rectangle controlRectangle)
		{
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? ToggleSwitch.BackColor : ToggleSwitch.BackColor.ToGrayScale());
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(brush, controlRectangle);
			}
		}

		// Token: 0x0600045B RID: 1115
		public abstract void RenderBorder(Graphics graphics_0, Rectangle borderRectangle);

		// Token: 0x0600045C RID: 1116
		public abstract void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth);

		// Token: 0x0600045D RID: 1117
		public abstract void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth);

		// Token: 0x0600045E RID: 1118
		public abstract void RenderButton(Graphics graphics_0, Rectangle buttonRectangle);

		// Token: 0x0600045F RID: 1119
		public abstract int GetButtonWidth();

		// Token: 0x06000460 RID: 1120
		public abstract Rectangle GetButtonRectangle();

		// Token: 0x06000461 RID: 1121
		public abstract Rectangle GetButtonRectangle(int buttonWidth);

		// Token: 0x0400024D RID: 589
		private ToggleSwitch _toggleSwitch;
	}
}
