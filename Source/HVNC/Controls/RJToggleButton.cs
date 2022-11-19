using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC.Controls
{
	// Token: 0x020000F0 RID: 240
	public class RJToggleButton : CheckBox
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00062EFC File Offset: 0x000610FC
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0000AE8A File Offset: 0x0000908A
		[Category("RJ Code Advance")]
		public Color OnBackColor
		{
			get
			{
				return onBackColor;
			}
			set
			{
				onBackColor = value;
				Invalidate();
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00062F14 File Offset: 0x00061114
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0000AE99 File Offset: 0x00009099
		[Category("RJ Code Advance")]
		public Color OnToggleColor
		{
			get
			{
				return onToggleColor;
			}
			set
			{
				onToggleColor = value;
				Invalidate();
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00062F2C File Offset: 0x0006112C
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Category("RJ Code Advance")]
		public Color OffBackColor
		{
			get
			{
				return offBackColor;
			}
			set
			{
				offBackColor = value;
				Invalidate();
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00062F44 File Offset: 0x00061144
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0000AEB7 File Offset: 0x000090B7
		[Category("RJ Code Advance")]
		public Color OffToggleColor
		{
			get
			{
				return offToggleColor;
			}
			set
			{
				offToggleColor = value;
				Invalidate();
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00062F5C File Offset: 0x0006115C
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000063EF File Offset: 0x000045EF
		[Browsable(false)]
		public override string Text
		{
			get
			{
				return method_0();
			}
			set
			{
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0000AEC6 File Offset: 0x000090C6
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0000AECE File Offset: 0x000090CE
		[Category("RJ Code Advance")]
		[DefaultValue(true)]
		public bool SolidStyle
		{
			get
			{
				return solidStyle;
			}
			set
			{
				solidStyle = value;
				Invalidate();
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00062F74 File Offset: 0x00061174
		public RJToggleButton()
		{
			MinimumSize = new Size(45, 22);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00062FCC File Offset: 0x000611CC
		private GraphicsPath GetFigurePath()
		{
			int num = Height - 1;
			Rectangle rectangle = new Rectangle(0, 0, num, num);
			Rectangle rectangle2 = new Rectangle(Width - num - 2, 0, num, num);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rectangle, 90f, 180f);
			graphicsPath.AddArc(rectangle2, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0006303C File Offset: 0x0006123C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			int num = Height - 5;
			pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			pevent.Graphics.Clear(Parent.BackColor);
			if (Checked)
			{
				if (solidStyle)
				{
					pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
				}
				else
				{
					pevent.Graphics.DrawPath(new Pen(onBackColor, 2f), GetFigurePath());
				}
				pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(Width - Height + 1, 2, num, num));
			}
			else
			{
				if (solidStyle)
				{
					pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
				}
				else
				{
					pevent.Graphics.DrawPath(new Pen(offBackColor, 2f), GetFigurePath());
				}
				pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, num, num));
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0000AEDD File Offset: 0x000090DD
		string method_0()
		{
			return base.Text;
		}

		// Token: 0x04000767 RID: 1895
		private Color onBackColor = Color.MediumSlateBlue;

		// Token: 0x04000768 RID: 1896
		private Color onToggleColor = Color.WhiteSmoke;

		// Token: 0x04000769 RID: 1897
		private Color offBackColor = Color.Gray;

		// Token: 0x0400076A RID: 1898
		private Color offToggleColor = Color.Gainsboro;

		// Token: 0x0400076B RID: 1899
		private bool solidStyle = true;
	}
}
